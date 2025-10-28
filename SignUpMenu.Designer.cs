namespace MdiLoginSystem
{
    partial class SignUpMenu
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
            pnlRegister = new Panel();
            grpSignUp = new GroupBox();
            lblUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlRegister.SuspendLayout();
            grpSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(grpSignUp);
            pnlRegister.Location = new Point(12, 12);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(776, 426);
            pnlRegister.TabIndex = 0;
            // 
            // grpSignUp
            // 
            grpSignUp.Controls.Add(label3);
            grpSignUp.Controls.Add(label2);
            grpSignUp.Controls.Add(label1);
            grpSignUp.Controls.Add(lblUser);
            grpSignUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSignUp.Location = new Point(3, 3);
            grpSignUp.Name = "grpSignUp";
            grpSignUp.Size = new Size(770, 420);
            grpSignUp.TabIndex = 0;
            grpSignUp.TabStop = false;
            grpSignUp.Text = "Sign Up";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(6, 29);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(73, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(73, 113);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(84, 169);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegister);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            pnlRegister.ResumeLayout(false);
            grpSignUp.ResumeLayout(false);
            grpSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private GroupBox grpSignUp;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblUser;
    }
}