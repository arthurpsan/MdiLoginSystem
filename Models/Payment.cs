using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class Payment
    {
        [Key]
        public UInt64 Id { get; set; }

        [Required]
        public DateTime? ExpirationDate { get; set; }

        private DateTime? _datePayment;
        public DateTime? DatePayment
        {
            get => _datePayment;
            set
            {
                if (value != null && ExpirationDate != null && value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Payment date cannot be in the future.");
                }

                _datePayment = value;
            }
        }

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
