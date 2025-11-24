namespace UserManagementSystem.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 


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
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstPendingPayments = new System.Windows.Forms.ListView();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalWithFine = new System.Windows.Forms.Label();

            // Setup Search Box
            this.txtSearchCustomer.Location = new System.Drawing.Point(12, 12);
            this.txtSearchCustomer.Size = new System.Drawing.Size(200, 20);

            // Setup Search Button
            this.btnSearch.Location = new System.Drawing.Point(220, 10);
            this.btnSearch.Text = "Search Client";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Setup ListView
            this.lstPendingPayments.Location = new System.Drawing.Point(12, 50);
            this.lstPendingPayments.Size = new System.Drawing.Size(400, 200);
            this.lstPendingPayments.View = System.Windows.Forms.View.Details;
            this.lstPendingPayments.FullRowSelect = true;
            this.lstPendingPayments.Columns.Add("Pay ID", 50);
            this.lstPendingPayments.Columns.Add("Purchase", 70);
            this.lstPendingPayments.Columns.Add("Due Date", 100);
            this.lstPendingPayments.Columns.Add("Original Val", 80);
            this.lstPendingPayments.Columns.Add("Total (w/ Fine)", 100);
            this.lstPendingPayments.SelectedIndexChanged += new System.EventHandler(this.lstPendingPayments_SelectedIndexChanged);

            // Setup Pay Button
            this.btnPay.Location = new System.Drawing.Point(12, 260);
            this.btnPay.Text = "Confirm Payment";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);

            // Add Controls
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstPendingPayments);
            this.Controls.Add(this.btnPay);

            this.Text = "Cashier - Payment Registry";
            this.Size = new System.Drawing.Size(450, 350);
        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstPendingPayments; // Columns: ID, Purchase ID, Due Date, Value, Fine
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalWithFine;
    }
}