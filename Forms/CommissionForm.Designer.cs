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
            lblTitle = new Label();
            pnlReports = new TableLayoutPanel();
            lstReports = new ListView();
            columnHeaderGhost = new ColumnHeader();
            columnHeaderSalespersonId = new ColumnHeader();
            columnHeaderPurchaseId = new ColumnHeader();
            columnHeaderComission = new ColumnHeader();
            columnHeaderSalesperson = new ColumnHeader();
            lblSalesperson = new Label();
            lblPeriod = new Label();
            cboSalesperson = new ComboBox();
            dtpFinalDate = new DateTimePicker();
            dtpInitialDate = new DateTimePicker();
            btnRefresh = new Button();
            lblTotalComission = new Label();
            pnlReports.SuspendLayout();
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
            pnlReports.Controls.Add(lstReports, 0, 1);
            pnlReports.Controls.Add(lblTitle, 0, 0);
            pnlReports.Controls.Add(lblSalesperson, 0, 3);
            pnlReports.Controls.Add(lblPeriod, 2, 3);
            pnlReports.Controls.Add(cboSalesperson, 0, 4);
            pnlReports.Controls.Add(dtpFinalDate, 3, 4);
            pnlReports.Controls.Add(dtpInitialDate, 2, 4);
            pnlReports.Controls.Add(btnRefresh, 2, 5);
            pnlReports.Controls.Add(lblTotalComission, 0, 5);
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
            // lstReports
            // 
            lstReports.BackColor = Color.LightGray;
            lstReports.Columns.AddRange(new ColumnHeader[] { columnHeaderGhost, columnHeaderSalespersonId, columnHeaderPurchaseId, columnHeaderComission, columnHeaderSalesperson });
            pnlReports.SetColumnSpan(lstReports, 4);
            lstReports.Dock = DockStyle.Fill;
            lstReports.FullRowSelect = true;
            lstReports.GridLines = true;
            lstReports.LabelWrap = false;
            lstReports.Location = new Point(3, 48);
            lstReports.Name = "lstReports";
            pnlReports.SetRowSpan(lstReports, 2);
            lstReports.Size = new Size(794, 264);
            lstReports.TabIndex = 18;
            lstReports.UseCompatibleStateImageBehavior = false;
            lstReports.View = View.Details;
            // 
            // columnHeaderGhost
            // 
            columnHeaderGhost.Text = "";
            columnHeaderGhost.Width = 0;
            // 
            // columnHeaderSalespersonId
            // 
            columnHeaderSalespersonId.Text = "Salesperson ID";
            columnHeaderSalespersonId.TextAlign = HorizontalAlignment.Center;
            columnHeaderSalespersonId.Width = 100;
            // 
            // columnHeaderPurchaseId
            // 
            columnHeaderPurchaseId.Text = "Purchase Number";
            columnHeaderPurchaseId.TextAlign = HorizontalAlignment.Center;
            columnHeaderPurchaseId.Width = 296;
            // 
            // columnHeaderComission
            // 
            columnHeaderComission.Text = "Comission";
            columnHeaderComission.TextAlign = HorizontalAlignment.Center;
            columnHeaderComission.Width = 200;
            // 
            // columnHeaderSalesperson
            // 
            columnHeaderSalesperson.Text = "Salesperson Name";
            columnHeaderSalesperson.TextAlign = HorizontalAlignment.Center;
            columnHeaderSalesperson.Width = 194;
            // 
            // lblSalesperson
            // 
            lblSalesperson.AutoSize = true;
            lblSalesperson.Dock = DockStyle.Fill;
            lblSalesperson.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesperson.Location = new Point(3, 315);
            lblSalesperson.Name = "lblSalesperson";
            lblSalesperson.Size = new Size(194, 45);
            lblSalesperson.TabIndex = 17;
            lblSalesperson.Text = "Salesperson:";
            lblSalesperson.TextAlign = ContentAlignment.MiddleLeft;
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
            // cboSalesperson
            // 
            cboSalesperson.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlReports.SetColumnSpan(cboSalesperson, 2);
            cboSalesperson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSalesperson.FormattingEnabled = true;
            cboSalesperson.Location = new Point(3, 368);
            cboSalesperson.Name = "cboSalesperson";
            cboSalesperson.Size = new Size(394, 29);
            cboSalesperson.TabIndex = 16;
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
            // btnRefresh
            // 
            pnlReports.SetColumnSpan(btnRefresh, 2);
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(403, 408);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(394, 39);
            btnRefresh.TabIndex = 22;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTotalComission
            // 
            lblTotalComission.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalComission.AutoSize = true;
            pnlReports.SetColumnSpan(lblTotalComission, 2);
            lblTotalComission.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalComission.Location = new Point(3, 417);
            lblTotalComission.Name = "lblTotalComission";
            lblTotalComission.Size = new Size(394, 21);
            lblTotalComission.TabIndex = 23;
            lblTotalComission.Text = "Total Comission: R$ 0,00";
            lblTotalComission.TextAlign = ContentAlignment.MiddleRight;
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel pnlReports;
        private ComboBox cboSalesperson;
        private Label lblSalesperson;
        private ListView lstReports;
        private ColumnHeader columnHeaderGhost;
        private ColumnHeader columnHeaderSalespersonId;
        private ColumnHeader columnHeaderPurchaseId;
        private ColumnHeader columnHeaderComission;
        private ColumnHeader columnHeaderSalesperson;
        private Label lblPeriod;
        private DateTimePicker dtpInitialDate;
        private DateTimePicker dtpFinalDate;
        private Button btnRefresh;
        private Label lblTotalComission;
    }
}