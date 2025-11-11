using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Product
    {
        [Key]
        public UInt64? Id { get; set; }

        [Required]
        public String? Name { get; set; }
        public Decimal? Price { get; set; }
        public UInt32? Stockpile { get; set; }
        public UInt32? MinimumStock { get; set; } = 10;
        public Boolean Active { get; set; } = true;

        // Relationship with category
        [Required]
        public Category? Category { get; set; }
    }
}
