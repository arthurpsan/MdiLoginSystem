namespace UserManagementSystem.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 


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
            txtSearchCustomer = new TextBox();
            btnPay = new Button();
            lblTotalWithFine = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSearchCustomer = new Label();
            label1 = new Label();
            dgvReports = new DataGridView();
            purchaseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bdsPayments = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdsPayments).BeginInit();
            SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtSearchCustomer, 2);
            txtSearchCustomer.Location = new Point(3, 258);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(336, 23);
            txtSearchCustomer.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.Dock = DockStyle.Fill;
            btnPay.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(516, 327);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(165, 31);
            btnPay.TabIndex = 3;
            btnPay.Text = "Confirm Payment";
            btnPay.Click += btnPay_Click;
            // 
            // lblTotalWithFine
            // 
            lblTotalWithFine.Location = new Point(0, 0);
            lblTotalWithFine.Name = "lblTotalWithFine";
            lblTotalWithFine.Size = new Size(100, 23);
            lblTotalWithFine.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnPay, 3, 5);
            tableLayoutPanel1.Controls.Add(txtSearchCustomer, 0, 3);
            tableLayoutPanel1.Controls.Add(lblSearchCustomer, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvReports, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(684, 361);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblSearchCustomer, 2);
            lblSearchCustomer.Dock = DockStyle.Fill;
            lblSearchCustomer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchCustomer.Location = new Point(3, 216);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(336, 36);
            lblSearchCustomer.TabIndex = 4;
            lblSearchCustomer.Text = "Search Customer:";
            lblSearchCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 53, 123);
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(678, 36);
            label1.TabIndex = 5;
            label1.Text = "Payment Registry";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { purchaseIdDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(dgvReports, 4);
            dgvReports.DataSource = bdsPayments;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(3, 39);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersVisible = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(678, 174);
            dgvReports.TabIndex = 6;
            // 
            // purchaseIdDataGridViewTextBoxColumn
            // 
            purchaseIdDataGridViewTextBoxColumn.DataPropertyName = "PurchaseId";
            purchaseIdDataGridViewTextBoxColumn.HeaderText = "Purchase #";
            purchaseIdDataGridViewTextBoxColumn.Name = "purchaseIdDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // bdsPayments
            // 
            bdsPayments.DataSource = typeof(Models.ViewModels.PaymentViewModel);
            // 
            // PaymentForm
            // 
            ClientSize = new Size(684, 361);
            Controls.Add(tableLayoutPanel1);
            Name = "PaymentForm";
            Text = "Cashier - Payment Registry";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdsPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalWithFine;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSearchCustomer;
        private Label label1;
        private DataGridView dgvReports;
        private BindingSource bdsPayments;
        private DataGridViewTextBoxColumn purchaseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    }
}