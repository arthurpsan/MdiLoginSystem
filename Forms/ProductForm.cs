using System;
using System.ComponentModel;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private static ProductForm? _instance;
        private readonly User? _loggedInUser;

        private readonly BindingSource _bdsProducts = new BindingSource();
        private readonly BindingSource _bdsCategories = new BindingSource();

        public static ProductForm GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new ProductForm(user);
            return _instance;
        }

        public ProductForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;
            this.Load += Form_Load;

            // wire grid selections to inputs
            dgvCategory.SelectionChanged += (s, e) => PopulateCategoryInputs();
            dgvProduct.SelectionChanged += (s, e) => PopulateProductInputs();

            dgvProduct.CellFormatting += (s, e) =>
            {
                if (dgvProduct.Columns[e.ColumnIndex].Name == "ColumnProductCategory" && e.Value is Category cat)
                {
                    e.Value = cat.Name;
                    e.FormattingApplied = true;
                }
            };
        }

        public ProductForm() : this(null) { }

        private void Form_Load(object? sender, EventArgs e)
        {
            SetupGrids();

            nudProductPrice.Maximum = 9999999;
            nudProductPrice.DecimalPlaces = 2;

            nudStock.Maximum = 999999;
            nudMinStock.Maximum = 999999;

            LoadData();
        }

        private void SetupGrids()
        {
            // categories grid
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.ReadOnly = true;

            dgvCategory.Columns.Clear();
            dgvCategory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnCategoryName",
                HeaderText = "Category Name",
                DataPropertyName = nameof(Category.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCategory.DataSource = _bdsCategories;

            // products grid
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ReadOnly = true;

            dgvProduct.Columns.Clear();
            dgvProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnProductName", HeaderText = "Name", DataPropertyName = nameof(Product.Name), Width = 200 });
            dgvProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnProductPrice", HeaderText = "Price", DataPropertyName = nameof(Product.Price), Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnProductCurrentStock", HeaderText = "Stock", DataPropertyName = nameof(Product.StockQuantity), Width = 70 });
            dgvProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnProductMinStock", HeaderText = "Min.", DataPropertyName = nameof(Product.MinimumStock), Width = 70 });
            dgvProduct.Columns.Add(new DataGridViewCheckBoxColumn { Name = "ColumnProductIsActive", HeaderText = "Active", DataPropertyName = nameof(Product.IsActive), Width = 50 });

            dgvProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnProductCategory", HeaderText 
                = "Category", DataPropertyName 
                = nameof(Product.Category), 
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvProduct.DataSource = _bdsProducts;

            // combobox
            cboProductCategory.DataSource = _bdsCategories;
            cboProductCategory.DisplayMember = "Name";
        }

        private void LoadData()
        {
            try
            {
                var categories = CategoryRepository.FindAll();
                _bdsCategories.DataSource = new BindingList<Category>(categories);

                var products = ProductRepository.FindAll();
                _bdsProducts.DataSource = new BindingList<Product>(products);
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Failed to load data: " + ex.Message);
            }
        }

        #region Input Population
        private void PopulateCategoryInputs()
        {
            if (_bdsCategories.Current is Category selected)
            {
                txtCategoryName.Text = selected.Name;
            }
            else
            {
                txtCategoryName.Clear();
            }
        }

        private void PopulateProductInputs()
        {
            if (_bdsProducts.Current is Product selected)
            {
                txtProductName.Text = selected.Name;
                nudProductPrice.Value = selected.Price ?? 0;
                nudStock.Value = selected.StockQuantity ?? 0;
                nudMinStock.Value = selected.MinimumStock ?? 0;
                chkIsActive.Checked = selected.IsActive;

                cboProductCategory.SelectedItem = selected.Category;
            }
            else
            {
                ClearProductInputs();
            }
        }

        private void ClearProductInputs()
        {
            txtProductName.Clear();
            nudProductPrice.Value = 0;
            nudStock.Value = 0;
            nudMinStock.Value = 0;
            chkIsActive.Checked = true;
            if (cboProductCategory.Items.Count > 0) cboProductCategory.SelectedIndex = 0;
            dgvProduct.ClearSelection();
        }
        #endregion

        #region CATEGORY EVENT HANDLERS
        private void btnRegisterCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                Alerts.ShowWarning("Please enter a category name.");
                return;
            }

            string nameToCheck = txtCategoryName.Text.Trim();

            try
            {
                bool exists = CategoryRepository.FindAll()
                    .Any(c => c.Name.Equals(nameToCheck, StringComparison.OrdinalIgnoreCase));

                if (exists)
                {
                    Alerts.ShowWarning("A category with this name already exists.");
                    return;
                }

                var category = new Category { Name = txtCategoryName.Text };
                CategoryRepository.SaveOrUpdate(category);

                _bdsCategories.Add(category);
                _bdsCategories.MoveLast();
                Alerts.ShowSuccess("Category registered!");
                txtCategoryName.Clear();
            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (_bdsCategories.Current is not Category current)
            {
                Alerts.ShowWarning("Select a category to update.");
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                Alerts.ShowWarning("Category name cannot be empty.");
                return;
            }

            String newName = txtCategoryName.Text.Trim();

            try
            {
                bool exists = CategoryRepository.FindAll()
                    .Any(c => c.Name.Equals(newName, StringComparison.OrdinalIgnoreCase) 
                    && c.Id != current.Id);

                if (exists)
                {
                    Alerts.ShowWarning("Another category already uses this name.");
                    return;
                }

                current.Name = newName;
                CategoryRepository.SaveOrUpdate(current);

                _bdsCategories.ResetCurrentItem();
                dgvProduct.Refresh();

                Alerts.ShowSuccess("Category updated!");
            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (_bdsCategories.Current is not Category current) return;

            if (Alerts.ConfirmAction($"Delete category '{current.Name}'?"))
            {
                try
                {
                    CategoryRepository.Delete(current);
                    _bdsCategories.RemoveCurrent();
                    Alerts.ShowSuccess("Category deleted.");
                }
                catch (Exception ex)
                {
                    Alerts.ShowError("Cannot delete: " + ex.Message);
                }
            }
        }
        #endregion

        #region PRODUCT EVENT HANDLERS
        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            if (cboProductCategory.SelectedItem is not Category selectedCategory)
            {
                Alerts.ShowWarning("Please select a valid category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                Alerts.ShowWarning("Please enter a product name.");
                return;
            }

            string nameToCheck = txtProductName.Text.Trim();

            try
            {
                bool exists = ProductRepository.FindAll()
                    .Any(p => p.Name.Equals(nameToCheck, StringComparison.OrdinalIgnoreCase));

                if (exists)
                {
                    Alerts.ShowWarning("A product with this name already exists.");
                    return;
                }

                var product = new Product
                {
                    Name = nameToCheck,
                    Price = nudProductPrice.Value,
                    StockQuantity = (uint)nudStock.Value,
                    MinimumStock = (uint)nudMinStock.Value,
                    Category = selectedCategory,
                    IsActive = chkIsActive.Checked
                };

                ProductRepository.SaveOrUpdate(product);
                _bdsProducts.Add(product);
                _bdsProducts.MoveLast();

                Alerts.ShowSuccess("Product registered!");
                ClearProductInputs();

                if (this.MdiParent is SystemMainMenu mainMenu)
                {
                    mainMenu.CheckStockAlert();
                }
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Error: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (_bdsProducts.Current is not Product current)
            {
                Alerts.ShowWarning("Select a product to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                Alerts.ShowWarning("Product name cannot be empty.");
                return;
            }

            string newName = txtProductName.Text.Trim();

            try
            {
                bool exists = ProductRepository.FindAll()
                    .Any(p => p.Name.Equals(newName, StringComparison.OrdinalIgnoreCase) 
                    && p.Id != current.Id);

                if (exists)
                {
                    Alerts.ShowWarning("Another product already uses this name.");
                    return;
                }

                current.Name = newName;
                current.Price = nudProductPrice.Value;
                current.StockQuantity = (uint)nudStock.Value;
                current.MinimumStock = (uint)nudMinStock.Value;
                current.Category = cboProductCategory.SelectedItem as Category;
                current.IsActive = chkIsActive.Checked;

                ProductRepository.SaveOrUpdate(current);
                _bdsProducts.ResetCurrentItem();

                Alerts.ShowSuccess("Product updated!");

                if (this.MdiParent is SystemMainMenu mainMenu)
                {
                    mainMenu.CheckStockAlert();
                }
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Update failed: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (_bdsProducts.Current is not Product current) return;

            if (Alerts.ConfirmAction($"Delete product '{current.Name}'?"))
            {
                try
                {
                    ProductRepository.Delete(current);
                    _bdsProducts.RemoveCurrent();
                    Alerts.ShowSuccess("Product deleted.");
                    ClearProductInputs();
                }
                catch (InvalidOperationException ex)
                {
                    // Soft delete notification
                    Alerts.ShowWarning(ex.Message);
                    _bdsProducts.ResetCurrentItem(); // Update IsActive visual
                }
                catch (Exception ex)
                {
                    Alerts.ShowError("Deletion failed: " + ex.Message);
                }
            }
        }
        #endregion
    }
}