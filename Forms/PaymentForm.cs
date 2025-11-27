using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Models.ViewModels;

namespace UserManagementSystem.Forms
{
    public partial class PaymentForm : Form
    {
        private static PaymentForm? _instance;

        public static PaymentForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PaymentForm();
            }
            return _instance;
        }

        public PaymentForm()
        {
            InitializeComponent();

            dgvReports.AutoGenerateColumns = true;
            dgvReports.DataSource = bdsPayments;

            // Wire up the Search event manually since the button is gone
            txtSearchCustomer.TextChanged += TxtSearchCustomer_TextChanged;

            // Optional: Format the grid logic
            dgvReports.CellFormatting += DgvReports_CellFormatting;
        }

        // Logic 1: Real-time Search
        private void TxtSearchCustomer_TextChanged(object? sender, EventArgs e)
        {
            string term = txtSearchCustomer.Text.Trim();

            // Don't search if empty to save performance, or clear list
            if (string.IsNullOrEmpty(term))
            {
                bdsPayments.DataSource = null;
                return;
            }

            try
            {
                // 1. Find Customer(s)
                var customers = CustomerRepository.FindAll()
                    .Where(c => c.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                var displayList = new List<PaymentViewModel>();

                foreach (var customer in customers)
                {
                    // 2. Get Unpaid Purchases
                    var purchases = PurchaseRepository.FindByCustomerIdAndDate(customer.Id, DateTime.MinValue);

                    foreach (var purchase in purchases)
                    {
                        if (purchase.Payments == null) continue;

                        foreach (var pay in purchase.Payments)
                        {
                            if (pay.DatePayment == null) // Only show unpaid
                            {
                                // Calculate Fine/Total
                                pay.DatePayment = DateTime.Now;
                                decimal total = pay.CalcTotalPayment() ?? 0;
                                pay.DatePayment = null;

                                displayList.Add(new PaymentViewModel
                                {
                                    PaymentId = pay.Id,
                                    PurchaseId = purchase.Id,
                                    ExpirationDate = pay.ExpirationDate?.ToShortDateString() ?? "-",
                                    TotalAmount = total.ToString("C"), // Formatted Currency
                                    RealPaymentObject = pay // Hidden object for logic
                                });
                            }
                        }
                    }
                }

                // 3. Update the BindingSource (Grid updates automatically)
                bdsPayments.DataSource = new BindingList<PaymentViewModel>(displayList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        // Logic 2: Process Payment
        private void btnPay_Click(object sender, EventArgs e)
        {
            // Get the selected object safely from the BindingSource
            if (bdsPayments.Current is PaymentViewModel selectedVM)
            {
                try
                {
                    Payment payment = selectedVM.RealPaymentObject;

                    // Finalize Payment
                    payment.DatePayment = DateTime.Now;
                    // Note: You might want to save the calculated fine amount here specifically if your logic requires it

                    PaymentRepository.SaveOrUpdate(payment);

                    MessageBox.Show("Payment confirmed successfully!", "Success");

                    // Refresh the list immediately
                    TxtSearchCustomer_TextChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to process.");
            }
        }

        // Logic 3: Visual Polish (Red text for overdue items)
        private void DgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReports.Rows[e.RowIndex].DataBoundItem is PaymentViewModel vm)
            {
                // Check if date is parsed correctly and compares
                if (DateTime.TryParse(vm.ExpirationDate, out DateTime expDate) && expDate < DateTime.Now)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red; // Keep it red even when selected
                }
            }
        }
    }
}