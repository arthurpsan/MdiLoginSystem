using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;
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
            if (_instance == null || _instance.IsDisposed) _instance = new PaymentForm();
            return _instance;
        }

        public PaymentForm()
        {
            InitializeComponent();
            dgvReports.AutoGenerateColumns = true;
            dgvReports.DataSource = bdsPayments;

            // Wire events
            txtSearchCustomer.TextChanged += TxtSearchCustomer_TextChanged;
            dgvReports.CellFormatting += DgvReports_CellFormatting;

            // Load initial data
            this.Load += (s, e) => TxtSearchCustomer_TextChanged(s, e);
        }

        private void TxtSearchCustomer_TextChanged(object? sender, EventArgs e)
        {
            string term = txtSearchCustomer.Text.Trim();
            var displayList = new List<PaymentViewModel>();

            try
            {
                // FIX: Use a custom query here to ensure we get Purchases and Customers included
                // (Repository.FindAll() usually doesn't include deep children)
                using (var db = new Repository())
                {
                    // Fetch all payments that are NOT paid (DatePayment is null)
                    var pendingPayments = db.Payments
                        .Include(p => p.Purchase)
                        .ThenInclude(pur => pur.Customer)
                        .Where(p => p.DatePayment == null)
                        .ToList();

                    // Filter in memory (easier for complex object graphs)
                    if (!string.IsNullOrEmpty(term))
                    {
                        pendingPayments = pendingPayments
                            .Where(p => p.Purchase.Customer.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }

                    // Map to ViewModel
                    foreach (var payment in pendingPayments)
                    {
                        // Calculate total with fine if overdue
                        decimal total = payment.CalcTotalPayment() ?? 0;
                        // If logic returns 0 for unpaid, fallback to purchase total or handle logic
                        if (total == 0 && payment.Purchase != null)
                            total = payment.Purchase.CalcTotal() ?? 0;

                        displayList.Add(new PaymentViewModel
                        {
                            PaymentId = payment.Id,
                            PurchaseId = payment.Purchase?.Id ?? 0,
                            ExpirationDate = payment.ExpirationDate?.ToShortDateString() ?? "-",
                            TotalAmount = total.ToString("C", new CultureInfo("pt-BR")),
                            RealPaymentObject = payment
                        });
                    }
                }

                bdsPayments.DataSource = new BindingList<PaymentViewModel>(displayList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (bdsPayments.Current is PaymentViewModel selectedVM)
            {
                try
                {
                    // We need to re-attach the object to the context to save it, 
                    // or fetch it again by ID to avoid tracking issues.
                    var paymentId = selectedVM.RealPaymentObject.Id;
                    var payment = PaymentRepository.FindById(paymentId);

                    if (payment != null)
                    {
                        payment.DatePayment = DateTime.Now;
                        PaymentRepository.SaveOrUpdate(payment);
                        MessageBox.Show("Payment confirmed!", "Success");
                        TxtSearchCustomer_TextChanged(null, null); // Refresh
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReports.Rows[e.RowIndex].DataBoundItem is PaymentViewModel vm)
            {
                if (DateTime.TryParse(vm.ExpirationDate, out DateTime expDate) && expDate < DateTime.Now)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
            }
        }
    }
}