using System;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace UserManagementSystem.Forms
{
    public partial class PaymentForm : Form
    {
        private static PaymentForm? _instance;
        public static PaymentForm? GetInstance(User? user)
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchCustomer.Text;
            lstPendingPayments.Items.Clear();

            try
            {
                var allCustomers = CustomerRepository.FindAll();
                var customer = allCustomers.FirstOrDefault(c => c.Name.ToLower().Contains(name.ToLower()));

                if (customer == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                // Fetch purchases and pending payments
                var purchases = PurchaseRepository.FindByCustomerIdAndDate(customer.Id, DateTime.MinValue);

                foreach (var purchase in purchases)
                {
                    if (purchase.Payments == null) continue;

                    foreach (var payment in purchase.Payments)
                    {
                        if (payment.DatePayment == null) // Only unpaid ones
                        {
                            // Simulate fine for visualization (Requirement 4)
                            payment.DatePayment = DateTime.Now;
                            decimal? totalWithFine = payment.CalcTotalPayment();
                            payment.DatePayment = null; // Reset

                            decimal? totalPurchase = purchase.CalcTotal();
                            int paymentCount = purchase.Payments.Count;

                            ListViewItem item = new ListViewItem(payment.Id.ToString());
                            item.SubItems.Add(purchase.Id.ToString());
                            item.SubItems.Add(payment.ExpirationDate?.ToShortDateString());
                            decimal? originalVal = paymentCount > 0 ? (totalPurchase / paymentCount) : 0;
                            item.SubItems.Add(totalWithFine?.ToString("C")); // Value with fine

                            item.Tag = payment;
                            lstPendingPayments.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void lstPendingPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendingPayments.SelectedItems.Count > 0)
                lblTotalWithFine.Text = "Amount to Pay: " + lstPendingPayments.SelectedItems[0].SubItems[4].Text;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lstPendingPayments.SelectedItems.Count == 0) return;

            Payment? selectedPayment = lstPendingPayments.SelectedItems[0].Tag as Payment;

            if (selectedPayment != null)
            {
                try
                {
                    selectedPayment.DatePayment = DateTime.Now;
                    PaymentRepository.SaveOrUpdate(selectedPayment); // Save to DB

                    MessageBox.Show("Payment registered successfully!");
                    btnSearch_Click(sender, e); // Refresh list
                    lblTotalWithFine.Text = "";
                }
                catch (Exception ex) { MessageBox.Show("Error paying: " + ex.Message); }
            }
        }
    }
}