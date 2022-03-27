namespace MMStore
{
    partial class frmUserDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.subHeadLbl = new System.Windows.Forms.Label();
            this.appLbl = new System.Windows.Forms.Label();
            this.logedUserLbl = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripUser";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shops";
            // 
            // subHeadLbl
            // 
            this.subHeadLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subHeadLbl.AutoSize = true;
            this.subHeadLbl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subHeadLbl.ForeColor = System.Drawing.Color.Orange;
            this.subHeadLbl.Location = new System.Drawing.Point(378, 263);
            this.subHeadLbl.Name = "subHeadLbl";
            this.subHeadLbl.Size = new System.Drawing.Size(176, 16);
            this.subHeadLbl.TabIndex = 7;
            this.subHeadLbl.Text = "Billing and Inventory";
            // 
            // appLbl
            // 
            this.appLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appLbl.AutoSize = true;
            this.appLbl.Location = new System.Drawing.Point(419, 246);
            this.appLbl.Name = "appLbl";
            this.appLbl.Size = new System.Drawing.Size(25, 13);
            this.appLbl.TabIndex = 8;
            this.appLbl.Text = "MM";
            // 
            // logedUserLbl
            // 
            this.logedUserLbl.AutoSize = true;
            this.logedUserLbl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logedUserLbl.ForeColor = System.Drawing.Color.Orange;
            this.logedUserLbl.Location = new System.Drawing.Point(65, 48);
            this.logedUserLbl.Name = "logedUserLbl";
            this.logedUserLbl.Size = new System.Drawing.Size(48, 16);
            this.logedUserLbl.TabIndex = 4;
            this.logedUserLbl.Text = "Admin";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(28, 48);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User : ";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 420);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1000, 26);
            this.panelFooter.TabIndex = 9;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFooter.Location = new System.Drawing.Point(419, 7);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(109, 13);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = " Developped by WLP";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 446);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subHeadLbl);
            this.Controls.Add(this.appLbl);
            this.Controls.Add(this.logedUserLbl);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subHeadLbl;
        private System.Windows.Forms.Label appLbl;
        private System.Windows.Forms.Label logedUserLbl;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}