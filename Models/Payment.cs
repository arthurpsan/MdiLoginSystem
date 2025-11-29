using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt64 Id { get; set; }

        [Required]
        public Purchase? Purchase { get; set; }

        [Required]
        public Decimal Amount { get; set; }

        private const Decimal _paymentMonthTax = 0.02m; // 2% monthly tax for late payments

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

        [Required]
        public Decimal? PaymentFine { get; set; } = 0;

        public Decimal? CalcTotalPayment()
        {
            if (ExpirationDate == null || Purchase == null) return 0;

            Decimal? totalPurchase = Purchase.CalcTotal();
            if (totalPurchase == null) totalPurchase = 0;

            if (DatePayment != null && DatePayment > ExpirationDate)
            {
                // paid Late
                TimeSpan delay = DatePayment.Value - ExpirationDate.Value;
                Int32 delayedMonths = (Int32)Math.Ceiling(delay.TotalDays / 30.0);

                return totalPurchase * _paymentMonthTax * delayedMonths;
            }
            else if (DatePayment == null && DateTime.Now > ExpirationDate)
            {
                // currently late (simulation)
                TimeSpan delay = DateTime.Now - ExpirationDate.Value;
                Int32 delayedMonths = (Int32)Math.Ceiling(delay.TotalDays / 30.0);

                return totalPurchase * _paymentMonthTax * delayedMonths;
            }

            return 0; // no fine
        }

    }
}
