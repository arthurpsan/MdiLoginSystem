using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.ComponentModel;

namespace UserManagementSystem.Forms
{
    public partial class CustomerForm : Form
    {
        private static CustomerForm? _instance;
        private User? _loggedInUser;
        private readonly Repository _dbContext = new Repository();
        private BindingList<Customer> _customers;

        public static CustomerForm? GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CustomerForm(user);
            }

            _instance._loggedInUser = user;
            return _instance;
        }

        public CustomerForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            LoadCustomers();
            BindControls();

            customersGridView.AutoGenerateColumns = false;
            customersGridView.AllowUserToAddRows = false;

            customersGridView.SelectionChanged += customersGridView_SelectionChanged;
        }

        public void LoadCustomers()
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Customers.Load();

            if (_customers != null)
            {
                _customers = _dbContext.Customers.Local.ToBindingList();
                customersGridView.DataSource = _customers;
            }
            else
            {
                customersGridView.Refresh();
            }

        }

        public void BindControls()
        {
            ColumnCustomerName.DataPropertyName = nameof(Customer.Name);
            ColumnCustomerEmail.DataPropertyName = nameof(Customer.Email);
        }

        #region CRUD methods for customers

        private void RegisterCustomer()
        {
            var customer = new Customer();
            try
            {
                customer.Name = txtCustomerName.Text;
                customer.Email = txtCustomerEmail.Text;

                CustomerRepository.SaveOrUpdate(customer);

                LoadCustomers();
                ClearInputs();
                MessageBox.Show("Customer registered successfully!");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Validation error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void UpdateCustomer()
        {
            if (customersGridView.CurrentRow?.DataBoundItem is Customer currentCustomer)
            {
                try
                {
                    currentCustomer.Name = txtCustomerName.Text;
                    currentCustomer.Email = txtCustomerEmail.Text;

                    CustomerRepository.SaveOrUpdate(currentCustomer);

                    customersGridView.Refresh();
                    MessageBox.Show("Customer updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update failed: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No customer selected for update.");
            }
        }

        private void DeleteCustomer()
        {
            if (customersGridView.CurrentRow?.DataBoundItem is Customer currentCustomer)
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CustomerRepository.Delete(currentCustomer);
                        _dbContext.Remove(currentCustomer);

                        ClearInputs();
                        MessageBox.Show("Customer deleted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Deletion failed: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void ClearInputs()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
        }

        #endregion

        #region Event Handlers
        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            RegisterCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void customersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (customersGridView.CurrentRow?.DataBoundItem is Customer selectedCustomer)
            {
                txtCustomerName.Text = selectedCustomer.Name;
                txtCustomerEmail.Text = selectedCustomer.Email;
            }
        }

        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _dbContext.Dispose();
            base.OnFormClosed(e);
        }

    }
}