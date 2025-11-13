namespace UserManagementSystem
{
    partial class AboutScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pnlAbout = new TableLayoutPanel();
            pctLogo = new PictureBox();
            lblProductName = new Label();
            lblProductVersion = new Label();
            lblDevteam = new Label();
            lblProductLicense = new Label();
            lblProductOrg = new Label();
            lblDevteamProfessor = new Label();
            pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlAbout
            // 
            pnlAbout.ColumnCount = 2;
            pnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            pnlAbout.Controls.Add(pctLogo, 0, 0);
            pnlAbout.Controls.Add(lblProductName, 1, 0);
            pnlAbout.Controls.Add(lblProductVersion, 1, 1);
            pnlAbout.Controls.Add(lblDevteam, 1, 2);
            pnlAbout.Controls.Add(lblProductLicense, 1, 3);
            pnlAbout.Controls.Add(lblProductOrg, 0, 2);
            pnlAbout.Controls.Add(lblDevteamProfessor, 0, 3);
            pnlAbout.Dock = DockStyle.Fill;
            pnlAbout.Location = new Point(10, 10);
            pnlAbout.Margin = new Padding(4, 3, 4, 3);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.RowCount = 4;
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlAbout.Size = new Size(487, 307);
            pnlAbout.TabIndex = 0;
            // 
            // pctLogo
            // 
            pctLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctLogo.BackgroundImageLayout = ImageLayout.None;
            pctLogo.Image = UserManagementSystem.Properties.Resources.montes_claros_vertical_verde_jpg;
            pctLogo.Location = new Point(3, 3);
            pctLogo.Name = "pctLogo";
            pnlAbout.SetRowSpan(pctLogo, 2);
            pctLogo.Size = new Size(140, 146);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 26;
            pctLogo.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(149, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(335, 76);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "User Management System";
            lblProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductVersion
            // 
            lblProductVersion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductVersion.AutoSize = true;
            lblProductVersion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductVersion.Location = new Point(149, 76);
            lblProductVersion.Name = "lblProductVersion";
            lblProductVersion.Size = new Size(335, 76);
            lblProductVersion.TabIndex = 28;
            lblProductVersion.Text = "Version 0.0.1";
            lblProductVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDevteam
            // 
            lblDevteam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDevteam.AutoSize = true;
            lblDevteam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevteam.Location = new Point(149, 152);
            lblDevteam.Name = "lblDevteam";
            lblDevteam.Size = new Size(335, 76);
            lblDevteam.TabIndex = 29;
            lblDevteam.Text = "By: Arthur Santos, Maria Luisa";
            lblDevteam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductLicense
            // 
            lblProductLicense.AutoSize = true;
            lblProductLicense.Dock = DockStyle.Fill;
            lblProductLicense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductLicense.Location = new Point(149, 228);
            lblProductLicense.Name = "lblProductLicense";
            lblProductLicense.Size = new Size(335, 79);
            lblProductLicense.TabIndex = 30;
            lblProductLicense.Text = "Creative Commons (CC) License";
            lblProductLicense.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductOrg
            // 
            lblProductOrg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductOrg.AutoSize = true;
            lblProductOrg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductOrg.Location = new Point(3, 152);
            lblProductOrg.Name = "lblProductOrg";
            lblProductOrg.Size = new Size(140, 76);
            lblProductOrg.TabIndex = 31;
            lblProductOrg.Text = "IFNMG - Campus Montes Claros";
            lblProductOrg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDevteamProfessor
            // 
            lblDevteamProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDevteamProfessor.AutoSize = true;
            lblDevteamProfessor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevteamProfessor.Location = new Point(3, 228);
            lblDevteamProfessor.Name = "lblDevteamProfessor";
            lblDevteamProfessor.Size = new Size(140, 79);
            lblDevteamProfessor.TabIndex = 32;
            lblDevteamProfessor.Text = "Professor: \r\nLuís Guisso";
            lblDevteamProfessor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 327);
            Controls.Add(pnlAbout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "About";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += About_Load;
            pnlAbout.ResumeLayout(false);
            pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlAbout;
        private PictureBox pctLogo;
        private Label lblProductName;
        private Label lblProductVersion;
        private Label lblDevteam;
        private Label lblProductLicense;
        private Label lblProductOrg;
        private Label lblDevteamProfessor;
    }
}
