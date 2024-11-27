namespace Inventry_Management_System
{
    partial class Inventry_Management_SystemMDI
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdHomePage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuStrip_Master = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuStrip_Master.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1320, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.CmdHomePage);
            this.pnlTitle.Controls.Add(this.panel4);
            this.pnlTitle.Controls.Add(this.lblLogOut);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1320, 101);
            this.pnlTitle.TabIndex = 4;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(622, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Hardware Material Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 53);
            this.label1.TabIndex = 30;
            this.label1.Text = "YOGI  DISTRIBUTORS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmdHomePage
            // 
            this.CmdHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdHomePage.BackgroundImage = global::Inventry_Management_System.Properties.Resources.home_page_icon_orange_round_sign_vector_20468855;
            this.CmdHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdHomePage.Location = new System.Drawing.Point(1249, 33);
            this.CmdHomePage.Name = "CmdHomePage";
            this.CmdHomePage.Size = new System.Drawing.Size(44, 38);
            this.CmdHomePage.TabIndex = 29;
            this.CmdHomePage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Inventry_Management_System.Properties.Resources._333;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 101);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.White;
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Black;
            this.lblLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogOut.Location = new System.Drawing.Point(1165, 41);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(77, 21);
            this.lblLogOut.TabIndex = 26;
            this.lblLogOut.Text = "LOG OUT";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.MenuStrip_Master);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 588);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MenuStrip_Master
            // 
            this.MenuStrip_Master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.MenuStrip_Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStrip_Master.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.MenuStrip_Master.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuStrip_Master.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Master.Margin = new System.Windows.Forms.Padding(4);
            this.MenuStrip_Master.Name = "MenuStrip_Master";
            this.MenuStrip_Master.Padding = new System.Windows.Forms.Padding(15, 15, 15, 2);
            this.MenuStrip_Master.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip_Master.Size = new System.Drawing.Size(317, 199);
            this.MenuStrip_Master.TabIndex = 7;
            this.MenuStrip_Master.Text = "Masters";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.customerToolStripMenuItem1});
            this.mastersToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastersToolStripMenuItem.ForeColor = System.Drawing.Color.FloralWhite;
            this.mastersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mastersToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 20, 4, 0);
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(286, 50);
            this.mastersToolStripMenuItem.Text = "Masters";
            this.mastersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mastersToolStripMenuItem.Click += new System.EventHandler(this.mastersToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.customerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 5, 3, 1);
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.customerToolStripMenuItem.Text = "Material";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.vendorToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.vendorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.customerToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.customerToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(159, 34);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountledgerToolStripMenuItem,
            this.ledgerToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.Color.FloralWhite;
            this.transactionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(286, 50);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountledgerToolStripMenuItem
            // 
            this.accountledgerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.accountledgerToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.accountledgerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.accountledgerToolStripMenuItem.Name = "accountledgerToolStripMenuItem";
            this.accountledgerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.accountledgerToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.accountledgerToolStripMenuItem.Text = "Purchase";
            this.accountledgerToolStripMenuItem.Click += new System.EventHandler(this.accountledgerToolStripMenuItem_Click);
            // 
            // ledgerToolStripMenuItem
            // 
            this.ledgerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.ledgerToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.ledgerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            this.ledgerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.ledgerToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.ledgerToolStripMenuItem.Text = "Sales";
            this.ledgerToolStripMenuItem.Click += new System.EventHandler(this.ledgerToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.stockToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.configurationToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationToolStripMenuItem.ForeColor = System.Drawing.Color.FloralWhite;
            this.configurationToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configurationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(286, 50);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.createUserToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.createUserToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnlStatus.Controls.Add(this.label2);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 689);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1320, 38);
            this.pnlStatus.TabIndex = 0;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatus_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "@ All rights reserved by Akash Chougule and Team";
            // 
            // Inventry_Management_SystemMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "Inventry_Management_SystemMDI";
            this.Text = "Yogi Distributors";
            this.Load += new System.EventHandler(this.Inventry_Management_SystemMDI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuStrip_Master.ResumeLayout(false);
            this.MenuStrip_Master.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.MenuStrip MenuStrip_Master;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Button CmdHomePage;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
    }
}



