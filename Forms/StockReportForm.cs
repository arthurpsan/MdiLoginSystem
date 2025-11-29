using System;
using System.ComponentModel;
using System.Data;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class StockReportForm : Form
    {
        private static StockReportForm? _instance;
        private bool _isFilterActive = false;

        public static StockReportForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed) _instance = new StockReportForm();
            return _instance;
        }

        public StockReportForm()
        {
            InitializeComponent();
            SetupGrid();

            btnLowStock.Click += btnLowStock_Click;

            txtSearch.TextChanged += (s, e) => LoadStockData();

            LoadStockData();
        }

        private void SetupGrid()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductStock.DataPropertyName = nameof(Product.StockQuantity);
            ColumunMinStock.DataPropertyName = nameof(Product.MinimumStock);
        }

        private void LoadStockData()
        {
            try
            {
                var query = ProductRepository.FindAll().AsEnumerable();

                // low stock filter
                if (_isFilterActive)
                {
                    query = query.Where(p => p.StockQuantity <= p.MinimumStock);
                    btnLowStock.Text = "Show All";
                }
                else
                {
                    btnLowStock.Text = "Filter Low Stock";
                }

                // search filter
                string searchTerm = txtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.Name != null &&
                                             p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                }

                var resultList = query.ToList();

                dgvStock.DataSource = new BindingList<Product>(resultList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            _isFilterActive = !_isFilterActive;
            LoadStockData();
        }
    }
}