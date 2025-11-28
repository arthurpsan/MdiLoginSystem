using System.ComponentModel;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem.Forms
{
    public partial class CustomerForm : Form
    {
        private static CustomerForm? _instance;
        private readonly BindingSource _bindingSource = new BindingSource();

        public static CustomerForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new CustomerForm();
            return _instance;
        }

        public CustomerForm()
        {
            InitializeComponent();
            this.Load += Form_Load;

            // Link input population to grid selection
            dgvCustomers.SelectionChanged += (s, e) => PopulateInputs();
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.DataSource = _bindingSource;

            // Ensure mappings exist
            if (dgvCustomers.Columns["ColumnCustomerName"] != null)
                dgvCustomers.Columns["ColumnCustomerName"].DataPropertyName = nameof(Customer.Name);

            if (dgvCustomers.Columns["ColumnCustomerEmail"] != null)
                dgvCustomers.Columns["ColumnCustomerEmail"].DataPropertyName = nameof(Customer.Email);
        }

        private void LoadData()
        {
            try
            {
                var list = CustomerRepository.FindAll();
                _bindingSource.DataSource = new BindingList<Customer>(list);
                PopulateInputs();
            }
            catch (Exception ex)
            {
                Alerts.ShowError($"Failed to load data: {ex.Message}");
            }
        }

        private void PopulateInputs()
        {
            if (_bindingSource.Current is Customer selected)
            {
                txtCustomerName.Text = selected.Name;
                txtCustomerEmail.Text = selected.Email;
            }
            else
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            dgvCustomers.ClearSelection();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomerEmail.Text))
            {
                Alerts.ShowWarning("Please fill in all fields.");
                return;
            }

            try
            {
                var newCustomer = new Customer
                {
                    Name = txtCustomerName.Text.Trim(),
                    Email = txtCustomerEmail.Text.Trim()
                };

                CustomerRepository.SaveOrUpdate(newCustomer);
                _bindingSource.Add(newCustomer); // Updates grid automatically
                _bindingSource.MoveLast();

                Alerts.ShowSuccess("Customer registered successfully!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Error saving customer: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Customer selected)
            {
                Alerts.ShowWarning("Please select a customer to edit.");
                return;
            }

            try
            {
                selected.Name = txtCustomerName.Text.Trim();
                selected.Email = txtCustomerEmail.Text.Trim();

                CustomerRepository.SaveOrUpdate(selected);
                dgvCustomers.Refresh();
                Alerts.ShowSuccess("Customer updated successfully!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Error updating: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Customer selected)
            {
                Alerts.ShowWarning("Please select a customer to delete.");
                return;
            }

            if (Alerts.ConfirmAction($"Delete {selected.Name}?"))
            {
                try
                {
                    CustomerRepository.Delete(selected);
                    _bindingSource.RemoveCurrent();
                    ClearInputs();
                    Alerts.ShowSuccess("Customer deleted.");
                }
                catch (Exception ex)
                {
                    Alerts.ShowError("Error deleting: " + ex.Message);
                }
            }
        }
    }
}