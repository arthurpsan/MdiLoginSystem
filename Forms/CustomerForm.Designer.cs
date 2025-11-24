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
            tabControlMain = new TabControl();
            tbpNewCustomer = new TabPage();
            pnlCreateCustomer = new TableLayoutPanel();
            groupboxName = new GroupBox();
            txtName = new TextBox();
            lblCreateNewCustomer = new Label();
            groupboxEmail = new GroupBox();
            txtEmail = new TextBox();
            tbpEditCustomer = new TabPage();
            pnlEditCustomer = new TableLayoutPanel();
            groupBoxEditName = new GroupBox();
            txtEditCustomerName = new TextBox();
            groupBoxEditEmail = new GroupBox();
            txtEditCustomerEmail = new TextBox();
            lblEditCustomer = new Label();
            pnlCustomerManagement = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            customersGridView = new DataGridView();
            ColumnCustomerId = new DataGridViewTextBoxColumn();
            ColumnCustomerName = new DataGridViewTextBoxColumn();
            ColumnCustomerEmail = new DataGridViewTextBoxColumn();
            tabControlMain.SuspendLayout();
            tbpNewCustomer.SuspendLayout();
            pnlCreateCustomer.SuspendLayout();
            groupboxName.SuspendLayout();
            groupboxEmail.SuspendLayout();
            tbpEditCustomer.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            groupBoxEditName.SuspendLayout();
            groupBoxEditEmail.SuspendLayout();
            pnlCustomerManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            pnlCustomerManagement.SetColumnSpan(tabControlMain, 3);
            tabControlMain.Controls.Add(tbpNewCustomer);
            tabControlMain.Controls.Add(tbpEditCustomer);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(3, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(794, 228);
            tabControlMain.TabIndex = 0;
            // 
            // tbpNewCustomer
            // 
            tbpNewCustomer.Controls.Add(pnlCreateCustomer);
            tbpNewCustomer.Location = new Point(4, 24);
            tbpNewCustomer.Name = "tbpNewCustomer";
            tbpNewCustomer.Padding = new Padding(3);
            tbpNewCustomer.Size = new Size(786, 200);
            tbpNewCustomer.TabIndex = 0;
            tbpNewCustomer.Text = "Add New Customer";
            tbpNewCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlCreateCustomer
            // 
            pnlCreateCustomer.ColumnCount = 2;
            pnlCreateCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCreateCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCreateCustomer.Controls.Add(groupboxName, 0, 2);
            pnlCreateCustomer.Controls.Add(lblCreateNewCustomer, 0, 0);
            pnlCreateCustomer.Controls.Add(groupboxEmail, 0, 1);
            pnlCreateCustomer.Dock = DockStyle.Fill;
            pnlCreateCustomer.Location = new Point(3, 3);
            pnlCreateCustomer.Name = "pnlCreateCustomer";
            pnlCreateCustomer.RowCount = 4;
            pnlCreateCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlCreateCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlCreateCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlCreateCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlCreateCustomer.Size = new Size(780, 194);
            pnlCreateCustomer.TabIndex = 0;
            // 
            // groupboxName
            // 
            pnlCreateCustomer.SetColumnSpan(groupboxName, 3);
            groupboxName.Controls.Add(txtName);
            groupboxName.Dock = DockStyle.Fill;
            groupboxName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupboxName.Location = new Point(3, 118);
            groupboxName.Name = "groupboxName";
            pnlCreateCustomer.SetRowSpan(groupboxName, 2);
            groupboxName.Size = new Size(774, 73);
            groupboxName.TabIndex = 0;
            groupboxName.TabStop = false;
            groupboxName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(762, 29);
            txtName.TabIndex = 0;
            // 
            // lblCreateNewCustomer
            // 
            lblCreateNewCustomer.AutoSize = true;
            lblCreateNewCustomer.BackColor = Color.FromArgb(0, 53, 123);
            pnlCreateCustomer.SetColumnSpan(lblCreateNewCustomer, 5);
            lblCreateNewCustomer.Dock = DockStyle.Fill;
            lblCreateNewCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNewCustomer.ForeColor = Color.White;
            lblCreateNewCustomer.Location = new Point(3, 0);
            lblCreateNewCustomer.Name = "lblCreateNewCustomer";
            lblCreateNewCustomer.Size = new Size(774, 38);
            lblCreateNewCustomer.TabIndex = 1;
            lblCreateNewCustomer.Text = "Create New Customer";
            lblCreateNewCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupboxEmail
            // 
            pnlCreateCustomer.SetColumnSpan(groupboxEmail, 5);
            groupboxEmail.Controls.Add(txtEmail);
            groupboxEmail.Dock = DockStyle.Fill;
            groupboxEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupboxEmail.Location = new Point(3, 41);
            groupboxEmail.Name = "groupboxEmail";
            groupboxEmail.Size = new Size(774, 71);
            groupboxEmail.TabIndex = 2;
            groupboxEmail.TabStop = false;
            groupboxEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(6, 28);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(762, 29);
            txtEmail.TabIndex = 0;
            // 
            // tbpEditCustomer
            // 
            tbpEditCustomer.Controls.Add(pnlEditCustomer);
            tbpEditCustomer.Location = new Point(4, 24);
            tbpEditCustomer.Name = "tbpEditCustomer";
            tbpEditCustomer.Padding = new Padding(3);
            tbpEditCustomer.Size = new Size(786, 200);
            tbpEditCustomer.TabIndex = 2;
            tbpEditCustomer.Text = "Edit Customer";
            tbpEditCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlEditCustomer
            // 
            pnlEditCustomer.ColumnCount = 2;
            pnlEditCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlEditCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlEditCustomer.Controls.Add(groupBoxEditName, 0, 2);
            pnlEditCustomer.Controls.Add(groupBoxEditEmail, 0, 1);
            pnlEditCustomer.Controls.Add(lblEditCustomer, 0, 0);
            pnlEditCustomer.Dock = DockStyle.Fill;
            pnlEditCustomer.Location = new Point(3, 3);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.RowCount = 2;
            pnlEditCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlEditCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlEditCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlEditCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlEditCustomer.Size = new Size(780, 194);
            pnlEditCustomer.TabIndex = 0;
            // 
            // groupBoxEditName
            // 
            pnlEditCustomer.SetColumnSpan(groupBoxEditName, 3);
            groupBoxEditName.Controls.Add(txtEditCustomerName);
            groupBoxEditName.Dock = DockStyle.Fill;
            groupBoxEditName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxEditName.Location = new Point(3, 118);
            groupBoxEditName.Name = "groupBoxEditName";
            groupBoxEditName.Size = new Size(774, 73);
            groupBoxEditName.TabIndex = 4;
            groupBoxEditName.TabStop = false;
            groupBoxEditName.Text = "Name";
            // 
            // txtEditCustomerName
            // 
            txtEditCustomerName.Location = new Point(6, 28);
            txtEditCustomerName.Name = "txtEditCustomerName";
            txtEditCustomerName.Size = new Size(762, 29);
            txtEditCustomerName.TabIndex = 0;
            // 
            // groupBoxEditEmail
            // 
            pnlEditCustomer.SetColumnSpan(groupBoxEditEmail, 5);
            groupBoxEditEmail.Controls.Add(txtEditCustomerEmail);
            groupBoxEditEmail.Dock = DockStyle.Fill;
            groupBoxEditEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxEditEmail.Location = new Point(3, 41);
            groupBoxEditEmail.Name = "groupBoxEditEmail";
            groupBoxEditEmail.Size = new Size(774, 71);
            groupBoxEditEmail.TabIndex = 3;
            groupBoxEditEmail.TabStop = false;
            groupBoxEditEmail.Text = "E-mail";
            // 
            // txtEditCustomerEmail
            // 
            txtEditCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEditCustomerEmail.Location = new Point(6, 28);
            txtEditCustomerEmail.Name = "txtEditCustomerEmail";
            txtEditCustomerEmail.Size = new Size(762, 29);
            txtEditCustomerEmail.TabIndex = 0;
            // 
            // lblEditCustomer
            // 
            lblEditCustomer.AutoSize = true;
            lblEditCustomer.BackColor = Color.FromArgb(0, 53, 123);
            pnlEditCustomer.SetColumnSpan(lblEditCustomer, 5);
            lblEditCustomer.Dock = DockStyle.Fill;
            lblEditCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditCustomer.ForeColor = Color.White;
            lblEditCustomer.Location = new Point(3, 0);
            lblEditCustomer.Name = "lblEditCustomer";
            lblEditCustomer.Size = new Size(774, 38);
            lblEditCustomer.TabIndex = 2;
            lblEditCustomer.Text = "Edit Customer";
            lblEditCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCustomerManagement
            // 
            pnlCustomerManagement.ColumnCount = 3;
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlCustomerManagement.Controls.Add(tabControlMain, 0, 0);
            pnlCustomerManagement.Controls.Add(btnDelete, 1, 2);
            pnlCustomerManagement.Controls.Add(btnSave, 2, 2);
            pnlCustomerManagement.Controls.Add(customersGridView, 0, 1);
            pnlCustomerManagement.Dock = DockStyle.Fill;
            pnlCustomerManagement.Location = new Point(0, 0);
            pnlCustomerManagement.Name = "pnlCustomerManagement";
            pnlCustomerManagement.RowCount = 3;
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlCustomerManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            pnlCustomerManagement.Size = new Size(800, 450);
            pnlCustomerManagement.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(643, 417);
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
            btnSave.Click += BtnSave_Click;
            // 
            // customersGridView
            // 
            customersGridView.AllowUserToAddRows = false;
            customersGridView.AllowUserToDeleteRows = false;
            customersGridView.AllowUserToResizeColumns = false;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnCustomerId, ColumnCustomerName, ColumnCustomerEmail });
            pnlCustomerManagement.SetColumnSpan(customersGridView, 3);
            customersGridView.Dock = DockStyle.Fill;
            customersGridView.Location = new Point(3, 237);
            customersGridView.Name = "customersGridView";
            customersGridView.ReadOnly = true;
            customersGridView.Size = new Size(794, 174);
            customersGridView.TabIndex = 5;
            // 
            // ColumnCustomerId
            // 
            ColumnCustomerId.HeaderText = "ID";
            ColumnCustomerId.Name = "ColumnCustomerId";
            ColumnCustomerId.ReadOnly = true;
            ColumnCustomerId.Resizable = DataGridViewTriState.False;
            ColumnCustomerId.Width = 80;
            // 
            // ColumnCustomerName
            // 
            ColumnCustomerName.HeaderText = "Name";
            ColumnCustomerName.Name = "ColumnCustomerName";
            ColumnCustomerName.ReadOnly = true;
            ColumnCustomerName.Resizable = DataGridViewTriState.False;
            ColumnCustomerName.Width = 270;
            // 
            // ColumnCustomerEmail
            // 
            ColumnCustomerEmail.HeaderText = "E-mail";
            ColumnCustomerEmail.Name = "ColumnCustomerEmail";
            ColumnCustomerEmail.ReadOnly = true;
            ColumnCustomerEmail.Width = 401;
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
            tabControlMain.ResumeLayout(false);
            tbpNewCustomer.ResumeLayout(false);
            pnlCreateCustomer.ResumeLayout(false);
            pnlCreateCustomer.PerformLayout();
            groupboxName.ResumeLayout(false);
            groupboxName.PerformLayout();
            groupboxEmail.ResumeLayout(false);
            groupboxEmail.PerformLayout();
            tbpEditCustomer.ResumeLayout(false);
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            groupBoxEditName.ResumeLayout(false);
            groupBoxEditName.PerformLayout();
            groupBoxEditEmail.ResumeLayout(false);
            groupBoxEditEmail.PerformLayout();
            pnlCustomerManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tbpNewCustomer;
        private TabPage tbpEditCustomer;
        private TableLayoutPanel pnlCustomerManagement;
        private Button btnSave;
        private Button btnDelete;
        private TableLayoutPanel pnlCreateCustomer;
        private GroupBox groupboxName;
        private TextBox txtName;
        private Label lblCreateNewCustomer;
        private GroupBox groupboxEmail;
        private TextBox txtEmail;
        private TableLayoutPanel pnlEditCustomer;
        private GroupBox groupBoxEditName;
        private TextBox txtEditCustomerName;
        private GroupBox groupBoxEditEmail;
        private TextBox txtEditCustomerEmail;
        private Label lblEditCustomer;
        private DataGridView customersGridView;
        private DataGridViewTextBoxColumn ColumnCustomerId;
        private DataGridViewTextBoxColumn ColumnCustomerName;
        private DataGridViewTextBoxColumn ColumnCustomerEmail;
    }
}