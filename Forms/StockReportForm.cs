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
        private User? _loggedInUser;

        // Use BindingList for automatic UI updates (optional, but good practice)
        private BindingList<Product> _lowStockProducts;

        public static StockReportForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new StockReportForm(user);
            }
            return _instance;
        }

        // 1. Constructor that accepts User (matching other forms)
        public StockReportForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            SetupGrid();

            // 2. Wire up the button from your Designer
            btnLowStock.Click += btnLowStock_Click;

            // Load data immediately on open
            LoadLowStockData();
        }

        // Default constructor if needed by Designer
        public StockReportForm() : this(null) { }

        private void SetupGrid()
        {
            // IMPORTANT: Stop the grid from creating its own columns.
            // We want to use the ones you created: ColumnProductName, ColumnProductStock, etc.
            dgvStock.AutoGenerateColumns = false;

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.ReadOnly = true;
            dgvStock.AllowUserToAddRows = false;

            // 3. Map Your Designer Columns to the Data Properties
            // These names "Name", "Stockpile", "MinimumStock" must match your Product.cs model exactly.
            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductStock.DataPropertyName = nameof(Product.Stockpile);
            ColumunMinStock.DataPropertyName = nameof(Product.MinimumStock);
        }

        private void LoadLowStockData()
        {
            try
            {
                var allProducts = ProductRepository.FindAll();

                // 4. Filter: Products where Stockpile <= MinimumStock
                var lowStockList = allProducts
                                    .Where(p => p.Stockpile <= p.MinimumStock)
                                    .ToList();

                // Bind directly to the list of Products
                _lowStockProducts = new BindingList<Product>(lowStockList);
                dgvStock.DataSource = _lowStockProducts;

                if (lowStockList.Count == 0)
                {
                    MessageBox.Show("Great news! No products are running low on stock.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }

        // 5. The event handler for your specific button
        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            LoadLowStockData();
        }
    }
}