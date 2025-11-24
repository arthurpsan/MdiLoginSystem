namespace UserManagementSystem.Forms
{
    partial class ManagerAuthForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblInstructions = new Label();
            grpEmail = new GroupBox();
            panel1 = new Panel();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnAuthorize = new Button();
            lblErrorAlert = new Label();
            tableLayoutPanel1.SuspendLayout();
            grpEmail.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlPassword.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblInstructions, 0, 0);
            tableLayoutPanel1.Controls.Add(grpEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCancel, 2, 4);
            tableLayoutPanel1.Controls.Add(btnAuthorize, 3, 4);
            tableLayoutPanel1.Controls.Add(lblErrorAlert, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.FromArgb(0, 53, 123);
            tableLayoutPanel1.SetColumnSpan(lblInstructions, 4);
            lblInstructions.Dock = DockStyle.Fill;
            lblInstructions.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(3, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(794, 45);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Manager Authorization Required";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpEmail
            // 
            tableLayoutPanel1.SetColumnSpan(grpEmail, 4);
            grpEmail.Controls.Add(panel1);
            grpEmail.Dock = DockStyle.Fill;
            grpEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmail.Location = new Point(3, 48);
            grpEmail.Name = "grpEmail";
            grpEmail.Size = new Size(794, 129);
            grpEmail.TabIndex = 1;
            grpEmail.TabStop = false;
            grpEmail.Text = "Email";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 101);
            panel1.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(8, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(779, 29);
            txtEmail.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(pnlPassword);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Password";
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Dock = DockStyle.Fill;
            pnlPassword.Location = new Point(3, 25);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(788, 101);
            pnlPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(6, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(776, 29);
            txtPassword.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(403, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(194, 39);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAuthorize
            // 
            btnAuthorize.Dock = DockStyle.Fill;
            btnAuthorize.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthorize.Location = new Point(603, 408);
            btnAuthorize.Name = "btnAuthorize";
            btnAuthorize.Size = new Size(194, 39);
            btnAuthorize.TabIndex = 4;
            btnAuthorize.Text = "Authorize";
            btnAuthorize.UseVisualStyleBackColor = true;
            // 
            // lblErrorAlert
            // 
            lblErrorAlert.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblErrorAlert, 2);
            lblErrorAlert.Dock = DockStyle.Fill;
            lblErrorAlert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorAlert.ForeColor = Color.LightCoral;
            lblErrorAlert.Location = new Point(3, 405);
            lblErrorAlert.Name = "lblErrorAlert";
            lblErrorAlert.Size = new Size(394, 45);
            lblErrorAlert.TabIndex = 5;
            lblErrorAlert.Text = "Credentials don't match. Please try again!";
            lblErrorAlert.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManagerAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ManagerAuthForm";
            ShowIcon = false;
            Text = "ManagerAuthorizationScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grpEmail.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblInstructions;
        private GroupBox grpEmail;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnAuthorize;
        private Label lblErrorAlert;
        private Panel panel1;
        private Panel pnlPassword;
        private TextBox txtPassword;
    }
}