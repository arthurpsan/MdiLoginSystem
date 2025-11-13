using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserManagementSystem.Forms
{
    public partial class SaleReportScreen : Form
    {
        private static SaleReportScreen _instance;
        public static SaleReportScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SaleReportScreen();
            }

            return _instance;
        }
        public SaleReportScreen()
        {
            InitializeComponent();
        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
