namespace UserManagementSystem.Forms
{
    partial class StockReformForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            lblStockTitle = new Label();
            grpActions = new GroupBox();
            pnlActions = new TableLayoutPanel();
            lblShowLowStock = new Label();
            btnLowStock = new Button();
            ColumnProductId = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductStock = new DataGridViewTextBoxColumn();
            ColumunMinStock = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpActions.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblStockTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(grpActions, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.8421059F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductId, ColumnProductName, ColumnProductStock, ColumunMinStock });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(43, 50);
            dataGridView1.Name = "dataGridView1";
            tableLayoutPanel1.SetRowSpan(dataGridView1, 2);
            dataGridView1.Size = new Size(714, 230);
            dataGridView1.TabIndex = 0;
            // 
            // lblStockTitle
            // 
            lblStockTitle.AutoSize = true;
            lblStockTitle.BackColor = Color.FromArgb(0, 53, 123);
            tableLayoutPanel1.SetColumnSpan(lblStockTitle, 2);
            lblStockTitle.Dock = DockStyle.Fill;
            lblStockTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockTitle.ForeColor = Color.White;
            lblStockTitle.Location = new Point(43, 0);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(714, 47);
            lblStockTitle.TabIndex = 1;
            lblStockTitle.Text = "Stock Reports";
            lblStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpActions
            // 
            tableLayoutPanel1.SetColumnSpan(grpActions, 2);
            grpActions.Controls.Add(pnlActions);
            grpActions.Dock = DockStyle.Fill;
            grpActions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpActions.Location = new Point(43, 286);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(714, 161);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // pnlActions
            // 
            pnlActions.ColumnCount = 6;
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlActions.Controls.Add(lblShowLowStock, 0, 0);
            pnlActions.Controls.Add(btnLowStock, 1, 0);
            pnlActions.Location = new Point(6, 28);
            pnlActions.Name = "pnlActions";
            pnlActions.RowCount = 4;
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.Size = new Size(702, 124);
            pnlActions.TabIndex = 0;
            // 
            // lblShowLowStock
            // 
            lblShowLowStock.AutoSize = true;
            lblShowLowStock.Dock = DockStyle.Fill;
            lblShowLowStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowLowStock.Location = new Point(3, 0);
            lblShowLowStock.Name = "lblShowLowStock";
            lblShowLowStock.Size = new Size(345, 31);
            lblShowLowStock.TabIndex = 0;
            lblShowLowStock.Text = "Show products with low stock:";
            lblShowLowStock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLowStock
            // 
            pnlActions.SetColumnSpan(btnLowStock, 2);
            btnLowStock.Dock = DockStyle.Fill;
            btnLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.Location = new Point(354, 3);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(134, 25);
            btnLowStock.TabIndex = 1;
            btnLowStock.Text = "Show";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // ColumnProductId
            // 
            ColumnProductId.HeaderText = "Product ID";
            ColumnProductId.Name = "ColumnProductId";
            ColumnProductId.ReadOnly = true;
            ColumnProductId.Resizable = DataGridViewTriState.False;
            ColumnProductId.Width = 60;
            // 
            // ColumnProductName
            // 
            ColumnProductName.HeaderText = "Product Name";
            ColumnProductName.Name = "ColumnProductName";
            ColumnProductName.ReadOnly = true;
            ColumnProductName.Resizable = DataGridViewTriState.False;
            ColumnProductName.Width = 280;
            // 
            // columnProductStock
            // 
            ColumnProductStock.HeaderText = "Current Stock";
            ColumnProductStock.Name = "columnProductStock";
            ColumnProductStock.ReadOnly = true;
            ColumnProductStock.Resizable = DataGridViewTriState.False;
            ColumnProductStock.Width = 180;
            // 
            // columunMinStock
            // 
            ColumunMinStock.HeaderText = "Minimum Stock";
            ColumunMinStock.Name = "columunMinStock";
            ColumunMinStock.ReadOnly = true;
            ColumunMinStock.Resizable = DataGridViewTriState.False;
            ColumunMinStock.Width = 151;
            // 
            // StockReformForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "StockReformForm";
            ShowIcon = false;
            Text = "StockReformForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpActions.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label lblStockTitle;
        private GroupBox grpActions;
        private TableLayoutPanel pnlActions;
        private Label lblShowLowStock;
        private Button btnLowStock;
        private DataGridViewTextBoxColumn ColumnProductId;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnProductStock;
        private DataGridViewTextBoxColumn ColumunMinStock;
    }
}