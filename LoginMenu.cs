namespace MdiLoginSystem
{
    public partial class LoginMenu : Form
    {

        private static LoginMenu _instance;
        private User _user;

        private LoginMenu()
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

        public static LoginMenu GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginMenu();
            }
            return _instance;
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == _user.Name && txtPassword.Text == _user.Credential.Password)
            {
                txtUser.Clear();
                txtPassword.Clear();

                Hide();

                SystemMenu.GetInstance(_user).Show();
            }
        }
    }
}
