using System;
using System.Windows.Forms;

namespace MdiLoginSystem
{
    partial class About : Form
    {
        private static About? _instance;
        private About()
        {
            InitializeComponent();

        }

        public static About GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new About();
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
