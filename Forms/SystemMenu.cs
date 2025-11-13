using UserManagementSystem.Forms;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    public partial class SystemMenu : Form
    {
        private static SystemMenu? _instance;
        public SystemMenu(User? user)
        {
            InitializeComponent();

            Text = $"System - User Management - User level: {user.Name} - [v0.0.1]";

            if (user != null && user.Credential != null)
            {
                userToolStripMenuItem.Enabled = user.Credential.Manager;

                lblLastAccess.Text = $"Last Access: {user.Credential.LastAccess?.ToString("g") ?? "First Access!"}";
            }
            else
            {
                lblLastAccess.Text = "Error while loading session data!";
            }

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutScreen aboutForm = AboutScreen.GetInstance();
            aboutForm.MdiParent = this;
            aboutForm.Show();
            aboutForm.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen.GetInstance().ClearFieldsAndShow();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReportScreen userReportForm = UserReportScreen.GetInstance();
            userReportForm.MdiParent = this;
            userReportForm.Show();
            userReportForm.BringToFront();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignupScreen signupForm = SignupScreen.GetInstance();
            signupForm.MdiParent = this;
            signupForm.Show();
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginScreen.GetInstance().ClearFieldsAndShow();
        }

        private void salesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReportScreen saleReportForm = SaleReportScreen.GetInstance();
            saleReportForm.MdiParent = this;
            saleReportForm.Show();
            saleReportForm.BringToFront();
        }

        private void comissionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComissionReportScreen comissionReportForm = ComissionReportScreen.GetInstance();
            comissionReportForm.MdiParent = this;
            comissionReportForm.Show();
            comissionReportForm.BringToFront();
        }

        private void clientsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPurchasesReport customerReportForm = CustomerPurchasesReport.GetInstance();
            customerReportForm.MdiParent = this;
            customerReportForm.Show();
            customerReportForm.BringToFront();
        }
    }
}
