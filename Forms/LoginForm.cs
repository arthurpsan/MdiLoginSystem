using UserManagementSystem.Data;
using UserManagementSystem.Models;

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Get email and password from text boxes
            String email = txtUserEmail.Text;
            String password = txtUserPassword.Text;

            // Search for the model in the database (Credential)

            Credential? dbCredential = CredentialRepository.FindByEmail(email);

            // Verify if the credential exists

            if (dbCredential == null)
            {
                lblErrorAlert.Visible = true;
                txtUserPassword.Clear();
                txtUserEmail.Focus();
                return;
            }

            // If the user exists, verify the password

            string hashedInputPassword = Credential.ComputeSHA256(password, Credential.SALT);

            // Compare the hashed password with the stored hashed password

            if (dbCredential.Password == hashedInputPassword)
            {
                // Sucessful login!
                lblErrorAlert.Visible = false;

                //  Save or Update the last access time
                try
                {
                    dbCredential.LastAccess = DateTime.Now;
                    CredentialRepository.SaveOrUpdate(dbCredential);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating last access time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dbCredential.User.Credential = dbCredential;

                txtUserEmail.Clear();
                txtUserPassword.Clear();
                this.Hide();

                // Pass the model User to the System Menu
                SystemMainMenu.GetInstance(dbCredential.User).Show();
            }
            else
            {
                // Invalid password
                lblErrorAlert.Visible = true;
                txtUserPassword.Clear();
                txtUserPassword.Focus();
            }
        }

        // Method to Clear fields and error messages
        public void ClearFieldsAndShow()
        {
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            lblErrorAlert.Visible = false;
            this.Show();
            txtUserEmail.Focus();
        }

        #region Input Field Highlighting Methods
        private void TxtUserEmail_Enter(object sender, EventArgs e)
        {
            txtUserEmail.BackColor = Color.LightCyan;
        }

        private void TxtUserEmail_Leave(object sender, EventArgs e)
        {
            txtUserEmail.BackColor = Color.White;
        }

        private void TxtUserPassword_Enter(object sender, EventArgs e)
        {
            txtUserPassword.BackColor = Color.LightCyan;
        }

        private void TxtUserPassword_Leave(object sender, EventArgs e)
        {
            txtUserPassword.BackColor = Color.White;
        }
        #endregion 

        // Method to handle Enter key navigation
        private void UserLoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserEmail.Focused)
                {
                    txtUserPassword.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtUserPassword.Focused)
                {
                    btnLogin.PerformClick();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void TxtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }
    }
}
