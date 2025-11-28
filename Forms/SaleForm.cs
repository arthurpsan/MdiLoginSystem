using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem.Forms
{
    public partial class SaleForm : Form
    {
        private static SaleForm? _instance;
        private readonly User? _loggedInSeller;

        private readonly BindingList<Item> _cartItems;
        private Customer? _selectedCustomer;

        private bool _managerOverride = false;
        private bool _isSearchOperation = false;
        private const decimal MAX_DISCOUNT_NO_AUTH = 0.05m;

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _isSearchOperation = true; // lock events
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

                _isSearchOperation = false; // unlock events
            }
        }

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
            // Ativa a flag para impedir que o 'SelectionChanged' dispare popups enquanto a lista muda
            bool wasSearching = _isSearchOperation;
            _isSearchOperation = true;

            try
            {
                string filter = txtSearchCustomer.Text.Trim();
                var customers = CustomerRepository.FindAll()
                    .Where(c => c.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dgvCustomers.DataSource = new BindingList<Customer>(customers);

                // Limpa a seleção automática do DataGridView
                dgvCustomers.ClearSelection();
                dgvCustomers.CurrentCell = null; // Extra safety
                _selectedCustomer = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
            finally
            {
                // Restaura o estado anterior da flag
                _isSearchOperation = wasSearching;
            }
        }

        private void SelectCustomer()
        {
            // CRÍTICO: Se estivermos pesquisando ou carregando, NÃO execute a lógica de seleção
            if (_isSearchOperation) return;

            // If nothing is selected, reset and return
            if (dgvCustomers.CurrentRow == null)
            {
                _selectedCustomer = null;
                return;
            }

            if (dgvCustomers.CurrentRow.DataBoundItem is not Customer shallow)
            {
                return;
            }

            // Optimization: Don't re-run logic if clicking the same customer
            if (_selectedCustomer != null && _selectedCustomer.Id == shallow.Id) return;

            // Busca dados completos (incluindo compras para verificar inadimplência)
            var fullCustomer = CustomerRepository.FindByIdWithPurchases(shallow.Id);

            if (fullCustomer == null) return;

            _selectedCustomer = fullCustomer;
            lblSelectedCustomerName.Text = _selectedCustomer.Name;
            _managerOverride = false;

            // Verifica Inadimplência
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

            // Muda para a aba de produtos
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
                string filter = txtSearchProduct.Text.Trim();
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

            decimal discountPercent = numDiscount.Value;
            decimal discountDecimal = discountPercent / 100.0m;
            decimal rawQty = numQuantity.Value;

            if (rawQty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            uint quantity = (uint)rawQty;

            // Validar Estoque
            if (quantity > selectedProduct.StockQuantity)
            {
                MessageBox.Show($"Insufficient stock! Available: {selectedProduct.StockQuantity}");
                return;
            }

            // Validar Desconto (Regra de Negócio: > 5% precisa de gerente)
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

            // Adicionar Item
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
            dgvProducts.ClearSelection();
        }

        private void FinishSale()
        {
            if (_selectedCustomer == null || _cartItems.Count == 0) return;
            if (_loggedInSeller == null)
            {
                MessageBox.Show("Seller session error. Please relogin.");
                return;
            }

            // Re-checar segurança (caso o usuário tenha trocado de cliente no meio do processo)
            if (!_selectedCustomer.CanBuy() && !_managerOverride)
            {
                MessageBox.Show("Customer blocked. Manager authorization required.");
                return;
            }

            decimal totalSale = _cartItems.Sum(i => i.CalcTotal() ?? 0);
            int installments = (int)numInstallments.Value;

            if (!ValidateSaleRules(totalSale, installments)) return;

            // Verificar Papel (Apenas vendedores podem vender)
            if (_loggedInSeller is not Salesperson seller)
            {
                MessageBox.Show("Only registered Salespeople can finalize sales.\n(Admins cannot be the 'Seller' of record).");
                return;
            }

            try
            {
                // 1. Criar Objeto Compra
                Purchase purchase = new Purchase
                {
                    Customer = _selectedCustomer,
                    Seller = seller,
                    Items = _cartItems.ToList(),
                    Beginning = DateTime.Now,
                    Implementation = DateTime.Now,
                    State = State.FINISHED
                };

                // 2. Gerar Pagamentos (Parcelas)
                for (int i = 1; i <= installments; i++)
                {
                    purchase.Payments.Add(new Payment
                    {
                        ExpirationDate = DateTime.Now.AddMonths(i),
                        PaymentFine = 0,
                        Purchase = purchase
                    });
                }

                // 3. Salvar (Transação abate estoque automaticamente)
                PurchaseRepository.ProcessSaleTransaction(purchase);

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

            lblSelectedCustomerName.Text = "Customer: (None)";
            lblTotalSale.Text = "R$ 0,00";
            txtSearchCustomer.Clear();

            // Reset Grids
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

        private void btnFinishSale_Click(object sender, EventArgs e) => FinishSale();

        private void DgvCart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => FormatCartGrid(e);

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an item to remove.", "Warning");
                return;
            }

            int selectedIndex = dgvCart.CurrentRow.Index;

            if (selectedIndex < _cartItems.Count)
            {
                Item itemToRemove = _cartItems[selectedIndex];
                _cartItems.Remove(itemToRemove);
                UpdateTotals();
            }
        }

        #endregion
    }
}