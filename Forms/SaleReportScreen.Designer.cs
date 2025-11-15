namespace UserManagementSystem.Forms
{
    partial class SaleReportScreen
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
            pnlReports = new TableLayoutPanel();
            lblSalesReports = new Label();
            btnRefresh = new Button();
            lstReports = new ListView();
            columnHeaderGhost = new ColumnHeader();
            columnHeaderId = new ColumnHeader();
            columnHeaderPeriod = new ColumnHeader();
            columnHeaderSales = new ColumnHeader();
            columnHeaderSeller = new ColumnHeader();
            lblTimePeriod = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 4;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlReports.Controls.Add(lblSalesReports, 0, 1);
            pnlReports.Controls.Add(btnRefresh, 3, 5);
            pnlReports.Controls.Add(lstReports, 0, 3);
            pnlReports.Controls.Add(lblTimePeriod, 2, 0);
            pnlReports.Controls.Add(label2, 1, 2);
            pnlReports.Controls.Add(label1, 1, 1);
            pnlReports.Controls.Add(label3, 0, 5);
            pnlReports.Controls.Add(dtpStartDate, 2, 1);
            pnlReports.Controls.Add(dtpEndDate, 2, 2);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 6;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 1;
            pnlReports.Paint += pnlReports_Paint;
            // 
            // lblSalesReports
            // 
            lblSalesReports.AutoSize = true;
            lblSalesReports.Dock = DockStyle.Fill;
            lblSalesReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesReports.Location = new Point(3, 40);
            lblSalesReports.Name = "lblSalesReports";
            lblSalesReports.Size = new Size(474, 40);
            lblSalesReports.TabIndex = 1;
            lblSalesReports.Text = "Sales Data Reports";
            lblSalesReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(683, 408);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 39);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lstReports
            // 
            lstReports.BackColor = Color.LightGray;
            lstReports.Columns.AddRange(new ColumnHeader[] { columnHeaderGhost, columnHeaderId, columnHeaderPeriod, columnHeaderSales, columnHeaderSeller });
            pnlReports.SetColumnSpan(lstReports, 4);
            lstReports.Dock = DockStyle.Fill;
            lstReports.FullRowSelect = true;
            lstReports.GridLines = true;
            lstReports.LabelWrap = false;
            lstReports.Location = new Point(3, 123);
            lstReports.Name = "lstReports";
            pnlReports.SetRowSpan(lstReports, 2);
            lstReports.Size = new Size(794, 279);
            lstReports.TabIndex = 12;
            lstReports.UseCompatibleStateImageBehavior = false;
            lstReports.View = View.Details;
            lstReports.SelectedIndexChanged += lstReports_SelectedIndexChanged;
            // 
            // columnHeaderGhost
            // 
            columnHeaderGhost.Text = "";
            columnHeaderGhost.Width = 0;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "Sale ID";
            columnHeaderId.TextAlign = HorizontalAlignment.Center;
            columnHeaderId.Width = 80;
            // 
            // columnHeaderPeriod
            // 
            columnHeaderPeriod.Text = "Period";
            columnHeaderPeriod.TextAlign = HorizontalAlignment.Center;
            columnHeaderPeriod.Width = 180;
            // 
            // columnHeaderSales
            // 
            columnHeaderSales.Text = "Sale";
            columnHeaderSales.TextAlign = HorizontalAlignment.Center;
            columnHeaderSales.Width = 295;
            // 
            // columnHeaderSeller
            // 
            columnHeaderSeller.Text = "Seller";
            columnHeaderSeller.TextAlign = HorizontalAlignment.Center;
            columnHeaderSeller.Width = 235;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            pnlReports.SetColumnSpan(lblTimePeriod, 2);
            lblTimePeriod.Dock = DockStyle.Fill;
            lblTimePeriod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimePeriod.Location = new Point(563, 0);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(234, 40);
            lblTimePeriod.TabIndex = 6;
            lblTimePeriod.Text = "Time Period";
            lblTimePeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(483, 80);
            label2.Name = "label2";
            label2.Size = new Size(74, 40);
            label2.TabIndex = 8;
            label2.Text = "End";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 40);
            label1.Name = "label1";
            label1.Size = new Size(74, 40);
            label1.TabIndex = 7;
            label1.Text = "Begin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 417);
            label3.Name = "label3";
            label3.Size = new Size(474, 21);
            label3.TabIndex = 14;
            label3.Text = "Total sales:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlReports.SetColumnSpan(dtpStartDate, 2);
            dtpStartDate.Location = new Point(563, 48);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(234, 23);
            dtpStartDate.TabIndex = 5;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpEndDate.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlReports.SetColumnSpan(dtpEndDate, 2);
            dtpEndDate.Location = new Point(563, 88);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(234, 23);
            dtpEndDate.TabIndex = 11;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            // 
            // SaleReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            MaximizeBox = false;
            Name = "SaleReportScreen";
            ShowIcon = false;
            Text = "SaleReportScreen";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private Label lblSalesReports;
        private Label lblTimePeriod;
        private Label label1;
        private Label label2;
        private ListView lstReports;
        private ColumnHeader columnHeaderGhost;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderPeriod;
        private ColumnHeader columnHeaderSales;
        private ColumnHeader columnHeaderSeller;
        private Button btnRefresh;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
    }
}