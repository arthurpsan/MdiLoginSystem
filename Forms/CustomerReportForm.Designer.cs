namespace UserManagementSystem.Forms
{
    partial class CustomerReportForm
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
            pnlMainLayout = new TableLayoutPanel();
            lblCustomerList = new Label();
            lblTitle = new Label();
            txtSearchCustomer = new TextBox();
            lblSearchCustomer = new Label();
            lblDescription = new Label();
            chkShowDelinquents = new CheckBox();
            dgvCustomers = new DataGridView();
            dgvPurchases = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            colSeller = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            pnlMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).BeginInit();
            SuspendLayout();
            // 
            // pnlMainLayout
            // 
            pnlMainLayout.ColumnCount = 4;
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlMainLayout.Controls.Add(lblCustomerList, 2, 1);
            pnlMainLayout.Controls.Add(lblTitle, 0, 0);
            pnlMainLayout.Controls.Add(txtSearchCustomer, 0, 2);
            pnlMainLayout.Controls.Add(lblSearchCustomer, 0, 1);
            pnlMainLayout.Controls.Add(lblDescription, 0, 4);
            pnlMainLayout.Controls.Add(chkShowDelinquents, 1, 3);
            pnlMainLayout.Controls.Add(dgvCustomers, 2, 2);
            pnlMainLayout.Controls.Add(dgvPurchases, 0, 5);
            pnlMainLayout.Dock = DockStyle.Fill;
            pnlMainLayout.Location = new Point(0, 0);
            pnlMainLayout.Name = "pnlMainLayout";
            pnlMainLayout.RowCount = 6;
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlMainLayout.Size = new Size(800, 450);
            pnlMainLayout.TabIndex = 0;
            // 
            // lblCustomerList
            // 
            lblCustomerList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerList.AutoSize = true;
            pnlMainLayout.SetColumnSpan(lblCustomerList, 2);
            lblCustomerList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerList.Location = new Point(403, 57);
            lblCustomerList.Name = "lblCustomerList";
            lblCustomerList.Size = new Size(394, 21);
            lblCustomerList.TabIndex = 6;
            lblCustomerList.Text = "Customer List";
            lblCustomerList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(0, 53, 123);
            pnlMainLayout.SetColumnSpan(lblTitle, 4);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(794, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Customer Data Reports";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlMainLayout.SetColumnSpan(txtSearchCustomer, 2);
            txtSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCustomer.Location = new Point(3, 98);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(394, 29);
            txtSearchCustomer.TabIndex = 3;
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSearchCustomer.AutoSize = true;
            pnlMainLayout.SetColumnSpan(lblSearchCustomer, 2);
            lblSearchCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchCustomer.Location = new Point(3, 57);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(394, 21);
            lblSearchCustomer.TabIndex = 4;
            lblSearchCustomer.Text = "Search by Customer:";
            lblSearchCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            pnlMainLayout.SetColumnSpan(lblDescription, 2);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(3, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(394, 45);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "(Exhibits client data for the last 30 days.)";
            lblDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // chkShowDelinquents
            // 
            chkShowDelinquents.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkShowDelinquents.AutoSize = true;
            chkShowDelinquents.CheckAlign = ContentAlignment.TopRight;
            chkShowDelinquents.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowDelinquents.Location = new Point(203, 149);
            chkShowDelinquents.Name = "chkShowDelinquents";
            chkShowDelinquents.Size = new Size(194, 17);
            chkShowDelinquents.TabIndex = 8;
            chkShowDelinquents.Text = "Show delinquents only";
            chkShowDelinquents.TextAlign = ContentAlignment.MiddleRight;
            chkShowDelinquents.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Name, Email });
            pnlMainLayout.SetColumnSpan(dgvCustomers, 2);
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(403, 93);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            pnlMainLayout.SetRowSpan(dgvCustomers, 2);
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(394, 84);
            dgvCustomers.TabIndex = 9;
            // 
            // dgvPurchases
            // 
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchases.Columns.AddRange(new DataGridViewColumn[] { Date, colSeller, colTotal });
            pnlMainLayout.SetColumnSpan(dgvPurchases, 4);
            dgvPurchases.Dock = DockStyle.Fill;
            dgvPurchases.Location = new Point(3, 228);
            dgvPurchases.Name = "dgvPurchases";
            dgvPurchases.Size = new Size(794, 219);
            dgvPurchases.TabIndex = 10;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 126;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 225;
            // 
            // Date
            // 
            Date.DataPropertyName = "Implementation";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 190;
            // 
            // colSeller
            // 
            colSeller.HeaderText = "Seller";
            colSeller.Name = "colSeller";
            colSeller.ReadOnly = true;
            colSeller.Width = 380;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 181;
            // 
            // CustomerReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMainLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ShowIcon = false;
            Text = "Customers Report";
            pnlMainLayout.ResumeLayout(false);
            pnlMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMainLayout;
        private Label lblTitle;
        private TextBox txtSearchCustomer;
        private Label lblSearchCustomer;
        private Label lblCustomerList;
        private Label lblDescription;
        private CheckBox chkShowDelinquents;
        private DataGridView dgvCustomers;
        private DataGridView dgvPurchases;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn colSeller;
        private DataGridViewTextBoxColumn colTotal;
    }
}