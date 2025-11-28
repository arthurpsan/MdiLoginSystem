namespace UserManagementSystem.Forms
{
    partial class CustomerForm
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
            pnlCustomerManagement = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            dgvCustomers = new DataGridView();
            ColumnCustomerName = new DataGridViewTextBoxColumn();
            ColumnCustomerEmail = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            lblCustomerManagement = new Label();
            gpoCustomerCredentials = new GroupBox();
            pnlCustomerCredentials = new TableLayoutPanel();
            txtCustomerEmail = new TextBox();
            lblCustomerEmail = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            pnlCustomerManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            gpoCustomerCredentials.SuspendLayout();
            pnlCustomerCredentials.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCustomerManagement
            // 
            pnlCustomerManagement.ColumnCount = 4;
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.Controls.Add(btnDelete, 1, 3);
            pnlCustomerManagement.Controls.Add(btnSave, 3, 3);
            pnlCustomerManagement.Controls.Add(dgvCustomers, 0, 2);
            pnlCustomerManagement.Controls.Add(btnUpdate, 2, 3);
            pnlCustomerManagement.Controls.Add(lblCustomerManagement, 0, 0);
            pnlCustomerManagement.Controls.Add(gpoCustomerCredentials, 0, 1);
            pnlCustomerManagement.Dock = DockStyle.Fill;
            pnlCustomerManagement.Location = new Point(0, 0);
            pnlCustomerManagement.Name = "pnlCustomerManagement";
            pnlCustomerManagement.RowCount = 4;
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            pnlCustomerManagement.Size = new Size(800, 450);
            pnlCustomerManagement.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(563, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(723, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnRegisterCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnCustomerName, ColumnCustomerEmail });
            pnlCustomerManagement.SetColumnSpan(dgvCustomers, 4);
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(3, 237);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(794, 174);
            dgvCustomers.TabIndex = 5;
            // 
            // ColumnCustomerName
            // 
            ColumnCustomerName.HeaderText = "Name";
            ColumnCustomerName.Name = "ColumnCustomerName";
            ColumnCustomerName.ReadOnly = true;
            ColumnCustomerName.Resizable = DataGridViewTriState.False;
            // 
            // ColumnCustomerEmail
            // 
            ColumnCustomerEmail.HeaderText = "E-mail";
            ColumnCustomerEmail.Name = "ColumnCustomerEmail";
            ColumnCustomerEmail.ReadOnly = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Location = new Point(643, 417);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(74, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblCustomerManagement
            // 
            lblCustomerManagement.AutoSize = true;
            lblCustomerManagement.BackColor = Color.FromArgb(0, 53, 123);
            pnlCustomerManagement.SetColumnSpan(lblCustomerManagement, 4);
            lblCustomerManagement.Dock = DockStyle.Fill;
            lblCustomerManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerManagement.ForeColor = Color.White;
            lblCustomerManagement.Location = new Point(3, 0);
            lblCustomerManagement.Name = "lblCustomerManagement";
            lblCustomerManagement.Size = new Size(794, 45);
            lblCustomerManagement.TabIndex = 7;
            lblCustomerManagement.Text = "Customer Management";
            lblCustomerManagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpoCustomerCredentials
            // 
            pnlCustomerManagement.SetColumnSpan(gpoCustomerCredentials, 4);
            gpoCustomerCredentials.Controls.Add(pnlCustomerCredentials);
            gpoCustomerCredentials.Dock = DockStyle.Fill;
            gpoCustomerCredentials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpoCustomerCredentials.Location = new Point(3, 48);
            gpoCustomerCredentials.Name = "gpoCustomerCredentials";
            gpoCustomerCredentials.Size = new Size(794, 183);
            gpoCustomerCredentials.TabIndex = 8;
            gpoCustomerCredentials.TabStop = false;
            gpoCustomerCredentials.Text = "Customer Credentials";
            // 
            // pnlCustomerCredentials
            // 
            pnlCustomerCredentials.ColumnCount = 2;
            pnlCustomerCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCustomerCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCustomerCredentials.Controls.Add(txtCustomerEmail, 1, 1);
            pnlCustomerCredentials.Controls.Add(lblCustomerEmail, 0, 1);
            pnlCustomerCredentials.Controls.Add(lblCustomerName, 0, 0);
            pnlCustomerCredentials.Controls.Add(txtCustomerName, 1, 0);
            pnlCustomerCredentials.Dock = DockStyle.Fill;
            pnlCustomerCredentials.Location = new Point(3, 25);
            pnlCustomerCredentials.Name = "pnlCustomerCredentials";
            pnlCustomerCredentials.RowCount = 4;
            pnlCustomerCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlCustomerCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlCustomerCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlCustomerCredentials.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlCustomerCredentials.Size = new Size(788, 155);
            pnlCustomerCredentials.TabIndex = 0;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerEmail.Location = new Point(397, 46);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(388, 22);
            txtCustomerEmail.TabIndex = 3;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Dock = DockStyle.Fill;
            lblCustomerEmail.Location = new Point(3, 38);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(388, 38);
            lblCustomerEmail.TabIndex = 2;
            lblCustomerEmail.Text = "E-mail:";
            lblCustomerEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Dock = DockStyle.Fill;
            lblCustomerName.Location = new Point(3, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(388, 38);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Name:";
            lblCustomerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(397, 8);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(388, 22);
            txtCustomerName.TabIndex = 0;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCustomerManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerForm";
            ShowIcon = false;
            Text = "\tCustomer Management";
            pnlCustomerManagement.ResumeLayout(false);
            pnlCustomerManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            gpoCustomerCredentials.ResumeLayout(false);
            pnlCustomerCredentials.ResumeLayout(false);
            pnlCustomerCredentials.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel pnlCustomerManagement;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvCustomers;
        private Button btnUpdate;
        private Label lblCustomerManagement;
        private GroupBox gpoCustomerCredentials;
        private TableLayoutPanel pnlCustomerCredentials;
        private TextBox txtCustomerEmail;
        private Label lblCustomerEmail;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private DataGridViewTextBoxColumn ColumnCustomerName;
        private DataGridViewTextBoxColumn ColumnCustomerEmail;
    }
}