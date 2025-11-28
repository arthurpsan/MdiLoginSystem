using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils; // 1. Import Utils

namespace UserManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private static ProductForm? _instance;
        private readonly User? _loggedInUser;

        // 2. Define BindingSources
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

            // Wire grid selections to inputs
            dgvCategory.SelectionChanged += (s, e) => PopulateCategoryInputs();
            dgvProduct.SelectionChanged += (s, e) => PopulateProductInputs();
        }

        public ProductForm() : this(null) { }

        private void Form_Load(object? sender, EventArgs e)
        {
            SetupGrids();
            LoadData();
        }

        private void SetupGrids()
        {
            // --- Categories Grid ---
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.DataSource = _bdsCategories;

            if (dgvCategory.Columns["ColumnCategoryName"] != null)
                dgvCategory.Columns["ColumnCategoryName"].DataPropertyName = nameof(Category.Name);

            // --- Products Grid ---
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.DataSource = _bdsProducts;

            if (dgvProduct.Columns["ColumnProductName"] != null)
                dgvProduct.Columns["ColumnProductName"].DataPropertyName = nameof(Product.Name);
            if (dgvProduct.Columns["ColumnProductPrice"] != null)
                dgvProduct.Columns["ColumnProductPrice"].DataPropertyName = nameof(Product.Price);
            if (dgvProduct.Columns["ColumnProductCurrentStock"] != null)
                dgvProduct.Columns["ColumnProductCurrentStock"].DataPropertyName = nameof(Product.StockQuantity);
            if (dgvProduct.Columns["ColumnProductMinStock"] != null)
                dgvProduct.Columns["ColumnProductMinStock"].DataPropertyName = nameof(Product.MinimumStock);
            if (dgvProduct.Columns["ColumnProductCategory"] != null)
                dgvProduct.Columns["ColumnProductCategory"].DataPropertyName = nameof(Product.Category);
            if (dgvProduct.Columns["ColumnProductIsActive"] != null)
                dgvProduct.Columns["ColumnProductIsActive"].DataPropertyName = nameof(Product.IsActive);

            // --- ComboBox ---
            cboProductCategory.DataSource = _bdsCategories;
            cboProductCategory.DisplayMember = nameof(Category.Name);
            // cboProductCategory.ValueMember = "Id"; // Optional if needed
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

        #region Category CRUD
        private void btnRegisterCategory_Click(object sender, EventArgs e)
        {
            try
            {
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

            try
            {
                current.Name = txtCategoryName.Text;
                CategoryRepository.SaveOrUpdate(current);

                _bdsCategories.ResetCurrentItem(); // Refreshes grid
                // Also refresh products grid as categories might have changed names
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

        #region Product CRUD
        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            if (cboProductCategory.SelectedItem is not Category selectedCategory)
            {
                Alerts.ShowWarning("Please select a valid category.");
                return;
            }

            try
            {
                var product = new Product
                {
                    Name = txtProductName.Text,
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

            try
            {
                current.Name = txtProductName.Text;
                current.Price = nudProductPrice.Value;
                current.StockQuantity = (uint)nudStock.Value;
                current.MinimumStock = (uint)nudMinStock.Value;
                current.Category = cboProductCategory.SelectedItem as Category;
                current.IsActive = chkIsActive.Checked;

                ProductRepository.SaveOrUpdate(current);
                _bdsProducts.ResetCurrentItem();

                Alerts.ShowSuccess("Product updated!");
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