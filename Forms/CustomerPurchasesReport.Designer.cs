namespace UserManagementSystem.Forms
{
    partial class CustomerPurchasesReport
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
            label2 = new Label();
            lblComissionReports = new Label();
            listView1 = new ListView();
            textBox1 = new TextBox();
            label1 = new Label();
            listView2 = new ListView();
            lblDescription = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(lblComissionReports, 0, 0);
            tableLayoutPanel1.Controls.Add(listView1, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(listView2, 2, 2);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(403, 57);
            label2.Name = "label2";
            label2.Size = new Size(394, 21);
            label2.TabIndex = 6;
            label2.Text = "Customer List";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblComissionReports
            // 
            lblComissionReports.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblComissionReports, 2);
            lblComissionReports.Dock = DockStyle.Fill;
            lblComissionReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComissionReports.Location = new Point(3, 0);
            lblComissionReports.Name = "lblComissionReports";
            lblComissionReports.Size = new Size(394, 45);
            lblComissionReports.TabIndex = 2;
            lblComissionReports.Text = "Customer Data Reports";
            lblComissionReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 228);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 219);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 29);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(394, 21);
            label1.TabIndex = 4;
            label1.Text = "Search by Customer:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            tableLayoutPanel1.SetColumnSpan(listView2, 2);
            listView2.Dock = DockStyle.Fill;
            listView2.Location = new Point(403, 93);
            listView2.Name = "listView2";
            tableLayoutPanel1.SetRowSpan(listView2, 2);
            listView2.Size = new Size(394, 84);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDescription, 2);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(3, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(394, 45);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "(Exhibits client data for the last 30 days.)";
            lblDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // CustomerPurchasesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "CustomerPurchasesReport";
            ShowIcon = false;
            Text = "PurchasesReport";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private Label lblComissionReports;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ListView listView2;
        private Label lblDescription;
    }
}