using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementSystem.Data;

namespace UserManagementSystem.Forms
{
    public partial class StockReformForm : Form
    {
        public StockReformForm()
        {
            InitializeComponent();
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
