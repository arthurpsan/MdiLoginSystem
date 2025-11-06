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
        public List<Purchase>? Purchase { get; set; }
        public Boolean PodeRealizarCompra()
        {
            return false;
        }
    }
}
