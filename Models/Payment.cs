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

        private Decimal? _paymentFine;
        public Decimal? PaymentFine
        {
            get => _paymentFine;
            set
            {
                if ( DatePayment < DateTime.Now)
                {
                    value = 0;
                }
                else if (ExpirationDate != null && DatePayment != null && DatePayment > ExpirationDate)
                {
                    TimeSpan delay = DateTime.Now - ExpirationDate.Value;
                    int monthsDelayed = (delay.Days / 30);
                    decimal fineRate = 0.02m; // 2% fine per month

                    value = monthsDelayed * fineRate;
                }

                    _paymentFine = value;
            }
        }

    }
}
