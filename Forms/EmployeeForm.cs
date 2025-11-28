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

        private void Form_Load(object? sender, EventArgs e)
        {
            InitializeRoles();
            SetupGrid();
            LoadData();

            ClearInputs();
        }

        private void InitializeRoles()
        {
            cboEmployeeRoles.Items.Clear();
            cboEmployeeRoles.Items.AddRange(new object[] { "Manager", "Salesperson", "Cashier" });
            cboEmployeeRoles.SelectedIndex = 0;
        }

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
                Name = "ColumnEmployeeName", // Internal name for finding the column later
                HeaderText = "Name",         // What the user sees
                DataPropertyName = "Name",   // Must match 'public string Name { get; set; }' in User model
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // This column takes up extra space
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

                // Calculate if they are a manager right now
                bool isManager = (role == "Manager");

                // === SCENARIO A: UPDATE EXISTING USER ===
                if (btnSave.Text == "Update" && bdsEmployees.Current is User currentUser)
                {
                    currentUser.Name = txtEmployeeName.Text;
                    currentUser.Nickname = txtEmployeeNickname.Text;
                    currentUser.Email = txtEmployeeEmail.Text;

                    // FIX: If Credential is missing, create it so we don't lose the Manager status
                    if (currentUser.Credential == null)
                    {
                        currentUser.Credential = new Credential { User = currentUser };
                    }
                    currentUser.Credential.Manager = isManager;

                    string cleanPhone = new string(mskPhoneNumber.Text.Where(char.IsDigit).ToArray());
                    if (ulong.TryParse(cleanPhone, out ulong phone))
                        currentUser.PhoneNumber = phone;

                    // Use the User repo to save (Cascading to Credential depends on your Repo implementation)
                    UserRepository.SaveOrUpdate(currentUser);

                    bdsEmployees.ResetCurrentItem();
                    Alerts.ShowSuccess("Employee updated successfully!");
                }
                // === SCENARIO B: CREATE NEW USER ===
                else
                {
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

                    // REMOVED: newUser.Credential.Manager = ... (This caused the crash!)

                    string cleanPhone = new string(mskPhoneNumber.Text.Where(char.IsDigit).ToArray());
                    if (ulong.TryParse(cleanPhone, out ulong phone)) newUser.PhoneNumber = phone;

                    // Create the credential and assign the Manager status HERE
                    Credential credential = new Credential
                    {
                        Email = newUser.Email,
                        Password = txtEmployeePassword.Text,
                        Manager = isManager, // <--- Set it directly here
                        User = newUser
                    };

                    // Bi-directional link (good practice so the object graph is complete)
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
            // FIX: Stop the logic if the user just clicked "New" (cleared selection)
            if (dgvEmployees.SelectedRows.Count == 0) return;

            if (bdsEmployees.Current is User selectedUser)
            {
                txtEmployeeName.Text = selectedUser.Name;
                txtEmployeeNickname.Text = selectedUser.Nickname;
                txtEmployeeEmail.Text = selectedUser.Email;
                mskPhoneNumber.Text = selectedUser.PhoneNumber.ToString();

                // Check for null Credential to prevent crashes
                bool isManager = selectedUser.Credential?.Manager ?? false;

                if (isManager)
                    cboEmployeeRoles.SelectedItem = "Manager";
                else if (selectedUser is Salesperson)
                    cboEmployeeRoles.SelectedItem = "Salesperson";
                else if (selectedUser is Cashier)
                    cboEmployeeRoles.SelectedItem = "Cashier";
                // Default fallback if nothing matches
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
            // Clear text fields
            txtEmployeeName.Clear();
            txtEmployeeNickname.Clear();
            txtEmployeeEmail.Clear();
            mskPhoneNumber.Clear();
            txtEmployeePassword.Clear();
            txtRepeatPassword.Clear();
            cboEmployeeRoles.SelectedIndex = 0;

            // Reset UI state
            btnSave.Text = "Save";          // Reset button text
            dgvEmployees.ClearSelection();  // Deselect grid row
        }
    }
}