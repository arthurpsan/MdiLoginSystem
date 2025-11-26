using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Salesperson : User
    {
        [Required]
        private UInt32 _sellerEnrollment;
        public UInt32? SellerEnrollment
        {
            get => _sellerEnrollment;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(SellerEnrollment));

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Enrollment must be a positive number.");
                }

                _sellerEnrollment = value.Value;
            }
        }

        // Relationship with Purchase class
        [Required]
        public List<Purchase>? IssuePurchases { get; set; }
    }
}
