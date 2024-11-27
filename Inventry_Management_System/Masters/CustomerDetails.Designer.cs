namespace Inventry_Management_System.Masters
{
    partial class CustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBoxMaterialDetails = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonPrev = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonLast = new System.Windows.Forms.ToolStripButton();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtSearchByCustomer = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.DGV_CustomerDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.GrpBoxMaterialDetails.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomerDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxMaterialDetails
            // 
            this.GrpBoxMaterialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxMaterialDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxMaterialDetails.Controls.Add(this.toolStrip1);
            this.GrpBoxMaterialDetails.Controls.Add(this.BtnCreate);
            this.GrpBoxMaterialDetails.Controls.Add(this.TxtSearchByCustomer);
            this.GrpBoxMaterialDetails.Controls.Add(this.LblCustomerName);
            this.GrpBoxMaterialDetails.Controls.Add(this.DGV_CustomerDetails);
            this.GrpBoxMaterialDetails.Controls.Add(this.groupBox1);
            this.GrpBoxMaterialDetails.Location = new System.Drawing.Point(1, -1);
            this.GrpBoxMaterialDetails.Name = "GrpBoxMaterialDetails";
            this.GrpBoxMaterialDetails.Size = new System.Drawing.Size(926, 625);
            this.GrpBoxMaterialDetails.TabIndex = 6;
            this.GrpBoxMaterialDetails.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(306, 578);
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
            this.BtnCreate.Location = new System.Drawing.Point(800, 93);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(104, 31);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = " &Create";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtSearchByCustomer
            // 
            this.TxtSearchByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchByCustomer.Location = new System.Drawing.Point(260, 98);
            this.TxtSearchByCustomer.Name = "TxtSearchByCustomer";
            this.TxtSearchByCustomer.Size = new System.Drawing.Size(221, 21);
            this.TxtSearchByCustomer.TabIndex = 4;
            this.TxtSearchByCustomer.TextChanged += new System.EventHandler(this.TxtSearchByCustomer_TextChanged);
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(18, 98);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(239, 20);
            this.LblCustomerName.TabIndex = 3;
            this.LblCustomerName.Text = "Search By Customer Name  :";
            // 
            // DGV_CustomerDetails
            // 
            this.DGV_CustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CustomerDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_CustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CustomerDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CustomerDetails.Location = new System.Drawing.Point(19, 141);
            this.DGV_CustomerDetails.Name = "DGV_CustomerDetails";
            this.DGV_CustomerDetails.RowHeadersVisible = false;
            this.DGV_CustomerDetails.Size = new System.Drawing.Size(885, 422);
            this.DGV_CustomerDetails.TabIndex = 2;
            this.DGV_CustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CustomerDetails_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblCustomerDetails);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCustomerDetails.Location = new System.Drawing.Point(36, 16);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(177, 27);
            this.lblCustomerDetails.TabIndex = 23;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 624);
            this.Controls.Add(this.GrpBoxMaterialDetails);
            this.Name = "CustomerDetails";
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialDetails_KeyDown);
            this.GrpBoxMaterialDetails.ResumeLayout(false);
            this.GrpBoxMaterialDetails.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomerDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxMaterialDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonFirst;
        private System.Windows.Forms.ToolStripButton ToolStripButtonPrev;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNext;
        private System.Windows.Forms.ToolStripButton ToolStripButtonLast;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtSearchByCustomer;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.DataGridView DGV_CustomerDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCustomerDetails;
    }
}