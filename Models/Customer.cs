using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Customer
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
                ArgumentNullException.ThrowIfNull(value, nameof(Name));

                if (value.Length < 3 || value.Length > 80)
                {
                    throw new ArgumentException("Name must be between 3 and 80 characters long.", nameof(Name));
                }

                _name = value;
            }
        }

        [Required]
        private String? _email;
        public String? Email
        {
            get => _email;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Email));
                if (value.Length < 5 || value.Length > 140 || !value.Contains('@'))
                {
                    throw new ArgumentException("Email must be between 5 and 100 characters long and contain '@'.", nameof(Email));
                }
                _email = value;
            }
        }

        [Required]

        private List<Purchase> _purchases = new();
        public List<Purchase> Purchases
        {
            get => _purchases;
            set
            {
                _purchases = value;
            }
        }

        // Method to check if the customer can make a new purchase
        public Boolean CanBuy()
        {
            if (Purchases == null || Purchases.Count == 0)
            {
                return true;
            }
            else if (Purchases.Any(purchase => purchase != null && purchase.Payments
                .Any(payment => DateTime.Now > payment.ExpirationDate && payment.DatePayment is null)))
            {
                return false;
            }

            return true;
        }

    }
}
