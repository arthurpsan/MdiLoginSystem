namespace MdiLoginSystem
{
    public partial class LoginMenu : Form
    {

        private static LoginMenu _instance;
        private User _user;
    
        private LoginMenu()
        {
            InitializeComponent();

            Credential credential = new Credential()
            {
                Id = 1,
                Password = "123456",
                Manager = true
            };

            _user = new User()
            {
                Id = 1,
                Name = "Maria Luisa",
                Credential = credential
            };

        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == _user.Name && txtPassword.Text == _user.Credential.Password)
            {
                _instance = MainMenu.GetInstance(_user);
            }
        }
    }
}
