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

            if (_loggedInUser.Credential != null && _loggedInUser.Credential.Manager)
            {
                CheckStockAlert();
            }
        }

        // method to manage setup permissions
        private void SetupPermissions()
        {
            Text = $"System - User Management - User: {_loggedInUser.Name} - [v0.0.1]";
            lblLastAccess.Text = $"Last Access: {_loggedInUser.Credential?.LastAccess?.ToString("g") ?? "First Access!"}";

            Boolean isManager = _loggedInUser.Credential?.Manager ?? false;
            Boolean isSalesperson = _loggedInUser is Salesperson;
            Boolean isCashier = _loggedInUser is Cashier;

            reportToolStripMenuItem.Visible = isManager;
            employeeToolStripMenuItem.Enabled = isManager;
            producttoolStripMenuItem.Visible = isManager;

            saleToolStripMenuItem.Visible = isSalesperson;
            paymentToolStripMenuItem.Visible = isCashier;
            customerToolStripMenuItem.Visible = isManager || isSalesperson;
        }

        // generic method to open MDI forms
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

        private void CheckStockAlert()
        {
            try
            {
                if (lblStockAlert == null) return;

                int lowStockCount = ProductRepository.FindAll()
                    .Count(p => p.StockQuantity <= p.MinimumStock);

                if (lowStockCount > 0)
                {
                    lblStockAlert.Text = $"⚠ ALERTA: {lowStockCount} Produtos com Estoque Baixo!";
                    lblStockAlert.ForeColor = Color.Red;
                    lblStockAlert.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lblStockAlert.Visible = true;

                    lblStockAlert.IsLink = true;
                    lblStockAlert.Click -= LblStockAlert_Click;
                    lblStockAlert.Click += LblStockAlert_Click;
                }
                else
                {
                    lblStockAlert.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Em produção logaríamos, aqui apenas evitamos travar o menu
                System.Diagnostics.Debug.WriteLine("Erro ao verificar estoque: " + ex.Message);
            }
        }

        private void LblStockAlert_Click(object? sender, EventArgs e)
        {
            OpenMdiForm(() => StockReportForm.GetInstance(_loggedInUser));
        }

        #region MENU EVENTS

        // management
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

        // reports
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