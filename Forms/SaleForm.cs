using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class SaleForm : Form
    {
        private static SaleForm? _instance;
        private readonly User? _loggedInSeller;

        private readonly BindingList<Item> _cartItems;
        private Customer? _selectedCustomer;

        // logic flags
        private bool _managerOverride = false;
        private const decimal MAX_DISCOUNT_NO_AUTH = 0.05m; // 5%

        public static SaleForm GetInstance(User? seller)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SaleForm(seller);
            }
            return _instance;
        }

        public SaleForm(User? seller)
        {
            InitializeComponent();
            _loggedInSeller = seller;

            // init empty cart
            _cartItems = new BindingList<Item>();

            // bind controls once
            BindControls();

            // load initial data
            LoadInitialData();

            // wire up events
            txtSearchProduct.TextChanged += (s, e) => SearchProducts();
            cboCategories.SelectedIndexChanged += (s, e) => SearchProducts();

            // grid events
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            dgvCart.CellFormatting += DgvCart_CellFormatting;

            // button events
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            btnAddItem.Click += btnAddItem_Click;
            btnFinalizeSale.Click += btnFinishSale_Click;
            btnRequestAuth.Click += btnRequestAuth_Click;
        }

        // default constructor for designer
        public SaleForm() : this(null) { }

        private void BindControls()
        {
            // PREVENT DUPLICATE COLUMNS
            dgvCart.AutoGenerateColumns = false;
            dgvCustomers.AutoGenerateColumns = false;
            dgvProducts.AutoGenerateColumns = false;

            // PREVENT USER EDITING
            dgvCart.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;

            // BIND CART (Starts Empty)
            dgvCart.DataSource = _cartItems;
        }

        #region logic methods

        private void LoadInitialData()
        {
            try
            {
                // 1. Setup Categories
                cboCategories.DataSource = CategoryRepository.FindAll();
                cboCategories.DisplayMember = "Name";
                cboCategories.ValueMember = "Id";
                cboCategories.SelectedItem = null;

                // 2. Load All Customers (Fix: Call search with empty text)
                SearchCustomers();

                // 3. Load All Products (Optional: populate product grid immediately)
                SearchProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}");
            }
        }

        private void SearchCustomers()
        {
            try
            {
                string filter = txtSearchCustomer.Text.Trim();
                var customers = CustomerRepository.FindAll()
                    .Where(c => c.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // DIRECT BINDING - Requires DataPropertyName in Designer to be "Name"
                dgvCustomers.DataSource = new BindingList<Customer>(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void SelectCustomer()
        {
            // Validates selection
            if (dgvCustomers.CurrentRow == null || dgvCustomers.CurrentRow.DataBoundItem is not Customer shallow)
            {
                _selectedCustomer = null;
                return;
            }

            // Re-fetch for deep data (Purchases/Payments)
            _selectedCustomer = CustomerRepository.FindByIdWithPurchases(shallow.Id);

            if (_selectedCustomer == null) return;

            lblSelectedCustomerName.Text = _selectedCustomer.Name;
            _managerOverride = false;

            if (!_selectedCustomer.CanBuy())
            {
                MessageBox.Show("Customer is delinquent. Manager authorization required.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFinalizeSale.Enabled = false;
                btnRequestAuth.Visible = true;
            }
            else
            {
                btnFinalizeSale.Enabled = true;
                btnRequestAuth.Visible = false;
            }

            // Move to Product Tab automatically
            TabControlMain.SelectedTab = tabPageProduct;
        }

        private void SearchProducts()
        {
            try
            {
                string filter = txtSearchProduct.Text.Trim();
                var products = ProductRepository.FindByPartialName(filter);

                if (cboCategories.SelectedItem is Category cat)
                {
                    products = products?.Where(p => p.CategoryId == cat.Id).ToList();
                }

                if (products != null)
                {
                    dgvProducts.DataSource = new BindingList<Product>(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message);
            }
        }

        private void AddItemToCart()
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.");
                TabControlMain.SelectedTab = tabPageCustomer;
                return;
            }

            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selectedProduct)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            uint quantity = (uint)numQuantity.Value;
            decimal discountPercent = numDiscount.Value;
            decimal discountDecimal = discountPercent / 100.0m;

            if (quantity == 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            // 1. Stock Validation
            if (quantity > selectedProduct.Stockpile)
            {
                MessageBox.Show($"Insufficient stock! Available: {selectedProduct.Stockpile}");
                return;
            }

            // 2. Manager Auth for Discount
            if (discountDecimal > MAX_DISCOUNT_NO_AUTH)
            {
                using (ManagerAuthForm auth = new ManagerAuthForm())
                {
                    if (auth.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Authorization denied. Item not added.");
                        return;
                    }
                }
            }

            // 3. Add to Cart
            Item newItem = new Item
            {
                Product = selectedProduct,
                Quantity = quantity,
                UnitPrice = selectedProduct.Price,
                Discount = discountDecimal
            };

            _cartItems.Add(newItem);
            UpdateTotals();

            // Reset UI
            numQuantity.Value = 0;
            numDiscount.Value = 0;
        }

        private void FinishSale()
        {
            if (_selectedCustomer == null || _cartItems.Count == 0) return;
            if (_loggedInSeller == null)
            {
                MessageBox.Show("Seller session error. Please relogin.");
                return;
            }

            // Security Check
            if (!_selectedCustomer.CanBuy() && !_managerOverride)
            {
                MessageBox.Show("Customer blocked. Manager authorization required.");
                return;
            }

            decimal totalSale = _cartItems.Sum(i => i.CalcTotal() ?? 0);
            int installments = (int)numInstallments.Value;

            if (!ValidateSaleRules(totalSale, installments)) return;

            try
            {
                Purchase purchase = new Purchase
                {
                    Customer = _selectedCustomer,
                    Seller = (Salesperson)_loggedInSeller,
                    Items = _cartItems.ToList(),
                    Beggining = DateTime.Now,
                    Implementation = DateTime.Now,
                    State = State.FINISHED
                };

                // Generate Installments
                for (int i = 1; i <= installments; i++)
                {
                    purchase.Payments.Add(new Payment
                    {
                        ExpirationDate = DateTime.Now.AddMonths(i),
                        PaymentFine = 0,
                        Purchase = purchase
                    });
                }

                // Update Stock
                foreach (var item in _cartItems)
                {
                    if (item.Product != null)
                    {
                        item.Product.Stockpile -= item.Quantity;
                        ProductRepository.SaveOrUpdate(item.Product);
                    }
                }

                // Save Sale
                PurchaseRepository.SaveOrUpdate(purchase);

                MessageBox.Show("Sale completed successfully!", "Success");
                ClearSaleScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing sale: " + ex.Message);
            }
        }

        private bool ValidateSaleRules(decimal totalValue, int installments)
        {
            decimal installmentValue = totalValue / installments;

            if (installmentValue < 50)
            {
                MessageBox.Show($"Installment value ({installmentValue:C}) is less than R$ 50.00 minimum.", "Rule Violation");
                return false;
            }

            if (installments > 6)
            {
                MessageBox.Show("Maximum installments is 6.", "Rule Violation");
                return false;
            }

            return true;
        }

        private void ClearSaleScreen()
        {
            _selectedCustomer = null;
            _cartItems.Clear();
            _managerOverride = false;

            lblSelectedCustomerName.Text = "Customer:";
            lblTotalSale.Text = "R$ 0,00";
            txtSearchCustomer.Clear();

            // Clear grids
            dgvCustomers.DataSource = null;
            dgvProducts.DataSource = null;

            btnFinalizeSale.Enabled = true;
            btnRequestAuth.Visible = false;

            TabControlMain.SelectedTab = tabPageCustomer;
        }

        private void FormatCartGrid(DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cartItems.Count) return;

            Item item = _cartItems[e.RowIndex];

            // Ensure these Column Names match your Designer Names!
            if (dgvCart.Columns[e.ColumnIndex].Name == "colProduct")
            {
                e.Value = item.Product?.Name ?? "Unknown";
            }
            else if (dgvCart.Columns[e.ColumnIndex].Name == "colTotal")
            {
                e.Value = item.CalcTotal()?.ToString("C");
            }
        }

        private void UpdateTotals()
        {
            decimal total = _cartItems.Sum(i => i.CalcTotal() ?? 0);
            lblTotalSale.Text = total.ToString("C");
        }

        private void RequestAuthorization()
        {
            using (ManagerAuthForm authForm = new ManagerAuthForm())
            {
                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Sale Authorized by Manager.", "Success");
                    _managerOverride = true;
                    btnFinalizeSale.Enabled = true;
                    btnRequestAuth.Visible = false;
                }
            }
        }

        #endregion

        #region event handlers

        private void btnSearchCustomer_Click(object sender, EventArgs e) => SearchCustomers();

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e) => SelectCustomer();

        private void btnRequestAuth_Click(object sender, EventArgs e) => RequestAuthorization();

        private void btnAddItem_Click(object sender, EventArgs e) => AddItemToCart();

        private void btnFinishSale_Click(object sender, EventArgs e) => FinishSale();

        private void DgvCart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => FormatCartGrid(e);

        #endregion
    }
}