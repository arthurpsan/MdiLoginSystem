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
            lblReports = new Label();
            btnRefresh = new Button();
            lblTimePeriod = new Label();
            mskDateBegin = new MaskedTextBox();
            mskDateEnd = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 4;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            pnlReports.Controls.Add(lblReports, 0, 0);
            pnlReports.Controls.Add(btnRefresh, 3, 0);
            pnlReports.Controls.Add(lblTimePeriod, 2, 0);
            pnlReports.Controls.Add(mskDateBegin, 2, 1);
            pnlReports.Controls.Add(mskDateEnd, 2, 2);
            pnlReports.Controls.Add(label1, 1, 1);
            pnlReports.Controls.Add(label2, 1, 2);
            pnlReports.Controls.Add(listView1, 0, 3);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 4;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 1;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Dock = DockStyle.Left;
            lblReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(3, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(300, 90);
            lblReports.TabIndex = 1;
            lblReports.Text = "Sales Data Reports";
            lblReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(699, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 84);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimePeriod.Location = new Point(506, 0);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(187, 90);
            lblTimePeriod.TabIndex = 6;
            lblTimePeriod.Text = "Time Period";
            lblTimePeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mskDateBegin
            // 
            mskDateBegin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mskDateBegin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            mskDateBegin.Location = new Point(506, 100);
            mskDateBegin.Name = "mskDateBegin";
            mskDateBegin.Size = new Size(187, 25);
            mskDateBegin.TabIndex = 5;
            // 
            // mskDateEnd
            // 
            mskDateEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mskDateEnd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            mskDateEnd.Location = new Point(506, 145);
            mskDateEnd.Name = "mskDateEnd";
            mskDateEnd.Size = new Size(187, 25);
            mskDateEnd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 90);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 7;
            label1.Text = "Begin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(390, 135);
            label2.Name = "label2";
            label2.Size = new Size(110, 45);
            label2.TabIndex = 8;
            label2.Text = "End";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            pnlReports.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 183);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 264);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SaleReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            Name = "SaleReportScreen";
            Text = "SaleReportScreen";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private Label lblReports;
        private Button btnRefresh;
        private MaskedTextBox mskDateEnd;
        private MaskedTextBox mskDateBegin;
        private Label lblTimePeriod;
        private Label label1;
        private Label label2;
        private ListView listView1;
    }
}