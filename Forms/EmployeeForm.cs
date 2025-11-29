using System;
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

        private void InitializeRoles()
        {
            cboEmployeeRoles.Items.Clear();
            cboEmployeeRoles.Items.AddRange(new object[] { "Manager", "Salesperson", "Cashier" });
            cboEmployeeRoles.SelectedIndex = 0;
        }

        // setup datagridview
        private void SetupGrid()
        {
            // grid settings
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.ReadOnly = true;

            // clear existing columns
            dgvEmployees.Columns.Clear();

            // manually add columns

            var colName = new DataGridViewTextBoxColumn
            {
                Name = "ColumnEmployeeName",
                HeaderText = "Name",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvEmployees.Columns.Add(colName);

            var colNick = new DataGridViewTextBoxColumn
            {
                Name = "ColumnEmployeeNickname",
                HeaderText = "Nickname",
                DataPropertyName = "Nickname",
                Width = 120
            };
            dgvEmployees.Columns.Add(colNick);

            var colEmail = new DataGridViewTextBoxColumn
            {
                Name = "ColumnEmployeeEmail",
                HeaderText = "E-mail",
                DataPropertyName = "Email",
                Width = 200
            };
            dgvEmployees.Columns.Add(colEmail);

            var colPhone = new DataGridViewTextBoxColumn
            {
                Name = "ColumnEmployeePhone",
                HeaderText = "Phone",
                DataPropertyName = "PhoneNumber",
                Width = 120
            };
            dgvEmployees.Columns.Add(colPhone);

            var colRole = new DataGridViewTextBoxColumn
            {
                Name = "ColumnEmployeeRole",
                HeaderText = "Role",
                DataPropertyName = "Role",
                Width = 100
            };
            dgvEmployees.Columns.Add(colRole);

            dgvEmployees.SelectionChanged -= DgvEmployees_SelectionChanged;
            dgvEmployees.SelectionChanged += DgvEmployees_SelectionChanged;
        }

        private void LoadData()
        {
            try
            {
                var list = UserRepository.FindAll();
                bdsEmployees.DataSource = new BindingList<User>(list);
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Failed to load employees: " + ex.Message);
            }
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            InitializeRoles();
            SetupGrid();
            LoadData();

            ClearInputs();
        }

        #region EVENT HANDLERS
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (txtEmployeePassword.Text != txtRepeatPassword.Text)
            {
                Alerts.ShowWarning("Passwords do not match.");
                return;
            }

            string emailToCheck = txtEmployeeEmail.Text.Trim();

            try
            {
                string role = cboEmployeeRoles.SelectedItem?.ToString() ?? "Salesperson";
                bool isManager = (role == "Manager");

                // update existing user
                if (btnSave.Text == "Update" && bdsEmployees.Current is User currentUser)
                {
                    bool emailTaken = UserRepository.FindAll()
                        .Any(u => u.Email.Equals(emailToCheck, 
                        StringComparison.OrdinalIgnoreCase) && u.Id != currentUser.Id);

                    if (emailTaken)
                    {
                        Alerts.ShowWarning("This E-mail is already used by another employee.");
                        return;
                    }

                    currentUser.Name = txtEmployeeName.Text;
                    currentUser.Nickname = txtEmployeeNickname.Text;
                    currentUser.Email = txtEmployeeEmail.Text;

                    if (currentUser.Credential == null)
                    {
                        currentUser.Credential = new Credential { User = currentUser };
                    }
                    currentUser.Credential.Manager = isManager;

                    string cleanPhone = new string(mskPhoneNumber.Text.Where(char.IsDigit).ToArray());
                    if (ulong.TryParse(cleanPhone, out ulong phone))
                        currentUser.PhoneNumber = phone;

                    UserRepository.SaveOrUpdate(currentUser);

                    bdsEmployees.ResetCurrentItem();
                    Alerts.ShowSuccess("Employee updated successfully!");
                }
                // create new user
                else
                {
                    bool emailExists = UserRepository.FindAll()
                        .Any(u => u.Email.Equals(emailToCheck, StringComparison.OrdinalIgnoreCase));

                    if (emailExists)
                    {
                        Alerts.ShowWarning("An employee with this E-mail already exists.");
                        return;
                    }

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

                    // assign manager status
                    Credential credential = new Credential
                    {
                        Email = newUser.Email,
                        Password = txtEmployeePassword.Text,
                        Manager = isManager, // <--- Set it directly here
                        User = newUser
                    };

                    newUser.Credential = credential;

                    CredentialRepository.SaveOrUpdate(credential);
                    bdsEmployees.Add(newUser);
                    Alerts.ShowSuccess($"{role} registered successfully!");
                }

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

        private void DgvEmployees_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0) return;

            if (bdsEmployees.Current is User selectedUser)
            {
                txtEmployeeName.Text = selectedUser.Name;
                txtEmployeeNickname.Text = selectedUser.Nickname;
                txtEmployeeEmail.Text = selectedUser.Email;
                mskPhoneNumber.Text = selectedUser.PhoneNumber.ToString();

                bool isManager = selectedUser.Credential?.Manager ?? false;

                if (isManager)
                    cboEmployeeRoles.SelectedItem = "Manager";
                else if (selectedUser is Salesperson)
                    cboEmployeeRoles.SelectedItem = "Salesperson";
                else if (selectedUser is Cashier)
                    cboEmployeeRoles.SelectedItem = "Cashier";
                // default fallback if nothing matches
                else
                    cboEmployeeRoles.SelectedIndex = -1;

                btnSave.Text = "Update";

                txtEmployeePassword.Clear();
                txtRepeatPassword.Clear();
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            // clear text fields
            txtEmployeeName.Clear();
            txtEmployeeNickname.Clear();
            txtEmployeeEmail.Clear();
            mskPhoneNumber.Clear();
            txtEmployeePassword.Clear();
            txtRepeatPassword.Clear();
            cboEmployeeRoles.SelectedIndex = 0;

            // reset UI state
            btnSave.Text = "Save";
            dgvEmployees.ClearSelection();
        }

        #endregion
    }
}