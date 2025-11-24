using System;
using System.Windows.Forms;

namespace UserManagementSystem
{
    partial class AboutForm : Form
    {
        private static AboutForm? _instance;
        private AboutForm()
        {
            InitializeComponent();

        }

        public static AboutForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new AboutForm();
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
