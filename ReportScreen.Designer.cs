namespace UserManagementSystem
{
    partial class ReportScreen
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
            lstReports = new ListBox();
            lblReportsTitle = new Label();
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 1;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlReports.Controls.Add(lstReports, 0, 1);
            pnlReports.Controls.Add(lblReportsTitle, 0, 0);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 2;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 0;
            // 
            // lstReports
            // 
            lstReports.Dock = DockStyle.Fill;
            lstReports.FormattingEnabled = true;
            lstReports.ItemHeight = 15;
            lstReports.Location = new Point(3, 93);
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(794, 354);
            lstReports.TabIndex = 0;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.Dock = DockStyle.Left;
            lblReportsTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsTitle.Location = new Point(3, 0);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(137, 90);
            lblReportsTitle.TabIndex = 1;
            lblReportsTitle.Text = "Reports";
            lblReportsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportScreen";
            ShowIcon = false;
            Text = "System - User Reports";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private ListBox lstReports;
        private Label lblReportsTitle;
    }
}