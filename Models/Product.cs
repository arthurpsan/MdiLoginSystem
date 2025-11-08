using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Product
    {
        public UInt64? Id { get; set; }

        public String? Name { get; set; }
        public Decimal? Price { get; set; }
        public UInt32? Stockpile { get; set; }
        public UInt32? MinimumStock { get; set; } = 10;
        public Boolean Active { get; set; } = true;

        // Relationship with category
        public Category? Category { get; set; }
    }
}
