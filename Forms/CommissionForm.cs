using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class CommissionForm : Form
    {
        private static CommissionForm? _instance;
        public static CommissionForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CommissionForm();
            }

            return _instance;
        }

        public CommissionForm()
        {
            InitializeComponent();
            this.Load += ComissionReportScreen_Load;
        }

        private void ComissionReportScreen_Load(object sender, EventArgs e)
        {
            try
            {
                List<Salesperson> sellers = SellerRepository.FindAll();

                cboSalesperson.Items.Add("All sellers");

                cboSalesperson.Items.AddRange(sellers.ToArray());

                cboSalesperson.DisplayMember = "Name";
                cboSalesperson.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading sellers data: {ex.Message}", "Error");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpInitialDate.Value.Date;
            DateTime endDate = dtpFinalDate.Value.Date.AddDays(1).AddTicks(-1);

            lstReports.Items.Clear();
            decimal totalComission = 0;

            try
            {
                Salesperson? selectedSeller = cboSalesperson.SelectedItem as Salesperson;

                List<Purchase> purchases;

                if (selectedSeller == null)
                {
                    purchases = PurchaseRepository.FindByDateRange(startDate, endDate);
                }
                else
                {
                    purchases = PurchaseRepository.FindByDateRangeAndSeller(startDate, endDate, selectedSeller.Id);
                }

                foreach (var purchase in purchases)
                {
                    decimal? comission = purchase.CalcComission();
                    totalComission += comission ?? 0;

                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add(purchase.Seller?.Id.ToString() ?? "N/A");
                    item.SubItems.Add(purchase.Id.ToString());

                    item.SubItems.Add(comission?.ToString("C"));

                    item.SubItems.Add(purchase.Seller?.Name ?? "N/A");

                    lstReports.Items.Add(item);
                }

                lblTotalComission.Text = $"Total Comission: {totalComission:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Critical Error");
            }
        }
    }
}
