using System;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class CustomerSignUpScreen : Form
    {
        private static CustomerSignUpScreen? _instance;
        private User? _loggedInUser;
        public static CustomerSignUpScreen? GetInstance(User? user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CustomerSignUpScreen();
            }

            _instance._loggedInUser = user;
            return _instance;
        }

        public CustomerSignUpScreen()
        {
            InitializeComponent();
        }
    }
}
