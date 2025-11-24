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
                // Find customer by name
                var allCustomers = CustomerRepository.FindAll();
                var customer = allCustomers.FirstOrDefault(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

                if (customer == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                // Requirement: Find pending payments
                // We fetch purchases for this client. 
                // Ideally, PurchaseRepository needs a method to fetch deep data, 
                // but we can filter the FindByCustomerIdAndDate existing method.
                var purchases = PurchaseRepository.FindByCustomerIdAndDate(customer.Id, DateTime.MinValue);

                foreach (var purchase in purchases)
                {
                    // Ensure payments are loaded
                    if (purchase.Payments == null) continue;

                    foreach (var payment in purchase.Payments)
                    {
                        // Requirement: Select the parcel to be paid (only show unpaid)
                        if (payment.DatePayment == null)
                        {
                            // Logic to PREVIEW the fine before paying
                            // We temporarily set the date to NOW to calculate what the fine would be
                            payment.DatePayment = DateTime.Now;
                            decimal? totalWithFine = payment.CalcTotalPayment();

                            // Reset it back to null because we haven't paid yet
                            payment.DatePayment = null;

                            // Calculate original value (approximate based on purchase total / installments)
                            decimal? originalVal = purchase.CalcTotal() / purchase.Payments.Count;

                            ListViewItem item = new ListViewItem(payment.Id.ToString());
                            item.SubItems.Add(purchase.Id.ToString());
                            item.SubItems.Add(payment.ExpirationDate?.ToShortDateString());
                            item.SubItems.Add(originalVal?.ToString("C"));

                            // Requirement: Visualize calculation of fine
                            item.SubItems.Add(totalWithFine?.ToString("C"));

                            item.Tag = payment; // Store the object for the Pay button

                            lstPendingPayments.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void lstPendingPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendingPayments.SelectedItems.Count > 0)
            {
                // Optional: Show details in the label
                lblTotalWithFine.Text = "Selected Amount: " + lstPendingPayments.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lstPendingPayments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a payment first.");
                return;
            }

            Payment selectedPayment = lstPendingPayments.SelectedItems[0].Tag as Payment;

            if (selectedPayment != null)
            {
                try
                {
                    // Requirement: Inform debt settlement
                    selectedPayment.DatePayment = DateTime.Now;

                    // Requirement: Automatic fine registration 
                    // (Happens inside the CalcTotalPayment logic implicitly or you can save the specific calculated fine if you add a field for it)

                    // Save to database
                    PaymentRepository.SaveOrUpdate(selectedPayment);

                    MessageBox.Show("Payment Confirmed!");
                    btnSearch_Click(sender, e); // Refresh the list
                    lblTotalWithFine.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message);
                }
            }
        }
    }
}