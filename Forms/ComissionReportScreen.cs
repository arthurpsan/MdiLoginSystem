using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserManagementSystem.Forms
{
    public partial class ComissionReportScreen : Form
    {
        private static ComissionReportScreen? _instance;
        public static ComissionReportScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ComissionReportScreen();
            }

            return _instance;
        }

        public ComissionReportScreen()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
