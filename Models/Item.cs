using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Item
    {
        public UInt64 Id { get; set; }

        public UInt32? Quantity { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? Discount { get; set; }

    }
}
