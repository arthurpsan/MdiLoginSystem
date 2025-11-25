namespace UserManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLoginScreen = new TableLayoutPanel();
            grpLogin = new GroupBox();
            pnlLoginCredentials = new TableLayoutPanel();
            lblUserEmail = new Label();
            lblUserPassword = new Label();
            txtUserEmail = new TextBox();
            txtUserPassword = new TextBox();
            btnLogin = new Button();
            lblErrorAlert = new Label();
            pnlLoginScreen.SuspendLayout();
            grpLogin.SuspendLayout();
            pnlLoginCredentials.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginScreen
            // 
            resources.ApplyResources(pnlLoginScreen, "pnlLoginScreen");
            pnlLoginScreen.Controls.Add(grpLogin, 1, 0);
            pnlLoginScreen.Controls.Add(btnLogin, 1, 4);
            pnlLoginScreen.Controls.Add(lblErrorAlert, 1, 2);
            pnlLoginScreen.Name = "pnlLoginScreen";
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(pnlLoginCredentials);
            resources.ApplyResources(grpLogin, "grpLogin");
            grpLogin.Name = "grpLogin";
            pnlLoginScreen.SetRowSpan(grpLogin, 2);
            grpLogin.TabStop = false;
            // 
            // pnlLoginCredentials
            // 
            resources.ApplyResources(pnlLoginCredentials, "pnlLoginCredentials");
            pnlLoginCredentials.Controls.Add(lblUserEmail, 0, 0);
            pnlLoginCredentials.Controls.Add(lblUserPassword, 0, 2);
            pnlLoginCredentials.Controls.Add(txtUserEmail, 0, 1);
            pnlLoginCredentials.Controls.Add(txtUserPassword, 0, 3);
            pnlLoginCredentials.Name = "pnlLoginCredentials";
            // 
            // lblUserEmail
            // 
            resources.ApplyResources(lblUserEmail, "lblUserEmail");
            lblUserEmail.Name = "lblUserEmail";
            // 
            // lblUserPassword
            // 
            resources.ApplyResources(lblUserPassword, "lblUserPassword");
            lblUserPassword.Name = "lblUserPassword";
            // 
            // txtUserEmail
            // 
            resources.ApplyResources(txtUserEmail, "txtUserEmail");
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Enter += TxtUserEmail_Enter;
            txtUserEmail.Leave += TxtUserEmail_Leave;
            // 
            // txtUserPassword
            // 
            resources.ApplyResources(txtUserPassword, "txtUserPassword");
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Enter += TxtUserPassword_Enter;
            txtUserPassword.KeyDown += TxtUserPassword_KeyDown;
            txtUserPassword.Leave += TxtUserPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 53, 123);
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblErrorAlert
            // 
            resources.ApplyResources(lblErrorAlert, "lblErrorAlert");
            lblErrorAlert.ForeColor = Color.Red;
            lblErrorAlert.Name = "lblErrorAlert";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLoginScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            KeyDown += UserLoginScreen_KeyDown;
            pnlLoginScreen.ResumeLayout(false);
            pnlLoginScreen.PerformLayout();
            grpLogin.ResumeLayout(false);
            pnlLoginCredentials.ResumeLayout(false);
            pnlLoginCredentials.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlLoginScreen;
        private GroupBox grpLogin;
        private TableLayoutPanel pnlLoginCredentials;
        private Label lblUserEmail;
        private Label lblUserPassword;
        private TextBox txtUserEmail;
        private TextBox txtUserPassword;
        private Button btnLogin;
        private Label lblErrorAlert;
    }
}
