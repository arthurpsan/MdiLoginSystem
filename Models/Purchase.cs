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

        // State relationship
        [Required]
        public State State { get; set; } = State.PENDENT;

        // Relationships with other classes
        [Required]
        public Salesperson? Seller { get; set; }
        public Customer? Customer { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Payment> Payments { get; set; } = new List<Payment>();


        #region Methods to calculate totals and comissions
        public Decimal? CalcTotal()
        {
            decimal? total = 0;

            if (Items == null || Items.Count == 0)
            {
                return 0;
            }

            foreach (Item item in Items)
            {
                decimal? itemValue = item.CalcTotal();

                if (itemValue == null)
                {
                    return 0;
                }
                    
                total += itemValue;
            }

            return total;
        }

        private const Decimal ComissionTax = 0.01m; // 5% comission

        public Decimal? CalcComission()
        {
            decimal? total = CalcTotal();

            if (total == null || total == 0)
            {
                return 0;
            }

            return (total * ComissionTax);
        }

        #endregion
    }
}
