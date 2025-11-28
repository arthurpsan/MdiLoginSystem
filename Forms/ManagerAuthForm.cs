using System;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Utils; // Import Utils

namespace UserManagementSystem.Forms
{
    public partial class ManagerAuthForm : Form
    {
        public ManagerAuthForm()
        {
            InitializeComponent();

            // Wire events
            btnAuthorize.Click += btnAuthorize_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnAuthorize_Click(object? sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                if (CredentialRepository.ValidateManagerCredentials(email, password))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblErrorAlert.Visible = true;
                    // Don't close, let them try again
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                Alerts.ShowError($"Authorization Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            ClearAllFields();
            this.Close();
        }

        private void ClearAllFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            lblErrorAlert.Visible = false;
        }
    }
}