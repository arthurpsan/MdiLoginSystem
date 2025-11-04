using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Payment
    {
        public DateTime? ExpirationDate { get; set; }
        public DateTime? DatePayment { get; set; }
        public Decimal? PaymentFine { get; set; }
    }
}
