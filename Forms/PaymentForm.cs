using System;
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

        private const Decimal MonthlyTax = 0.02m;

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

            txtSearchCustomer.TextChanged += TxtSearchCustomer_TextChanged;
            dgvReports.CellFormatting += DgvReports_CellFormatting;

            dgvReports.SelectionChanged += DgvReports_SelectionChanged;

            this.Load += (s, e) => TxtSearchCustomer_TextChanged(s, e);
        }

        // helper to calculate fine based on Date.Now (made so it simulates Payment.cs logic)
        private Decimal CalculateSimulatedFine(Payment payment, Decimal purchaseTotal)
        {
            if (payment.ExpirationDate == null) return 0;

            if (DateTime.Now.Date > payment.ExpirationDate.Value.Date)
            {
                TimeSpan delay = DateTime.Now.Date - payment.ExpirationDate.Value.Date;
                Int32 delayedMonths = (Int32)Math.Ceiling(delay.TotalDays / 30.0);

                return purchaseTotal * MonthlyTax * delayedMonths;
            }
            return 0;
        }

        #region EVENT HANDLERS
        private void TxtSearchCustomer_TextChanged(object? sender, EventArgs e)
        {
            String term = txtSearchCustomer.Text.Trim();
            var displayList = new List<PaymentViewModel>();

            try
            {
                using (var dbContext = new Repository())
                {
                    var pendingPayments = dbContext.Payments
                        .Include(p => p.Purchase)
                        .ThenInclude(pur => pur.Customer)
                        .Include(p => p.Purchase.Items) // important to include items for fine calculation
                        .ThenInclude(i => i.Product)
                        .Where(p => p.DatePayment == null)
                        .ToList();

                    // filters by customer name if term is provided
                    if (!string.IsNullOrEmpty(term))
                    {
                        pendingPayments = pendingPayments
                            .Where(p => p.Purchase.Customer != null &&
                                        p.Purchase.Customer.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }

                    foreach (var payment in pendingPayments)
                    {
                        Decimal installment = payment.Amount;
                        Decimal fine = payment.CalcTotalPayment() ?? 0;
                        Decimal totalToPay = installment + fine;

                        displayList.Add(new PaymentViewModel
                        {
                            PaymentId = payment.Id,
                            PurchaseId = payment.Purchase?.Id ?? 0,
                            CustomerName = payment.Purchase?.Customer?.Name ?? "Desconhecido",
                            ExpirationDate = payment.ExpirationDate?.ToShortDateString() ?? "-",

                            // original installment value
                            InstallmentValue = installment.ToString("C", new CultureInfo("pt-BR")),

                            // total with fine
                            TotalAmount = totalToPay.ToString("C", new CultureInfo("pt-BR")),

                            RealPaymentObject = payment
                        });
                    }
                }

                bdsPayments.DataSource = new BindingList<PaymentViewModel>(displayList);

                lblTotalWithFine.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pagamentos: " + ex.Message);
            }
        }

        private void DgvReports_SelectionChanged(object? sender, EventArgs e)
        {
            if (bdsPayments.Current is PaymentViewModel selectedVM)
            {
                var payment = selectedVM.RealPaymentObject;

                Decimal installmentValue = payment.Amount;
                Decimal purchaseTotal = payment.Purchase?.CalcTotal() ?? 0;
                Decimal fine = CalculateSimulatedFine(payment, purchaseTotal);
                Decimal totalToPay = installmentValue + fine;

                if (fine > 0)
                {
                    lblTotalWithFine.Text = $"Principal: {installmentValue:C} | Fine (on Total): {fine:C} | TOTAL: {totalToPay:C}";
                    lblTotalWithFine.ForeColor = Color.Red;
                }
                else
                {
                    lblTotalWithFine.Text = $"Total to Pay: {installmentValue:C} (No fines)";
                    lblTotalWithFine.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (bdsPayments.Current is PaymentViewModel selectedVM)
            {
                try
                {
                    var payment = PaymentRepository.FindById(selectedVM.PaymentId);

                    if (payment != null)
                    {
                        Decimal installmentValue = payment.Amount;
                        Decimal purchaseTotal = payment.Purchase?.CalcTotal() ?? 0; // base for fine
                        Decimal fineToSave = CalculateSimulatedFine(payment, purchaseTotal);

                        payment.DatePayment = DateTime.Now;
                        payment.PaymentFine = fineToSave;

                        PaymentRepository.SaveOrUpdate(payment);

                        Decimal totalPaid = installmentValue + fineToSave;

                        MessageBox.Show($"Payment Confirmed!\n\n" +
                                        $"Installment Value: {installmentValue:C}\n" +
                                        $"Fine: {fineToSave:C}\n" +
                                        $"Total Paid: {totalPaid:C}",
                                        "Success");

                        TxtSearchCustomer_TextChanged(null, null);
                        lblTotalWithFine.Text = "Payment processed.";
                        lblTotalWithFine.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment first.");
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
        #endregion
    }
}