namespace UserManagementSystem.Forms
{
    partial class StockReportForm
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
            dgvStock = new DataGridView();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductStock = new DataGridViewTextBoxColumn();
            ColumunMinStock = new DataGridViewTextBoxColumn();
            lblStockTitle = new Label();
            grpActions = new GroupBox();
            pnlActions = new TableLayoutPanel();
            lblShowLowStock = new Label();
            btnLowStock = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
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
            tableLayoutPanel1.Controls.Add(dgvStock, 0, 1);
            tableLayoutPanel1.Controls.Add(lblStockTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(grpActions, 0, 3);
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
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { ColumnProductName, ColumnProductStock, ColumunMinStock });
            tableLayoutPanel1.SetColumnSpan(dgvStock, 4);
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(3, 50);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(dgvStock, 2);
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(794, 230);
            dgvStock.TabIndex = 0;
            // 
            // ColumnProductName
            // 
            ColumnProductName.HeaderText = "Product Name";
            ColumnProductName.Name = "ColumnProductName";
            ColumnProductName.ReadOnly = true;
            ColumnProductName.Resizable = DataGridViewTriState.False;
            // 
            // ColumnProductStock
            // 
            ColumnProductStock.HeaderText = "Current Stock";
            ColumnProductStock.Name = "ColumnProductStock";
            ColumnProductStock.ReadOnly = true;
            ColumnProductStock.Resizable = DataGridViewTriState.False;
            // 
            // ColumunMinStock
            // 
            ColumunMinStock.HeaderText = "Minimum Stock";
            ColumunMinStock.Name = "ColumunMinStock";
            ColumunMinStock.ReadOnly = true;
            ColumunMinStock.Resizable = DataGridViewTriState.False;
            // 
            // lblStockTitle
            // 
            lblStockTitle.AutoSize = true;
            lblStockTitle.BackColor = Color.FromArgb(0, 53, 123);
            tableLayoutPanel1.SetColumnSpan(lblStockTitle, 4);
            lblStockTitle.Dock = DockStyle.Fill;
            lblStockTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockTitle.ForeColor = Color.White;
            lblStockTitle.Location = new Point(3, 0);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(794, 47);
            lblStockTitle.TabIndex = 1;
            lblStockTitle.Text = "Stock Reports";
            lblStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpActions
            // 
            tableLayoutPanel1.SetColumnSpan(grpActions, 4);
            grpActions.Controls.Add(pnlActions);
            grpActions.Dock = DockStyle.Fill;
            grpActions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpActions.Location = new Point(3, 286);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(794, 161);
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
            pnlActions.Controls.Add(lblShowLowStock, 1, 0);
            pnlActions.Controls.Add(btnLowStock, 4, 0);
            pnlActions.Dock = DockStyle.Fill;
            pnlActions.Location = new Point(3, 25);
            pnlActions.Name = "pnlActions";
            pnlActions.RowCount = 4;
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlActions.Size = new Size(788, 133);
            pnlActions.TabIndex = 0;
            // 
            // lblShowLowStock
            // 
            lblShowLowStock.AutoSize = true;
            pnlActions.SetColumnSpan(lblShowLowStock, 3);
            lblShowLowStock.Dock = DockStyle.Fill;
            lblShowLowStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowLowStock.Location = new Point(397, 0);
            lblShowLowStock.Name = "lblShowLowStock";
            lblShowLowStock.Size = new Size(228, 33);
            lblShowLowStock.TabIndex = 0;
            lblShowLowStock.Text = "Show products with low stock:";
            lblShowLowStock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLowStock
            // 
            pnlActions.SetColumnSpan(btnLowStock, 2);
            btnLowStock.Dock = DockStyle.Fill;
            btnLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.Location = new Point(631, 3);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(154, 27);
            btnLowStock.TabIndex = 1;
            btnLowStock.Text = "Show";
            btnLowStock.UseVisualStyleBackColor = true;
            // 
            // StockReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "StockReportForm";
            ShowIcon = false;
            Text = "StockReformForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            grpActions.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvStock;
        private Label lblStockTitle;
        private GroupBox grpActions;
        private TableLayoutPanel pnlActions;
        private Label lblShowLowStock;
        private Button btnLowStock;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnProductStock;
        private DataGridViewTextBoxColumn ColumunMinStock;
    }
}