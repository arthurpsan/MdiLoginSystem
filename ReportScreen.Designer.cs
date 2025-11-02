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
            lblReports = new Label();
            lstReports = new ListView();
            columnHeaderGhost = new ColumnHeader();
            columnHeaderId = new ColumnHeader();
            columnHeaderUsername = new ColumnHeader();
            columnHeaderEmail = new ColumnHeader();
            columnHeaderLevel = new ColumnHeader();
            columnHeaderLastAccess = new ColumnHeader();
            btnRefresh = new Button();
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 3;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            pnlReports.Controls.Add(lblReports, 0, 0);
            pnlReports.Controls.Add(lstReports, 0, 1);
            pnlReports.Controls.Add(btnRefresh, 2, 0);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 2;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 0;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Dock = DockStyle.Left;
            lblReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(3, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(292, 90);
            lblReports.TabIndex = 1;
            lblReports.Text = "User Data Reports";
            lblReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstReports
            // 
            lstReports.BackColor = Color.LightGray;
            lstReports.Columns.AddRange(new ColumnHeader[] { columnHeaderGhost, columnHeaderId, columnHeaderUsername, columnHeaderEmail, columnHeaderLevel, columnHeaderLastAccess });
            pnlReports.SetColumnSpan(lstReports, 3);
            lstReports.Dock = DockStyle.Fill;
            lstReports.FullRowSelect = true;
            lstReports.GridLines = true;
            lstReports.LabelWrap = false;
            lstReports.Location = new Point(3, 93);
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(794, 354);
            lstReports.TabIndex = 2;
            lstReports.UseCompatibleStateImageBehavior = false;
            lstReports.View = View.Details;
            // 
            // columnHeaderGhost
            // 
            columnHeaderGhost.Text = "";
            columnHeaderGhost.Width = 0;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.TextAlign = HorizontalAlignment.Center;
            columnHeaderId.Width = 100;
            // 
            // columnHeaderUsername
            // 
            columnHeaderUsername.Text = "Username";
            columnHeaderUsername.TextAlign = HorizontalAlignment.Center;
            columnHeaderUsername.Width = 200;
            // 
            // columnHeaderEmail
            // 
            columnHeaderEmail.Text = "E-mail";
            columnHeaderEmail.TextAlign = HorizontalAlignment.Center;
            columnHeaderEmail.Width = 300;
            // 
            // columnHeaderLevel
            // 
            columnHeaderLevel.Text = "Level";
            columnHeaderLevel.TextAlign = HorizontalAlignment.Center;
            columnHeaderLevel.Width = 90;
            // 
            // columnHeaderLastAccess
            // 
            columnHeaderLastAccess.Text = "Last Access";
            columnHeaderLastAccess.TextAlign = HorizontalAlignment.Center;
            columnHeaderLastAccess.Width = 100;
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
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportScreen";
            ShowIcon = false;
            Text = "System - User Reports";
            Load += ReportScreen_Load;
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private Label lblReports;
        private ListView lstReports;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderEmail;
        private ColumnHeader columnHeaderLevel;
        private Button btnRefresh;
        private ColumnHeader columnHeaderLastAccess;
        private ColumnHeader columnHeaderGhost;
    }
}