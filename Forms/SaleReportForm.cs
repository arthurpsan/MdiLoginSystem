using System.ComponentModel;
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

            this.Load += (s, e) => btnRefresh_Click(s, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            decimal totalValue = 0;

            try
            {
                var purchases = PurchaseRepository.FindByDateRange(start, end);

                _originalList = purchases.Select(p =>
                {
                    decimal total = p.CalcTotal() ?? 0;
                    totalValue += total;

                    return new SaleReportViewModel
                    {
                        SaleId = p.Id,
                        Date = p.Implementation?.ToString("g") ?? "-",
                        SellerName = p.Seller?.Name ?? "Unknown",
                        TotalValue = total.ToString("C")
                    };
                }).ToList();

                FilterData();
                lblTotalSales.Text = $"Total Period Sales: {totalValue:C}";
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
            bdsSales.DataSource = new BindingList<SaleReportViewModel>(filtered); // Assuming you named BindingSource 'bdsSales'
        }
    }
}