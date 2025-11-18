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
        public Purchase? Purchase { get; set; }

        private const Decimal _paymentMonthTax = 0.02m; // 2% monthly tax for late payments

        [Required]
        public DateTime? ExpirationDate { get; set; }

        [Required]
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

        [Required]
        public Decimal? PaymentFine { get; set; } = 0;

        public Decimal? CalcTotalPayment()
        {

            if (ExpirationDate == null || Purchase == null || Purchase.CalcTotal() == null)
            {
                return 0;
            }

            if (DatePayment != null && DatePayment > ExpirationDate)
            {
                TimeSpan delay = DatePayment.Value - ExpirationDate.Value;
                int delayedMonths = (int)Math.Ceiling(delay.TotalDays / 30);

                Decimal? totalPurchase = Purchase.CalcTotal();
                return totalPurchase * _paymentMonthTax * delayedMonths;
            }

            // In case the payment is still not made and is past due (today)
            else if (DatePayment != null && DateTime.Now > ExpirationDate)
            { 
                TimeSpan delay = DateTime.Now - ExpirationDate.Value;
                int delayedMonths = (int)Math.Ceiling(delay.TotalDays / 30);

                Decimal? totalPurchase = Purchase.CalcTotal();
                return totalPurchase * _paymentMonthTax * delayedMonths;
            }
            
            return 0;
        }

    }
}
