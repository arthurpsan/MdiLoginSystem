using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Salesperson : User
    {
        [Required]
        public UInt32? SalespersonEnrollment { get; set; }

        // Relationship with Purchase class
        [Required]
        public List<Purchase>? IssuePurchases { get; set; }
    }
}
