namespace UserManagementSystem.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

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
            txtSearchCustomer = new TextBox();
            btnSearch = new Button();
            btnPay = new Button();
            lblTotalWithFine = new Label();
            lstPendingPayments = new ListView();
            SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(12, 12);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(200, 23);
            txtSearchCustomer.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(220, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Client";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(12, 260);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(150, 40);
            btnPay.TabIndex = 3;
            btnPay.Text = "Confirm Payment";
            btnPay.Click += btnPay_Click;
            // 
            // lblTotalWithFine
            // 
            lblTotalWithFine.Location = new Point(0, 0);
            lblTotalWithFine.Name = "lblTotalWithFine";
            lblTotalWithFine.Size = new Size(100, 23);
            lblTotalWithFine.TabIndex = 0;
            // 
            // lstPendingPayments
            // 
            lstPendingPayments.FullRowSelect = true;
            lstPendingPayments.Location = new Point(12, 50);
            lstPendingPayments.Name = "lstPendingPayments";
            lstPendingPayments.Size = new Size(400, 200);
            lstPendingPayments.TabIndex = 2;
            lstPendingPayments.UseCompatibleStateImageBehavior = false;
            lstPendingPayments.View = View.Details;
            lstPendingPayments.SelectedIndexChanged += lstPendingPayments_SelectedIndexChanged;
            // 
            // PaymentForm
            // 
            ClientSize = new Size(434, 311);
            Controls.Add(txtSearchCustomer);
            Controls.Add(btnSearch);
            Controls.Add(lstPendingPayments);
            Controls.Add(btnPay);
            Name = "PaymentForm";
            Text = "Cashier - Payment Registry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalWithFine;
        private ListView lstPendingPayments;
    }
}