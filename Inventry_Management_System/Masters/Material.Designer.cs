namespace Inventry_Management_System.Masters
{
    partial class Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.GrpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.TxtMaterialName = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.lblunitCost = new System.Windows.Forms.Label();
            this.LblMaterialType = new System.Windows.Forms.Label();
            this.TxtMaterialCode = new System.Windows.Forms.TextBox();
            this.LBLId = new System.Windows.Forms.Label();
            this.TxtMaterialDetails = new System.Windows.Forms.TextBox();
            this.LblMaterialCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.lblMaterialDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMaterialMaster = new System.Windows.Forms.Label();
            this.ErrorProviderCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderAlert = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxCustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxCustomerDetails
            // 
            this.GrpBoxCustomerDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxCustomerDetails.Controls.Add(this.txtSalePrice);
            this.GrpBoxCustomerDetails.Controls.Add(this.label1);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtMaterialName);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtPrice);
            this.GrpBoxCustomerDetails.Controls.Add(this.lblunitCost);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblMaterialType);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtMaterialCode);
            this.GrpBoxCustomerDetails.Controls.Add(this.LBLId);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtMaterialDetails);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblMaterialCode);
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox2);
            this.GrpBoxCustomerDetails.Controls.Add(this.lblMaterialDetails);
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox1);
            this.GrpBoxCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpBoxCustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxCustomerDetails.Name = "GrpBoxCustomerDetails";
            this.GrpBoxCustomerDetails.Size = new System.Drawing.Size(641, 514);
            this.GrpBoxCustomerDetails.TabIndex = 4;
            this.GrpBoxCustomerDetails.TabStop = false;
            this.GrpBoxCustomerDetails.Enter += new System.EventHandler(this.GrpBoxCustomerDetails_Enter);
            // 
            // TxtMaterialName
            // 
            this.TxtMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterialName.Location = new System.Drawing.Point(230, 159);
            this.TxtMaterialName.MaxLength = 10;
            this.TxtMaterialName.Name = "TxtMaterialName";
            this.TxtMaterialName.Size = new System.Drawing.Size(365, 21);
            this.TxtMaterialName.TabIndex = 2;
            this.TxtMaterialName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaterialName_Validating);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(230, 204);
            this.TxtPrice.MaxLength = 10;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(365, 21);
            this.TxtPrice.TabIndex = 3;
            // 
            // lblunitCost
            // 
            this.lblunitCost.AutoSize = true;
            this.lblunitCost.BackColor = System.Drawing.Color.Transparent;
            this.lblunitCost.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunitCost.Location = new System.Drawing.Point(36, 201);
            this.lblunitCost.Name = "lblunitCost";
            this.lblunitCost.Size = new System.Drawing.Size(122, 22);
            this.lblunitCost.TabIndex = 149;
            this.lblunitCost.Text = "Purchase Price";
            // 
            // LblMaterialType
            // 
            this.LblMaterialType.AutoSize = true;
            this.LblMaterialType.BackColor = System.Drawing.Color.Transparent;
            this.LblMaterialType.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterialType.Location = new System.Drawing.Point(36, 159);
            this.LblMaterialType.Name = "LblMaterialType";
            this.LblMaterialType.Size = new System.Drawing.Size(119, 22);
            this.LblMaterialType.TabIndex = 144;
            this.LblMaterialType.Text = "Material Name";
            this.LblMaterialType.Click += new System.EventHandler(this.LblMaterialUnit_Click);
            // 
            // TxtMaterialCode
            // 
            this.TxtMaterialCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterialCode.Location = new System.Drawing.Point(230, 118);
            this.TxtMaterialCode.MaxLength = 10;
            this.TxtMaterialCode.Name = "TxtMaterialCode";
            this.TxtMaterialCode.Size = new System.Drawing.Size(365, 21);
            this.TxtMaterialCode.TabIndex = 1;
            // 
            // LBLId
            // 
            this.LBLId.AutoSize = true;
            this.LBLId.Location = new System.Drawing.Point(519, 16);
            this.LBLId.Name = "LBLId";
            this.LBLId.Size = new System.Drawing.Size(0, 13);
            this.LBLId.TabIndex = 15;
            this.LBLId.Visible = false;
            // 
            // TxtMaterialDetails
            // 
            this.TxtMaterialDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterialDetails.Location = new System.Drawing.Point(230, 290);
            this.TxtMaterialDetails.Multiline = true;
            this.TxtMaterialDetails.Name = "TxtMaterialDetails";
            this.TxtMaterialDetails.Size = new System.Drawing.Size(365, 57);
            this.TxtMaterialDetails.TabIndex = 4;
            this.TxtMaterialDetails.TextChanged += new System.EventHandler(this.TxtMaterialSpecification_TextChanged);
            // 
            // LblMaterialCode
            // 
            this.LblMaterialCode.AutoSize = true;
            this.LblMaterialCode.BackColor = System.Drawing.Color.Transparent;
            this.LblMaterialCode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterialCode.Location = new System.Drawing.Point(36, 115);
            this.LblMaterialCode.Name = "LblMaterialCode";
            this.LblMaterialCode.Size = new System.Drawing.Size(114, 22);
            this.LblMaterialCode.TabIndex = 142;
            this.LblMaterialCode.Text = "Material Code";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(87, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 77);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Inventry_Management_System.Properties.Resources.Save1;
            this.BtnSave.Location = new System.Drawing.Point(50, 23);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(97, 37);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "  &Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = global::Inventry_Management_System.Properties.Resources.Delete;
            this.BtnExit.Location = new System.Drawing.Point(313, 23);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 37);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "  &Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = global::Inventry_Management_System.Properties.Resources.Update;
            this.BtnUpdate.Location = new System.Drawing.Point(183, 23);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(97, 37);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = " &Update";
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblMaterialDetails
            // 
            this.lblMaterialDetails.AutoSize = true;
            this.lblMaterialDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterialDetails.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialDetails.Location = new System.Drawing.Point(36, 289);
            this.lblMaterialDetails.Name = "lblMaterialDetails";
            this.lblMaterialDetails.Size = new System.Drawing.Size(126, 22);
            this.lblMaterialDetails.TabIndex = 138;
            this.lblMaterialDetails.Text = "Material Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.LblMaterialMaster);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 55);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // LblMaterialMaster
            // 
            this.LblMaterialMaster.AutoSize = true;
            this.LblMaterialMaster.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterialMaster.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblMaterialMaster.Location = new System.Drawing.Point(36, 16);
            this.LblMaterialMaster.Name = "LblMaterialMaster";
            this.LblMaterialMaster.Size = new System.Drawing.Size(162, 27);
            this.LblMaterialMaster.TabIndex = 14;
            this.LblMaterialMaster.Text = "Material Master";
            // 
            // ErrorProviderCorrect
            // 
            this.ErrorProviderCorrect.ContainerControl = this;
            this.ErrorProviderCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderCorrect.Icon")));
            // 
            // ErrorProviderWrong
            // 
            this.ErrorProviderWrong.ContainerControl = this;
            this.ErrorProviderWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderWrong.Icon")));
            // 
            // ErrorProviderAlert
            // 
            this.ErrorProviderAlert.ContainerControl = this;
            this.ErrorProviderAlert.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderAlert.Icon")));
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(230, 248);
            this.txtSalePrice.MaxLength = 10;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(365, 21);
            this.txtSalePrice.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "Sale Price";
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 514);
            this.Controls.Add(this.GrpBoxCustomerDetails);
            this.Name = "Material";
            this.Text = "Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Material_FormClosing);
            this.Load += new System.EventHandler(this.Material_Load);
            this.GrpBoxCustomerDetails.ResumeLayout(false);
            this.GrpBoxCustomerDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxCustomerDetails;
        private System.Windows.Forms.Label LblMaterialType;
        public System.Windows.Forms.TextBox TxtMaterialCode;
        public System.Windows.Forms.Label LBLId;
        private System.Windows.Forms.Label LblMaterialCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblMaterialMaster;
        public System.Windows.Forms.TextBox TxtMaterialDetails;
        private System.Windows.Forms.Label lblMaterialDetails;
        private System.Windows.Forms.ErrorProvider ErrorProviderCorrect;
        private System.Windows.Forms.ErrorProvider ErrorProviderWrong;
        private System.Windows.Forms.ErrorProvider ErrorProviderAlert;
        public System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label lblunitCost;
        public System.Windows.Forms.TextBox TxtMaterialName;
        public System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label1;
    }
}