using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt64 Id { get; set; }

        [Required]
        public String? Name { get; set; }

        [Required]
        public Decimal? Price { get; set; }

        // FIXED: Renamed from 'Stockpile' to 'StockQuantity'
        [Required]
        public UInt32? StockQuantity { get; set; }

        [Required]
        public UInt32? MinimumStock { get; set; }

        [Required]
        public Boolean IsActive { get; set; } = true;

        [Required]
        public Category? Category { get; set; }

        public UInt64 CategoryId { get; set; }
    }
}