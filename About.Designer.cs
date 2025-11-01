namespace MdiLoginSystem
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pnlAbout = new TableLayoutPanel();
            lblProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            labelCompanyName = new Label();
            textBoxDescription = new TextBox();
            pctLogo = new PictureBox();
            pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlAbout
            // 
            pnlAbout.ColumnCount = 2;
            pnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            pnlAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
            pnlAbout.Controls.Add(lblProductName, 1, 0);
            pnlAbout.Controls.Add(labelVersion, 1, 1);
            pnlAbout.Controls.Add(labelCopyright, 1, 2);
            pnlAbout.Controls.Add(labelCompanyName, 1, 3);
            pnlAbout.Controls.Add(textBoxDescription, 1, 4);
            pnlAbout.Controls.Add(pctLogo, 0, 0);
            pnlAbout.Dock = DockStyle.Fill;
            pnlAbout.Location = new Point(10, 10);
            pnlAbout.Margin = new Padding(4, 3, 4, 3);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.RowCount = 3;
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pnlAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555573F));
            pnlAbout.Size = new Size(487, 307);
            pnlAbout.TabIndex = 0;
            // 
            // lblProductName
            // 
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(133, 0);
            lblProductName.Margin = new Padding(7, 0, 4, 0);
            lblProductName.MaximumSize = new Size(0, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(350, 20);
            lblProductName.TabIndex = 19;
            lblProductName.Text = "User Management System";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelVersion.Location = new Point(133, 34);
            labelVersion.Margin = new Padding(7, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 20);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(350, 20);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "v0.0.1";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.Dock = DockStyle.Fill;
            labelCopyright.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCopyright.Location = new Point(133, 68);
            labelCopyright.Margin = new Padding(7, 0, 4, 0);
            labelCopyright.MaximumSize = new Size(0, 20);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(350, 20);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Creative Commons (CC)";
            labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = DockStyle.Fill;
            labelCompanyName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCompanyName.Location = new Point(133, 102);
            labelCompanyName.Margin = new Padding(7, 0, 4, 0);
            labelCompanyName.MaximumSize = new Size(0, 20);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(350, 20);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "IFNMG, Arthur Santos, Maria Luisa";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(133, 139);
            textBoxDescription.Margin = new Padding(7, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(350, 165);
            textBoxDescription.TabIndex = 25;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // pctLogo
            // 
            pctLogo.BackgroundImageLayout = ImageLayout.None;
            pctLogo.Dock = DockStyle.Fill;
            pctLogo.Image = UserManagementSystem.Properties.Resources.montes_claros_vertical_verde_jpg;
            pctLogo.Location = new Point(3, 3);
            pctLogo.Name = "pctLogo";
            pnlAbout.SetRowSpan(pctLogo, 4);
            pctLogo.Size = new Size(120, 130);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 26;
            pctLogo.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 327);
            Controls.Add(pnlAbout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label lblProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private PictureBox pctLogo;
    }
}
