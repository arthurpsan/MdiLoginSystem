namespace UserManagementSystem.Forms
{
    partial class SaleForm
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
            TabControlMain = new TabControl();
            tabPageCustomer = new TabPage();
            pnlCustomer = new TableLayoutPanel();
            lstCustomers = new ListView();
            chCustomerGhost = new ColumnHeader();
            chCustomerId = new ColumnHeader();
            chCustomerEmail = new ColumnHeader();
            lblSearchCustomer = new Label();
            txtSearchCustomer = new TextBox();
            btnSearchCustomer = new Button();
            tabPageProduct = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCategory = new Label();
            lblSearchProduct = new Label();
            numQuantity = new NumericUpDown();
            cboCategories = new ComboBox();
            lblQuantity = new Label();
            txtSearchProduct = new TextBox();
            btnAddItem = new Button();
            lstProducts = new ListView();
            chProductGhost = new ColumnHeader();
            chProductId = new ColumnHeader();
            chProductName = new ColumnHeader();
            chProductPrice = new ColumnHeader();
            chProductStock = new ColumnHeader();
            chProductMinimalStock = new ColumnHeader();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            splitContainerSales = new SplitContainer();
            pnlCart = new TableLayoutPanel();
            lblSelectedCustomerName = new Label();
            lstCart = new ListView();
            chCartGhost = new ColumnHeader();
            chCartProductName = new ColumnHeader();
            chCartProductQty = new ColumnHeader();
            chCartProductDiscount = new ColumnHeader();
            chCartProductUnitPrice = new ColumnHeader();
            chCartProductTotalPrice = new ColumnHeader();
            lblTotalSale = new Label();
            btnFinalizeSale = new Button();
            lblInstallments = new Label();
            numInstallments = new NumericUpDown();
            btnRequestAuth = new Button();
            lblCart = new Label();
            TabControlMain.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            pnlCustomer.SuspendLayout();
            tabPageProduct.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerSales).BeginInit();
            splitContainerSales.Panel1.SuspendLayout();
            splitContainerSales.Panel2.SuspendLayout();
            splitContainerSales.SuspendLayout();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInstallments).BeginInit();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPageCustomer);
            TabControlMain.Controls.Add(tabPageProduct);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(266, 450);
            TabControlMain.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(pnlCustomer);
            tabPageCustomer.Location = new Point(4, 26);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(3);
            tabPageCustomer.Size = new Size(258, 420);
            tabPageCustomer.TabIndex = 0;
            tabPageCustomer.Text = "Customer";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlCustomer
            // 
            pnlCustomer.ColumnCount = 4;
            pnlCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCustomer.Controls.Add(lstCustomers, 0, 2);
            pnlCustomer.Controls.Add(lblSearchCustomer, 0, 0);
            pnlCustomer.Controls.Add(txtSearchCustomer, 0, 1);
            pnlCustomer.Controls.Add(btnSearchCustomer, 2, 1);
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Location = new Point(3, 3);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.RowCount = 4;
            pnlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlCustomer.Size = new Size(252, 414);
            pnlCustomer.TabIndex = 0;
            // 
            // lstCustomers
            // 
            lstCustomers.BackColor = Color.LightGray;
            lstCustomers.CheckBoxes = true;
            lstCustomers.Columns.AddRange(new ColumnHeader[] { chCustomerGhost, chCustomerId, chCustomerEmail });
            pnlCustomer.SetColumnSpan(lstCustomers, 4);
            lstCustomers.Dock = DockStyle.Fill;
            lstCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCustomers.FullRowSelect = true;
            lstCustomers.GridLines = true;
            lstCustomers.LabelWrap = false;
            lstCustomers.Location = new Point(3, 81);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(246, 309);
            lstCustomers.TabIndex = 3;
            lstCustomers.UseCompatibleStateImageBehavior = false;
            lstCustomers.View = View.Details;
            // 
            // chCustomerGhost
            // 
            chCustomerGhost.Text = "";
            chCustomerGhost.Width = 0;
            // 
            // chCustomerId
            // 
            chCustomerId.Text = "ID";
            chCustomerId.TextAlign = HorizontalAlignment.Center;
            chCustomerId.Width = 40;
            // 
            // chCustomerEmail
            // 
            chCustomerEmail.Text = "Name";
            chCustomerEmail.TextAlign = HorizontalAlignment.Center;
            chCustomerEmail.Width = 202;
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.AutoSize = true;
            pnlCustomer.SetColumnSpan(lblSearchCustomer, 2);
            lblSearchCustomer.Dock = DockStyle.Fill;
            lblSearchCustomer.Location = new Point(3, 0);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(120, 39);
            lblSearchCustomer.TabIndex = 4;
            lblSearchCustomer.Text = "Search Customer:";
            lblSearchCustomer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlCustomer.SetColumnSpan(txtSearchCustomer, 2);
            txtSearchCustomer.Location = new Point(3, 46);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(120, 25);
            txtSearchCustomer.TabIndex = 5;
            // 
            // btnSearchCustomer
            // 
            pnlCustomer.SetColumnSpan(btnSearchCustomer, 2);
            btnSearchCustomer.Dock = DockStyle.Fill;
            btnSearchCustomer.Location = new Point(129, 42);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(120, 33);
            btnSearchCustomer.TabIndex = 6;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(tableLayoutPanel1);
            tabPageProduct.Location = new Point(4, 26);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(258, 420);
            tabPageProduct.TabIndex = 1;
            tabPageProduct.Text = "Products";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 2);
            tableLayoutPanel1.Controls.Add(lblSearchProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(numQuantity, 2, 3);
            tableLayoutPanel1.Controls.Add(cboCategories, 2, 2);
            tableLayoutPanel1.Controls.Add(lblQuantity, 0, 3);
            tableLayoutPanel1.Controls.Add(txtSearchProduct, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAddItem, 2, 4);
            tableLayoutPanel1.Controls.Add(lstProducts, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDiscount, 0, 4);
            tableLayoutPanel1.Controls.Add(numDiscount, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(252, 414);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCategory, 2);
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 289);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(120, 41);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblSearchProduct, 2);
            lblSearchProduct.Dock = DockStyle.Fill;
            lblSearchProduct.Location = new Point(3, 0);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(120, 41);
            lblSearchProduct.TabIndex = 5;
            lblSearchProduct.Text = "Search Products:";
            lblSearchProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(numQuantity, 2);
            numQuantity.Location = new Point(129, 338);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 25);
            numQuantity.TabIndex = 9;
            numQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // cboCategories
            // 
            cboCategories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(cboCategories, 2);
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(129, 298);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(120, 25);
            cboCategories.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblQuantity, 2);
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(3, 330);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 41);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";
            lblQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtSearchProduct, 2);
            txtSearchProduct.Location = new Point(129, 8);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(120, 25);
            txtSearchProduct.TabIndex = 6;
            // 
            // btnAddItem
            // 
            tableLayoutPanel1.SetColumnSpan(btnAddItem, 2);
            btnAddItem.Dock = DockStyle.Fill;
            btnAddItem.Location = new Point(129, 374);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(120, 37);
            btnAddItem.TabIndex = 12;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lstProducts
            // 
            lstProducts.BackColor = Color.LightGray;
            lstProducts.CheckBoxes = true;
            lstProducts.Columns.AddRange(new ColumnHeader[] { chProductGhost, chProductId, chProductName, chProductPrice, chProductStock, chProductMinimalStock });
            tableLayoutPanel1.SetColumnSpan(lstProducts, 4);
            lstProducts.Dock = DockStyle.Fill;
            lstProducts.FullRowSelect = true;
            lstProducts.GridLines = true;
            lstProducts.Location = new Point(3, 44);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(246, 242);
            lstProducts.TabIndex = 13;
            lstProducts.UseCompatibleStateImageBehavior = false;
            lstProducts.View = View.Details;
            // 
            // chProductGhost
            // 
            chProductGhost.Text = "";
            chProductGhost.Width = 0;
            // 
            // chProductId
            // 
            chProductId.Text = "ID";
            chProductId.TextAlign = HorizontalAlignment.Center;
            // 
            // chProductName
            // 
            chProductName.Text = "Name";
            chProductName.TextAlign = HorizontalAlignment.Center;
            chProductName.Width = 61;
            // 
            // chProductPrice
            // 
            chProductPrice.Text = "Price";
            chProductPrice.TextAlign = HorizontalAlignment.Center;
            chProductPrice.Width = 61;
            // 
            // chProductStock
            // 
            chProductStock.Text = "Stock";
            chProductStock.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Dock = DockStyle.Fill;
            lblDiscount.Location = new Point(3, 371);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(57, 43);
            lblDiscount.TabIndex = 14;
            lblDiscount.Text = "Desconto (%):";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDiscount
            // 
            numDiscount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDiscount.Location = new Point(66, 380);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(57, 25);
            numDiscount.TabIndex = 15;
            numDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // splitContainerSales
            // 
            splitContainerSales.Dock = DockStyle.Fill;
            splitContainerSales.Location = new Point(0, 0);
            splitContainerSales.Name = "splitContainerSales";
            // 
            // splitContainerSales.Panel1
            // 
            splitContainerSales.Panel1.Controls.Add(TabControlMain);
            // 
            // splitContainerSales.Panel2
            // 
            splitContainerSales.Panel2.Controls.Add(pnlCart);
            splitContainerSales.Size = new Size(800, 450);
            splitContainerSales.SplitterDistance = 266;
            splitContainerSales.TabIndex = 1;
            // 
            // pnlCart
            // 
            pnlCart.ColumnCount = 4;
            pnlCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCart.Controls.Add(lblSelectedCustomerName, 0, 3);
            pnlCart.Controls.Add(lstCart, 0, 1);
            pnlCart.Controls.Add(lblTotalSale, 0, 2);
            pnlCart.Controls.Add(btnFinalizeSale, 2, 4);
            pnlCart.Controls.Add(lblInstallments, 2, 2);
            pnlCart.Controls.Add(numInstallments, 4, 2);
            pnlCart.Controls.Add(btnRequestAuth, 0, 4);
            pnlCart.Controls.Add(lblCart, 0, 0);
            pnlCart.Dock = DockStyle.Fill;
            pnlCart.Location = new Point(0, 0);
            pnlCart.Name = "pnlCart";
            pnlCart.RowCount = 5;
            pnlCart.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCart.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            pnlCart.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCart.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCart.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlCart.Size = new Size(530, 450);
            pnlCart.TabIndex = 0;
            // 
            // lblSelectedCustomerName
            // 
            lblSelectedCustomerName.AutoSize = true;
            pnlCart.SetColumnSpan(lblSelectedCustomerName, 2);
            lblSelectedCustomerName.Dock = DockStyle.Fill;
            lblSelectedCustomerName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedCustomerName.Location = new Point(3, 360);
            lblSelectedCustomerName.Name = "lblSelectedCustomerName";
            lblSelectedCustomerName.Size = new Size(258, 45);
            lblSelectedCustomerName.TabIndex = 0;
            lblSelectedCustomerName.Text = "Customer Name";
            lblSelectedCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstCart
            // 
            lstCart.BackColor = Color.LightGray;
            lstCart.CheckBoxes = true;
            lstCart.Columns.AddRange(new ColumnHeader[] { chCartGhost, chCartProductName, chCartProductQty, chCartProductDiscount, chCartProductUnitPrice, chCartProductTotalPrice });
            pnlCart.SetColumnSpan(lstCart, 4);
            lstCart.Dock = DockStyle.Fill;
            lstCart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCart.FullRowSelect = true;
            lstCart.GridLines = true;
            lstCart.LabelWrap = false;
            lstCart.Location = new Point(3, 48);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(524, 264);
            lstCart.TabIndex = 7;
            lstCart.UseCompatibleStateImageBehavior = false;
            lstCart.View = View.Details;
            // 
            // chCartGhost
            // 
            chCartGhost.Width = 0;
            // 
            // chCartProductName
            // 
            chCartProductName.Text = "Product";
            chCartProductName.TextAlign = HorizontalAlignment.Center;
            chCartProductName.Width = 180;
            // 
            // chCartProductQty
            // 
            chCartProductQty.Text = "Quantity";
            chCartProductQty.TextAlign = HorizontalAlignment.Center;
            chCartProductQty.Width = 80;
            // 
            // chCartProductDiscount
            // 
            chCartProductDiscount.Text = "Disc. %";
            chCartProductDiscount.TextAlign = HorizontalAlignment.Center;
            chCartProductDiscount.Width = 58;
            // 
            // chCartProductUnitPrice
            // 
            chCartProductUnitPrice.Text = "Unit Price";
            chCartProductUnitPrice.TextAlign = HorizontalAlignment.Center;
            chCartProductUnitPrice.Width = 92;
            // 
            // chCartProductTotalPrice
            // 
            chCartProductTotalPrice.Text = "Total";
            chCartProductTotalPrice.TextAlign = HorizontalAlignment.Center;
            chCartProductTotalPrice.Width = 110;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.BackColor = Color.White;
            pnlCart.SetColumnSpan(lblTotalSale, 2);
            lblTotalSale.Dock = DockStyle.Fill;
            lblTotalSale.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalSale.Location = new Point(3, 315);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(258, 45);
            lblTotalSale.TabIndex = 8;
            lblTotalSale.Text = "Total";
            lblTotalSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinalizeSale
            // 
            pnlCart.SetColumnSpan(btnFinalizeSale, 2);
            btnFinalizeSale.Dock = DockStyle.Fill;
            btnFinalizeSale.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizeSale.Location = new Point(267, 408);
            btnFinalizeSale.Name = "btnFinalizeSale";
            btnFinalizeSale.Size = new Size(260, 39);
            btnFinalizeSale.TabIndex = 9;
            btnFinalizeSale.Text = "Finish Sale";
            btnFinalizeSale.UseVisualStyleBackColor = true;
            btnFinalizeSale.Click += btnFinishSale_Click;
            // 
            // lblInstallments
            // 
            lblInstallments.AutoSize = true;
            lblInstallments.Dock = DockStyle.Fill;
            lblInstallments.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstallments.Location = new Point(267, 315);
            lblInstallments.Name = "lblInstallments";
            lblInstallments.Size = new Size(126, 45);
            lblInstallments.TabIndex = 10;
            lblInstallments.Text = "Installments:";
            lblInstallments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numInstallments
            // 
            numInstallments.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numInstallments.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numInstallments.Location = new Point(399, 325);
            numInstallments.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numInstallments.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInstallments.Name = "numInstallments";
            numInstallments.Size = new Size(128, 25);
            numInstallments.TabIndex = 11;
            numInstallments.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRequestAuth
            // 
            pnlCart.SetColumnSpan(btnRequestAuth, 2);
            btnRequestAuth.Dock = DockStyle.Fill;
            btnRequestAuth.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequestAuth.Location = new Point(3, 408);
            btnRequestAuth.Name = "btnRequestAuth";
            btnRequestAuth.Size = new Size(258, 39);
            btnRequestAuth.TabIndex = 12;
            btnRequestAuth.Text = "Authorize Sale";
            btnRequestAuth.UseVisualStyleBackColor = true;
            btnRequestAuth.Visible = false;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.BackColor = Color.FromArgb(0, 53, 123);
            pnlCart.SetColumnSpan(lblCart, 4);
            lblCart.Dock = DockStyle.Fill;
            lblCart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(3, 0);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(524, 45);
            lblCart.TabIndex = 13;
            lblCart.Text = "SHOPPING CART";
            lblCart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerSales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaleForm";
            ShowIcon = false;
            Text = "Sales and Checkout";
            TabControlMain.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            tabPageProduct.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            splitContainerSales.Panel1.ResumeLayout(false);
            splitContainerSales.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerSales).EndInit();
            splitContainerSales.ResumeLayout(false);
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInstallments).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl TabControlMain;
        private TabPage tabPageCustomer;
        private ListView lstCustomers;
        private ColumnHeader chCustomerGhost;
        private ColumnHeader columnHeaderId;
        private ColumnHeader chCustomerId;
        private ColumnHeader chCustomerEmail;
        private SplitContainer splitContainerSales;
        private TabPage tabPageProduct;
        private TableLayoutPanel pnlCustomer;
        private Label lblSearchCustomer;
        private TextBox txtSearchCustomer;
        private Button btnSearchCustomer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSearchProduct;
        private TextBox txtSearchProduct;
        private Label lblCategory;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private ComboBox cboCategories;
        private Button btnAddItem;
        private ListView lstProducts;
        private ColumnHeader chProductGhost;
        private ColumnHeader chProductName;
        private ColumnHeader chProductPrice;
        private ColumnHeader chProductId;
        private ColumnHeader chProductStock;
        private ColumnHeader chProductMinimalStock;
        private TableLayoutPanel pnlCart;
        private Label lblSelectedCustomerName;
        private ListView lstCart;
        private ColumnHeader chCartProductName;
        private ColumnHeader chCartProductQty;
        private ColumnHeader chCartProductDiscount;
        private ColumnHeader chCartProductUnitPrice;
        private ColumnHeader chCartProductTotalPrice;
        private Label lblTotalSale;
        private Button btnFinalizeSale;
        private Label lblInstallments;
        private NumericUpDown numInstallments;
        private Button btnRequestAuth;
        private Label lblDiscount;
        private NumericUpDown numDiscount;
        private ColumnHeader chCartGhost;
        private Label lblCart;
    }
}