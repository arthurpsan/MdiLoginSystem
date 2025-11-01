using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MdiLoginSystem
{
    public partial class SignupScreen : Form
    {
        private static SignupScreen? _instance;
        public static SignupScreen GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SignupScreen();
            }
            return _instance;
        }

        public SignupScreen()
        {
            InitializeComponent();
        }
        
    }
}
