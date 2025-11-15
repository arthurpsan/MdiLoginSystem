namespace UserManagementSystem
{
    partial class UserReportScreen
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
            columnHeaderNickname = new ColumnHeader();
            columnHeaderEmail = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            columnHeaderLevel = new ColumnHeader();
            columnHeaderLastAccess = new ColumnHeader();
            btnRefresh = new Button();
            pnlReports.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 3;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlReports.Controls.Add(lblReports, 0, 0);
            pnlReports.Controls.Add(lstReports, 0, 2);
            pnlReports.Controls.Add(btnRefresh, 2, 3);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 4;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 0;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            pnlReports.SetColumnSpan(lblReports, 2);
            lblReports.Dock = DockStyle.Fill;
            lblReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(3, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(526, 45);
            lblReports.TabIndex = 1;
            lblReports.Text = "General Employee Dashboard";
            // 
            // lstReports
            // 
            lstReports.BackColor = Color.LightGray;
            lstReports.CheckBoxes = true;
            lstReports.Columns.AddRange(new ColumnHeader[] { columnHeaderGhost, columnHeaderId, columnHeaderUsername, columnHeaderNickname, columnHeaderEmail, columnHeaderPhone, columnHeaderLevel, columnHeaderLastAccess });
            pnlReports.SetColumnSpan(lstReports, 3);
            lstReports.Dock = DockStyle.Fill;
            lstReports.FullRowSelect = true;
            lstReports.GridLines = true;
            lstReports.LabelWrap = false;
            lstReports.Location = new Point(3, 93);
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(794, 309);
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
            // columnHeaderNickname
            // 
            columnHeaderNickname.Text = "Nickname";
            columnHeaderNickname.TextAlign = HorizontalAlignment.Center;
            columnHeaderNickname.Width = 100;
            // 
            // columnHeaderEmail
            // 
            columnHeaderEmail.Text = "E-mail";
            columnHeaderEmail.TextAlign = HorizontalAlignment.Center;
            columnHeaderEmail.Width = 300;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Phone";
            columnHeaderPhone.TextAlign = HorizontalAlignment.Center;
            columnHeaderPhone.Width = 100;
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
            columnHeaderLastAccess.Width = 160;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(535, 408);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(262, 39);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserReportScreen";
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
        private ColumnHeader columnHeaderNickname;
        private ColumnHeader columnHeaderPhone;
    }
}