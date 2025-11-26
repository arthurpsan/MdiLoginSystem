using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private static ProductForm? _instance;
        private readonly User? _loggedInUser;

        private readonly BindingList<Product> _products;
        private readonly BindingList<Category> _categories;

        public static ProductForm GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ProductForm(user);
            }


            return _instance;
        }

        public ProductForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // Load data from repositories into BindingLists
            _categories = new BindingList<Category>(CategoryRepository.FindAll());
            _products = new BindingList<Product>(ProductRepository.FindAll());

            // Bind controls once
            BindControls();

            dgvProduct.AllowUserToAddRows = false;
            dgvCategory.AllowUserToAddRows = false;
        }

        private void BindControls()
        {
            // Categories
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = _categories;

            cboProductCategory.DataSource = _categories;
            cboProductCategory.DisplayMember = nameof(Category.Name);

            ColumnCategoryName.DataPropertyName = nameof(Category.Name);

            // Products
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = _products;

            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductPrice.DataPropertyName = nameof(Product.Price);
            ColumnProductCurrentStock.DataPropertyName = nameof(Product.Stockpile);
            ColumnProductMinStock.DataPropertyName = nameof(Product.MinimumStock);
            ColumnProductCategory.DataPropertyName = nameof(Product.Category);
            ColumnProductIsActive.DataPropertyName = nameof(Product.IsActive);
        }

        #region CRUD methods for category

        private void RegisterCategory()
        {
            var category = new Category();
            try
            {
                category.Name = txtCategoryName.Text;
                CategoryRepository.SaveOrUpdate(category);

                // add to bound list to refresh UI
                _categories.Add(category);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Category name cannot be empty.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Category name must have 3-50 characters.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void UpdateCategory()
        {
            if (dgvCategory.CurrentRow?.DataBoundItem is not Category currentCategory)
            {
                MessageBox.Show("No category selected for update.");
                return;
            }

            try
            {
                currentCategory.Name = txtCategoryName.Text;
                CategoryRepository.SaveOrUpdate(currentCategory);
                dgvCategory.Refresh(); // collection already bound
                cboProductCategory.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category update failed: " + ex.Message);
            }
        }

        private void DeleteCategory()
        {
            if (dgvCategory.CurrentRow?.DataBoundItem is not Category currentCategory)
                return;

            try
            {
                CategoryRepository.Delete(currentCategory);
                _categories.Remove(currentCategory); // remove from bound list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category deletion failed: " + ex.Message);
            }
        }

        #endregion

        #region CRUD methods for product

        private void RegisterProduct()
        {
            if (cboProductCategory.SelectedItem is not Category selectedCategory)
            {
                MessageBox.Show("Please select a valid category.");
                return;
            }

            var product = new Product();
            try
            {
                product.Name = txtProductName.Text;
                product.Price = decimal.Parse(nudProductPrice.Text);
                product.Stockpile = uint.Parse(nudStock.Text);
                product.MinimumStock = uint.Parse(nudMinStock.Text);
                product.Category = selectedCategory;
                product.IsActive = chkIsActive.Checked;

                ProductRepository.SaveOrUpdate(product);
                _products.Add(product);             // notify grid
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void UpdateProduct()
        {
            if (cboProductCategory.SelectedItem is not Category selectedCategory ||
                dgvProduct.CurrentRow?.DataBoundItem is not Product currentProduct)
            {
                MessageBox.Show("Please select a valid product and category.");
                return;
            }

            try
            {
                currentProduct.Name = txtProductName.Text;
                currentProduct.Price = decimal.Parse(nudProductPrice.Text);
                currentProduct.Stockpile = uint.Parse(nudStock.Text);
                currentProduct.MinimumStock = uint.Parse(nudMinStock.Text);
                currentProduct.Category = selectedCategory;
                currentProduct.IsActive = chkIsActive.Checked;

                ProductRepository.SaveOrUpdate(currentProduct);
                dgvProduct.Refresh(); // collection already bound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product update failed: " + ex.Message);
            }
        }

        private void DeleteProduct()
        {
            if (dgvProduct.CurrentRow?.DataBoundItem is not Product currentProduct)
                return;

            try
            {
                ProductRepository.Delete(currentProduct);
                _products.Remove(currentProduct); // remove from bound list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product deletion failed: " + ex.Message);
            }
        }

        #endregion

        #region event handlers

        private void btnRegisterCategory_Click(object sender, EventArgs e) => RegisterCategory();
        private void btnUpdateCategory_Click(object sender, EventArgs e) => UpdateCategory();
        private void btnDeleteCategory_Click(object sender, EventArgs e) => DeleteCategory();

        private void btnRegisterProduct_Click(object sender, EventArgs e) => RegisterProduct();
        private void btnUpdateProduct_Click(object sender, EventArgs e) => UpdateProduct();
        private void btnDeleteProduct_Click(object sender, EventArgs e) => DeleteProduct();

        #endregion
    }
}
