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

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || mskPhoneNumber.Text == "")
            {
                lblErrorAlert.Visible = true;
            }
            

            newUser.Name = txtUsername.Text;
            newUser.Email = txtEmail.Text;
            newUser.Credential = new Credential
            {
                Email = txtEmail.Text,
                Password = Credential.ComputeSHA256(txtPassword.Text, Credential.SALT),
                Manager = chkIsManager.Checked
            };

            String phoneNumber = mskPhoneNumber.Text;
            UInt64 phoneNumerical = Convert.ToUInt64(phoneNumber);

            newUser.PhoneNumber = phoneNumerical;

            if (chkIsManager.Checked)
            {
                newUser.Credential.Manager = true;
            }
            else
            {
                newUser.Credential.Manager = false;
            }
        }
    }
}
