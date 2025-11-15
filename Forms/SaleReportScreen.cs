using System;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class SaleReportScreen : Form
    {
        private static SaleReportScreen _instance;
        public static SaleReportScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SaleReportScreen();
            }

            return _instance;
        }
        public SaleReportScreen()
        {
            InitializeComponent();
        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

            lstReports.Items.Clear();
            decimal totalSales = 0;

            try
            {
                var purchases = PurchaseRepository.FindByDateRange(startDate, endDate);

                foreach (var purchase in purchases)
                {
                    decimal? saleValue = purchase.CalcTotal();
                    totalSales += saleValue ?? 0;

                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add(purchase.Id.ToString());
                    item.SubItems.Add(purchase.Implementation?.ToString("g"));
                    item.SubItems.Add(saleValue?.ToString("C"));

                    item.SubItems.Add(purchase.Seller?.Name ?? "N/A");

                    lstReports.Items.Add(item);
                }

                label3.Text = $"Total sales: {totalSales:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading report: {ex.Message}", "Critical Error");
            }
        }
    }
}
