using System;
using System.ComponentModel;
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

        private Boolean _managerOverride = false;
        private Boolean _isSearchOperation = false;
        private const Decimal MAX_DISCOUNT_NO_AUTH = 0.05m;

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
            _cartItems = new BindingList<Item>();

            // setup numeric controls
            numQuantity.Minimum = 0;
            numQuantity.Maximum = 9999;
            numQuantity.DecimalPlaces = 0;

            numDiscount.Minimum = 0;
            numDiscount.Maximum = 100;

            // setup data bindings
            BindControls();

            // wire events
            txtSearchProduct.TextChanged += (s, e) => SearchProducts();
            cboCategories.SelectedIndexChanged += (s, e) => SearchProducts();
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            dgvCart.CellFormatting += DgvCart_CellFormatting;
        }

        public SaleForm() : this(null) { }

        private void BindControls()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCustomers.AutoGenerateColumns = false;
            dgvProducts.AutoGenerateColumns = false;

            if (dgvProducts.Columns["colProdStock"] != null)
            {
                dgvProducts.Columns["colProdStock"].DataPropertyName = "StockQuantity";
            }

            dgvCart.DataSource = _cartItems;

            dgvCart.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;
        }

        #region Logic Methods

        private void LoadInitialData()
        {
            try
            {
                cboCategories.DataSource = CategoryRepository.FindAll();
                cboCategories.DisplayMember = "Name";
                cboCategories.ValueMember = "Id";
                cboCategories.SelectedItem = null;

                SearchCustomers();
                SearchProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}");
            }
        }

        private void SearchCustomers()
        {
            Boolean wasSearching = _isSearchOperation;
            _isSearchOperation = true;

            try
            {
                String filter = txtSearchCustomer.Text.Trim();
                var customers = CustomerRepository.FindAll()
                    .Where(c => c.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dgvCustomers.DataSource = new BindingList<Customer>(customers);

                dgvCustomers.ClearSelection();
                dgvCustomers.CurrentCell = null;
                _selectedCustomer = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
            finally
            {
                _isSearchOperation = wasSearching;
            }
        }

        private void SelectCustomer()
        {
            if (_isSearchOperation) return;

            if (dgvCustomers.CurrentRow == null)
            {
                _selectedCustomer = null;
                return;
            }

            if (dgvCustomers.CurrentRow.DataBoundItem is not Customer shallow)
            {
                return;
            }

            // don't rerun logic if clicking the same customer
            if (_selectedCustomer != null && _selectedCustomer.Id == shallow.Id) return;

            var fullCustomer = CustomerRepository.FindByIdWithPurchases(shallow.Id);

            if (fullCustomer == null) return;

            _selectedCustomer = fullCustomer;
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

            TabControlMain.SelectedTab = tabPageProduct;
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

        private void SearchProducts()
        {
            try
            {
                String filter = txtSearchProduct.Text.Trim();
                var products = ProductRepository.FindByPartialName(filter);

                if (cboCategories.SelectedItem is Category cat)
                {
                    products = products?.Where(p => p.CategoryId == cat.Id).ToList();
                }

                if (products != null)
                {
                    dgvProducts.DataSource = new BindingList<Product>(products);
                    dgvProducts.ClearSelection();
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

            Decimal discountPercent = numDiscount.Value;
            Decimal discountDecimal = discountPercent / 100.0m;
            Decimal rawQty = numQuantity.Value;

            if (rawQty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            UInt32 quantity = (UInt32)rawQty;

            if (quantity > selectedProduct.StockQuantity)
            {
                MessageBox.Show($"Insufficient stock! Available: {selectedProduct.StockQuantity}");
                return;
            }

            if (discountDecimal > MAX_DISCOUNT_NO_AUTH)
            {
                MessageBox.Show($"Discount of {discountPercent}% requires Manager Authorization.", "Authorization");
                using (ManagerAuthForm auth = new ManagerAuthForm())
                {
                    if (auth.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Authorization denied. Item not added.");
                        return;
                    }
                }
            }

            Item newItem = new Item
            {
                Product = selectedProduct,
                Quantity = quantity,
                UnitPrice = selectedProduct.Price,
                Discount = discountDecimal
            };

            _cartItems.Add(newItem);
            UpdateTotals();

            numQuantity.Value = 0;
            numDiscount.Value = 0;
            dgvProducts.ClearSelection();
            txtSearchProduct.Focus();
            txtSearchProduct.SelectAll();
        }

        private void FinishSale()
        {
            if (_selectedCustomer == null || _cartItems.Count == 0) return;
            if (_loggedInSeller == null)
            {
                MessageBox.Show("Seller session error. Please relogin.");
                return;
            }

            if (!_selectedCustomer.CanBuy() && !_managerOverride)
            {
                MessageBox.Show("Customer blocked. Manager authorization required.");
                return;
            }

            Decimal totalSale = _cartItems.Sum(i => i.CalcTotal() ?? 0);
            Int32 installmentsCount = (Int32)numInstallments.Value;
            Decimal installmentValue = totalSale / installmentsCount;

            if (!ValidateSaleRules(totalSale, installmentsCount)) return;

            if (_loggedInSeller is not Salesperson seller)
            {
                MessageBox.Show("Only registered Salespeople can finalize sales.\n(Admins cannot be the 'Seller' of record).");
                return;
            }

            try
            {
                Purchase purchase = new Purchase
                {
                    Customer = _selectedCustomer,
                    Seller = seller,
                    Items = _cartItems.ToList(),
                    Beginning = DateTime.Now,
                    Implementation = DateTime.Now,
                    State = State.FINISHED
                };

                Decimal currentTotalDistributed = 0;

                for (Int32 i = 1; i <= installmentsCount; i++)
                {
                    Decimal valToPay;

                    if (i == installmentsCount) // check if this is the last installment
                    {
                        // last installment takes whatever is left to match the exact Total
                        valToPay = totalSale - currentTotalDistributed;
                    }
                    else
                    {
                        // standard rounding to 2 decimal places
                        valToPay = Math.Round(totalSale / installmentsCount, 2);
                    }

                    currentTotalDistributed += valToPay;

                    purchase.Payments.Add(new Payment
                    {
                        ExpirationDate = DateTime.Now.AddMonths(i),
                        Amount = valToPay, // saves the corrected value
                        PaymentFine = 0,
                        Purchase = purchase
                    });
                }

                PurchaseRepository.ProcessSaleTransaction(purchase);

                MessageBox.Show("Sale completed successfully!", "Success");
                ClearSaleScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing sale: " + ex.Message);
            }
        }

        private Boolean ValidateSaleRules(Decimal totalValue, Int32 installments)
        {
            Decimal installmentValue = totalValue / installments;

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

            lblSelectedCustomerName.Text = "Customer: (None)";
            lblTotalSale.Text = "R$ 0,00";
            txtSearchCustomer.Clear();

            SearchCustomers();
            dgvProducts.ClearSelection();

            btnFinalizeSale.Enabled = true;
            btnRequestAuth.Visible = false;

            TabControlMain.SelectedTab = tabPageCustomer;
        }

        private void FormatCartGrid(DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cartItems.Count) return;

            Item item = _cartItems[e.RowIndex];

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

        #endregion

        #region Event Handlers

        private void btnSearchCustomer_Click(object sender, EventArgs e) => SearchCustomers();

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e) => SelectCustomer();

        private void btnRequestAuth_Click(object sender, EventArgs e) => RequestAuthorization();

        private void btnAddItem_Click(object sender, EventArgs e) => AddItemToCart();

        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            FinishSale();

            if (this.MdiParent is SystemMainMenu mainMenu)
            {
                mainMenu.CheckStockAlert();
            }
        }

        private void DgvCart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => FormatCartGrid(e);

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an item to remove.", "Warning");
                return;
            }

            Int32 selectedIndex = dgvCart.CurrentRow.Index;

            if (selectedIndex < _cartItems.Count)
            {
                Item itemToRemove = _cartItems[selectedIndex];
                _cartItems.Remove(itemToRemove);
                UpdateTotals();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _isSearchOperation = true;
            try
            {
                LoadInitialData();
            }
            finally
            {
                // force clean state after data is bound
                TabControlMain.SelectedTab = tabPageCustomer;
                lblSelectedCustomerName.Text = "Customer: (None)";
                _selectedCustomer = null;

                dgvCustomers.CurrentCell = null;
                dgvCustomers.ClearSelection();

                _isSearchOperation = false;
            }
        }

        #endregion
    }
}