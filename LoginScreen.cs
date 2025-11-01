namespace MdiLoginSystem
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

        private void grpLogin_Enter(object sender, EventArgs e)
        {

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
                txtEmail.Clear();
                txtPassword.Clear();
                lblErrorAlert.Visible = false;

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

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
