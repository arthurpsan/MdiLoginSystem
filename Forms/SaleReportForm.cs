using System.ComponentModel;
using System.Globalization;
using UserManagementSystem.Data;
using UserManagementSystem.Models.ViewModels;

namespace UserManagementSystem.Forms
{
    public partial class SaleReportForm : Form
    {
        private static SaleReportForm? _instance;
        private List<SaleReportViewModel> _originalList = new();

        public static SaleReportForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new SaleReportForm();
            return _instance;
        }

        public SaleReportForm()
        {
            InitializeComponent();
            dgvSales.AutoGenerateColumns = true;
            dgvSales.DataSource = bdsSales;
            txtSearch.TextChanged += (s, e) => FilterData();
        }

        // FIX: Use OnLoad to set dates back 30 days so you can see older data
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dtpStartDate.Value = DateTime.Now.AddDays(-60);
            dtpEndDate.Value = DateTime.Now;
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            decimal totalValue = 0;

            try
            {
                var purchases = PurchaseRepository.FindByDateRange(start, end);
                var brCulture = new CultureInfo("pt-BR"); // FIX: Force Brazil Currency

                _originalList = purchases.Select(p =>
                {
                    decimal total = p.CalcTotal() ?? 0;
                    totalValue += total;

                    return new SaleReportViewModel
                    {
                        SaleId = p.Id,
                        Date = p.Implementation?.ToString("g", brCulture) ?? "-",
                        SellerName = p.Seller?.Name ?? "Unknown",
                        TotalValue = total.ToString("C", brCulture) // FIX: Use explicit culture
                    };
                }).ToList();

                FilterData();
                lblTotalSales.Text = $"Total Period Sales: {totalValue.ToString("C", brCulture)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FilterData()
        {
            string term = txtSearch.Text.ToLower().Trim();
            var filtered = _originalList.Where(x => x.SellerName.ToLower().Contains(term)).ToList();
            bdsSales.DataSource = new BindingList<SaleReportViewModel>(filtered);
        }
    }
}