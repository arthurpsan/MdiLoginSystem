using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementSystem.Data;

namespace UserManagementSystem.Forms
{
    public partial class PaymentForm : Form
    {
        private static PaymentForm? _instance;
        private Models.User? _loggedInUser;
        private readonly Repository _dbContext;

        public PaymentForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PaymentForm();
            }
            return _instance;
        }


        public PaymentForm()
        {
            InitializeComponent();
        }
    }
}
