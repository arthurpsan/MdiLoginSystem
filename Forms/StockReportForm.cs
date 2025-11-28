using System;
using System.ComponentModel;
using System.Data;
using System.Linq; // Necessário para o LINQ (.Where)
using System.Windows.Forms; // Necessário para MessageBox, Form, etc
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class StockReportForm : Form
    {
        private static StockReportForm? _instance;
        private User? _loggedInUser;

        // Use BindingList for automatic UI updates
        private BindingList<Product> _stockList;

        public static StockReportForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new StockReportForm(user);
            }
            return _instance;
        }

        // 1. Constructor
        public StockReportForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            SetupGrid();

            // Wire up the button
            btnLowStock.Click += btnLowStock_Click;

            // FIX: Load ALL data by default (false) instead of filtering immediately
            LoadStockData(false);
        }

        // Default constructor
        public StockReportForm() : this(null) { }

        private void SetupGrid()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.ReadOnly = true;
            dgvStock.AllowUserToAddRows = false;

            // Map Designer Columns to Data Properties
            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductStock.DataPropertyName = nameof(Product.StockQuantity);
            ColumunMinStock.DataPropertyName = nameof(Product.MinimumStock);
        }

        // FIX: Added boolean parameter to control filtering
        private void LoadStockData(bool showLowStockOnly)
        {
            try
            {
                var allProducts = ProductRepository.FindAll();
                List<Product> displayList;

                if (showLowStockOnly)
                {
                    // Filter: Products where StockQuantity <= MinimumStock
                    displayList = allProducts
                                    .Where(p => p.StockQuantity <= p.MinimumStock)
                                    .ToList();

                    if (displayList.Count == 0)
                    {
                        MessageBox.Show("Great news! No products are running low on stock.");
                    }
                }
                else
                {
                    // Show Everything
                    displayList = allProducts;
                }

                // Bind the result
                _stockList = new BindingList<Product>(displayList);
                dgvStock.DataSource = _stockList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }

        // 5. Event handler for the "Show Low Stock" button
        private void btnLowStock_Click(object? sender, EventArgs e)
        {
            // When clicked, we explicitly ask for the filtered list
            LoadStockData(true);
        }

        // Opcional: Se você quiser um botão para "Mostrar Todos" novamente, 
        // você pode adicionar outro botão no Designer e chamar LoadStockData(false);
    }
}