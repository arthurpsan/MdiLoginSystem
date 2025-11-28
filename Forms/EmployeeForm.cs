using System.ComponentModel;
using System.Data;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private static EmployeeForm? _instance;
        // The BindingSource is now in the Designer file as 'bdsEmployees'

        public static EmployeeForm GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new EmployeeForm();
            return _instance;
        }

        public EmployeeForm()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            InitializeRoles();
            SetupGrid();
            LoadData();
        }

        private void InitializeRoles()
        {
            cboEmployeeRoles.Items.Clear();
            cboEmployeeRoles.Items.AddRange(new object[] { "Manager", "Salesperson", "Cashier" });
            cboEmployeeRoles.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // The Designer already does: dgvEmployees.DataSource = bdsEmployees;
            // But good to ensure columns match properties
            if (dgvEmployees.Columns["ColumnEmployeeName"] != null)
                dgvEmployees.Columns["ColumnEmployeeName"].DataPropertyName = nameof(User.Name);
            if (dgvEmployees.Columns["ColumnEmployeeNickname"] != null)
                dgvEmployees.Columns["ColumnEmployeeNickname"].DataPropertyName = nameof(User.Nickname);
            if (dgvEmployees.Columns["ColumnEmployeeEmail"] != null)
                dgvEmployees.Columns["ColumnEmployeeEmail"].DataPropertyName = nameof(User.Email);
            if (dgvEmployees.Columns["ColumnEmployeePhone"] != null)
                dgvEmployees.Columns["ColumnEmployeePhone"].DataPropertyName = nameof(User.PhoneNumber);
        }

        private void LoadData()
        {
            try
            {
                var list = UserRepository.FindAll();
                // Assign list to the Designer's BindingSource
                bdsEmployees.DataSource = new BindingList<User>(list);
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Failed to load employees: " + ex.Message);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (txtEmployeePassword.Text != txtRepeatPassword.Text)
            {
                Alerts.ShowWarning("Passwords do not match.");
                return;
            }

            try
            {
                string role = cboEmployeeRoles.SelectedItem?.ToString() ?? "Salesperson";
                uint defaultEnrollment = (uint)new Random().Next(1000, 9999);

                User newUser = role switch
                {
                    "Salesperson" => new Salesperson { SellerEnrollment = defaultEnrollment },
                    "Cashier" => new Cashier { CashierEnrollment = defaultEnrollment },
                    _ => new User()
                };

                newUser.Name = txtEmployeeName.Text;
                newUser.Nickname = txtEmployeeNickname.Text;
                newUser.Email = txtEmployeeEmail.Text;

                string cleanPhone = new string(mskPhoneNumber.Text.Where(char.IsDigit).ToArray());
                if (ulong.TryParse(cleanPhone, out ulong phone)) newUser.PhoneNumber = phone;

                Credential credential = new Credential
                {
                    Email = newUser.Email,
                    Password = txtEmployeePassword.Text,
                    Manager = (role == "Manager"),
                    User = newUser
                };

                CredentialRepository.SaveOrUpdate(credential);

                // Add to the Designer's BindingSource
                bdsEmployees.Add(newUser);

                Alerts.ShowSuccess($"{role} registered successfully!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Error saving: " + ex.Message);
            }
        }

        private void BtnRemoveEmployee_Click(object? sender, EventArgs e)
        {
            if (bdsEmployees.Current is not User selectedUser)
            {
                Alerts.ShowWarning("Please select an employee to delete.");
                return;
            }

            if (Alerts.ConfirmAction($"Delete {selectedUser.Name}?"))
            {
                try
                {
                    UserRepository.Delete(selectedUser);
                    bdsEmployees.RemoveCurrent();
                    ClearInputs();
                    Alerts.ShowSuccess("Employee deleted.");
                }
                catch (Exception ex)
                {
                    Alerts.ShowError("Error deleting: " + ex.Message);
                }
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