using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Org.BouncyCastle.Tls;

namespace MdiLoginSystem
{
    public partial class SystemMenu : Form
    {
        private static SystemMenu? _instance;
        private SystemMenu(User user)
        {
            InitializeComponent();

            Text = "Sys - User Management - [v0.0.1]";

            mnuSystem.Enabled = user.Credential.Manager;
        }
        public SystemMenu()
        {
            InitializeComponent();
        }

        public static SystemMenu GetInstance(User user)
        {
            if (_instance == null)
            {
                _instance = new SystemMenu();
            }

            return _instance;

            // return new SystemMenu(user);
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginMenu.GetInstance().Show();
        }

    }
}
