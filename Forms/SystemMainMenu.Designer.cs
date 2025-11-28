namespace UserManagementSystem
{
    partial class SystemMainMenu
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
            mnuSystem = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            producttoolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            reporToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            salesDataToolStripMenuItem = new ToolStripMenuItem();
            stockDataToolStripMenuItem = new ToolStripMenuItem();
            CustomerDataToolStripMenuItem = new ToolStripMenuItem();
            comissionDataToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStripAcess = new StatusStrip();
            staAccess = new ToolStripStatusLabel();
            lblLastAccess = new ToolStripStatusLabel();
            mnuSystem.SuspendLayout();
            statusStripAcess.SuspendLayout();
            SuspendLayout();
            // 
            // mnuSystem
            // 
            mnuSystem.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, registerToolStripMenuItem, reporToolStripMenuItem, helpToolStripMenuItem });
            mnuSystem.Location = new Point(0, 0);
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Padding = new Padding(7, 2, 0, 2);
            mnuSystem.Size = new Size(914, 24);
            mnuSystem.TabIndex = 0;
            mnuSystem.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "FIle";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, customerToolStripMenuItem, saleToolStripMenuItem, producttoolStripMenuItem, paymentToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(199, 22);
            employeeToolStripMenuItem.Text = "Employee...";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(199, 22);
            customerToolStripMenuItem.Text = "Customer...";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(199, 22);
            saleToolStripMenuItem.Text = "Sale...";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // producttoolStripMenuItem
            // 
            producttoolStripMenuItem.Name = "producttoolStripMenuItem";
            producttoolStripMenuItem.Size = new Size(199, 22);
            producttoolStripMenuItem.Text = "Product and Category...";
            producttoolStripMenuItem.Click += producttoolStripMenuItem_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(199, 22);
            paymentToolStripMenuItem.Text = "Payment...";
            paymentToolStripMenuItem.Click += paymentToolStripMenuItem_Click;
            // 
            // reporToolStripMenuItem
            // 
            reporToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, salesDataToolStripMenuItem, stockDataToolStripMenuItem, CustomerDataToolStripMenuItem, comissionDataToolStripMenuItem });
            reporToolStripMenuItem.Name = "reporToolStripMenuItem";
            reporToolStripMenuItem.Size = new Size(59, 20);
            reporToolStripMenuItem.Text = "Reports";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(166, 22);
            usersToolStripMenuItem.Text = "User Data...";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // salesDataToolStripMenuItem
            // 
            salesDataToolStripMenuItem.Name = "salesDataToolStripMenuItem";
            salesDataToolStripMenuItem.Size = new Size(166, 22);
            salesDataToolStripMenuItem.Text = "Sale Data...";
            salesDataToolStripMenuItem.Click += salesDataToolStripMenuItem_Click;
            // 
            // stockDataToolStripMenuItem
            // 
            stockDataToolStripMenuItem.Name = "stockDataToolStripMenuItem";
            stockDataToolStripMenuItem.Size = new Size(166, 22);
            stockDataToolStripMenuItem.Text = "Stock Data...";
            stockDataToolStripMenuItem.Click += stockDataToolStripMenuItem_Click;
            // 
            // CustomerDataToolStripMenuItem
            // 
            CustomerDataToolStripMenuItem.Name = "CustomerDataToolStripMenuItem";
            CustomerDataToolStripMenuItem.Size = new Size(166, 22);
            CustomerDataToolStripMenuItem.Text = "Customer Data...";
            CustomerDataToolStripMenuItem.Click += clientsDataToolStripMenuItem_Click;
            // 
            // comissionDataToolStripMenuItem
            // 
            comissionDataToolStripMenuItem.Name = "comissionDataToolStripMenuItem";
            comissionDataToolStripMenuItem.Size = new Size(166, 22);
            comissionDataToolStripMenuItem.Text = "Comission Data...";
            comissionDataToolStripMenuItem.Click += comissionDataToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStripAcess
            // 
            statusStripAcess.Items.AddRange(new ToolStripItem[] { staAccess, lblLastAccess });
            statusStripAcess.Location = new Point(0, 488);
            statusStripAcess.Name = "statusStripAcess";
            statusStripAcess.Padding = new Padding(1, 0, 16, 0);
            statusStripAcess.Size = new Size(914, 22);
            statusStripAcess.TabIndex = 2;
            statusStripAcess.Text = "statusStrip1";
            // 
            // staAccess
            // 
            staAccess.Name = "staAccess";
            staAccess.Size = new Size(0, 17);
            // 
            // lblLastAccess
            // 
            lblLastAccess.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastAccess.Name = "lblLastAccess";
            lblLastAccess.Size = new Size(131, 17);
            lblLastAccess.Text = "toolStripStatusLabel1";
            // 
            // SystemMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(statusStripAcess);
            Controls.Add(mnuSystem);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = mnuSystem;
            MaximizeBox = false;
            Name = "SystemMainMenu";
            ShowIcon = false;
            Text = "System - Main Menu - [v 0.0.1]";
            WindowState = FormWindowState.Maximized;
            FormClosing += SystemMenu_FormClosing;
            mnuSystem.ResumeLayout(false);
            mnuSystem.PerformLayout();
            statusStripAcess.ResumeLayout(false);
            statusStripAcess.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuSystem;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem reporToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private StatusStrip statusStripAcess;
        private ToolStripStatusLabel staAccess;
        private ToolStripStatusLabel lblLastAccess;
        private ToolStripMenuItem salesDataToolStripMenuItem;
        private ToolStripMenuItem CustomerDataToolStripMenuItem;
        private ToolStripMenuItem comissionDataToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem producttoolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem stockDataToolStripMenuItem;
    }
}