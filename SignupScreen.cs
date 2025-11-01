using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MdiLoginSystem
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect data from the form.
            string name = txtUsername.Text;
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
            }
            catch (Exception ex)
            {
                lblErrorAlert.Text = $"Error while saving the user: {ex.Message}";
                lblErrorAlert.Visible = true;
            }
        }
    }
}
