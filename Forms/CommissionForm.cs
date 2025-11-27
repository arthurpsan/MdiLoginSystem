using System.ComponentModel;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Models.ViewModels;

namespace UserManagementSystem.Forms
{
    public partial class CommissionForm : Form
    {
        private static CommissionForm? _instance;
        private List<CommissionViewModel> _originalList = new();

        public static CommissionForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new CommissionForm();
            return _instance;
        }

        public CommissionForm()
        {
            InitializeComponent();

            dgvCommissions.AutoGenerateColumns = true;
            dgvCommissions.DataSource = bdsCommissions;

            txtSearch.TextChanged += (s, e) => FilterData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DateTime start = dtpInitialDate.Value.Date;
            DateTime end = dtpFinalDate.Value.Date.AddDays(1).AddTicks(-1);
            decimal totalComm = 0;

            try
            {
                Salesperson? seller = cboSalesperson.SelectedItem as Salesperson;
                List<Purchase> purchases;

                if (seller == null || cboSalesperson.SelectedIndex == 0)
                    purchases = PurchaseRepository.FindByDateRange(start, end);
                else
                    purchases = PurchaseRepository.FindByDateRangeAndSeller(start, end, seller.Id);

                _originalList = purchases.Select(p =>
                {
                    decimal comm = p.CalcComission() ?? 0;
                    totalComm += comm;

                    return new CommissionViewModel
                    {
                        SellerId = p.Seller?.Id,
                        SellerName = p.Seller?.Name ?? "N/A",
                        PurchaseId = p.Id,
                        Date = p.Implementation?.ToString("d") ?? "-",
                        Commission = comm.ToString("C")
                    };
                }).ToList();

                FilterData();
                lblTotalComission.Text = $"Total Commission: {totalComm:C}";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void FilterData()
        {
            string term = txtSearch.Text.ToLower().Trim();
            var filtered = _originalList.Where(x => x.SellerName.ToLower().Contains(term)).ToList();
            bdsCommissions.DataSource = new BindingList<CommissionViewModel>(filtered);
        }
    }
}