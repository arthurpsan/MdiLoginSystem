using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Cashier : User
    {
        [Required]
        public UInt32? CashierEnrollment { get; set; }

        // Relationship with Purchase class
        [Required]
        public List<Purchase>? ProcessedPurchases { get; set; }
    }
}
