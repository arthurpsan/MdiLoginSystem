using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class CustomerReportForm : Form
    {
        private static CustomerReportForm? _instance;
        private List<Customer> _allCustomers = new List<Customer>();

        public static CustomerReportForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CustomerReportForm();
            }

            return _instance;
        }

        public CustomerReportForm()
        {
            InitializeComponent();

            this.Load += CustomerPurchasesReport_Load;

            txtSearchCustomer.TextChanged += TxtSearchCustomer_TextChanged;
            lstCustomers.SelectedIndexChanged += LstCustomers_SelectedIndexChanged;

            lstPurchasesReport.Columns.Add("ID", 80);
            lstPurchasesReport.Columns.Add("Data", 120);
            lstPurchasesReport.Columns.Add("Salesperson", 150);
            lstPurchasesReport.Columns.Add("Total value", 100);
            lstPurchasesReport.View = View.Details;

            lstCustomers.Columns.Add("Customer ID", 80);
            lstCustomers.Columns.Add("Name", 250);
            lstCustomers.View = View.Details;
        }

        private void CustomerPurchasesReport_Load(object sender, EventArgs e)
        {
            try
            {
                _allCustomers = CustomerRepository.FindAll();
                PopulateCustomerList(_allCustomers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load customers: {ex.Message}", "Error");
            }
        }

        private void PopulateCustomerList(List<Customer> customers)
        {
            lstCustomers.Items.Clear();
            foreach (var customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.Id.ToString());
                item.SubItems.Add(customer.Name);
                item.Tag = customer;
                lstCustomers.Items.Add(item);
            }
        }

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchCustomer.Text.ToLower();

            var filteredList = _allCustomers
                .Where(c => c.Name.ToLower().Contains(filter))
                .ToList();

            PopulateCustomerList(filteredList);
        }

        private void LstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count == 0) return;

            Customer? selectedCustomer = lstCustomers.SelectedItems[0].Tag as Customer;
            if (selectedCustomer == null) return;

            lstPurchasesReport.Items.Clear();

            try
            {
                // Define a data de início (30 dias atrás)
                DateTime startDate = DateTime.Now.AddDays(-30);

                // Busca no repositório
                var purchases = PurchaseRepository.FindByCustomerIdAndDate(selectedCustomer.Id, startDate);

                if (purchases.Count == 0)
                {
                    lblDescription.Text = "Customer has no purchases in the last 30 days";
                }

                // Popula o relatório 'listView1'
                foreach (var purchase in purchases)
                {
                    ListViewItem item = new ListViewItem(purchase.Id.ToString());
                    item.SubItems.Add(purchase.Implementation?.ToString("g"));
                    item.SubItems.Add(purchase.Seller?.Name ?? "N/A");
                    item.SubItems.Add(purchase.CalcTotal()?.ToString("C"));

                    lstPurchasesReport.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar compras do cliente: {ex.Message}", "Erro");
            }
        }
    }
}
