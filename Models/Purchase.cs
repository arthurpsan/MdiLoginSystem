using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Purchase
    {
        [Key]
        public UInt64? Id { get; set; }

        [Required]
        public UInt64? Number { get; set; }
        public DateTime? Beggining { get; set; }
        public DateTime? Implementation { get; set; }
        public Decimal? Comission { get; set; }

        // State relationship
        [Required]
        public State State { get; set; } = State.PENDENT;

        // Relationships with other classes
        [Required]
        public Seller? Seller { get; set; }
        public Customer? Customer { get; set; }
        public List<Item>? Items { get; set; }
        public List<Payment>? Payments { get; set; }


        #region Methods to calculate totals and comissions
        public Decimal? CalcTotal()
        {
            decimal? total = 0;

            foreach (Item item in Items)
            {
                if (item.CalcTotal() == null)
                {
                    return 0;
                }
                else if (item.CalcTotal() != null)
                {
                    total += item.CalcTotal();
                    return total;
                }
            }

            return total;
        }

        public Decimal? CalcComission()
        {
            decimal? total = CalcTotal();

            if (Comission == null || total == null)
            {
                return 0;
            }

            return (total * Comission) / 100;
        }

        #endregion
    }
}
