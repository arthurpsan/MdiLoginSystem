namespace UserManagementSystem.Forms
{
    partial class EmployeeForm
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
            components = new System.ComponentModel.Container();
            pnlEmployeeManagement = new TableLayoutPanel();
            lblEmployeeManagement = new Label();
            dgvEmployees = new DataGridView();
            grpEmployeeCredentials = new GroupBox();
            pnlEmployeeCredentials = new TableLayoutPanel();
            btnRemoveEmployee = new Button();
            lblEmployeeRole = new Label();
            lblRepeatPassword = new Label();
            lblPassword = new Label();
            lblEmployeePhone = new Label();
            lblEmployeeEmail = new Label();
            lblEmployeeNickname = new Label();
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            txtEmployeeNickname = new TextBox();
            txtEmployeeEmail = new TextBox();
            txtEmployeePassword = new TextBox();
            txtRepeatPassword = new TextBox();
            cboEmployeeRoles = new ComboBox();
            btnSave = new Button();
            mskPhoneNumber = new MaskedTextBox();
            bdsEmployees = new BindingSource(components);
            pnlEmployeeManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            grpEmployeeCredentials.SuspendLayout();
            pnlEmployeeCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bdsEmployees).BeginInit();
            SuspendLayout();
            // 
            // pnlEmployeeManagement
            // 
            pnlEmployeeManagement.ColumnCount = 4;
            pnlEmployeeManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlEmployeeManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlEmployeeManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlEmployeeManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlEmployeeManagement.Controls.Add(lblEmployeeManagement, 0, 0);
            pnlEmployeeManagement.Controls.Add(dgvEmployees, 0, 3);
            pnlEmployeeManagement.Controls.Add(grpEmployeeCredentials, 0, 1);
            pnlEmployeeManagement.Dock = DockStyle.Fill;
            pnlEmployeeManagement.Location = new Point(0, 0);
            pnlEmployeeManagement.Name = "pnlEmployeeManagement";
            pnlEmployeeManagement.RowCount = 4;
            pnlEmployeeManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlEmployeeManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlEmployeeManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlEmployeeManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlEmployeeManagement.Size = new Size(800, 450);
            pnlEmployeeManagement.TabIndex = 0;
            // 
            // lblEmployeeManagement
            // 
            lblEmployeeManagement.AutoSize = true;
            lblEmployeeManagement.BackColor = Color.FromArgb(0, 53, 123);
            pnlEmployeeManagement.SetColumnSpan(lblEmployeeManagement, 4);
            lblEmployeeManagement.Dock = DockStyle.Fill;
            lblEmployeeManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeManagement.ForeColor = Color.White;
            lblEmployeeManagement.Location = new Point(3, 0);
            lblEmployeeManagement.Name = "lblEmployeeManagement";
            lblEmployeeManagement.Size = new Size(794, 45);
            lblEmployeeManagement.TabIndex = 0;
            lblEmployeeManagement.Text = "Employee Management";
            lblEmployeeManagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pnlEmployeeManagement.SetColumnSpan(dgvEmployees, 4);
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(3, 318);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.Size = new Size(794, 129);
            dgvEmployees.TabIndex = 1;
            // 
            // grpEmployeeCredentials
            // 
            pnlEmployeeManagement.SetColumnSpan(grpEmployeeCredentials, 4);
            grpEmployeeCredentials.Controls.Add(pnlEmployeeCredentials);
            grpEmployeeCredentials.Dock = DockStyle.Fill;
            grpEmployeeCredentials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployeeCredentials.Location = new Point(3, 48);
            grpEmployeeCredentials.Name = "grpEmployeeCredentials";
            pnlEmployeeManagement.SetRowSpan(grpEmployeeCredentials, 2);
            grpEmployeeCredentials.Size = new Size(794, 264);
            grpEmployeeCredentials.TabIndex = 2;
            grpEmployeeCredentials.TabStop = false;
            grpEmployeeCredentials.Text = "Employee Credentials";
            // 
            // pnlEmployeeCredentials
            // 
            pnlEmployeeCredentials.ColumnCount = 5;
            pnlEmployeeCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.Controls.Add(btnRemoveEmployee, 3, 4);
            pnlEmployeeCredentials.Controls.Add(lblEmployeeRole, 3, 0);
            pnlEmployeeCredentials.Controls.Add(lblRepeatPassword, 3, 3);
            pnlEmployeeCredentials.Controls.Add(lblPassword, 3, 2);
            pnlEmployeeCredentials.Controls.Add(lblEmployeePhone, 0, 3);
            pnlEmployeeCredentials.Controls.Add(lblEmployeeEmail, 0, 2);
            pnlEmployeeCredentials.Controls.Add(lblEmployeeNickname, 0, 1);
            pnlEmployeeCredentials.Controls.Add(lblEmployeeName, 0, 0);
            pnlEmployeeCredentials.Controls.Add(txtEmployeeName, 1, 0);
            pnlEmployeeCredentials.Controls.Add(txtEmployeeNickname, 1, 1);
            pnlEmployeeCredentials.Controls.Add(txtEmployeeEmail, 1, 2);
            pnlEmployeeCredentials.Controls.Add(txtEmployeePassword, 4, 2);
            pnlEmployeeCredentials.Controls.Add(txtRepeatPassword, 4, 3);
            pnlEmployeeCredentials.Controls.Add(cboEmployeeRoles, 4, 0);
            pnlEmployeeCredentials.Controls.Add(btnSave, 4, 4);
            pnlEmployeeCredentials.Controls.Add(mskPhoneNumber, 1, 3);
            pnlEmployeeCredentials.Dock = DockStyle.Fill;
            pnlEmployeeCredentials.Location = new Point(3, 25);
            pnlEmployeeCredentials.Name = "pnlEmployeeCredentials";
            pnlEmployeeCredentials.RowCount = 5;
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEmployeeCredentials.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlEmployeeCredentials.Size = new Size(788, 236);
            pnlEmployeeCredentials.TabIndex = 0;
            // 
            // btnRemoveEmployee
            // 
            btnRemoveEmployee.Dock = DockStyle.Fill;
            btnRemoveEmployee.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveEmployee.Location = new Point(474, 191);
            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Size = new Size(151, 42);
            btnRemoveEmployee.TabIndex = 15;
            btnRemoveEmployee.Text = "Remove";
            btnRemoveEmployee.UseVisualStyleBackColor = true;
            btnRemoveEmployee.Click += BtnRemoveEmployee_Click;
            // 
            // lblEmployeeRole
            // 
            lblEmployeeRole.AutoSize = true;
            lblEmployeeRole.Dock = DockStyle.Fill;
            lblEmployeeRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeRole.Location = new Point(474, 0);
            lblEmployeeRole.Name = "lblEmployeeRole";
            lblEmployeeRole.Size = new Size(151, 47);
            lblEmployeeRole.TabIndex = 12;
            lblEmployeeRole.Text = "Role:";
            lblEmployeeRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Dock = DockStyle.Fill;
            lblRepeatPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepeatPassword.Location = new Point(474, 141);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(151, 47);
            lblRepeatPassword.TabIndex = 10;
            lblRepeatPassword.Text = "Repeat password:";
            lblRepeatPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(474, 94);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(151, 47);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Dock = DockStyle.Fill;
            lblEmployeePhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeePhone.Location = new Point(3, 141);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(151, 47);
            lblEmployeePhone.TabIndex = 4;
            lblEmployeePhone.Text = "Phone number:";
            lblEmployeePhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployeeEmail
            // 
            lblEmployeeEmail.AutoSize = true;
            lblEmployeeEmail.Dock = DockStyle.Fill;
            lblEmployeeEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeEmail.Location = new Point(3, 94);
            lblEmployeeEmail.Name = "lblEmployeeEmail";
            lblEmployeeEmail.Size = new Size(151, 47);
            lblEmployeeEmail.TabIndex = 3;
            lblEmployeeEmail.Text = "E-mail:";
            lblEmployeeEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployeeNickname
            // 
            lblEmployeeNickname.AutoSize = true;
            lblEmployeeNickname.Dock = DockStyle.Fill;
            lblEmployeeNickname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeNickname.Location = new Point(3, 47);
            lblEmployeeNickname.Name = "lblEmployeeNickname";
            lblEmployeeNickname.Size = new Size(151, 47);
            lblEmployeeNickname.TabIndex = 2;
            lblEmployeeNickname.Text = "Nickname:";
            lblEmployeeNickname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Dock = DockStyle.Fill;
            lblEmployeeName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(3, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(151, 47);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Name:";
            lblEmployeeName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(160, 12);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(151, 22);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeNickname
            // 
            txtEmployeeNickname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeNickname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeNickname.Location = new Point(160, 59);
            txtEmployeeNickname.Name = "txtEmployeeNickname";
            txtEmployeeNickname.Size = new Size(151, 22);
            txtEmployeeNickname.TabIndex = 6;
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlEmployeeCredentials.SetColumnSpan(txtEmployeeEmail, 2);
            txtEmployeeEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeEmail.Location = new Point(160, 106);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(308, 22);
            txtEmployeeEmail.TabIndex = 7;
            // 
            // txtEmployeePassword
            // 
            txtEmployeePassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeePassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeePassword.Location = new Point(631, 106);
            txtEmployeePassword.Name = "txtEmployeePassword";
            txtEmployeePassword.Size = new Size(154, 22);
            txtEmployeePassword.TabIndex = 9;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRepeatPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepeatPassword.Location = new Point(631, 153);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(154, 22);
            txtRepeatPassword.TabIndex = 11;
            // 
            // cboEmployeeRoles
            // 
            cboEmployeeRoles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboEmployeeRoles.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmployeeRoles.FormattingEnabled = true;
            cboEmployeeRoles.Location = new Point(631, 13);
            cboEmployeeRoles.Name = "cboEmployeeRoles";
            cboEmployeeRoles.Size = new Size(154, 21);
            cboEmployeeRoles.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(631, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 42);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // mskPhoneNumber
            // 
            mskPhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mskPhoneNumber.Font = new Font("Segoe UI", 8.25F);
            mskPhoneNumber.Location = new Point(160, 153);
            mskPhoneNumber.Mask = "+00 (00) 00000-0000";
            mskPhoneNumber.Name = "mskPhoneNumber";
            mskPhoneNumber.Size = new Size(151, 22);
            mskPhoneNumber.TabIndex = 16;
            // 
            // bdsEmployees
            // 
            bdsEmployees.DataSource = typeof(Models.ViewModels.UserViewModel);
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlEmployeeManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeForm";
            ShowIcon = false;
            Text = "Employee Management";
            pnlEmployeeManagement.ResumeLayout(false);
            pnlEmployeeManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            grpEmployeeCredentials.ResumeLayout(false);
            pnlEmployeeCredentials.ResumeLayout(false);
            pnlEmployeeCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bdsEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlEmployeeManagement;
        private Label lblEmployeeManagement;
        private DataGridView dgvEmployees;
        private GroupBox grpEmployeeCredentials;
        private TableLayoutPanel pnlEmployeeCredentials;
        private Label lblEmployeeNickname;
        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblPassword;
        private Label lblEmployeePhone;
        private Label lblEmployeeEmail;
        private TextBox txtEmployeeNickname;
        private Label lblRepeatPassword;
        private TextBox txtEmployeeEmail;
        private TextBox txtEmployeePassword;
        private Label lblEmployeeRole;
        private TextBox txtRepeatPassword;
        private ComboBox cboEmployeeRoles;
        private Button btnRemoveEmployee;
        private Button btnSave;
        private MaskedTextBox mskPhoneNumber;
        private BindingSource bdsEmployees;
    }
}