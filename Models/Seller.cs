using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Seller : User
    {
        public UInt32? Enrollment { get; set; }
        public Boolean? IsCashier { get; set; } = false;

        // Relationship with Purchase class
        public List<Purchase>? IssuePurchases { get; set; }
    }
}
