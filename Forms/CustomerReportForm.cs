using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class CustomerReportForm : Form
    {
        private static CustomerReportForm? _instance;

        private BindingList<Customer> _customerList;
        private List<Customer> _cacheAllCustomers;

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

            BindControls();

            LoadData();

            this.Load += (s, e) => LoadData();
            txtSearchCustomer.TextChanged += TxtSearchCustomer_TextChanged;
            chkShowDelinquents.CheckedChanged += ChkShowDelinquents_CheckedChanged;
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            dgvPurchases.CellFormatting += DgvPurchases_CellFormatting;
        }

        private void BindControls()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.DataSource = _customerList; // initially null, populated by LoadData

            // force id hidden if it exists in designer
            if (dgvCustomers.Columns["Id"] != null)
            {
                dgvCustomers.Columns["Id"].Visible = false;
            }

            dgvPurchases.AutoGenerateColumns = false;
            dgvPurchases.AllowUserToAddRows = false;
        }

        #region data loading & logic

        private void LoadData()
        {
            try
            {
                List<Customer> sourceData;

                if (chkShowDelinquents.Checked)
                {
                    sourceData = CustomerRepository.FindDelinquents();
                    UpdateStatusLabel("Delinquent Customers (Action Required)", Color.DarkRed);

                    if (sourceData.Count == 0)
                    {
                        MessageBox.Show("Great! No delinquent customers found.", "Report");
                    }
                }
                else
                {
                    sourceData = CustomerRepository.FindAll();
                    UpdateStatusLabel("Customer List (All)", Color.Black);
                }

                _cacheAllCustomers = sourceData;

                _customerList = new BindingList<Customer>(sourceData);
                dgvCustomers.DataSource = _customerList;

                dgvPurchases.DataSource = null;
                lblDescription.Text = "Select a customer to view details.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomer()
        {
            if (_cacheAllCustomers == null) return;

            string filter = txtSearchCustomer.Text.ToLower();
            var filteredList = _cacheAllCustomers
                .Where(c => c.Name.ToLower().Contains(filter))
                .ToList();

            dgvCustomers.DataSource = new BindingList<Customer>(filteredList);
        }

        private void LoadCustomerPurchases()
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is Customer selectedCustomer)
            {
                try
                {
                    DateTime startDate = DateTime.Now.AddDays(-30);
                    var purchases = PurchaseRepository.FindByCustomerIdAndDate(selectedCustomer.Id, startDate);

                    dgvPurchases.DataSource = new BindingList<Purchase>(purchases);

                    lblDescription.Text = purchases.Count == 0
                        ? "No purchases in the last 30 days."
                        : $"Showing {purchases.Count} purchases from the last 30 days.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading history: " + ex.Message);
                }
            }
        }

        private void FormatPurchaseGrid(DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvPurchases.Rows[e.RowIndex].DataBoundItem is Purchase purchase)
            {
                // match column names from designer
                if (dgvPurchases.Columns[e.ColumnIndex].Name == "colSeller")
                {
                    e.Value = purchase.Seller?.Name ?? "N/A";
                }
                else if (dgvPurchases.Columns[e.ColumnIndex].Name == "colTotal")
                {
                    e.Value = purchase.CalcTotal()?.ToString("C");
                }
            }
        }

        private void UpdateStatusLabel(string text, Color color)
        {
            lblCustomerList.Text = text;
            lblCustomerList.ForeColor = color;
        }

        #endregion

        #region event handlers

        private void ChkShowDelinquents_CheckedChanged(object sender, EventArgs e) => LoadData();

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e) => SearchCustomer();

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e) => LoadCustomerPurchases();

        private void DgvPurchases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => FormatPurchaseGrid(e);

        #endregion
    }
}