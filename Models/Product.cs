using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models
{
    public class Product
    {
        [Key]
        public UInt64? Id { get; set; }

        [Required]
        private String? _name;
        public String? Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value, nameof(Name));
                if (value.Length > 100 || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must contain between 3 and 100 characters.");
                }
                _name = value;
            }
        }

        [Required]
        private Decimal? _price;
        public Decimal? Price
        {
            get => _price;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Price));

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive value.");
                }

                _price = value;
            }
        }

        [Required]
        private UInt32? _stockpile;
        public UInt32? Stockpile
        {
            get => _stockpile;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Stockpile must be >= 0!");
                }

                _stockpile = value;
            }
        }

        [Required]
        private UInt32? _minimumStock;
        public UInt32? MinimumStock 
        {
            get => _minimumStock;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Minimum stock must be >= 0!");
                }

                _minimumStock = value;
            }
        }

        [Required]
        public Boolean IsActive { get; set; } = true;

        // Relationship with category
        [Required]
        private Category? _category;
        public Category? Category
        {
            get => _category;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Category));

                _category = value;
            }
        }
        
        public UInt64 CategoryId { get; set; }
    }
}
