using System;
using System.ComponentModel;

namespace UserManagementSystem.Models.ViewModels
{
    // user dashboard
    public class UserViewModel
    {
        [Browsable(false)] // makes it hide from the grid automatically
        public UInt64? Id { get; set; }

        [DisplayName("Full Name")]
        public String Name { get; set; } = string.Empty;
            
        [DisplayName("Username / Nick")]
        public String Nickname { get; set; } = String.Empty;

        [DisplayName("Email Address")]
        public String Email { get; set; } = String.Empty;

        [DisplayName("Phone")]
        public String Phone { get; set; } = String.Empty;

        [DisplayName("Role")]
        public String Role { get; set; } = String.Empty;

        [DisplayName("Last Access")]
        public String LastAccess { get; set; } = String.Empty;
    }

    // sales report
    public class SaleReportViewModel
    {
        [Browsable(false)]
        public UInt64 SaleId { get; set; }

        [DisplayName("Date")]
        public String Date { get; set; } = String.Empty;

        [DisplayName("Seller")]
        public String SellerName { get; set; } = String.Empty;

        [DisplayName("Total Value")]
        public String TotalValue { get; set; } = String.Empty;
    }

    // comission report
    public class CommissionViewModel
    {
        [Browsable(false)]
        public UInt64? SellerId { get; set; }

        [DisplayName("Seller Name")]
        public String SellerName { get; set; } = String.Empty;

        [DisplayName("Purchase #")]
        public UInt64 PurchaseId { get; set; }

        [DisplayName("Date")]
        public String Date { get; set; } = String.Empty;

        [DisplayName("Sale Value")]
        public String TotalSaleValue { get; set; }

        [DisplayName("Commission")]
        public String Commission { get; set; } = String.Empty;
    }

    // payment (cashier)
    public class PaymentViewModel
    {
        [Browsable(false)]
        public UInt64 PaymentId { get; set; }

        [DisplayName("Purchase #")]
        public UInt64 PurchaseId { get; set; }

        [DisplayName("Customer")]
        public String CustomerName { get; set; } = String.Empty;

        [DisplayName("Due Date")]
        public String ExpirationDate { get; set; } = String.Empty;

        [DisplayName("Instalment Value")]
        public String InstallmentValue { get; set; } = String.Empty;

        [DisplayName("Total Amount")] // shows value + fine
        public String TotalAmount { get; set; } = String.Empty;

        // storing of the real object + hide from grid
        [Browsable(false)]
        public Payment RealPaymentObject { get; set; }
    }

}