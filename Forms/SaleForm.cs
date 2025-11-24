using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class SaleForm : Form
    {
        private static SaleForm? _instance;
        private User? _loggedInSeller;

        // logic variables
        private Customer? _selectedCustomer;
        private List<Item> _cartItems = new List<Item>();
        private bool _managerOverride = false;
        private const decimal MAX_DISCOUNT_NO_AUTH = 0.05m; // 5%

        public static SaleForm GetInstance(User? seller)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SaleForm();
            }
            _instance._loggedInSeller = seller;
            return _instance;
        }

        public SaleForm()
        {
            InitializeComponent();

            this.Load += LoadInitialData;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            txtSearchProduct.TextChanged += (sender, e) => SearchProducts();
            cboCategories.SelectedIndexChanged += (sender, e) => SearchProducts();
            btnRequestAuth.Click += btnRequestAuth_Click;

            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            btnAddItem.Click += btnAddItem_Click;
            btnFinalizeSale.Click += btnFinishSale_Click;
        }

        private void LoadInitialData(object sender, EventArgs e)
        {
            try
            {
                cboCategories.DataSource = CategoryRepository.FindAll();
                cboCategories.DisplayMember = "Name";
                cboCategories.ValueMember = "Id";
                cboCategories.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falied to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customer Search

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var customers = CustomerRepository.FindAll()
                    .Where(c => c.Name.Contains(txtSearchCustomer.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                lstCustomers.Items.Clear();
                foreach (var customer in customers)
                {
                    // Usa as colunas do seu Designer (ID e Nome/Email)
                    ListViewItem item = new ListViewItem(customer.Id.ToString());

                    item.SubItems.Add(customer.Id.ToString());
                    item.SubItems.Add(customer.Name); // Corrigido de 'Email' para 'Name'
                    item.Tag = customer;
                    lstCustomers.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falied to search customers: {ex.Message}", "Error");
            }
        }

        private void SearchProducts()
        {
            try
            {
                var products = ProductRepository.FindByPartialName(txtSearchProduct.Text);
                Category? selectedCategory = cboCategories.SelectedItem as Category;

                if (selectedCategory != null && products != null)
                {
                    products = products.Where(p => p.Category != null && p.Category.Id == selectedCategory.Id).ToList();
                }

                lstProducts.Items.Clear();
                if (products != null)
                {
                    foreach (var product in products)
                    {
                        ListViewItem item = new ListViewItem(product.Id.ToString());
                        item.SubItems.Add(product.Name);
                        item.SubItems.Add(product.Price?.ToString("C"));
                        item.SubItems.Add(product.Stockpile?.ToString());
                        item.Tag = product;
                        lstProducts.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro while searching products: {ex.Message}", "Error");
            }
        }

        // Authorization and Customer Selection

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count == 0)
            {
                _selectedCustomer = null;
                return;
            }

            Customer? shallowCustomer = lstCustomers.SelectedItems[0].Tag as Customer;
            if (shallowCustomer == null) return;

            try
            {
                _selectedCustomer = CustomerRepository.FindByIdWithPurchases(shallowCustomer.Id);

                if (_selectedCustomer == null)
                {
                    MessageBox.Show("Erro while loading customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblSelectedCustomerName.Text = _selectedCustomer.Name;
                _managerOverride = false;

                if (!_selectedCustomer.CanBuy())
                {
                    MessageBox.Show("Customer has pending issues. Sale is blocked. waiting for authorization.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnFinalizeSale.Enabled = false;
                    btnRequestAuth.Visible = true;
                }
                else
                {
                    btnFinalizeSale.Enabled = true;
                    btnRequestAuth.Visible = false;
                }

                TabControlMain.SelectedTab = tabPageProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRequestAuth_Click(object sender, EventArgs e)
        {
            using (ManagerAuthForm authForm = new ManagerAuthForm())
            {
                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Authorization conceded. Sale approved.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _managerOverride = true;
                    btnFinalizeSale.Enabled = true;
                    btnRequestAuth.Visible = false;
                }
            }
        }

        // Logic/Method used in our shopping cart

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
            decimal discountPercent = (decimal)numDiscount.Value;
            decimal discountDecimal = discountPercent / 100.0m;

            if (selectedProduct == null || quantity == 0) return;

            if (discountDecimal > MAX_DISCOUNT_NO_AUTH)
            {
                MessageBox.Show($"{discountPercent}% Discount breaks our 5% limit. The manager's authorization is needed.", "Authorization");

                using (ManagerAuthForm authForm = new ManagerAuthForm())
                {
                    if (authForm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Discount not authorized. The item will not be added.", "Authorization blocked");
                        return;
                    }
                }
            }

            if (quantity > selectedProduct.Stockpile)
            {
                MessageBox.Show($"Insufficient stock. Avaible: {selectedProduct.Stockpile}", "Error");
                return;
            }

            Item newItem = new Item
            {
                Product = selectedProduct,
                Quantity = quantity,
                UnitPrice = selectedProduct.Price,
                Discount = discountDecimal
            };

            _cartItems.Add(newItem);
            UpdateCartListView();

            numQuantity.Value = 0;
            numDiscount.Value = 0;
            lstProducts.SelectedItems.Clear();
        }

        private void UpdateCartListView()
        {
            lstCart.Items.Clear();
            Decimal? totalSale = 0;

            foreach (Item item in _cartItems)
            {
                Decimal? itemTotal = item.CalcTotal();
                if (itemTotal == null) continue;

                // CORREÇÃO: Adiciona a coluna de desconto
                ListViewItem viewItem = new ListViewItem(item.Product?.Name ?? "N/A");
                viewItem.SubItems.Add(item.Quantity?.ToString() ?? "0");
                viewItem.SubItems.Add(item.Discount?.ToString("P0")); // "P0" = 5%
                viewItem.SubItems.Add(item.UnitPrice?.ToString("C"));
                viewItem.SubItems.Add(itemTotal?.ToString("C"));
                viewItem.Tag = item;

                lstCart.Items.Add(viewItem);
                totalSale += itemTotal.Value;
            }

            lblTotalSale.Text = totalSale?.ToString("C");
        }

        // Finishing

        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null) { return; }
            if (_cartItems.Count == 0) { return; }
            if (_loggedInSeller == null || _loggedInSeller is not Salesperson) { return; }

            if (!_selectedCustomer.CanBuy() && !_managerOverride)
            {
                MessageBox.Show("This customer is está delinquent does not have manager authorization.", "Sale not authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Purchase newPurchase = new Purchase
                {
                    Customer = _selectedCustomer,
                    Seller = (Salesperson)_loggedInSeller,
                    Items = _cartItems,
                    Beggining = DateTime.Now,
                    Implementation = DateTime.Now,
                    State = State.FINISHED,
                };

                int installmentsCount = (int)numInstallments.Value;
                decimal? totalSale = newPurchase.CalcTotal();
                decimal installmentValue = (totalSale ?? 0) / installmentsCount;

                if (installmentValue < 50)
                {
                    MessageBox.Show($"Value of installment (R$ {installmentValue:F2}) is less than R$ 50,00.", "Error");
                    return;
                }

                for (int i = 1; i <= installmentsCount; i++)
                {
                    Payment newPayment = new Payment
                    {
                        ExpirationDate = DateTime.Now.AddMonths(i),
                        DatePayment = null,
                        PaymentFine = 0,
                        Purchase = newPurchase
                    };
                    newPurchase.Payments.Add(newPayment);
                }

                foreach (Item item in _cartItems)
                {
                    if (item.Product != null && item.Quantity != null)
                    {
                        item.Product.Stockpile -= item.Quantity;
                        ProductRepository.SaveOrUpdate(item.Product);
                    }
                }

                PurchaseRepository.SaveOrUpdate(newPurchase);
                MessageBox.Show("Sale done with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearSaleScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to complete sale: {ex.Message}", "Critical Error");
            }
        }

        private void ClearSaleScreen()
        {
            _selectedCustomer = null;
            _cartItems.Clear();
            _managerOverride = false;

            lblSelectedCustomerName.Text = "Customer:";
            txtSearchCustomer.Clear();
            lstCustomers.Items.Clear();

            txtSearchProduct.Clear();
            lstProducts.Items.Clear();
            cboCategories.SelectedItem = null;

            UpdateCartListView();

            numInstallments.Value = 1;
            numDiscount.Value = 0;
            numQuantity.Value = 0;

            btnFinalizeSale.Enabled = true;
            btnRequestAuth.Visible = false;

            TabControlMain.SelectedTab = tabPageCustomer;
        }
    }
}