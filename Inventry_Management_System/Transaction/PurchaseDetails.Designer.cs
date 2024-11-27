namespace Inventry_Management_System.Transaction
{
    partial class PurchaseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBoxProductionDetails = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonPrev = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonLast = new System.Windows.Forms.ToolStripButton();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtSearchByVendor = new System.Windows.Forms.TextBox();
            this.LblVendorName = new System.Windows.Forms.Label();
            this.DGV_PurchaseDetails = new System.Windows.Forms.DataGridView();
            this.GbProdDetail = new System.Windows.Forms.GroupBox();
            this.lblpurchDetails = new System.Windows.Forms.Label();
            this.GrpBoxProductionDetails.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchaseDetails)).BeginInit();
            this.GbProdDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxProductionDetails
            // 
            this.GrpBoxProductionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxProductionDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxProductionDetails.Controls.Add(this.toolStrip1);
            this.GrpBoxProductionDetails.Controls.Add(this.BtnCreate);
            this.GrpBoxProductionDetails.Controls.Add(this.TxtSearchByVendor);
            this.GrpBoxProductionDetails.Controls.Add(this.LblVendorName);
            this.GrpBoxProductionDetails.Controls.Add(this.DGV_PurchaseDetails);
            this.GrpBoxProductionDetails.Controls.Add(this.GbProdDetail);
            this.GrpBoxProductionDetails.Location = new System.Drawing.Point(0, -1);
            this.GrpBoxProductionDetails.Name = "GrpBoxProductionDetails";
            this.GrpBoxProductionDetails.Size = new System.Drawing.Size(814, 599);
            this.GrpBoxProductionDetails.TabIndex = 7;
            this.GrpBoxProductionDetails.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonFirst,
            this.ToolStripButtonPrev,
            this.ToolStripButtonNext,
            this.ToolStripButtonLast});
            this.toolStrip1.Location = new System.Drawing.Point(250, 552);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButtonFirst
            // 
            this.ToolStripButtonFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonFirst.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonFirst.Image")));
            this.ToolStripButtonFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonFirst.Name = "ToolStripButtonFirst";
            this.ToolStripButtonFirst.Size = new System.Drawing.Size(62, 22);
            this.ToolStripButtonFirst.Text = "First Page";
            this.ToolStripButtonFirst.Click += new System.EventHandler(this.ToolStripButtonFirst_Click);
            // 
            // ToolStripButtonPrev
            // 
            this.ToolStripButtonPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonPrev.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonPrev.Image")));
            this.ToolStripButtonPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonPrev.Name = "ToolStripButtonPrev";
            this.ToolStripButtonPrev.Size = new System.Drawing.Size(85, 22);
            this.ToolStripButtonPrev.Text = "Previous Page";
            this.ToolStripButtonPrev.Click += new System.EventHandler(this.ToolStripButtonPrev_Click);
            // 
            // ToolStripButtonNext
            // 
            this.ToolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonNext.Image")));
            this.ToolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonNext.Name = "ToolStripButtonNext";
            this.ToolStripButtonNext.Size = new System.Drawing.Size(65, 22);
            this.ToolStripButtonNext.Text = "Next Page";
            this.ToolStripButtonNext.Click += new System.EventHandler(this.ToolStripButtonNext_Click);
            // 
            // ToolStripButtonLast
            // 
            this.ToolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonLast.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonLast.Image")));
            this.ToolStripButtonLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonLast.Name = "ToolStripButtonLast";
            this.ToolStripButtonLast.Size = new System.Drawing.Size(61, 22);
            this.ToolStripButtonLast.Text = "Last Page";
            this.ToolStripButtonLast.Click += new System.EventHandler(this.ToolStripButtonLast_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Image = global::Inventry_Management_System.Properties.Resources.New;
            this.BtnCreate.Location = new System.Drawing.Point(688, 93);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(104, 31);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = " &Create";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtSearchByVendor
            // 
            this.TxtSearchByVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchByVendor.Location = new System.Drawing.Point(269, 98);
            this.TxtSearchByVendor.Name = "TxtSearchByVendor";
            this.TxtSearchByVendor.Size = new System.Drawing.Size(221, 21);
            this.TxtSearchByVendor.TabIndex = 4;
            this.TxtSearchByVendor.TextChanged += new System.EventHandler(this.TxtSearchByProdMaterial_TextChanged);
            // 
            // LblVendorName
            // 
            this.LblVendorName.AutoSize = true;
            this.LblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorName.Location = new System.Drawing.Point(22, 98);
            this.LblVendorName.Name = "LblVendorName";
            this.LblVendorName.Size = new System.Drawing.Size(220, 20);
            this.LblVendorName.TabIndex = 3;
            this.LblVendorName.Text = "Search By Vendor Name  :";
            // 
            // DGV_PurchaseDetails
            // 
            this.DGV_PurchaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_PurchaseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PurchaseDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_PurchaseDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PurchaseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PurchaseDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PurchaseDetails.Location = new System.Drawing.Point(19, 141);
            this.DGV_PurchaseDetails.Name = "DGV_PurchaseDetails";
            this.DGV_PurchaseDetails.RowHeadersVisible = false;
            this.DGV_PurchaseDetails.Size = new System.Drawing.Size(773, 408);
            this.DGV_PurchaseDetails.TabIndex = 2;
            this.DGV_PurchaseDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ProdMaterialDetails_CellClick);
            // 
            // GbProdDetail
            // 
            this.GbProdDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbProdDetail.Controls.Add(this.lblpurchDetails);
            this.GbProdDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbProdDetail.Location = new System.Drawing.Point(3, 16);
            this.GbProdDetail.Name = "GbProdDetail";
            this.GbProdDetail.Size = new System.Drawing.Size(808, 55);
            this.GbProdDetail.TabIndex = 1;
            this.GbProdDetail.TabStop = false;
            // 
            // lblpurchDetails
            // 
            this.lblpurchDetails.AutoSize = true;
            this.lblpurchDetails.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurchDetails.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblpurchDetails.Location = new System.Drawing.Point(36, 16);
            this.lblpurchDetails.Name = "lblpurchDetails";
            this.lblpurchDetails.Size = new System.Drawing.Size(172, 27);
            this.lblpurchDetails.TabIndex = 23;
            this.lblpurchDetails.Text = "Purchase Details";
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 593);
            this.Controls.Add(this.GrpBoxProductionDetails);
            this.Name = "PurchaseDetails";
            this.Text = "Production  Details";
            this.Load += new System.EventHandler(this.ProductionDetails_Load);
            this.GrpBoxProductionDetails.ResumeLayout(false);
            this.GrpBoxProductionDetails.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchaseDetails)).EndInit();
            this.GbProdDetail.ResumeLayout(false);
            this.GbProdDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxProductionDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonFirst;
        private System.Windows.Forms.ToolStripButton ToolStripButtonPrev;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNext;
        private System.Windows.Forms.ToolStripButton ToolStripButtonLast;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtSearchByVendor;
        private System.Windows.Forms.Label LblVendorName;
        private System.Windows.Forms.DataGridView DGV_PurchaseDetails;
        private System.Windows.Forms.GroupBox GbProdDetail;
        private System.Windows.Forms.Label lblpurchDetails;
    }
}