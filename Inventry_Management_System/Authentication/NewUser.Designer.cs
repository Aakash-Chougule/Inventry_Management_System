namespace Inventry_Management_System.Authentication
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.GrpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNewUserInfo = new System.Windows.Forms.Label();
            this.chkbshowpassword = new System.Windows.Forms.CheckBox();
            this.lblAlreadyCorrect = new System.Windows.Forms.Label();
            this.LblPost = new System.Windows.Forms.Label();
            this.LBLId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtConfirmPassward = new System.Windows.Forms.TextBox();
            this.TxtPassward = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.LblPassward = new System.Windows.Forms.Label();
            this.LblConfirmPassward = new System.Windows.Forms.Label();
            this.ErrorProviderCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderAlert = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpBoxCustomerDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxCustomerDetails
            // 
            this.GrpBoxCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GrpBoxCustomerDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpBoxCustomerDetails.Controls.Add(this.txtuserName);
            this.GrpBoxCustomerDetails.Controls.Add(this.panel1);
            this.GrpBoxCustomerDetails.Controls.Add(this.chkbshowpassword);
            this.GrpBoxCustomerDetails.Controls.Add(this.lblAlreadyCorrect);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblPost);
            this.GrpBoxCustomerDetails.Controls.Add(this.LBLId);
            this.GrpBoxCustomerDetails.Controls.Add(this.groupBox2);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtConfirmPassward);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtPassward);
            this.GrpBoxCustomerDetails.Controls.Add(this.TxtUserId);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblUserId);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblPassward);
            this.GrpBoxCustomerDetails.Controls.Add(this.LblConfirmPassward);
            this.GrpBoxCustomerDetails.Location = new System.Drawing.Point(1, -2);
            this.GrpBoxCustomerDetails.Name = "GrpBoxCustomerDetails";
            this.GrpBoxCustomerDetails.Size = new System.Drawing.Size(593, 572);
            this.GrpBoxCustomerDetails.TabIndex = 1;
            this.GrpBoxCustomerDetails.TabStop = false;
            // 
            // txtuserName
            // 
            this.txtuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.Location = new System.Drawing.Point(196, 116);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(365, 21);
            this.txtuserName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblNewUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 46);
            this.panel1.TabIndex = 40;
            // 
            // LblNewUserInfo
            // 
            this.LblNewUserInfo.AutoSize = true;
            this.LblNewUserInfo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewUserInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNewUserInfo.Location = new System.Drawing.Point(188, 9);
            this.LblNewUserInfo.Name = "LblNewUserInfo";
            this.LblNewUserInfo.Size = new System.Drawing.Size(203, 29);
            this.LblNewUserInfo.TabIndex = 33;
            this.LblNewUserInfo.Text = "Create New User";
            // 
            // chkbshowpassword
            // 
            this.chkbshowpassword.AutoSize = true;
            this.chkbshowpassword.Location = new System.Drawing.Point(197, 258);
            this.chkbshowpassword.Name = "chkbshowpassword";
            this.chkbshowpassword.Size = new System.Drawing.Size(102, 17);
            this.chkbshowpassword.TabIndex = 39;
            this.chkbshowpassword.Text = "Show Password";
            this.chkbshowpassword.UseVisualStyleBackColor = true;
            this.chkbshowpassword.CheckedChanged += new System.EventHandler(this.chkbshowpassword_CheckedChanged_1);
            // 
            // lblAlreadyCorrect
            // 
            this.lblAlreadyCorrect.AutoSize = true;
            this.lblAlreadyCorrect.Location = new System.Drawing.Point(538, 16);
            this.lblAlreadyCorrect.Name = "lblAlreadyCorrect";
            this.lblAlreadyCorrect.Size = new System.Drawing.Size(0, 13);
            this.lblAlreadyCorrect.TabIndex = 12;
            this.lblAlreadyCorrect.Visible = false;
            // 
            // LblPost
            // 
            this.LblPost.AutoSize = true;
            this.LblPost.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPost.Location = new System.Drawing.Point(47, 116);
            this.LblPost.Name = "LblPost";
            this.LblPost.Size = new System.Drawing.Size(85, 20);
            this.LblPost.TabIndex = 26;
            this.LblPost.Text = "User Name";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(91, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 64);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Inventry_Management_System.Properties.Resources.Save1;
            this.BtnSave.Location = new System.Drawing.Point(38, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 31);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "  Save";
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
            this.BtnExit.Location = new System.Drawing.Point(301, 19);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(95, 31);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "  Exit";
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
            this.BtnUpdate.Location = new System.Drawing.Point(171, 19);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 31);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = " Update";
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtConfirmPassward
            // 
            this.TxtConfirmPassward.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassward.Location = new System.Drawing.Point(196, 285);
            this.TxtConfirmPassward.Name = "TxtConfirmPassward";
            this.TxtConfirmPassward.PasswordChar = '*';
            this.TxtConfirmPassward.Size = new System.Drawing.Size(365, 24);
            this.TxtConfirmPassward.TabIndex = 4;
            this.TxtConfirmPassward.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassward_Validating);
            // 
            // TxtPassward
            // 
            this.TxtPassward.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassward.Location = new System.Drawing.Point(196, 224);
            this.TxtPassward.Name = "TxtPassward";
            this.TxtPassward.PasswordChar = '*';
            this.TxtPassward.Size = new System.Drawing.Size(365, 24);
            this.TxtPassward.TabIndex = 3;
            this.TxtPassward.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassward_Validating);
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserId.Location = new System.Drawing.Point(196, 170);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(365, 21);
            this.TxtUserId.TabIndex = 2;
            this.TxtUserId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserId_Validating);
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserId.Location = new System.Drawing.Point(46, 172);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(58, 20);
            this.LblUserId.TabIndex = 2;
            this.LblUserId.Text = "User Id";
            // 
            // LblPassward
            // 
            this.LblPassward.AutoSize = true;
            this.LblPassward.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassward.Location = new System.Drawing.Point(46, 226);
            this.LblPassward.Name = "LblPassward";
            this.LblPassward.Size = new System.Drawing.Size(72, 20);
            this.LblPassward.TabIndex = 3;
            this.LblPassward.Text = "Passward";
            // 
            // LblConfirmPassward
            // 
            this.LblConfirmPassward.AutoSize = true;
            this.LblConfirmPassward.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmPassward.Location = new System.Drawing.Point(46, 287);
            this.LblConfirmPassward.Name = "LblConfirmPassward";
            this.LblConfirmPassward.Size = new System.Drawing.Size(132, 20);
            this.LblConfirmPassward.TabIndex = 6;
            this.LblConfirmPassward.Text = "Confirm Passward";
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
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 567);
            this.Controls.Add(this.GrpBoxCustomerDetails);
            this.Name = "NewUser";
            this.Text = "New User ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUser_FormClosing);
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewUser_KeyDown);
            this.GrpBoxCustomerDetails.ResumeLayout(false);
            this.GrpBoxCustomerDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxCustomerDetails;
        public System.Windows.Forms.Label LBLId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnUpdate;
        public System.Windows.Forms.TextBox TxtConfirmPassward;
        public System.Windows.Forms.TextBox TxtPassward;
        public System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Label LblPassward;
        private System.Windows.Forms.Label LblConfirmPassward;
        private System.Windows.Forms.Label LblPost;
        private System.Windows.Forms.ErrorProvider ErrorProviderCorrect;
        private System.Windows.Forms.ErrorProvider ErrorProviderWrong;
        private System.Windows.Forms.ErrorProvider ErrorProviderAlert;
        private System.Windows.Forms.Label LblNewUserInfo;
        public System.Windows.Forms.Label lblAlreadyCorrect;
        private System.Windows.Forms.CheckBox chkbshowpassword;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtuserName;
    }
}