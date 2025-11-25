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
            dgvCategory = new DataGridView();
            ColumnCategoryId = new DataGridViewTextBoxColumn();
            ColumnCategoryName = new DataGridViewTextBoxColumn();
            grpCategoryDetails = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            lblTitleCategory = new Label();
            btnRegisterCategory = new Button();
            btnDeleteCategory = new Button();
            btnUpdateCategory = new Button();
            tabPageProducts = new TabPage();
            pnlProductManagement = new TableLayoutPanel();
            btnRegisterProduct = new Button();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            grpProductDetails = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblIsActive = new Label();
            label2 = new Label();
            nudMinStock = new NumericUpDown();
            lblMinStock = new Label();
            label1 = new Label();
            txtProductName = new TextBox();
            lblProductPrice = new Label();
            lblProductName = new Label();
            nudStock = new NumericUpDown();
            cboProductCategory = new ComboBox();
            nudProductPrice = new NumericUpDown();
            chkIsActive = new CheckBox();
            lblProductManager = new Label();
            dgvProduct = new DataGridView();
            ColumnProductId = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductPrice = new DataGridViewTextBoxColumn();
            ColumnProductCurrentStock = new DataGridViewTextBoxColumn();
            ColumnProductMinStock = new DataGridViewTextBoxColumn();
            ColumnProductCategory = new DataGridViewTextBoxColumn();
            ColumnProductIsActive = new DataGridViewTextBoxColumn();
            tabControlMain.SuspendLayout();
            tabPageCategories.SuspendLayout();
            pnlCategorieManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            grpCategoryDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPageProducts.SuspendLayout();
            pnlProductManagement.SuspendLayout();
            grpProductDetails.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
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
            pnlCategorieManagement.Controls.Add(dgvCategory, 0, 1);
            pnlCategorieManagement.Controls.Add(grpCategoryDetails, 0, 3);
            pnlCategorieManagement.Controls.Add(lblTitleCategory, 0, 0);
            pnlCategorieManagement.Controls.Add(btnRegisterCategory, 3, 4);
            pnlCategorieManagement.Controls.Add(btnDeleteCategory, 2, 4);
            pnlCategorieManagement.Controls.Add(btnUpdateCategory, 1, 4);
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
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { ColumnCategoryId, ColumnCategoryName });
            pnlCategorieManagement.SetColumnSpan(dgvCategory, 4);
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Location = new Point(3, 44);
            dgvCategory.Name = "dgvCategory";
            pnlCategorieManagement.SetRowSpan(dgvCategory, 2);
            dgvCategory.Size = new Size(780, 201);
            dgvCategory.TabIndex = 4;
            // 
            // ColumnCategoryId
            // 
            ColumnCategoryId.HeaderText = "Id";
            ColumnCategoryId.Name = "ColumnCategoryId";
            ColumnCategoryId.ReadOnly = true;
            ColumnCategoryId.Resizable = DataGridViewTriState.False;
            ColumnCategoryId.Width = 160;
            // 
            // ColumnCategoryName
            // 
            ColumnCategoryName.HeaderText = "Name";
            ColumnCategoryName.Name = "ColumnCategoryName";
            ColumnCategoryName.ReadOnly = true;
            ColumnCategoryName.Resizable = DataGridViewTriState.False;
            ColumnCategoryName.Width = 577;
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
            tableLayoutPanel1.Controls.Add(txtCategoryName, 3, 0);
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
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(582, 12);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(189, 22);
            txtCategoryName.TabIndex = 3;
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
            // btnRegisterCategory
            // 
            btnRegisterCategory.Dock = DockStyle.Fill;
            btnRegisterCategory.Location = new Point(591, 375);
            btnRegisterCategory.Name = "btnRegisterCategory";
            btnRegisterCategory.Size = new Size(192, 38);
            btnRegisterCategory.TabIndex = 5;
            btnRegisterCategory.Text = "Register";
            btnRegisterCategory.UseVisualStyleBackColor = true;
            btnRegisterCategory.Click += btnRegisterCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Dock = DockStyle.Fill;
            btnDeleteCategory.Location = new Point(395, 375);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(190, 38);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Dock = DockStyle.Fill;
            btnUpdateCategory.Location = new Point(199, 375);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(190, 38);
            btnUpdateCategory.TabIndex = 7;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
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
            pnlProductManagement.Controls.Add(btnRegisterProduct, 3, 4);
            pnlProductManagement.Controls.Add(btnDeleteProduct, 1, 4);
            pnlProductManagement.Controls.Add(btnUpdateProduct, 2, 4);
            pnlProductManagement.Controls.Add(grpProductDetails, 0, 3);
            pnlProductManagement.Controls.Add(lblProductManager, 0, 0);
            pnlProductManagement.Controls.Add(dgvProduct, 0, 1);
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
            // btnRegisterProduct
            // 
            btnRegisterProduct.Dock = DockStyle.Fill;
            btnRegisterProduct.Location = new Point(591, 375);
            btnRegisterProduct.Name = "btnRegisterProduct";
            btnRegisterProduct.Size = new Size(192, 38);
            btnRegisterProduct.TabIndex = 8;
            btnRegisterProduct.Text = "Register";
            btnRegisterProduct.UseVisualStyleBackColor = true;
            btnRegisterProduct.Click += btnRegisterProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Dock = DockStyle.Fill;
            btnDeleteProduct.Location = new Point(199, 375);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(190, 38);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Dock = DockStyle.Fill;
            btnUpdateProduct.Location = new Point(395, 375);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(190, 38);
            btnUpdateProduct.TabIndex = 10;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
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
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(lblIsActive, 4, 1);
            tableLayoutPanel2.Controls.Add(label2, 4, 0);
            tableLayoutPanel2.Controls.Add(nudMinStock, 3, 1);
            tableLayoutPanel2.Controls.Add(lblMinStock, 2, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(txtProductName, 1, 0);
            tableLayoutPanel2.Controls.Add(lblProductPrice, 2, 0);
            tableLayoutPanel2.Controls.Add(lblProductName, 0, 0);
            tableLayoutPanel2.Controls.Add(nudStock, 1, 1);
            tableLayoutPanel2.Controls.Add(cboProductCategory, 5, 0);
            tableLayoutPanel2.Controls.Add(nudProductPrice, 3, 0);
            tableLayoutPanel2.Controls.Add(chkIsActive, 5, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(774, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Dock = DockStyle.Fill;
            lblIsActive.Location = new Point(519, 47);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(123, 47);
            lblIsActive.TabIndex = 17;
            lblIsActive.Text = "Product is active?";
            lblIsActive.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(519, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 47);
            label2.TabIndex = 11;
            label2.Text = "Product Category:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudMinStock
            // 
            nudMinStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudMinStock.Font = new Font("Segoe UI", 8.25F);
            nudMinStock.Location = new Point(390, 59);
            nudMinStock.Name = "nudMinStock";
            nudMinStock.Size = new Size(123, 22);
            nudMinStock.TabIndex = 10;
            nudMinStock.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Dock = DockStyle.Fill;
            lblMinStock.Location = new Point(261, 47);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(123, 47);
            lblMinStock.TabIndex = 9;
            lblMinStock.Text = "Min. Stock:";
            lblMinStock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(123, 47);
            label1.TabIndex = 7;
            label1.Text = "Stock:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Font = new Font("Segoe UI", 8.25F);
            txtProductName.Location = new Point(132, 12);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(123, 22);
            txtProductName.TabIndex = 3;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Dock = DockStyle.Fill;
            lblProductPrice.Location = new Point(261, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(123, 47);
            lblProductPrice.TabIndex = 0;
            lblProductPrice.Text = "Product Price:";
            lblProductPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(3, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(123, 47);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            lblProductName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudStock
            // 
            nudStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudStock.Font = new Font("Segoe UI", 8.25F);
            nudStock.Location = new Point(132, 59);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(123, 22);
            nudStock.TabIndex = 8;
            nudStock.TextAlign = HorizontalAlignment.Center;
            // 
            // cboProductCategory
            // 
            cboProductCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboProductCategory.Font = new Font("Segoe UI", 8.25F);
            cboProductCategory.FormattingEnabled = true;
            cboProductCategory.Location = new Point(648, 13);
            cboProductCategory.Name = "cboProductCategory";
            cboProductCategory.Size = new Size(123, 21);
            cboProductCategory.TabIndex = 12;
            // 
            // nudProductPrice
            // 
            nudProductPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudProductPrice.Font = new Font("Segoe UI", 8.25F);
            nudProductPrice.Location = new Point(390, 12);
            nudProductPrice.Name = "nudProductPrice";
            nudProductPrice.Size = new Size(123, 22);
            nudProductPrice.TabIndex = 15;
            nudProductPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Dock = DockStyle.Fill;
            chkIsActive.Location = new Point(648, 50);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(123, 41);
            chkIsActive.TabIndex = 16;
            chkIsActive.TextAlign = ContentAlignment.MiddleRight;
            chkIsActive.UseVisualStyleBackColor = true;
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
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { ColumnProductId, ColumnProductName, ColumnProductPrice, ColumnProductCurrentStock, ColumnProductMinStock, ColumnProductCategory, ColumnProductIsActive });
            pnlProductManagement.SetColumnSpan(dgvProduct, 4);
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(3, 44);
            dgvProduct.Name = "dgvProduct";
            pnlProductManagement.SetRowSpan(dgvProduct, 2);
            dgvProduct.Size = new Size(780, 201);
            dgvProduct.TabIndex = 3;
            // 
            // ColumnProductId
            // 
            ColumnProductId.HeaderText = "Id";
            ColumnProductId.Name = "ColumnProductId";
            ColumnProductId.ReadOnly = true;
            ColumnProductId.Resizable = DataGridViewTriState.False;
            ColumnProductId.Width = 60;
            // 
            // ColumnProductName
            // 
            ColumnProductName.HeaderText = "Name";
            ColumnProductName.Name = "ColumnProductName";
            ColumnProductName.ReadOnly = true;
            ColumnProductName.Resizable = DataGridViewTriState.False;
            ColumnProductName.Width = 160;
            // 
            // ColumnProductPrice
            // 
            ColumnProductPrice.HeaderText = "Price";
            ColumnProductPrice.Name = "ColumnProductPrice";
            ColumnProductPrice.ReadOnly = true;
            ColumnProductPrice.Resizable = DataGridViewTriState.False;
            ColumnProductPrice.Width = 117;
            // 
            // ColumnProductCurrentStock
            // 
            ColumnProductCurrentStock.HeaderText = "Current Stock";
            ColumnProductCurrentStock.Name = "ColumnProductCurrentStock";
            ColumnProductCurrentStock.ReadOnly = true;
            ColumnProductCurrentStock.Resizable = DataGridViewTriState.False;
            // 
            // ColumnProductMinStock
            // 
            ColumnProductMinStock.HeaderText = "Min. Stock";
            ColumnProductMinStock.Name = "ColumnProductMinStock";
            ColumnProductMinStock.ReadOnly = true;
            ColumnProductMinStock.Resizable = DataGridViewTriState.False;
            ColumnProductMinStock.Width = 60;
            // 
            // ColumnProductCategory
            // 
            ColumnProductCategory.HeaderText = "Category";
            ColumnProductCategory.Name = "ColumnProductCategory";
            ColumnProductCategory.ReadOnly = true;
            ColumnProductCategory.Resizable = DataGridViewTriState.False;
            ColumnProductCategory.Width = 140;
            // 
            // ColumnProductIsActive
            // 
            ColumnProductIsActive.HeaderText = "Is Active";
            ColumnProductIsActive.Name = "ColumnProductIsActive";
            ColumnProductIsActive.ReadOnly = true;
            ColumnProductIsActive.Resizable = DataGridViewTriState.False;
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
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            grpCategoryDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPageProducts.ResumeLayout(false);
            pnlProductManagement.ResumeLayout(false);
            pnlProductManagement.PerformLayout();
            grpProductDetails.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
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
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Label lblTitleCategory;
        private TableLayoutPanel pnlProductManagement;
        private GroupBox grpProductDetails;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtProductName;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblProductManager;
        private NumericUpDown nudMinStock;
        private Label lblMinStock;
        private Label label1;
        private NumericUpDown nudStock;
        private Label label2;
        private ComboBox cboProductCategory;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn ColumnProductId;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnProductPrice;
        private DataGridViewTextBoxColumn ColumnProductCurrentStock;
        private DataGridViewTextBoxColumn ColumnProductMinStock;
        private DataGridViewTextBoxColumn ColumnProductCategory;
        private DataGridViewTextBoxColumn ColumnProductIsActive;
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn ColumnCategoryId;
        private DataGridViewTextBoxColumn ColumnCategoryName;
        private Button btnRegisterCategory;
        private Button btnDeleteCategory;
        private Button btnUpdateCategory;
        private Button btnRegisterProduct;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Label lblProductPrice;
        private NumericUpDown nudProductPrice;
        private CheckBox chkIsActive;
        private Label lblIsActive;
    }
}