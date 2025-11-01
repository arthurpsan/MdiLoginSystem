using System;
using UserManagementSystem;

namespace MdiLoginSystem
{
    public partial class SystemMenu : Form
    {
        private static SystemMenu? _instance;
        public SystemMenu(User? user)
        {
            InitializeComponent();

            Text = "Sys - User Management - [v0.0.1]";

            managerToolStripMenuItem.Enabled = user.Credential.Manager;
        }

        public static SystemMenu GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SystemMenu(user);
            }

            return _instance;

            // return new SystemMenu(user);
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginScreen.GetInstance().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            About aboutForm = About.GetInstance();
            aboutForm.MdiParent = this;
            aboutForm.Show();
            aboutForm.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen.GetInstance().Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportScreen reportForm = ReportScreen.GetInstance();
            reportForm.MdiParent = this;
            reportForm.Show();
            reportForm.BringToFront();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignupScreen signupForm = SignupScreen.GetInstance();
            signupForm.MdiParent = this;
            signupForm.Show();
        }

        private void SystemMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            LoginScreen.GetInstance().Show();
        }
    }
}
