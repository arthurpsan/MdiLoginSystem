using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserManagementSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private static EmployeeForm? _instance;
        private User? _loggedInUser;

        private BindingList<User> _employees;

        public static EmployeeForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new EmployeeForm(user);
            }
            return _instance;
        }

        public EmployeeForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            InitializeForm();
        }
        public EmployeeForm() : this(null) { }

        private void InitializeForm()
        {
            // setup Role ComboBox
            cboEmployeeRoles.Items.Clear();
            cboEmployeeRoles.Items.Add("Manager");
            cboEmployeeRoles.Items.Add("Salesperson");
            cboEmployeeRoles.Items.Add("Cashier");
            cboEmployeeRoles.SelectedIndex = 0;

            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Map Columns (Ensure these match your Designer names)
            if (dgvEmployees.Columns["ColumnEmployeeName"] != null)
                dgvEmployees.Columns["ColumnEmployeeName"].DataPropertyName = nameof(User.Name);

            if (dgvEmployees.Columns["ColumnEmployeeNickname"] != null)
                dgvEmployees.Columns["ColumnEmployeeNickname"].DataPropertyName = nameof(User.Nickname);

            if (dgvEmployees.Columns["ColumnEmployeeEmail"] != null)
                dgvEmployees.Columns["ColumnEmployeeEmail"].DataPropertyName = nameof(User.Email);

            if (dgvEmployees.Columns["ColumnEmployeePhone"] != null)
            {
                dgvEmployees.Columns["ColumnEmployeePhone"].DataPropertyName = nameof(User.PhoneNumber);
            }
            else
            {
                MessageBox.Show("Error: ColumnEmployeePhone not found in grid.");
            }

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var list = UserRepository.FindAll();
            _employees = new BindingList<User>(list);

            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _employees;
        }

        

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // determine role and create appropriate user type
                string role = cboEmployeeRoles.SelectedItem?.ToString() ?? "Salesperson";
                User newUser;

                if (txtEmployeePassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                // generate a random enrollment number since we don't allow user input for it
                uint defaultEnrollment = (uint)new Random().Next(1000, 9999);

                switch (role)
                {
                    case "Manager":
                        newUser = new User();
                        break;
                    case "Salesperson":
                        newUser = new Salesperson { SellerEnrollment = defaultEnrollment };
                        break;
                    case "Cashier":
                        newUser = new Cashier { CashierEnrollment = defaultEnrollment };
                        break;
                    default:
                        newUser = new User();
                        break;
                }

                newUser.Name = txtEmployeeName.Text;
                newUser.Nickname = txtEmployeeNickname.Text;
                newUser.Email = txtEmployeeEmail.Text;

                string cleanPhone = new string(mskPhoneNumber.Text.Where(char.IsDigit).ToArray());

                if (ulong.TryParse(cleanPhone, out ulong phone))
                {
                    newUser.PhoneNumber = phone;
                }

                Credential credential = new Credential
                {
                    Email = newUser.Email,
                    Password = txtEmployeePassword.Text,
                    Manager = (role == "Manager"),
                    User = newUser
                };

                CredentialRepository.SaveOrUpdate(credential);

                _employees.Add(newUser);
                ClearInputs();

                MessageBox.Show($"{role} registered successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message, "Error");
            }
        }

        private void BtnRemoveEmployee_Click(object? sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow?.DataBoundItem is User selectedUser)
            {
                var confirm = MessageBox.Show($"Delete {selectedUser.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        UserRepository.Delete(selectedUser);
                        _employees.Remove(selectedUser);
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
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void ClearInputs()
        {
            txtEmployeeName.Clear();
            txtEmployeeNickname.Clear();
            txtEmployeeEmail.Clear();
            mskPhoneNumber.Clear();
            txtEmployeePassword.Clear();
            txtRepeatPassword.Clear();
            cboEmployeeRoles.SelectedIndex = 0;
        }
    }
}