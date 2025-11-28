using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt64 Id { get; set; }

        public UInt64? Number { get; set; }

        // FIXED: Renamed from 'Beggining'
        public DateTime? Beginning { get; set; }
        public DateTime? Implementation { get; set; }

        [Required]
        public State State { get; set; } = State.PENDENT;

        [Required]
        public Salesperson? Seller { get; set; }
        public Customer? Customer { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public Decimal? CalcTotal()
        {
            if (Items == null || Items.Count == 0) return 0;
            decimal? total = 0;
            foreach (Item item in Items)
            {
                total += item.CalcTotal() ?? 0;
            }
            return total;
        }

        private const Decimal ComissionTax = 0.01m;

        public Decimal? CalcComission()
        {
            decimal? total = CalcTotal();
            return (total ?? 0) * ComissionTax;
        }
    }
}