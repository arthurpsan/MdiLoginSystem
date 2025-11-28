// ... imports

using System.ComponentModel;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class StockReportForm : Form
    {
        private static StockReportForm? _instance;
        private bool _isFilterActive = false; // Toggle state

        public static StockReportForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed) _instance = new StockReportForm();
            return _instance;
        }

        public StockReportForm()
        {
            InitializeComponent();
            SetupGrid();

            // Wire event
            btnLowStock.Click += btnLowStock_Click;

            // Load all data by default
            LoadStockData(false);
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

        private void LoadStockData(bool showLowStockOnly)
        {
            try
            {
                var allProducts = ProductRepository.FindAll();
                List<Product> displayList;

                if (showLowStockOnly)
                {
                    displayList = allProducts.Where(p => p.StockQuantity <= p.MinimumStock).ToList();
                    btnLowStock.Text = "Show All"; // Update button text
                    if (displayList.Count == 0) MessageBox.Show("No low stock items found.");
                }
                else
                {
                    displayList = allProducts;
                    btnLowStock.Text = "Filter Low Stock"; // Update button text
                }

                dgvStock.DataSource = new BindingList<Product>(displayList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            _isFilterActive = !_isFilterActive; // Toggle
            LoadStockData(_isFilterActive);
        }
    }
}