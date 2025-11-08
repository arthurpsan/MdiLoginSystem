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

        public List<Purchase>? Purchases { get; set; }

        private Boolean _delayedPayment;
        
        public Boolean PodeRealizarCompra()
        {
            if (Purchases == null || Purchases.Count == 0)
            {
                return true;
            }
            
            return false;
        }
    }
}
