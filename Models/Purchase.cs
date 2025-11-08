using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Purchase
    {
        public UInt64? Id { get; set; }

        [Required]
        public UInt64? Number { get; set; }
        public DateTime? Beggining { get; set; }
        public DateTime? Implementation { get; set; }
        public Decimal? Comission { get; set; }

        // State relationship
        public State State { get; set; } = State.PENDENT;

        // Relationships with other classes
        public Seller? Seller { get; set; }
        public Customer? Customer { get; set; }
        public List<Product>? Products { get; set; }
        public List<Payment>? Payments { get; set; }


        #region Methods to calculate totals and comissions
        public Decimal? CalcTotal()
        {
            if (Products == null || Products.Count == 0)
            {
                return 0;
            }
            Decimal? total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }

        public Decimal? CalcComission()
        {
            decimal? total = CalcTotal();

            if (Comission == null || total == null)
            {
                return 0;
            }

            return (total * Comission) / 100;
        }

        #endregion
    }
}
