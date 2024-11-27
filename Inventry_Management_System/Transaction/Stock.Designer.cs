namespace Inventry_Management_System.Transaction
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_MaterialType = new System.Windows.Forms.ComboBox();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.Cmd_Report = new System.Windows.Forms.Button();
            this.CMB_MaterialName = new System.Windows.Forms.ComboBox();
            this.LblMaterialName = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBAllRecord = new System.Windows.Forms.RadioButton();
            this.RBParticularRecord = new System.Windows.Forms.RadioButton();
            this.DGV_StockDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockdetails = new System.Windows.Forms.Label();
            this.GrpBoxCustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StockDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxCustomerDetails
            // 
            this.GrpBoxCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxCustomerDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox2);
            this.GrpBoxCustomerDetails.Controls.Add(this.panel1);
            this.GrpBoxCustomerDetails.Controls.Add(this.DGV_StockDetails);
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox1);
            this.GrpBoxCustomerDetails.Location = new System.Drawing.Point(1, 1);
            this.GrpBoxCustomerDetails.Name = "GrpBoxCustomerDetails";
            this.GrpBoxCustomerDetails.Size = new System.Drawing.Size(871, 618);
            this.GrpBoxCustomerDetails.TabIndex = 9;
            this.GrpBoxCustomerDetails.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cmb_MaterialType);
            this.groupBox2.Controls.Add(this.lblMaterialType);
            this.groupBox2.Controls.Add(this.Cmd_Report);
            this.groupBox2.Controls.Add(this.CMB_MaterialName);
            this.groupBox2.Controls.Add(this.LblMaterialName);
            this.groupBox2.Controls.Add(this.BtnShow);
            this.groupBox2.Location = new System.Drawing.Point(299, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 96);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmb_MaterialType
            // 
            this.cmb_MaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaterialType.FormattingEnabled = true;
            this.cmb_MaterialType.Location = new System.Drawing.Point(133, 60);
            this.cmb_MaterialType.Name = "cmb_MaterialType";
            this.cmb_MaterialType.Size = new System.Drawing.Size(256, 21);
            this.cmb_MaterialType.TabIndex = 153;
            this.cmb_MaterialType.Visible = false;
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(25, 63);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(94, 15);
            this.lblMaterialType.TabIndex = 152;
            this.lblMaterialType.Text = "Material Type";
            this.lblMaterialType.Visible = false;
            // 
            // Cmd_Report
            // 
            this.Cmd_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.Cmd_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Report.Image = global::Inventry_Management_System.Properties.Resources.iconfinder_Report_669954;
            this.Cmd_Report.Location = new System.Drawing.Point(324, 43);
            this.Cmd_Report.Name = "Cmd_Report";
            this.Cmd_Report.Size = new System.Drawing.Size(106, 30);
            this.Cmd_Report.TabIndex = 151;
            this.Cmd_Report.Text = "  &Report";
            this.Cmd_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cmd_Report.UseVisualStyleBackColor = false;
            this.Cmd_Report.Click += new System.EventHandler(this.Cmd_Report_Click);
            // 
            // CMB_MaterialName
            // 
            this.CMB_MaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_MaterialName.FormattingEnabled = true;
            this.CMB_MaterialName.Location = new System.Drawing.Point(133, 22);
            this.CMB_MaterialName.Name = "CMB_MaterialName";
            this.CMB_MaterialName.Size = new System.Drawing.Size(256, 21);
            this.CMB_MaterialName.TabIndex = 149;
            this.CMB_MaterialName.Visible = false;
            // 
            // LblMaterialName
            // 
            this.LblMaterialName.AutoSize = true;
            this.LblMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterialName.Location = new System.Drawing.Point(25, 25);
            this.LblMaterialName.Name = "LblMaterialName";
            this.LblMaterialName.Size = new System.Drawing.Size(102, 15);
            this.LblMaterialName.TabIndex = 148;
            this.LblMaterialName.Text = "Material Name";
            this.LblMaterialName.Visible = false;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Image = global::Inventry_Management_System.Properties.Resources.Save1;
            this.BtnShow.Location = new System.Drawing.Point(125, 43);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(106, 30);
            this.BtnShow.TabIndex = 147;
            this.BtnShow.Text = "    &Show";
            this.BtnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBAllRecord);
            this.panel1.Controls.Add(this.RBParticularRecord);
            this.panel1.Location = new System.Drawing.Point(13, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 33);
            this.panel1.TabIndex = 150;
            this.panel1.Visible = false;
            // 
            // RBAllRecord
            // 
            this.RBAllRecord.AutoSize = true;
            this.RBAllRecord.Checked = true;
            this.RBAllRecord.Location = new System.Drawing.Point(23, 7);
            this.RBAllRecord.Name = "RBAllRecord";
            this.RBAllRecord.Size = new System.Drawing.Size(79, 17);
            this.RBAllRecord.TabIndex = 150;
            this.RBAllRecord.TabStop = true;
            this.RBAllRecord.Text = "All Records";
            this.RBAllRecord.UseVisualStyleBackColor = true;
            this.RBAllRecord.CheckedChanged += new System.EventHandler(this.RBAllRecord_CheckedChanged);
            // 
            // RBParticularRecord
            // 
            this.RBParticularRecord.AutoSize = true;
            this.RBParticularRecord.Location = new System.Drawing.Point(124, 7);
            this.RBParticularRecord.Name = "RBParticularRecord";
            this.RBParticularRecord.Size = new System.Drawing.Size(107, 17);
            this.RBParticularRecord.TabIndex = 151;
            this.RBParticularRecord.Text = "Particular Record";
            this.RBParticularRecord.UseVisualStyleBackColor = true;
            this.RBParticularRecord.CheckedChanged += new System.EventHandler(this.RBParticularRecord_CheckedChanged);
            // 
            // DGV_StockDetails
            // 
            this.DGV_StockDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_StockDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_StockDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_StockDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_StockDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_StockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_StockDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_StockDetails.Location = new System.Drawing.Point(13, 109);
            this.DGV_StockDetails.Name = "DGV_StockDetails";
            this.DGV_StockDetails.RowHeadersVisible = false;
            this.DGV_StockDetails.Size = new System.Drawing.Size(845, 491);
            this.DGV_StockDetails.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblStockdetails);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblStockdetails
            // 
            this.lblStockdetails.AutoSize = true;
            this.lblStockdetails.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockdetails.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStockdetails.Location = new System.Drawing.Point(29, 21);
            this.lblStockdetails.Name = "lblStockdetails";
            this.lblStockdetails.Size = new System.Drawing.Size(138, 27);
            this.lblStockdetails.TabIndex = 23;
            this.lblStockdetails.Text = "Stock Details";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 619);
            this.Controls.Add(this.GrpBoxCustomerDetails);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.GrpBoxCustomerDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StockDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxCustomerDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.DataGridView DGV_StockDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStockdetails;
        public System.Windows.Forms.ComboBox CMB_MaterialName;
        private System.Windows.Forms.Label LblMaterialName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBAllRecord;
        private System.Windows.Forms.RadioButton RBParticularRecord;
        private System.Windows.Forms.Button Cmd_Report;
        public System.Windows.Forms.ComboBox cmb_MaterialType;
        private System.Windows.Forms.Label lblMaterialType;
    }
}