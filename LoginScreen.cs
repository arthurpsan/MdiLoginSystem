namespace UserManagementSystem
{
    public partial class LoginScreen : Form
    {
        private static LoginScreen? _instance;

        private LoginScreen()
        {
            InitializeComponent();

        }

        public static LoginScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new LoginScreen();
            }

            return _instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get email and password from text boxes
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            // Search for the model in the database (Credential)

            Credential? dbCredential = CredentialRepository.FindByEmail(email);

            // Verify if the credential exists

            if (dbCredential == null)
            {
                lblErrorAlert.Visible = true;
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
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
                    CredentialRepository.SaveorUpdate(dbCredential);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating last access time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dbCredential.User.Credential = dbCredential;

                txtEmail.Clear();
                txtPassword.Clear();
                this.Hide();

                // Pass the model User to the System Menu
                SystemMenu.GetInstance(dbCredential.User).Show();
            }
            else
            {
                // Invalid password
                lblErrorAlert.Visible = true;
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.LightCyan;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void grpPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightCyan;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Focused)
                {
                    txtPassword.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (txtPassword.Focused)
                {
                    btnLogin.PerformClick();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
