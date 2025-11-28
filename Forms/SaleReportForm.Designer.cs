namespace UserManagementSystem.Forms
{
    partial class SaleReportForm
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
            pnlReports = new TableLayoutPanel();
            lblEnd = new Label();
            dtpEndDate = new DateTimePicker();
            lblSalesReports = new Label();
            lblTimePeriod = new Label();
            lblBegin = new Label();
            lblTotalSales = new Label();
            dtpStartDate = new DateTimePicker();
            dgvSales = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bdsSales = new BindingSource(components);
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdsSales).BeginInit();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 4;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlReports.Controls.Add(lblEnd, 1, 5);
            pnlReports.Controls.Add(dtpEndDate, 2, 5);
            pnlReports.Controls.Add(lblSalesReports, 0, 0);
            pnlReports.Controls.Add(lblTimePeriod, 1, 3);
            pnlReports.Controls.Add(lblBegin, 1, 4);
            pnlReports.Controls.Add(lblTotalSales, 0, 5);
            pnlReports.Controls.Add(dtpStartDate, 2, 4);
            pnlReports.Controls.Add(dgvSales, 0, 1);
            pnlReports.Controls.Add(lblSearch, 0, 3);
            pnlReports.Controls.Add(txtSearch, 0, 4);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 6;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 1;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Dock = DockStyle.Fill;
            lblEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnd.Location = new Point(483, 405);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(74, 45);
            lblEnd.TabIndex = 16;
            lblEnd.Text = "End";
            lblEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpEndDate.CalendarFont = new Font("Segoe UI", 9.75F);
            pnlReports.SetColumnSpan(dtpEndDate, 2);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(563, 416);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(234, 23);
            dtpEndDate.TabIndex = 15;
            // 
            // lblSalesReports
            // 
            lblSalesReports.AutoSize = true;
            lblSalesReports.BackColor = Color.FromArgb(0, 53, 123);
            pnlReports.SetColumnSpan(lblSalesReports, 4);
            lblSalesReports.Dock = DockStyle.Fill;
            lblSalesReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesReports.ForeColor = Color.White;
            lblSalesReports.Location = new Point(3, 0);
            lblSalesReports.Name = "lblSalesReports";
            lblSalesReports.Size = new Size(794, 45);
            lblSalesReports.TabIndex = 1;
            lblSalesReports.Text = "Sales Data Reports";
            lblSalesReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            pnlReports.SetColumnSpan(lblTimePeriod, 3);
            lblTimePeriod.Dock = DockStyle.Fill;
            lblTimePeriod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimePeriod.Location = new Point(483, 315);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(314, 45);
            lblTimePeriod.TabIndex = 6;
            lblTimePeriod.Text = "Time Period";
            lblTimePeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBegin
            // 
            lblBegin.AutoSize = true;
            lblBegin.Dock = DockStyle.Fill;
            lblBegin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBegin.Location = new Point(483, 360);
            lblBegin.Name = "lblBegin";
            lblBegin.Size = new Size(74, 45);
            lblBegin.TabIndex = 7;
            lblBegin.Text = "Begin";
            lblBegin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(3, 417);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(474, 21);
            lblTotalSales.TabIndex = 14;
            lblTotalSales.Text = "Total sales:";
            lblTotalSales.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.CalendarFont = new Font("Segoe UI", 9.75F);
            pnlReports.SetColumnSpan(dtpStartDate, 2);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(563, 371);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(234, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AutoGenerateColumns = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, sellerNameDataGridViewTextBoxColumn, totalValueDataGridViewTextBoxColumn });
            pnlReports.SetColumnSpan(dgvSales, 4);
            dgvSales.DataSource = bdsSales;
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(3, 48);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersVisible = false;
            pnlReports.SetRowSpan(dgvSales, 2);
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(794, 264);
            dgvSales.TabIndex = 17;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            sellerNameDataGridViewTextBoxColumn.HeaderText = "Seller";
            sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue";
            totalValueDataGridViewTextBoxColumn.HeaderText = "Total Value";
            totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsSales
            // 
            bdsSales.DataSource = typeof(Models.ViewModels.SaleReportViewModel);
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(3, 315);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(474, 45);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Search:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 371);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(474, 22);
            txtSearch.TabIndex = 19;
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaleReportForm";
            ShowIcon = false;
            Text = "Sale Reports";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdsSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private Label lblSalesReports;
        private Label lblTimePeriod;
        private Label lblBegin;
        private Label lblTotalSales;
        private DateTimePicker dtpStartDate;
        private Label lblEnd;
        private DateTimePicker dtpEndDate;
        private DataGridView dgvSales;
        private BindingSource bdsSales;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
    }
}