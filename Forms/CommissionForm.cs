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

            // setupgrid
            dgvCommissions.AutoGenerateColumns = false;

            if (dgvCommissions.Columns["colSaleValue"] == null)
            {
                var colSaleValue = new DataGridViewTextBoxColumn();
                colSaleValue.Name = "colSaleValue";
                colSaleValue.HeaderText = "Sale Value";
                colSaleValue.DataPropertyName = "TotalSaleValue"; // link to viewmodel
                colSaleValue.ReadOnly = true;
                dgvCommissions.Columns.Insert(3, colSaleValue);
            }

            dgvCommissions.DataSource = bdsCommissions;

            // setup events
            txtSearch.TextChanged += (s, e) => FilterData();

            // when dates change update data
            dtpInitialDate.ValueChanged += (s, e) => LoadCommissionData();
            dtpFinalDate.ValueChanged += (s, e) => LoadCommissionData();
        }

        #region DATA LOADING + FILTERING
        private void LoadCommissionData()
        {
            DateTime start = dtpInitialDate.Value.Date;
            DateTime end = dtpFinalDate.Value.Date.AddDays(1).AddTicks(-1);
            Decimal totalComm = 0;

            try
            {
                List<Purchase> purchases = PurchaseRepository.FindByDateRange(start, end);

                _originalList = purchases.Select(p =>
                {
                    // calc totals
                    Decimal saleTotal = p.CalcTotal() ?? 0;
                    Decimal comm = p.CalcComission() ?? 0;

                    totalComm += comm;

                    return new CommissionViewModel
                    {
                        SellerId = p.Seller?.Id,
                        SellerName = p.Seller?.Name ?? "N/A",
                        PurchaseId = p.Id,
                        Date = p.Implementation?.ToString("d") ?? "-",
                        TotalSaleValue = saleTotal.ToString("C"),

                        Commission = comm.ToString("C")
                    };
                }).ToList();

                FilterData();
                lblTotalComission.Text = $"Total Commission: {totalComm:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void FilterData()
        {
            String term = txtSearch.Text.ToLower().Trim();
            var filtered = _originalList.Where(x => x.SellerName.ToLower().Contains(term)).ToList();
            bdsCommissions.DataSource = new BindingList<CommissionViewModel>(filtered);
        }

        #endregion

        // Event handlers
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // set defaults
            dtpInitialDate.Value = DateTime.Now.AddDays(-30);
            dtpFinalDate.Value = DateTime.Now;
        }
    }
}