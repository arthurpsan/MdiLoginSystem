namespace MdiLoginSystem
{
    partial class SignUpMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlRegister = new Panel();
            grpSignUp = new GroupBox();
            btnSave = new Button();
            textBox1 = new TextBox();
            lblPhone = new Label();
            txtRepeatPassword = new TextBox();
            lblRepeatPassword = new Label();
            chkManager = new CheckBox();
            txtEmail = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblUser = new Label();
            pnlRegister.SuspendLayout();
            grpSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(grpSignUp);
            pnlRegister.Location = new Point(12, 12);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(776, 426);
            pnlRegister.TabIndex = 0;
            // 
            // grpSignUp
            // 
            grpSignUp.Controls.Add(btnSave);
            grpSignUp.Controls.Add(textBox1);
            grpSignUp.Controls.Add(lblPhone);
            grpSignUp.Controls.Add(txtRepeatPassword);
            grpSignUp.Controls.Add(lblRepeatPassword);
            grpSignUp.Controls.Add(chkManager);
            grpSignUp.Controls.Add(txtEmail);
            grpSignUp.Controls.Add(txtUser);
            grpSignUp.Controls.Add(txtPassword);
            grpSignUp.Controls.Add(label2);
            grpSignUp.Controls.Add(label1);
            grpSignUp.Controls.Add(lblUser);
            grpSignUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSignUp.Location = new Point(3, 3);
            grpSignUp.Name = "grpSignUp";
            grpSignUp.Size = new Size(770, 420);
            grpSignUp.TabIndex = 0;
            grpSignUp.TabStop = false;
            grpSignUp.Text = "Sign Up";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(670, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(758, 29);
            textBox1.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(6, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 21);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 12F);
            txtRepeatPassword.Location = new Point(6, 277);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(758, 29);
            txtRepeatPassword.TabIndex = 8;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRepeatPassword.Location = new Point(6, 253);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(135, 21);
            lblRepeatPassword.TabIndex = 7;
            lblRepeatPassword.Text = "Repeat Password";
            // 
            // chkManager
            // 
            chkManager.AutoSize = true;
            chkManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkManager.Location = new Point(670, 312);
            chkManager.Name = "chkManager";
            chkManager.Size = new Size(94, 25);
            chkManager.TabIndex = 6;
            chkManager.Text = "Manager";
            chkManager.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(6, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(758, 29);
            txtEmail.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(6, 53);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(758, 29);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(6, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(758, 29);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 197);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(6, 29);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "User";
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegister);
            Name = "SignUpMenu";
            ShowIcon = false;
            Text = "SignUpMenu";
            Load += SignUpMenu_Load;
            pnlRegister.ResumeLayout(false);
            grpSignUp.ResumeLayout(false);
            grpSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private GroupBox grpSignUp;
        private Label label2;
        private Label label1;
        private Label lblUser;
        private TextBox txtEmail;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox textBox1;
        private Label lblPhone;
        private TextBox txtRepeatPassword;
        private Label lblRepeatPassword;
        private CheckBox chkManager;
        private Button btnSave;
    }
}