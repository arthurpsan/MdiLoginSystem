namespace UserManagementSystem.Forms
{
    partial class DashboardForm
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
            lblDashboard = new Label();
            txtSearch = new TextBox();
            lblReports = new Label();
            dgvReports = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nicknameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastAccessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bdsReports = new BindingSource(components);
            lblSearch = new Label();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdsReports).BeginInit();
            SuspendLayout();
            // 
            // pnlReports
            // 
            pnlReports.ColumnCount = 4;
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlReports.Controls.Add(lblDashboard, 0, 0);
            pnlReports.Controls.Add(txtSearch, 2, 2);
            pnlReports.Controls.Add(lblReports, 0, 5);
            pnlReports.Controls.Add(dgvReports, 0, 1);
            pnlReports.Controls.Add(lblSearch, 0, 2);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(0, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.RowCount = 6;
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlReports.Size = new Size(800, 450);
            pnlReports.TabIndex = 0;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.BackColor = Color.FromArgb(0, 53, 123);
            pnlReports.SetColumnSpan(lblDashboard, 4);
            lblDashboard.Dock = DockStyle.Fill;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(3, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.RightToLeft = RightToLeft.No;
            lblDashboard.Size = new Size(794, 45);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Employee Dashboard";
            lblDashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlReports.SetColumnSpan(txtSearch, 2);
            txtSearch.Location = new Point(403, 281);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Dock = DockStyle.Fill;
            lblReports.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(3, 405);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(194, 45);
            lblReports.TabIndex = 2;
            lblReports.Text = "Reports";
            lblReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, nicknameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, lastAccessDataGridViewTextBoxColumn });
            pnlReports.SetColumnSpan(dgvReports, 4);
            dgvReports.DataSource = bdsReports;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(3, 48);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersVisible = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(794, 219);
            dgvReports.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            nicknameDataGridViewTextBoxColumn.HeaderText = "Username / Nick";
            nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email Address";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastAccessDataGridViewTextBoxColumn
            // 
            lastAccessDataGridViewTextBoxColumn.DataPropertyName = "LastAccess";
            lastAccessDataGridViewTextBoxColumn.HeaderText = "Last Access";
            lastAccessDataGridViewTextBoxColumn.Name = "lastAccessDataGridViewTextBoxColumn";
            lastAccessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsReports
            // 
            bdsReports.DataSource = typeof(Models.ViewModels.UserViewModel);
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            pnlReports.SetColumnSpan(lblSearch, 2);
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(3, 270);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(394, 45);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search Employee:";
            lblSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReports);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            ShowIcon = false;
            Text = "DashboardForm";
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdsReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlReports;
        private Label lblDashboard;
        private TextBox txtSearch;
        private Label lblReports;
        private DataGridView dgvReports;
        private Label lblSearch;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastAccessDataGridViewTextBoxColumn;
        private BindingSource bdsReports;
    }
}