using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementSystem.Models;

namespace UserManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private static ProductForm? _instance;
        private User? _loggedInUser;

        public static ProductForm GetInstance(User user)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ProductForm(user);
            }
            return _instance;
        }

        public ProductForm(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;


        }
    }
}
