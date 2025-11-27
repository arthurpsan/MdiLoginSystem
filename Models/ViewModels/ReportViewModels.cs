using System;
using System.ComponentModel;
using UserManagementSystem.Models;

namespace UserManagementSystem.Models.ViewModels
{
    // --- 1. User Dashboard ---
    public class UserViewModel
    {
        [Browsable(false)] // Hides from Grid automatically
        public ulong? Id { get; set; }

        [DisplayName("Full Name")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Username / Nick")]
        public string Nickname { get; set; } = string.Empty;

        [DisplayName("Email Address")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Phone")]
        public string Phone { get; set; } = string.Empty;

        [DisplayName("Role")]
        public string Role { get; set; } = string.Empty;

        [DisplayName("Last Access")]
        public string LastAccess { get; set; } = string.Empty;
    }

    // --- 2. Sales Report ---
    public class SaleReportViewModel
    {
        [Browsable(false)]
        public ulong SaleId { get; set; }

        [DisplayName("Date")]
        public string Date { get; set; } = string.Empty;

        [DisplayName("Seller")]
        public string SellerName { get; set; } = string.Empty;

        [DisplayName("Total Value")]
        public string TotalValue { get; set; } = string.Empty;
    }

    // --- 3. Commission Report ---
    public class CommissionViewModel
    {
        [Browsable(false)]
        public ulong? SellerId { get; set; }

        [DisplayName("Seller Name")]
        public string SellerName { get; set; } = string.Empty;

        [DisplayName("Purchase #")]
        public ulong PurchaseId { get; set; }

        [DisplayName("Date")]
        public string Date { get; set; } = string.Empty;

        [DisplayName("Commission")]
        public string Commission { get; set; } = string.Empty;
    }

    // --- 4. Payment (Cashier) ---
    public class PaymentViewModel
    {
        [Browsable(false)]
        public ulong PaymentId { get; set; }

        [DisplayName("Purchase #")]
        public ulong PurchaseId { get; set; }

        [DisplayName("Due Date")]
        public string ExpirationDate { get; set; } = string.Empty;

        [DisplayName("Total Amount")] // This will show Value + Fine
        public string TotalAmount { get; set; } = string.Empty;

        // We store the real object here to use in logic, but hide it from the grid
        [Browsable(false)]
        public Payment RealPaymentObject { get; set; }
    }
}