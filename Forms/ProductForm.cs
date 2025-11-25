using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace UserManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private static ProductForm? _instance;
        private User? _loggedInUser;
        private Repository _dbContext = new Repository();
        private BindingList<Product> _products;
        private BindingList<Category> _categories;

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

            LoadCategories();
            LoadProducts();
            BindControls();

            dgvProduct.AllowUserToAddRows = false;
            dgvCategory.AllowUserToAddRows = false;
        }

        // -- main methods for loading data --
        private void LoadCategories()
        {
            _dbContext.Categories.Load();
            _categories = _dbContext.Categories.Local.ToBindingList();
            cboProductCategory.DataSource = _categories;
            cboProductCategory.DisplayMember = "Name";
            cboProductCategory.ValueMember = "Id";
            dgvCategory.DataSource = null;
            dgvCategory.DataSource = _categories;
        }

        private void LoadProducts()
        {
            _dbContext.Products.Load();
            _products = _dbContext.Products.Local.ToBindingList();
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = _products;
        }

        // set up data bindings for DataGridView columns
        private void BindControls()
        {
            // products
            ColumnProductId.DataPropertyName = nameof(Product.Id);
            ColumnProductName.DataPropertyName = nameof(Product.Name);
            ColumnProductPrice.DataPropertyName = nameof(Product.Price);
            ColumnProductCurrentStock.DataPropertyName = nameof(Product.Stockpile);
            ColumnProductMinStock.DataPropertyName = nameof(Product.MinimumStock);
            ColumnProductCategory.DataPropertyName = nameof(Product.Category);
            ColumnProductIsActive.DataPropertyName = nameof(Product.IsActive);

            // categories
            ColumnCategoryId.DataPropertyName = nameof(Category.Id);
            ColumnCategoryName.DataPropertyName = nameof(Category.Name);
        }

        #region CRUD methods for category and product

        // category methods
        private void RegisterCategory()
        {
            var category = new Category();
            try
            {
                category.Name = txtCategoryName.Text;
                CategoryRepository.SaveOrUpdate(category);
                LoadCategories();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Category name cannot be empty.");
            }
            catch (ArgumentOutOfRangeException ex)
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
            if (dgvCategory.CurrentRow?.DataBoundItem is Category currentCategory)
            {
                currentCategory.Name = txtCategoryName.Text;
                CategoryRepository.SaveOrUpdate(currentCategory);
                LoadCategories();
            }

            else 
            {
                MessageBox.Show("No category selected for update.");
            }
        }

        private void DeleteCategory()
        {
            if (dgvCategory.CurrentRow?.DataBoundItem is Category currentCategory)
            {
                try
                {
                    CategoryRepository.Delete(currentCategory);
                    LoadCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Category detection failed: " + ex.Message);
                }
                
            }
        }

        // product methods
        private void RegisterProduct()
        {

            var selectedCategory = cboProductCategory.SelectedItem as Category;
            if (selectedCategory == null)
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
                product.CategoryId = selectedCategory.Id;
                product.IsActive = chkIsActive.Checked;

                ProductRepository.SaveOrUpdate(product);
                LoadProducts();
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
            var selectedCategory = cboProductCategory.SelectedItem as Category;

            if (selectedCategory == null || dgvProduct.CurrentRow?.DataBoundItem is not Product currentProduct)
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
                currentProduct.CategoryId = selectedCategory.Id;
                currentProduct.IsActive = chkIsActive.Checked;
                ProductRepository.SaveOrUpdate(currentProduct);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Product update failed: " + ex.Message);
            }
        }

        private void DeleteProduct()
        {
            if (dgvProduct.CurrentRow?.DataBoundItem is Product currentProduct)
            {
                try
                {
                    ProductRepository.Delete(currentProduct);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product deletion falied: " + ex.Message);
                }
            }
        }

        #endregion

        #region event handlers

        // event handlers for category button clicks
        private void btnRegisterCategory_Click(object sender, EventArgs e)
        {
            RegisterCategory();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        // event handlers for product button clicks
        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            RegisterProduct();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        #endregion

    }
}