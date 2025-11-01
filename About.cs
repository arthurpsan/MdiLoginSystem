using System;
using System.Windows.Forms;

namespace MdiLoginSystem
{
    partial class About : Form
    {
        private static About? _instance;
        public About GetInstance()
        {
            if (_instance == null)
            {
                _instance = new About();
            }

            return _instance;
        }

        public About()
        {
            InitializeComponent();

        }

        private void About_Load(object sender, EventArgs e)
        {

        }

    }
}
