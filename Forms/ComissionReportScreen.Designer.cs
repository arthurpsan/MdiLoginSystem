namespace UserManagementSystem.Forms
{
    partial class ComissionReportScreen
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
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            pnlReports.SetColumnSpan(lblTitle, 4);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            pnlReports.Controls.Add(lstReports, 0, 2);
            pnlReports.Controls.Add(lblTitle, 0, 0);
            pnlReports.Controls.Add(lblSalesperson, 0, 4);
            pnlReports.Controls.Add(lblPeriod, 2, 4);
            pnlReports.Controls.Add(cboSalesperson, 0, 5);
            pnlReports.Controls.Add(dtpFinalDate, 3, 5);
            pnlReports.Controls.Add(dtpInitialDate, 2, 5);
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
            lstReports.Location = new Point(3, 93);
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(794, 219);
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
            lblSalesperson.Location = new Point(3, 360);
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
            lblPeriod.Location = new Point(403, 360);
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
            cboSalesperson.Location = new Point(3, 413);
            cboSalesperson.Name = "cboSalesperson";
            cboSalesperson.Size = new Size(394, 29);
            cboSalesperson.TabIndex = 16;
            // 
            // dtpFinalDate
            // 
            dtpFinalDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFinalDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFinalDate.Font = new Font("Segoe UI", 12F);
            dtpFinalDate.Location = new Point(603, 413);
            dtpFinalDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFinalDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFinalDate.Name = "dtpFinalDate";
            dtpFinalDate.Size = new Size(194, 29);
            dtpFinalDate.TabIndex = 21;
            dtpFinalDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dtpInitialDate
            // 
            dtpInitialDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpInitialDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInitialDate.Font = new Font("Segoe UI", 12F);
            dtpInitialDate.Location = new Point(403, 413);
            dtpInitialDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpInitialDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpInitialDate.Name = "dtpInitialDate";
            dtpInitialDate.Size = new Size(194, 29);
            dtpInitialDate.TabIndex = 20;
            // 
            // ComissionReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            MaximizeBox = false;
            Name = "ComissionReportScreen";
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
    }
}