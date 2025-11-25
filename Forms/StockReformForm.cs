using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.ComponentModel;


namespace UserManagementSystem.Forms
{
    public partial class StockReformForm : Form
    {
        private static StockReformForm? _instance;
        private readonly Repository _dbContext;
        private BindingList<Product> _products;
        public static StockReformForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new StockReformForm();
            }
            return _instance;
        }

        public StockReformForm()
        {
            InitializeComponent();

            _dbContext = new Repository();
            _dbContext.Products.Load();

            _products = _dbContext.Products.Local.ToBindingList();

            ColumnProductId.DataPropertyName = nameof(Product.Id);
            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductStock.DataPropertyName = nameof(Product.Stockpile);
            ColumunMinStock.DataPropertyName = nameof(Product.MinimumStock);



        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            Form reportForm = new Form();
            reportForm.Text = "Products with Low Stock";
            reportForm.Size = new Size(500, 400);

            ListView lstStock = new ListView();
            lstStock.Parent = reportForm;
            lstStock.Dock = DockStyle.Fill;
            lstStock.View = View.Details;
            lstStock.Columns.Add("Product", 200);
            lstStock.Columns.Add("Current Stock", 100);
            lstStock.Columns.Add("Min Stock", 100);

            // Requirement: Filter products where Stock <= MinStock
            var products = ProductRepository.FindAll()
                            .Where(p => p.Stockpile <= p.MinimumStock)
                            .ToList();

            foreach (var p in products)
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Stockpile.ToString());
                item.SubItems.Add(p.MinimumStock.ToString());
                item.BackColor = Color.LightCoral; // Highlight Alert
                lstStock.Items.Add(item);
            }

            reportForm.ShowDialog();
        }
    }
}
