using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserManagementSystem.Forms
{
    public partial class CustomerPurchasesReport : Form
    {
        private static CustomerPurchasesReport? _instance;

        public static CustomerPurchasesReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CustomerPurchasesReport();
            }

            return _instance;
        }

        public CustomerPurchasesReport()
        {
            InitializeComponent();
        }
    }
}
