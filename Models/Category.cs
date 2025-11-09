using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Category
    {
        [Key]
        public UInt64 Id { get; set; }

        [Required]
        private String? _name;
        public String? Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value, nameof(Name));

                if (value.Length > 50 || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must contain between 3 and 50 characters.");
                }
                
                _name = value;
            }
        }
    }
}
