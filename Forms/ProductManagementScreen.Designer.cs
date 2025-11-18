namespace UserManagementSystem.Forms
{
    partial class ProductManagementScreen
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
            tabControlMain = new TabControl();
            tabPageCategories = new TabPage();
            tabPage2 = new TabPage();
            pnlCategories = new TableLayoutPanel();
            listView1 = new ListView();
            chCategoriesGhost = new ColumnHeader();
            chCategoriesId = new ColumnHeader();
            chCategoriesName = new ColumnHeader();
            grpCategoryDetails = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCategoryId = new Label();
            txtCategoryId = new TextBox();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            btnSaveCategory = new Button();
            btnDeleteCategory = new Button();
            btnClearCategory = new Button();
            lblTitleCategory = new Label();
            tabControlMain.SuspendLayout();
            tabPageCategories.SuspendLayout();
            pnlCategories.SuspendLayout();
            grpCategoryDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageCategories);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 450);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(pnlCategories);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(792, 422);
            tabPageCategories.TabIndex = 0;
            tabPageCategories.Text = "Categories";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCategories
            // 
            pnlCategories.ColumnCount = 4;
            pnlCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategories.Controls.Add(listView1, 0, 1);
            pnlCategories.Controls.Add(grpCategoryDetails, 0, 3);
            pnlCategories.Controls.Add(lblTitleCategory, 1, 0);
            pnlCategories.Dock = DockStyle.Fill;
            pnlCategories.Location = new Point(3, 3);
            pnlCategories.Name = "pnlCategories";
            pnlCategories.RowCount = 5;
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategories.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlCategories.Size = new Size(786, 416);
            pnlCategories.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { chCategoriesGhost, chCategoriesId, chCategoriesName });
            pnlCategories.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 44);
            listView1.Name = "listView1";
            pnlCategories.SetRowSpan(listView1, 2);
            listView1.Size = new Size(780, 201);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chCategoriesGhost
            // 
            chCategoriesGhost.Width = 0;
            // 
            // chCategoriesId
            // 
            chCategoriesId.Text = "ID";
            chCategoriesId.TextAlign = HorizontalAlignment.Center;
            chCategoriesId.Width = 192;
            // 
            // chCategoriesName
            // 
            chCategoriesName.Text = "Category Name";
            chCategoriesName.TextAlign = HorizontalAlignment.Center;
            chCategoriesName.Width = 392;
            // 
            // grpCategoryDetails
            // 
            pnlCategories.SetColumnSpan(grpCategoryDetails, 4);
            grpCategoryDetails.Controls.Add(tableLayoutPanel1);
            grpCategoryDetails.Dock = DockStyle.Fill;
            grpCategoryDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCategoryDetails.Location = new Point(3, 251);
            grpCategoryDetails.Name = "grpCategoryDetails";
            grpCategoryDetails.Size = new Size(780, 118);
            grpCategoryDetails.TabIndex = 1;
            grpCategoryDetails.TabStop = false;
            grpCategoryDetails.Text = "Category Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnClearCategory, 4, 1);
            tableLayoutPanel1.Controls.Add(btnDeleteCategory, 2, 1);
            tableLayoutPanel1.Controls.Add(txtCategoryName, 3, 0);
            tableLayoutPanel1.Controls.Add(lblCategoryId, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSaveCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCategoryId, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCategoryName, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(774, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Dock = DockStyle.Fill;
            lblCategoryId.Location = new Point(3, 0);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(187, 47);
            lblCategoryId.TabIndex = 0;
            lblCategoryId.Text = "Category ID:";
            lblCategoryId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryId.Location = new Point(196, 11);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(187, 25);
            txtCategoryId.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Dock = DockStyle.Fill;
            lblCategoryName.Location = new Point(389, 0);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(187, 47);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Category Name:";
            lblCategoryName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.Location = new Point(582, 11);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.ReadOnly = true;
            txtCategoryName.Size = new Size(189, 25);
            txtCategoryName.TabIndex = 3;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.Dock = DockStyle.Fill;
            btnSaveCategory.Location = new Point(196, 50);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(187, 41);
            btnSaveCategory.TabIndex = 4;
            btnSaveCategory.Text = "Save Category";
            btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Dock = DockStyle.Fill;
            btnDeleteCategory.Location = new Point(389, 50);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(187, 41);
            btnDeleteCategory.TabIndex = 5;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnClearCategory
            // 
            btnClearCategory.Dock = DockStyle.Fill;
            btnClearCategory.Location = new Point(582, 50);
            btnClearCategory.Name = "btnClearCategory";
            btnClearCategory.Size = new Size(189, 41);
            btnClearCategory.TabIndex = 6;
            btnClearCategory.Text = "Clear Category";
            btnClearCategory.UseVisualStyleBackColor = true;
            // 
            // lblTitleCategory
            // 
            lblTitleCategory.AutoSize = true;
            pnlCategories.SetColumnSpan(lblTitleCategory, 2);
            lblTitleCategory.Dock = DockStyle.Fill;
            lblTitleCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCategory.Location = new Point(199, 0);
            lblTitleCategory.Name = "lblTitleCategory";
            lblTitleCategory.Size = new Size(386, 41);
            lblTitleCategory.TabIndex = 2;
            lblTitleCategory.Text = "Category Manager";
            lblTitleCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductManagementScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "ProductManagementScreen";
            ShowIcon = false;
            Text = "ProductManagementScreen";
            tabControlMain.ResumeLayout(false);
            tabPageCategories.ResumeLayout(false);
            pnlCategories.ResumeLayout(false);
            pnlCategories.PerformLayout();
            grpCategoryDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCategories;
        private TableLayoutPanel pnlCategories;
        private TabPage tabPage2;
        private ListView listView1;
        private ColumnHeader chCategoriesGhost;
        private ColumnHeader chCategoriesId;
        private ColumnHeader chCategoriesName;
        private GroupBox grpCategoryDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCategoryId;
        private TextBox txtCategoryId;
        private Button btnClearCategory;
        private Button btnDeleteCategory;
        private TextBox txtCategoryName;
        private Button btnSaveCategory;
        private Label lblCategoryName;
        private Label lblTitleCategory;
    }
}