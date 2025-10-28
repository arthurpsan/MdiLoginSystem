namespace MdiLoginSystem
{
    partial class LoginMenu
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
            pnlLogin = new Panel();
            grpLogin = new GroupBox();
            lblErrorAlert = new Label();
            lblPassword = new Label();
            lblUser = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            btnLogin = new Button();
            pnlLogin.SuspendLayout();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.Controls.Add(grpLogin);
            pnlLogin.Location = new Point(12, 12);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(776, 426);
            pnlLogin.TabIndex = 0;
            // 
            // grpLogin
            // 
            grpLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(lblErrorAlert);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(lblUser);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUser);
            grpLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(3, 3);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(770, 420);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            grpLogin.Enter += grpLogin_Enter;
            // 
            // lblErrorAlert
            // 
            lblErrorAlert.AutoSize = true;
            lblErrorAlert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorAlert.ForeColor = Color.Crimson;
            lblErrorAlert.Location = new Point(6, 141);
            lblErrorAlert.Name = "lblErrorAlert";
            lblErrorAlert.Size = new Size(251, 21);
            lblErrorAlert.TabIndex = 4;
            lblErrorAlert.Text = "ERROR: Wrong user or password.";
            lblErrorAlert.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(6, 85);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUser.Location = new Point(6, 29);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(6, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(758, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(6, 53);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(758, 29);
            txtUser.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(464, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlLogin);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnLogin;
    }
}
