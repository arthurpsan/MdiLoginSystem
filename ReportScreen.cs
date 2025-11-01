using System;

namespace UserManagementSystem
{
    public partial class ReportScreen : Form
    {
        private static ReportScreen? _instance;
        public static ReportScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ReportScreen();
            }
            return _instance;
        }

        public ReportScreen()
        {
            InitializeComponent();
        }
    }
}
