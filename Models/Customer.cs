using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Customer
    {
        public UInt64 Id { get; set; }

        private List<Purchase>? _purchases;
        public List<Purchase>? Purchases
        {
            get => _purchases;
            set
            {
                _purchases = value;
            }
        }
        
        public Boolean CanBuy()
        {
            if (Purchases == null || Purchases.Count == 0)
            {
                return true;
            }
            else if (Purchases.Any(purchase => purchase.Payments != null && purchase.Payments.Any(payment => DateTime.Now > payment.ExpirationDate && payment.DatePayment is null)))
            {
                return false;
            }

            return true;
        }
    }
}
