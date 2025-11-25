using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Cashier : User
    {
        [Required]
        private UInt32? _cashierEnrollment;
        public UInt32? CashierEnrollment
        {
            get => _cashierEnrollment;
            set
            {
                if (value == null || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cashier enrollment must be a positive value.");
                }
                _cashierEnrollment = value;
            }
        }

        // Relationship with Purchase class
        [Required]
        public List<Purchase>? ProcessedPurchases { get; set; }
    }
}
