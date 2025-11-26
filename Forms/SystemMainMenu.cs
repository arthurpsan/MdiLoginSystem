using UserManagementSystem.Data;
using UserManagementSystem.Forms;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    public partial class SystemMainMenu : Form
    {
        private static SystemMainMenu? _instance;
        private User? _loggedInUser;

        public static SystemMainMenu GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SystemMainMenu(user);
            }

            return _instance;
        }

        public SystemMainMenu(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;

            Text = $"System - User Management - User level: {user.Name} - [v0.0.1]";

            if (user != null && user.Credential != null)
            {
                employeeToolStripMenuItem.Enabled = user.Credential.Manager;
                customerToolStripMenuItem.Enabled = user.Credential.Manager;
                producttoolStripMenuItem.Enabled = user.Credential.Manager;

                lblLastAccess.Text = $"Last Access: {user.Credential.LastAccess?.ToString("g") ?? "First Access!"}";
            }
            else
            {
                lblLastAccess.Text = "Error while loading session data!";
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.GetInstance().ClearFieldsAndShow();
        }

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lowStockProducts = ProductRepository.FindAll()
                                    .Where(p => p.Stockpile <= p.MinimumStock)
                                    .ToList();

            if (lowStockProducts.Count == 0)
            {
                MessageBox.Show("All stock levels are good!");
                return;
            }

            string report = "PRODUCTS WITH LOW STOCK:\n\n";
            foreach (var p in lowStockProducts)
            {
                report += $"- {p.Name}: Current {p.Stockpile} (Min {p.MinimumStock})\n";
            }
            MessageBox.Show(report, "Low Stock Report");
        }

        private void delinquentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customers = CustomerRepository.FindAll();
            var delinquents = customers.Where(c => !c.CanBuy()).ToList();

            if (delinquents.Count == 0)
            {
                MessageBox.Show("No delinquent customers found.");
                return;
            }

            string report = "DELINQUENT CUSTOMERS (Blocked):\n\n";
            foreach (var c in delinquents)
            {
                report += $"- {c.Name} (ID: {c.Id})\n";
            }
            MessageBox.Show(report, "Delinquency Report");
        }


        #region METHODS TO OPEN CHILD FORMS
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutForm aboutForm = AboutForm.GetInstance();
            aboutForm.MdiParent = this;
            aboutForm.Show();
            aboutForm.BringToFront();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm userReportForm = DashboardForm.GetInstance();
            userReportForm.MdiParent = this;
            userReportForm.Show();
            userReportForm.BringToFront();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = EmployeeForm.GetInstance(_loggedInUser);
            employeeForm.MdiParent = this;
            employeeForm.Show();
            employeeForm.BringToFront();
        }

        private void SystemMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.GetInstance().ClearFieldsAndShow();
        }

        private void salesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReportForm saleReportForm = SaleReportForm.GetInstance();
            saleReportForm.MdiParent = this;
            saleReportForm.Show();
            saleReportForm.BringToFront();
        }

        private void comissionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommissionForm comissionReportForm = CommissionForm.GetInstance();
            comissionReportForm.MdiParent = this;
            comissionReportForm.Show();
            comissionReportForm.BringToFront();
        }

        private void clientsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReportForm customerReportForm = CustomerReportForm.GetInstance();
            customerReportForm.MdiParent = this;
            customerReportForm.Show();
            customerReportForm.BringToFront();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = SaleForm.GetInstance(_loggedInUser);
            saleForm.MdiParent = this;
            saleForm.Show();
            saleForm.BringToFront();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = CustomerForm.GetInstance(_loggedInUser);
            customerForm.MdiParent = this;
            customerForm.Show();
            customerForm.BringToFront();
        }

        private void producttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = ProductForm.GetInstance(_loggedInUser);
            productForm.MdiParent = this;
            productForm.Show();
            productForm.BringToFront();
        }

        private void stockDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReportForm stockReportForm = StockReportForm.GetInstance(_loggedInUser);
            stockReportForm.MdiParent = this;
            stockReportForm.Show();
            stockReportForm.BringToFront();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = PaymentForm.GetInstance(_loggedInUser);
            paymentForm.MdiParent = this;
            paymentForm.Show();
            paymentForm.BringToFront();
        }

        #endregion


    }
}
