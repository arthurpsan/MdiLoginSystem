namespace UserManagementSystem.Forms
{
    partial class ProductForm
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
            pnlCategorieManagement = new TableLayoutPanel();
            lstCategories = new ListView();
            chCategoriesGhost = new ColumnHeader();
            chCategoriesId = new ColumnHeader();
            chCategoriesName = new ColumnHeader();
            grpCategoryDetails = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClearCategory = new Button();
            btnDeleteCategory = new Button();
            txtCategoryName = new TextBox();
            btnSaveCategory = new Button();
            lblCategoryName = new Label();
            lblTitleCategory = new Label();
            tabPageProducts = new TabPage();
            pnlProductManagement = new TableLayoutPanel();
            lstProducts = new ListView();
            chProductGhost = new ColumnHeader();
            chProductId = new ColumnHeader();
            chProductName = new ColumnHeader();
            chProductMinimalStock = new ColumnHeader();
            chProductStock = new ColumnHeader();
            chProductIsActive = new ColumnHeader();
            chProductPrice = new ColumnHeader();
            grpProductDetails = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnClearProduct = new Button();
            btnDeleteProduct = new Button();
            txtProductName = new TextBox();
            lblProductId = new Label();
            btnSaveProduct = new Button();
            txtProductId = new TextBox();
            lblProductName = new Label();
            lblProductManager = new Label();
            tabControlMain.SuspendLayout();
            tabPageCategories.SuspendLayout();
            pnlCategorieManagement.SuspendLayout();
            grpCategoryDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPageProducts.SuspendLayout();
            pnlProductManagement.SuspendLayout();
            grpProductDetails.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageCategories);
            tabControlMain.Controls.Add(tabPageProducts);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 450);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(pnlCategorieManagement);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(792, 422);
            tabPageCategories.TabIndex = 0;
            tabPageCategories.Text = "Categories";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // pnlCategorieManagement
            // 
            pnlCategorieManagement.ColumnCount = 4;
            pnlCategorieManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategorieManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategorieManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategorieManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCategorieManagement.Controls.Add(lstCategories, 0, 1);
            pnlCategorieManagement.Controls.Add(grpCategoryDetails, 0, 3);
            pnlCategorieManagement.Controls.Add(lblTitleCategory, 0, 0);
            pnlCategorieManagement.Dock = DockStyle.Fill;
            pnlCategorieManagement.Location = new Point(3, 3);
            pnlCategorieManagement.Name = "pnlCategorieManagement";
            pnlCategorieManagement.RowCount = 5;
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCategorieManagement.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlCategorieManagement.Size = new Size(786, 416);
            pnlCategorieManagement.TabIndex = 0;
            // 
            // lstCategories
            // 
            lstCategories.BackColor = Color.LightGray;
            lstCategories.Columns.AddRange(new ColumnHeader[] { chCategoriesGhost, chCategoriesId, chCategoriesName });
            pnlCategorieManagement.SetColumnSpan(lstCategories, 4);
            lstCategories.Dock = DockStyle.Fill;
            lstCategories.GridLines = true;
            lstCategories.Location = new Point(3, 44);
            lstCategories.Name = "lstCategories";
            pnlCategorieManagement.SetRowSpan(lstCategories, 2);
            lstCategories.Size = new Size(780, 201);
            lstCategories.TabIndex = 0;
            lstCategories.UseCompatibleStateImageBehavior = false;
            lstCategories.View = View.Details;
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
            pnlCategorieManagement.SetColumnSpan(grpCategoryDetails, 4);
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
            tableLayoutPanel1.Controls.Add(btnSaveCategory, 1, 1);
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
            // lblTitleCategory
            // 
            lblTitleCategory.AutoSize = true;
            lblTitleCategory.BackColor = Color.FromArgb(0, 53, 123);
            pnlCategorieManagement.SetColumnSpan(lblTitleCategory, 4);
            lblTitleCategory.Dock = DockStyle.Fill;
            lblTitleCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCategory.ForeColor = Color.White;
            lblTitleCategory.Location = new Point(3, 0);
            lblTitleCategory.Name = "lblTitleCategory";
            lblTitleCategory.Size = new Size(780, 41);
            lblTitleCategory.TabIndex = 2;
            lblTitleCategory.Text = "Category Manager";
            lblTitleCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(pnlProductManagement);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(792, 422);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Products";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // pnlProductManagement
            // 
            pnlProductManagement.ColumnCount = 4;
            pnlProductManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlProductManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlProductManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlProductManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlProductManagement.Controls.Add(lstProducts, 0, 1);
            pnlProductManagement.Controls.Add(grpProductDetails, 0, 3);
            pnlProductManagement.Controls.Add(lblProductManager, 0, 0);
            pnlProductManagement.Dock = DockStyle.Fill;
            pnlProductManagement.Location = new Point(3, 3);
            pnlProductManagement.Name = "pnlProductManagement";
            pnlProductManagement.RowCount = 5;
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlProductManagement.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlProductManagement.Size = new Size(786, 416);
            pnlProductManagement.TabIndex = 1;
            // 
            // lstProducts
            // 
            lstProducts.BackColor = Color.LightGray;
            lstProducts.Columns.AddRange(new ColumnHeader[] { chProductGhost, chProductId, chProductName, chProductMinimalStock, chProductStock, chProductIsActive, chProductPrice });
            pnlProductManagement.SetColumnSpan(lstProducts, 4);
            lstProducts.Dock = DockStyle.Fill;
            lstProducts.GridLines = true;
            lstProducts.Location = new Point(3, 44);
            lstProducts.Name = "lstProducts";
            pnlProductManagement.SetRowSpan(lstProducts, 2);
            lstProducts.Size = new Size(780, 201);
            lstProducts.TabIndex = 0;
            lstProducts.UseCompatibleStateImageBehavior = false;
            lstProducts.View = View.Details;
            // 
            // chProductGhost
            // 
            chProductGhost.Width = 0;
            // 
            // chProductId
            // 
            chProductId.Text = "ID";
            chProductId.TextAlign = HorizontalAlignment.Center;
            chProductId.Width = 96;
            // 
            // chProductName
            // 
            chProductName.Text = "Product Name";
            chProductName.TextAlign = HorizontalAlignment.Center;
            chProductName.Width = 192;
            // 
            // chProductMinimalStock
            // 
            chProductMinimalStock.Text = "Minimal Stock";
            chProductMinimalStock.TextAlign = HorizontalAlignment.Center;
            chProductMinimalStock.Width = 98;
            // 
            // chProductStock
            // 
            chProductStock.Text = "Stock";
            chProductStock.TextAlign = HorizontalAlignment.Center;
            chProductStock.Width = 98;
            // 
            // chProductIsActive
            // 
            chProductIsActive.Text = "Active?";
            chProductIsActive.TextAlign = HorizontalAlignment.Center;
            chProductIsActive.Width = 96;
            // 
            // chProductPrice
            // 
            chProductPrice.Text = "Price";
            chProductPrice.TextAlign = HorizontalAlignment.Center;
            chProductPrice.Width = 196;
            // 
            // grpProductDetails
            // 
            pnlProductManagement.SetColumnSpan(grpProductDetails, 4);
            grpProductDetails.Controls.Add(tableLayoutPanel2);
            grpProductDetails.Dock = DockStyle.Fill;
            grpProductDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProductDetails.Location = new Point(3, 251);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Size = new Size(780, 118);
            grpProductDetails.TabIndex = 1;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnClearProduct, 4, 1);
            tableLayoutPanel2.Controls.Add(btnDeleteProduct, 2, 1);
            tableLayoutPanel2.Controls.Add(txtProductName, 3, 0);
            tableLayoutPanel2.Controls.Add(lblProductId, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSaveProduct, 1, 1);
            tableLayoutPanel2.Controls.Add(txtProductId, 1, 0);
            tableLayoutPanel2.Controls.Add(lblProductName, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(774, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Dock = DockStyle.Fill;
            btnClearProduct.Location = new Point(582, 50);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(189, 41);
            btnClearProduct.TabIndex = 6;
            btnClearProduct.Text = "Clear Product";
            btnClearProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Dock = DockStyle.Fill;
            btnDeleteProduct.Location = new Point(389, 50);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(187, 41);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(582, 11);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(189, 25);
            txtProductName.TabIndex = 3;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Dock = DockStyle.Fill;
            lblProductId.Location = new Point(3, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(187, 47);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID:";
            lblProductId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Dock = DockStyle.Fill;
            btnSaveProduct.Location = new Point(196, 50);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(187, 41);
            btnSaveProduct.TabIndex = 4;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProductId.Location = new Point(196, 11);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(187, 25);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(389, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(187, 47);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            lblProductName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProductManager
            // 
            lblProductManager.AutoSize = true;
            lblProductManager.BackColor = Color.FromArgb(0, 53, 123);
            pnlProductManagement.SetColumnSpan(lblProductManager, 4);
            lblProductManager.Dock = DockStyle.Fill;
            lblProductManager.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductManager.ForeColor = Color.White;
            lblProductManager.Location = new Point(3, 0);
            lblProductManager.Name = "lblProductManager";
            lblProductManager.Size = new Size(780, 41);
            lblProductManager.TabIndex = 2;
            lblProductManager.Text = "Product Manager";
            lblProductManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "ProductForm";
            ShowIcon = false;
            Text = "ProductManagementScreen";
            tabControlMain.ResumeLayout(false);
            tabPageCategories.ResumeLayout(false);
            pnlCategorieManagement.ResumeLayout(false);
            pnlCategorieManagement.PerformLayout();
            grpCategoryDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPageProducts.ResumeLayout(false);
            pnlProductManagement.ResumeLayout(false);
            pnlProductManagement.PerformLayout();
            grpProductDetails.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCategories;
        private TableLayoutPanel pnlCategorieManagement;
        private TabPage tabPageProducts;
        private ListView lstCategories;
        private ColumnHeader chCategoriesGhost;
        private ColumnHeader chCategoriesId;
        private ColumnHeader chCategoriesName;
        private GroupBox grpCategoryDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClearCategory;
        private Button btnDeleteCategory;
        private TextBox txtCategoryName;
        private Button btnSaveCategory;
        private Label lblCategoryName;
        private Label lblTitleCategory;
        private TableLayoutPanel pnlProductManagement;
        private ListView lstProducts;
        private ColumnHeader chProductGhost;
        private ColumnHeader chProductId;
        private ColumnHeader chProductName;
        private GroupBox grpProductDetails;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnClearProduct;
        private Button btnDeleteProduct;
        private TextBox txtProductName;
        private Label lblProductId;
        private Button btnSaveProduct;
        private TextBox txtProductId;
        private Label lblProductName;
        private Label lblProductManager;
        private ColumnHeader chProductMinimalStock;
        private ColumnHeader chProductStock;
        private ColumnHeader chProductIsActive;
        private ColumnHeader chProductPrice;
    }
}