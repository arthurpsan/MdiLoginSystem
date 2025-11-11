using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Item
    {
        [Key]
        public UInt64 Id { get; set; }

        [Required]
        public UInt32? Quantity { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? Discount { get; set; }

        // Relationship with Purchase and Product class
        [Required]
        public Purchase? Purchase { get; set; }
        public Product? Product { get; set; }

        // Method to calculate the total value
        public Decimal? CalcTotal()
        {
            Decimal? totalDiscount = (Quantity * UnitPrice) * Discount;
            Decimal? totalValue = (Quantity * UnitPrice) - totalDiscount;

            return totalValue;
        }
    }
}
