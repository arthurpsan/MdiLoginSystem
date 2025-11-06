using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;

namespace UserManagementSystem.Models
{
    public class Item
    {
        public UInt64 Id { get; set; }

        // properties
        public UInt32? Quantity { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? Discount { get; set; }

        // relationships with other classes
        public List<Purchase>? Purchases { get; set; }
        public List<Product>? Products { get; set; }

        // Method to calculate the total value
        public Decimal? CalcTotal()
        {
            Decimal? discountValue = (Quantity * UnitPrice) * Discount;
            Decimal? totalValue = (Quantity * UnitPrice) - discountValue;

            return totalValue;
        }
    }
}
