namespace Inventry_Management_System.Authentication
{
    partial class NewUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonPrev = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonLast = new System.Windows.Forms.ToolStripButton();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtSearchByUserName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.DGV_NewUserDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbluserdtl = new System.Windows.Forms.Label();
            this.GrpBoxCustomerDetails.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NewUserDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxCustomerDetails
            // 
            this.GrpBoxCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxCustomerDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxCustomerDetails.Controls.Add(this.toolStrip1);
            this.GrpBoxCustomerDetails.Controls.Add(this.BtnCreate);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtSearchByUserName);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblName);
            this.GrpBoxCustomerDetails.Controls.Add(this.DGV_NewUserDetails);
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox1);
            this.GrpBoxCustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxCustomerDetails.Name = "GrpBoxCustomerDetails";
            this.GrpBoxCustomerDetails.Size = new System.Drawing.Size(961, 561);
            this.GrpBoxCustomerDetails.TabIndex = 3;
            this.GrpBoxCustomerDetails.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(317, 523);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButtonFirst
            // 
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
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Image = global::Inventry_Management_System.Properties.Resources.New;
            this.BtnCreate.Location = new System.Drawing.Point(841, 84);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(104, 31);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "  &Create";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtSearchByUserName
            // 
            this.TxtSearchByUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchByUserName.Location = new System.Drawing.Point(230, 87);
            this.TxtSearchByUserName.Name = "TxtSearchByUserName";
            this.TxtSearchByUserName.Size = new System.Drawing.Size(221, 21);
            this.TxtSearchByUserName.TabIndex = 4;
            this.TxtSearchByUserName.TextChanged += new System.EventHandler(this.TxtSearchByUserName_TextChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(18, 90);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(180, 17);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Search By user Name  :";
            this.LblName.Click += new System.EventHandler(this.LblChemicalName_Click);
            // 
            // DGV_NewUserDetails
            // 
            this.DGV_NewUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_NewUserDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_NewUserDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_NewUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_NewUserDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_NewUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_NewUserDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_NewUserDetails.Location = new System.Drawing.Point(16, 129);
            this.DGV_NewUserDetails.Name = "DGV_NewUserDetails";
            this.DGV_NewUserDetails.RowHeadersVisible = false;
            this.DGV_NewUserDetails.Size = new System.Drawing.Size(930, 391);
            this.DGV_NewUserDetails.TabIndex = 2;
            this.DGV_NewUserDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_NewUserDetails_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lbluserdtl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbluserdtl
            // 
            this.lbluserdtl.AutoSize = true;
            this.lbluserdtl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserdtl.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbluserdtl.Location = new System.Drawing.Point(36, 16);
            this.lbluserdtl.Name = "lbluserdtl";
            this.lbluserdtl.Size = new System.Drawing.Size(128, 27);
            this.lbluserdtl.TabIndex = 23;
            this.lbluserdtl.Text = "User Details";
            this.lbluserdtl.Click += new System.EventHandler(this.lbluserdtl_Click);
            // 
            // NewUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 560);
            this.Controls.Add(this.GrpBoxCustomerDetails);
            this.Name = "NewUserDetails";
            this.Text = "New User Details";
            this.Load += new System.EventHandler(this.NewUserDetails_Load);
            this.GrpBoxCustomerDetails.ResumeLayout(false);
            this.GrpBoxCustomerDetails.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NewUserDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxCustomerDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonFirst;
        private System.Windows.Forms.ToolStripButton ToolStripButtonPrev;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNext;
        private System.Windows.Forms.ToolStripButton ToolStripButtonLast;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtSearchByUserName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridView DGV_NewUserDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbluserdtl;
    }
}