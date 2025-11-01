namespace MdiLoginSystem
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            pnlLogin = new Panel();
            grpLogin = new GroupBox();
            btnLogin = new Button();
            lblErrorAlert = new Label();
            lblPassword = new Label();
            lblUser = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            pnlLogin.SuspendLayout();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            resources.ApplyResources(pnlLogin, "pnlLogin");
            pnlLogin.Controls.Add(grpLogin);
            pnlLogin.Name = "pnlLogin";
            // 
            // grpLogin
            // 
            resources.ApplyResources(grpLogin, "grpLogin");
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(lblErrorAlert);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(lblUser);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUser);
            grpLogin.Name = "grpLogin";
            grpLogin.TabStop = false;
            grpLogin.Enter += grpLogin_Enter;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorAlert
            // 
            resources.ApplyResources(lblErrorAlert, "lblErrorAlert");
            lblErrorAlert.ForeColor = Color.Crimson;
            lblErrorAlert.Name = "lblErrorAlert";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.Name = "lblPassword";
            // 
            // lblUser
            // 
            resources.ApplyResources(lblUser, "lblUser");
            lblUser.Name = "lblUser";
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // txtUser
            // 
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.Name = "txtUser";
            // 
            // LoginScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLogin);
            MaximizeBox = false;
            Name = "LoginScreen";
            ShowIcon = false;
            Load += LoginScreen_Load;
            pnlLogin.ResumeLayout(false);
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private GroupBox grpLogin;
        private Label lblErrorAlert;
        private Label lblPassword;
        private Label lblUser;
        private TextBox txtUser;
        private Button btnLogin;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtPassword;
    }
}
