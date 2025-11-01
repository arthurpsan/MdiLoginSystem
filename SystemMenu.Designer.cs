namespace MdiLoginSystem
{
    partial class SystemMenu
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
            userToolStripMenuItem = new ToolStripMenuItem();
            managerToolStripMenuItem = new ToolStripMenuItem();
            reporToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mnuSystem.SuspendLayout();
            SuspendLayout();
            // 
            // mnuSystem
            // 
            mnuSystem.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, registerToolStripMenuItem, reporToolStripMenuItem, helpToolStripMenuItem });
            mnuSystem.Location = new Point(0, 0);
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(800, 24);
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
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, managerToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(180, 22);
            userToolStripMenuItem.Text = "User";
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(180, 22);
            managerToolStripMenuItem.Text = "Manager";
            // 
            // reporToolStripMenuItem
            // 
            reporToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            reporToolStripMenuItem.Name = "reporToolStripMenuItem";
            reporToolStripMenuItem.Size = new Size(54, 20);
            reporToolStripMenuItem.Text = "Report";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(180, 22);
            usersToolStripMenuItem.Text = "Users";
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
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // SystemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuSystem);
            IsMdiContainer = true;
            MainMenuStrip = mnuSystem;
            Name = "SystemMenu";
            ShowIcon = false;
            Text = "System - Main Menu - [v 0.0.1]";
            WindowState = FormWindowState.Maximized;
            mnuSystem.ResumeLayout(false);
            mnuSystem.PerformLayout();
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
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem managerToolStripMenuItem;
    }
}