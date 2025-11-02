namespace UserManagementSystem
{
    partial class SignupScreen
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
            lblNickname = new Label();
            txtNickname = new TextBox();
            lblErrorAlert = new Label();
            mskPhoneNumber = new MaskedTextBox();
            btnSave = new Button();
            lblPhone = new Label();
            txtRepeatPassword = new TextBox();
            lblRepeatPassword = new Label();
            chkIsManager = new CheckBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblUsername = new Label();
            pnlRegister.SuspendLayout();
            grpSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(grpSignUp);
            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.Location = new Point(0, 0);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(800, 450);
            pnlRegister.TabIndex = 0;
            // 
            // grpSignUp
            // 
            grpSignUp.Controls.Add(lblNickname);
            grpSignUp.Controls.Add(txtNickname);
            grpSignUp.Controls.Add(lblErrorAlert);
            grpSignUp.Controls.Add(mskPhoneNumber);
            grpSignUp.Controls.Add(btnSave);
            grpSignUp.Controls.Add(lblPhone);
            grpSignUp.Controls.Add(txtRepeatPassword);
            grpSignUp.Controls.Add(lblRepeatPassword);
            grpSignUp.Controls.Add(chkIsManager);
            grpSignUp.Controls.Add(txtEmail);
            grpSignUp.Controls.Add(txtUsername);
            grpSignUp.Controls.Add(txtPassword);
            grpSignUp.Controls.Add(label2);
            grpSignUp.Controls.Add(label1);
            grpSignUp.Controls.Add(lblUsername);
            grpSignUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSignUp.Location = new Point(12, 12);
            grpSignUp.Name = "grpSignUp";
            grpSignUp.Size = new Size(776, 426);
            grpSignUp.TabIndex = 0;
            grpSignUp.TabStop = false;
            grpSignUp.Text = "Sign Up";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNickname.Location = new Point(405, 29);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(82, 21);
            lblNickname.TabIndex = 15;
            lblNickname.Text = "Nickname";
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Segoe UI", 12F);
            txtNickname.Location = new Point(405, 57);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(359, 29);
            txtNickname.TabIndex = 14;
            txtNickname.Enter += txtNickname_Enter;
            txtNickname.Leave += txtNickname_Leave;
            // 
            // lblErrorAlert
            // 
            lblErrorAlert.AutoSize = true;
            lblErrorAlert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblErrorAlert.ForeColor = Color.Crimson;
            lblErrorAlert.ImeMode = ImeMode.NoControl;
            lblErrorAlert.Location = new Point(6, 353);
            lblErrorAlert.Name = "lblErrorAlert";
            lblErrorAlert.Size = new Size(229, 21);
            lblErrorAlert.TabIndex = 13;
            lblErrorAlert.Text = "Invalid fields. Please try again!";
            lblErrorAlert.Visible = false;
            // 
            // mskPhoneNumber
            // 
            mskPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPhoneNumber.Location = new Point(6, 185);
            mskPhoneNumber.Mask = "(99) 00000-0000";
            mskPhoneNumber.Name = "mskPhoneNumber";
            mskPhoneNumber.Size = new Size(758, 29);
            mskPhoneNumber.TabIndex = 12;
            mskPhoneNumber.Enter += mskPhoneNumber_Enter;
            mskPhoneNumber.Leave += mskPhoneNumber_Leave;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(670, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(6, 157);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 21);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 12F);
            txtRepeatPassword.Location = new Point(6, 313);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(758, 29);
            txtRepeatPassword.TabIndex = 8;
            txtRepeatPassword.Enter += txtRepeatPassword_Enter;
            txtRepeatPassword.Leave += txtRepeatPassword_Leave;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRepeatPassword.Location = new Point(6, 285);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(135, 21);
            lblRepeatPassword.TabIndex = 7;
            lblRepeatPassword.Text = "Repeat Password";
            // 
            // chkIsManager
            // 
            chkIsManager.AutoSize = true;
            chkIsManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsManager.Location = new Point(670, 349);
            chkIsManager.Name = "chkIsManager";
            chkIsManager.Size = new Size(94, 25);
            chkIsManager.TabIndex = 6;
            chkIsManager.Text = "Manager";
            chkIsManager.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(6, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(758, 29);
            txtEmail.TabIndex = 5;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(6, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(359, 29);
            txtUsername.TabIndex = 4;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(6, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(758, 29);
            txtPassword.TabIndex = 3;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 221);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 93);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(6, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // SignupScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "SignupScreen";
            ShowIcon = false;
            Text = "System - Sign Up ";
            KeyDown += SignupScreen_KeyDown;
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
        private Label lblUsername;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPhone;
        private TextBox txtRepeatPassword;
        private Label lblRepeatPassword;
        private CheckBox chkIsManager;
        private Button btnSave;
        private MaskedTextBox mskPhoneNumber;
        private Label lblErrorAlert;
        private Label lblNickname;
        private TextBox txtNickname;
    }
}