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
        private readonly Repository _dbContext;
        private readonly BindingList<Customer> _customers;

        public static CustomerForm? GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CustomerForm();
            }

            _instance._loggedInUser = user;
            return _instance;
        }

        public CustomerForm()
        {
            InitializeComponent();

            _dbContext = new Repository();
            _dbContext.Customers.Load();

            _customers = _dbContext.Customers.Local.ToBindingList();

            customersGridView.DataSource = _customers;

            ColumnCustomerId.DataPropertyName = nameof(Customer.Id);
            ColumnCustomerName.DataPropertyName = nameof(Customer.Name);
            ColumnCustomerEmail.DataPropertyName = nameof(Customer.Email);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControlMain.SelectedTab == tbpNewCustomer)
                {
                    var customer = new Customer
                    {
                        Email = txtEmail.Text,
                        Name = txtName.Text
                    };

                    _dbContext.Customers.Add(customer);
                }
                else if (tabControlMain.SelectedTab == tbpEditCustomer)
                {
                    if (customersGridView.CurrentRow?.DataBoundItem is Customer currentCustomer)
                    {
                        currentCustomer.Name = txtEditCustomerName.Text;
                        currentCustomer.Email = txtEditCustomerEmail.Text;
                    }
                }

                _dbContext.SaveChanges();
                MessageBox.Show("Saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (customersGridView.CurrentRow?.DataBoundItem is Customer currentCustomer)
                {
                    _dbContext.Customers.Remove(currentCustomer);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _dbContext.Dispose();
            base.OnFormClosed(e);
        }

    }
}
