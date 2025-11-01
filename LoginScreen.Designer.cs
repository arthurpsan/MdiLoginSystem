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
            grpPassword = new GroupBox();
            txtPassword = new TextBox();
            lblErrorAlert = new Label();
            btnLogin = new Button();
            grpEmail = new GroupBox();
            txtEmail = new TextBox();
            pnlLogin.SuspendLayout();
            grpLogin.SuspendLayout();
            grpPassword.SuspendLayout();
            grpEmail.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(grpLogin);
            resources.ApplyResources(pnlLogin, "pnlLogin");
            pnlLogin.Name = "pnlLogin";
            // 
            // grpLogin
            // 
            resources.ApplyResources(grpLogin, "grpLogin");
            grpLogin.Controls.Add(grpPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(grpEmail);
            grpLogin.Name = "grpLogin";
            grpLogin.TabStop = false;
            grpLogin.Enter += grpLogin_Enter;
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(txtPassword);
            grpPassword.Controls.Add(lblErrorAlert);
            resources.ApplyResources(grpPassword, "grpPassword");
            grpPassword.Name = "grpPassword";
            grpPassword.TabStop = false;
            grpPassword.Enter += grpPassword_Enter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.KeyUp += txtPassword_KeyUp;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblErrorAlert
            // 
            resources.ApplyResources(lblErrorAlert, "lblErrorAlert");
            lblErrorAlert.ForeColor = Color.Crimson;
            lblErrorAlert.Name = "lblErrorAlert";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // grpEmail
            // 
            grpEmail.Controls.Add(txtEmail);
            resources.ApplyResources(grpEmail, "grpEmail");
            grpEmail.Name = "grpEmail";
            grpEmail.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.KeyPress += txtEmail_KeyPress;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // LoginScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLogin);
            MaximizeBox = false;
            Name = "LoginScreen";
            ShowIcon = false;
            pnlLogin.ResumeLayout(false);
            grpLogin.ResumeLayout(false);
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            grpEmail.ResumeLayout(false);
            grpEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private GroupBox grpLogin;
        private TextBox txtEmail;
        private Button btnLogin;
        private TextBox txtPassword;
        private GroupBox grpPassword;
        private Label lblErrorAlert;
        private GroupBox grpEmail;
    }
}
