using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class CustomerForm : Form
    {
        private static CustomerForm? _instance;
        private User? _loggedInUser;

        private BindingList<Customer> _customers;

        public static CustomerForm GetInstance(User? user)
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

            dgvCustomers.AutoGenerateColumns = false;

            if (dgvCustomers.Columns["ColumnCustomerName"] != null)
                dgvCustomers.Columns["ColumnCustomerName"].DataPropertyName = nameof(Customer.Name);

            if (dgvCustomers.Columns["ColumnCustomerEmail"] != null)
                dgvCustomers.Columns["ColumnCustomerEmail"].DataPropertyName = nameof(Customer.Email);

            LoadCustomers();

            dgvCustomers.AllowUserToAddRows = false;
        }

        private void LoadCustomers()
        {
            var list = CustomerRepository.FindAll();
            _customers = new BindingList<Customer>(list);

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customers;
        }

        // method linked to the "Register Customer" button in the Designer
        private void btnRegisterCustomer_Click(object? sender, EventArgs e)
        {
            try
            {

                Customer newCustomer = new Customer
                {
                    Name = txtCustomerName.Text,
                    Email = txtCustomerEmail.Text
                };

                CustomerRepository.SaveOrUpdate(newCustomer);

                _customers.Add(newCustomer);

                ClearInputs();
                MessageBox.Show("Customer registered successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation error: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method is linked to the "Update" button in the Designer
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is Customer selectedCustomer)
            {
                try
                {
                    selectedCustomer.Name = txtCustomerName.Text;
                    selectedCustomer.Email = txtCustomerEmail.Text;

                    CustomerRepository.SaveOrUpdate(selectedCustomer);

                    dgvCustomers.Refresh();
                    ClearInputs();
                    MessageBox.Show("Customer updated successfully!");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCustomers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        // This method is linked to the "Delete" button in the Designer
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is Customer selectedCustomer)
            {
                var confirm = MessageBox.Show($"Delete {selectedCustomer.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        CustomerRepository.Delete(selectedCustomer);
                        _customers.Remove(selectedCustomer);
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void customersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is Customer selectedCustomer)
            {
                txtCustomerName.Text = selectedCustomer.Name;
                txtCustomerEmail.Text = selectedCustomer.Email;
            }
        }

        private void ClearInputs()
        {
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
        }
    }
}