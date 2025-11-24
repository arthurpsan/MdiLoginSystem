using System;
using System.Windows.Forms;
using UserManagementSystem.Data;

namespace UserManagementSystem.Forms
{
    public partial class ManagerAuthForm : Form
    {
        public ManagerAuthForm()
        {
            InitializeComponent();

            btnAuthorize.Click += btnAuthorize_Click;
            btnCancel.Click += (sender, e) => { this.DialogResult = DialogResult.Cancel; };
        }

        private void btnAuthorize_Click(object? sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                if (CredentialRepository.ValidateManagerCredentials(email, password))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lblErrorAlert.Visible = true;
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao autorizar: {ex.Message}", "Erro");
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.ClearAllFields();
            this.Close();
        }

        private void ClearAllFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
