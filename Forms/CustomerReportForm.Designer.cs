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
            lstPurchasesReport = new ListView();
            txtSearchCustomer = new TextBox();
            lblSearchCustomer = new Label();
            lstCustomers = new ListView();
            lblDescription = new Label();
            pnlMainLayout.SuspendLayout();
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
            pnlMainLayout.Controls.Add(lstPurchasesReport, 0, 5);
            pnlMainLayout.Controls.Add(txtSearchCustomer, 0, 2);
            pnlMainLayout.Controls.Add(lblSearchCustomer, 0, 1);
            pnlMainLayout.Controls.Add(lstCustomers, 2, 2);
            pnlMainLayout.Controls.Add(lblDescription, 0, 4);
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
            // lstPurchasesReport
            // 
            lstPurchasesReport.BackColor = Color.LightGray;
            pnlMainLayout.SetColumnSpan(lstPurchasesReport, 4);
            lstPurchasesReport.Dock = DockStyle.Fill;
            lstPurchasesReport.FullRowSelect = true;
            lstPurchasesReport.GridLines = true;
            lstPurchasesReport.Location = new Point(3, 228);
            lstPurchasesReport.Name = "lstPurchasesReport";
            lstPurchasesReport.Size = new Size(794, 219);
            lstPurchasesReport.TabIndex = 0;
            lstPurchasesReport.UseCompatibleStateImageBehavior = false;
            lstPurchasesReport.View = View.Details;
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
            // lstCustomers
            // 
            lstCustomers.BackColor = Color.LightGray;
            pnlMainLayout.SetColumnSpan(lstCustomers, 2);
            lstCustomers.Dock = DockStyle.Fill;
            lstCustomers.FullRowSelect = true;
            lstCustomers.GridLines = true;
            lstCustomers.Location = new Point(403, 93);
            lstCustomers.Name = "lstCustomers";
            pnlMainLayout.SetRowSpan(lstCustomers, 2);
            lstCustomers.Size = new Size(394, 84);
            lstCustomers.TabIndex = 5;
            lstCustomers.UseCompatibleStateImageBehavior = false;
            lstCustomers.View = View.Details;
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
            // CustomerReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMainLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerReportForm";
            ShowIcon = false;
            Text = "PurchasesReport";
            pnlMainLayout.ResumeLayout(false);
            pnlMainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMainLayout;
        private ListView lstPurchasesReport;
        private Label lblTitle;
        private TextBox txtSearchCustomer;
        private Label lblSearchCustomer;
        private Label lblCustomerList;
        private ListView lstCustomers;
        private Label lblDescription;
    }
}