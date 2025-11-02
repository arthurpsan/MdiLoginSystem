using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    public partial class SignupScreen : Form
    {
        private static SignupScreen? _instance;
        public static SignupScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SignupScreen();
            }
            return _instance;
        }

        public SignupScreen()
        {
            InitializeComponent();
        }

        // Method to clear all input fields & put the focus back to the username field
        private void ClearFields()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            mskPhoneNumber.Clear();
            txtPassword.Clear();
            txtRepeatPassword.Clear();

            chkIsManager.Checked = false;
            lblErrorAlert.Visible = false;

            txtUsername.Focus();
        }

        // Event handler for the Save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect data from the form.
            string name = txtUsername.Text;
            string nickname = txtNickname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            bool isManager = chkIsManager.Checked;

            // Validating the data from the form (UI-Specific)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblErrorAlert.Text = "Name, Email and password are mandatory fields!";
                lblErrorAlert.Visible = true;
                return;
            }

            if (password != repeatPassword)
            {
                lblErrorAlert.Text = "The passwords do not match!";
                lblErrorAlert.Visible = true;

                return;
            }

            // Mandatory excession treatment
            try
            {
                string phoneText = mskPhoneNumber.Text;
                string phoneOnlyNumbers = new string(phoneText.Where(char.IsDigit).ToArray());
                UInt64? phoneNumeric = null;

                // Tryparse conversion method
                if (UInt64.TryParse(phoneOnlyNumbers, out UInt64 correctValue))
                {
                    phoneNumeric = correctValue;
                }

                User newUser = new User
                {
                    Name = name,
                    Nickname = nickname,
                    Email = email,
                    PhoneNumber = phoneNumeric
                };

                Credential newCredential = new Credential
                {
                    Email = email,
                    Password = password,
                    Manager = isManager,
                    User = newUser
                };

                CredentialRepository.SaveorUpdate(newCredential);

                MessageBox.Show("User registered succefully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblErrorAlert.Visible = false;

                ClearFields();
            }
            catch (Exception ex)
            {
                lblErrorAlert.Text = $"Error while saving the user: {ex.Message}";
                lblErrorAlert.Visible = true;
            }
        }

        #region TextBox Enter and Leave Events - Change BackColor

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.LightCyan;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtNickname_Enter(object sender, EventArgs e)
        {
            txtNickname.BackColor = Color.LightCyan;
        }

        private void txtNickname_Leave(object sender, EventArgs e)
        {
            txtNickname.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.LightCyan;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void mskPhoneNumber_Enter(object sender, EventArgs e)
        {
            mskPhoneNumber.BackColor = Color.LightCyan;
        }

        private void mskPhoneNumber_Leave(object sender, EventArgs e)
        {
            mskPhoneNumber.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightCyan;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtRepeatPassword_Enter(object sender, EventArgs e)
        {
            txtRepeatPassword.BackColor = Color.LightCyan;
        }

        private void txtRepeatPassword_Leave(object sender, EventArgs e)
        {
            txtRepeatPassword.BackColor = Color.White;
        }

        #endregion

        private void SignupScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Focused)
                {
                    txtNickname.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtNickname.Focused)
                {
                    txtEmail.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtEmail.Focused)
                {
                    mskPhoneNumber.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (mskPhoneNumber.Focused)
                {
                    txtPassword.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtPassword.Focused)
                {
                    txtRepeatPassword.Focus();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtRepeatPassword.Focused)
                {
                    btnSave.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
