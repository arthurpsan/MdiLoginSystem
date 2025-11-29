using System;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem
{
    public partial class LoginForm : Form
    {
        private static LoginForm? _instance;

        private LoginForm()
        {
            InitializeComponent();
        }

        public static LoginForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new LoginForm();
            }
            return _instance;
        }

        private void ShowLoginError()
        {
            lblErrorAlert.Visible = true;
            txtUserPassword.Clear();
            if (txtUserEmail.Focused) txtUserEmail.Focus();
            else txtUserPassword.Focus();
        }

        public void ClearFieldsAndShow()
        {
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            lblErrorAlert.Visible = false;
            this.Show();
            txtUserEmail.Focus();
        }

        private void PerformLogin(Credential credential)
        {
            lblErrorAlert.Visible = false;

            try
            {
                credential.LastAccess = DateTime.Now;
                CredentialRepository.SaveOrUpdate(credential);

                if (credential.User != null)
                {
                    credential.User.Credential = credential;

                    txtUserEmail.Clear();
                    txtUserPassword.Clear();
                    this.Hide();

                    SystemMainMenu.GetInstance(credential.User).Show();
                }
            }
            catch (Exception ex)
            {
                Alerts.ShowError("Could not update login time: " + ex.Message);
            }
        }

        #region UI Events (Highlighting & Navigation)

        // highlighting
        private void TxtUserEmail_Enter(object sender, EventArgs e) => txtUserEmail.BackColor = Color.LightCyan;
        private void TxtUserEmail_Leave(object sender, EventArgs e) => txtUserEmail.BackColor = Color.White;
        private void TxtUserPassword_Enter(object sender, EventArgs e) => txtUserPassword.BackColor = Color.LightCyan;
        private void TxtUserPassword_Leave(object sender, EventArgs e) => txtUserPassword.BackColor = Color.White;

        // navigation
        private void UserLoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (txtUserEmail.Focused)
                    txtUserPassword.Focus();
                else if (txtUserPassword.Focused)
                    btnLogin.PerformClick();
            }
        }

        private void TxtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtUserEmail.Text.Trim();
                string password = txtUserPassword.Text;

                Credential? dbCredential = CredentialRepository.FindByEmail(email);

                if (dbCredential == null)
                {
                    ShowLoginError();
                    return;
                }

                string hashedInput = Credential.ComputeSHA256(password, Credential.SALT);
                if (dbCredential.Password != hashedInput)
                {
                    ShowLoginError();
                    return;
                }

                PerformLogin(dbCredential);
            }
            catch (Exception ex)
            {
                Alerts.ShowError("System Error during login: " + ex.Message);
            }
        }

        #endregion
    }
}