using UserManagementSystem.Data;
using UserManagementSystem.Forms;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem
{
    public partial class SystemMainMenu : Form
    {
        private static SystemMainMenu? _instance;
        private readonly User _loggedInUser;

        public static SystemMainMenu GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SystemMainMenu(user);
            }
            return _instance;
        }

        private SystemMainMenu(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            SetupPermissions();
        }

        // method to manage setup permissions
        private void SetupPermissions()
        {
            Text = $"System - User Management - User: {_loggedInUser.Name} - [v0.0.1]";

            bool isManager = _loggedInUser.Credential?.Manager ?? false;

            employeeToolStripMenuItem.Enabled = isManager;
            customerToolStripMenuItem.Enabled = isManager;
            producttoolStripMenuItem.Enabled = isManager;

            lblLastAccess.Text = $"Last Access: {_loggedInUser.Credential?.LastAccess?.ToString("g") ?? "First Access!"}";
        }

        // --- generic MDI opener ---
        private void OpenMdiForm<T>(Func<T> factory) where T : Form
        {
            var form = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (form != null)
            {
                form.Activate();
                if (form.WindowState == FormWindowState.Minimized)
                    form.WindowState = FormWindowState.Normal;
            }
            else
            {
                form = factory();
                form.MdiParent = this;
                form.Show();
            }
        }

        #region MENU EVENTS

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => EmployeeForm.GetInstance(_loggedInUser));

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => CustomerForm.GetInstance(_loggedInUser));

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => SaleForm.GetInstance(_loggedInUser));

        private void producttoolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => ProductForm.GetInstance(_loggedInUser));

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => PaymentForm.GetInstance(_loggedInUser));

        // Reports
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => DashboardForm.GetInstance());

        private void salesDataToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => SaleReportForm.GetInstance());

        private void comissionDataToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => CommissionForm.GetInstance());

        private void clientsDataToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => CustomerReportForm.GetInstance());

        private void stockDataToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => StockReportForm.GetInstance(_loggedInUser));

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenMdiForm(() => AboutForm.GetInstance());

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Alerts.ConfirmAction("Are you sure you want to exit?"))
            {
                this.Close();
            }
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.GetInstance().ClearFieldsAndShow();
        }

        #endregion
    }
}