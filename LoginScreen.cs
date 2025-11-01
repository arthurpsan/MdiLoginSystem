namespace MdiLoginSystem
{
    public partial class LoginScreen : Form
    {
        private User _user;
        private static LoginScreen? _instance;

        private LoginScreen()
        {
            InitializeComponent();

            _user = new User()
            {
                Id = 1,
                Name = "abc"
            };

            Credential credential = new Credential()
            {
                Id = 1,
                Password = "123",
                Manager = true,
                User = _user
            };

            _user.Credential = credential;

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
            // Hash the input password
            string inputPasswordHash = Credential.ComputeSHA256(txtPassword.Text, Credential.SALT);

            if (txtUser.Text == _user.Name && inputPasswordHash == _user.Credential.Password)
            {
                txtUser.Clear();
                txtPassword.Clear();

                this.Hide();

                SystemMenu.GetInstance(_user).Show();
            }
            else
            {
                lblErrorAlert.Visible = true;
                txtUser.Clear();
                txtPassword.Clear();
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
