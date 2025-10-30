using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls;

namespace MdiLoginSystem
{
    public partial class SystemMenu : Form
    {
        private static SystemMenu _intance;
        private SystemMenu(User user)
        {
            InitializeComponent();

            Text = "Sys - User Management - [v0.0.1]";

            mnuSystem.Enabled = user.Credential.Manager;
        }

        public static SystemMenu GetInstance(User user)
        {
            if (_intance == null)
            {
                _intance = new SystemMenu();
            }

            return _intance;

            // return new SystemMenu(user);
        }

        public SystemMenu()
        {
            InitializeComponent();
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginMenu.GetInstance().Show();
        }

    }
}
