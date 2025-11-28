namespace UserManagementSystem.Forms
{
    partial class CommissionForm
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
            lblTitle = new Label();
            pnlReports = new TableLayoutPanel();
            lblSearch = new Label();
            lblPeriod = new Label();
            dtpFinalDate = new DateTimePicker();
            dtpInitialDate = new DateTimePicker();
            lblTotalComission = new Label();
            dgvCommissions = new DataGridView();
            sellerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purchaseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bdsCommissions = new BindingSource(components);
            txtSearch = new TextBox();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdsCommissions).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(0, 53, 123);
            pnlReports.SetColumnSpan(lblTitle, 4);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(794, 45);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Commission Analytics";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 4;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.Controls.Add(lblTitle, 0, 0);
            pnlReports.Controls.Add(lblSearch, 0, 3);
            pnlReports.Controls.Add(lblPeriod, 2, 3);
            pnlReports.Controls.Add(dtpFinalDate, 3, 4);
            pnlReports.Controls.Add(dtpInitialDate, 2, 4);
            pnlReports.Controls.Add(lblTotalComission, 2, 5);
            pnlReports.Controls.Add(dgvCommissions, 0, 1);
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
            pnlReports.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            pnlReports.SetColumnSpan(lblSearch, 2);
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(3, 315);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(394, 45);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search for Seller:";
            lblSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            pnlReports.SetColumnSpan(lblPeriod, 2);
            lblPeriod.Dock = DockStyle.Fill;
            lblPeriod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeriod.Location = new Point(403, 315);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(394, 45);
            lblPeriod.TabIndex = 19;
            lblPeriod.Text = "Timeframe:";
            lblPeriod.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFinalDate
            // 
            dtpFinalDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFinalDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFinalDate.Font = new Font("Segoe UI", 12F);
            dtpFinalDate.Location = new Point(603, 368);
            dtpFinalDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFinalDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFinalDate.Name = "dtpFinalDate";
            dtpFinalDate.Size = new Size(194, 29);
            dtpFinalDate.TabIndex = 21;
            // 
            // dtpInitialDate
            // 
            dtpInitialDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpInitialDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInitialDate.Font = new Font("Segoe UI", 12F);
            dtpInitialDate.Location = new Point(403, 368);
            dtpInitialDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpInitialDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpInitialDate.Name = "dtpInitialDate";
            dtpInitialDate.Size = new Size(194, 29);
            dtpInitialDate.TabIndex = 20;
            // 
            // lblTotalComission
            // 
            lblTotalComission.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalComission.AutoSize = true;
            pnlReports.SetColumnSpan(lblTotalComission, 2);
            lblTotalComission.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalComission.Location = new Point(403, 417);
            lblTotalComission.Name = "lblTotalComission";
            lblTotalComission.Size = new Size(394, 21);
            lblTotalComission.TabIndex = 23;
            lblTotalComission.Text = "Total Comission: R$ 0,00";
            lblTotalComission.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvCommissions
            // 
            dgvCommissions.AllowUserToAddRows = false;
            dgvCommissions.AllowUserToResizeColumns = false;
            dgvCommissions.AllowUserToResizeRows = false;
            dgvCommissions.AutoGenerateColumns = false;
            dgvCommissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommissions.Columns.AddRange(new DataGridViewColumn[] { sellerNameDataGridViewTextBoxColumn, purchaseIdDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, commissionDataGridViewTextBoxColumn });
            pnlReports.SetColumnSpan(dgvCommissions, 4);
            dgvCommissions.DataSource = bdsCommissions;
            dgvCommissions.Dock = DockStyle.Fill;
            dgvCommissions.Location = new Point(3, 48);
            dgvCommissions.Name = "dgvCommissions";
            dgvCommissions.ReadOnly = true;
            dgvCommissions.RowHeadersVisible = false;
            pnlReports.SetRowSpan(dgvCommissions, 2);
            dgvCommissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommissions.Size = new Size(794, 264);
            dgvCommissions.TabIndex = 24;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            sellerNameDataGridViewTextBoxColumn.HeaderText = "Seller Name";
            sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseIdDataGridViewTextBoxColumn
            // 
            purchaseIdDataGridViewTextBoxColumn.DataPropertyName = "PurchaseId";
            purchaseIdDataGridViewTextBoxColumn.HeaderText = "Purchase #";
            purchaseIdDataGridViewTextBoxColumn.Name = "purchaseIdDataGridViewTextBoxColumn";
            purchaseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commissionDataGridViewTextBoxColumn
            // 
            commissionDataGridViewTextBoxColumn.DataPropertyName = "Commission";
            commissionDataGridViewTextBoxColumn.HeaderText = "Commission";
            commissionDataGridViewTextBoxColumn.Name = "commissionDataGridViewTextBoxColumn";
            commissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsCommissions
            // 
            bdsCommissions.DataSource = typeof(Models.ViewModels.CommissionViewModel);
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlReports.SetColumnSpan(txtSearch, 2);
            txtSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 371);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 22);
            txtSearch.TabIndex = 25;
            // 
            // CommissionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CommissionForm";
            ShowIcon = false;
            Text = "Comission Analytics";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdsCommissions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel pnlReports;
        private Label lblSearch;
        private Label lblPeriod;
        private DateTimePicker dtpInitialDate;
        private DateTimePicker dtpFinalDate;
        private Label lblTotalComission;
        private DataGridView dgvCommissions;
        private BindingSource bdsCommissions;
        private DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commissionDataGridViewTextBoxColumn;
        private TextBox txtSearch;
    }
}