using System;
using UserManagementSystem.Models;
using UserManagementSystem.Data;

namespace UserManagementSystem.Forms
{
    public partial class NewSaleScreen : Form
    {
        private static NewSaleScreen? _instance;
        private User? _loggedInSeller;
        public static NewSaleScreen GetInstance(User? seller)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new NewSaleScreen();
            }

            _instance._loggedInSeller = seller;
            return _instance;
        }

        public static NewSaleScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new NewSaleScreen();
            }

            return _instance;
        }

        public NewSaleScreen()
        {
            InitializeComponent();
        }

        private Customer? _selectedCustomer;

        private List<Item> _cartItems = new List<Item>();

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementation for handling customer selection change

            if (lstCustomers.SelectedItems.Count == 0)
            {
                _selectedCustomer = null;
                return;
            }

            Customer? shallowCustomer = lstCustomers.SelectedItems[0].Tag as Customer;
            if (_selectedCustomer == null) return;

            try
            {
                _selectedCustomer = CustomerRepository.FindByIdWithPurchases(shallowCustomer.Id);

                if (_selectedCustomer == null)
                {
                    MessageBox.Show("Error loading customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblSelectedCustomerName.Text = _selectedCustomer.Name;

                if (!_selectedCustomer.CanBuy())
                {
                    MessageBox.Show("This customer is not allowed to make purchases.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnFinalizeSale.Enabled = false;
                }
                else
                {
                    btnFinalizeSale.Enabled = true;
                }

                TabControlMain.SelectedTab = tabPageProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("You cant add items without selecting a customer first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabControlMain.SelectedTab = tabPageCustomer;
                return;
            }

            if (lstProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a product.", "Error.");
                return;
            }

            Product? selectedProduct = lstProducts.SelectedItems[0].Tag as Product;
            UInt32 quantity = (UInt32)numQuantity.Value;

            if (selectedProduct == null || quantity == 0) return;

            if (quantity > selectedProduct.Stockpile)
            {
                MessageBox.Show($"Insuficcient stock. Avaible: {selectedProduct.Stockpile}", "Error");
                return;
            }

            Item newItem = new Item
            {
                Product = selectedProduct,
                Quantity = quantity,
                UnitPrice = selectedProduct.Price,
                Discount = 0
            };

            _cartItems.Add(newItem);

            UpdateCartListView();
        }

        private void UpdateCartListView()
        {
            lstCart.Items.Clear();
            Decimal? totalSale = 0;

            foreach (Item item in _cartItems)
            {
                Decimal? itemTotal = item.CalcTotal();
                if (itemTotal == null) continue;

                ListViewItem viewItem = new ListViewItem(item.Product?.Name);
                viewItem.SubItems.Add(item.Quantity?.ToString());

                viewItem.SubItems.Add(item.UnitPrice?.ToString("C"));
                viewItem.SubItems.Add(itemTotal?.ToString("C"));
                viewItem.Tag = item;

                lstCart.Items.Add(viewItem);
                totalSale += itemTotal.Value;
            }

            lblTotalSale.Text = totalSale?.ToString("C");
        }

        private void btnFinalizeSale_Click(object sender, EventArgs e)
        {

        }
    }
}
