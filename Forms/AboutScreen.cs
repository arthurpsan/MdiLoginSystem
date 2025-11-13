using System;
using System.Windows.Forms;

namespace UserManagementSystem
{
    partial class AboutScreen : Form
    {
        private static AboutScreen? _instance;
        private AboutScreen()
        {
            InitializeComponent();

        }

        public static AboutScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new AboutScreen();
            }

            return _instance;
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void okButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
