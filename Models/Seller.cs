using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Seller : User
    {
        [Required]
        public UInt32? Enrollment { get; set; }
        public Boolean? IsCashier { get; set; } = false;

        // Relationship with Purchase class
        public List<Purchase>? IssuePurchases { get; set; }
    }
}
