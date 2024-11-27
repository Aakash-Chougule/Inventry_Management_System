namespace Inventry_Management_System.Authentication
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.ErrorProviderCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderAlert = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLblChngpass = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkbShowpas = new System.Windows.Forms.CheckBox();
            this.cmd_clean = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblChangePass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(205)))), ((int)(((byte)(126)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(270, 348);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 41);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "&LOGIN";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(267, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(303, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // TxtUserId
            // 
            this.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserId.Location = new System.Drawing.Point(267, 178);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(303, 22);
            this.TxtUserId.TabIndex = 1;
            this.TxtUserId.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserId_Validating);
            // 
            // ErrorProviderCorrect
            // 
            this.ErrorProviderCorrect.BlinkRate = 100;
            this.ErrorProviderCorrect.ContainerControl = this;
            this.ErrorProviderCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderCorrect.Icon")));
            // 
            // ErrorProviderWrong
            // 
            this.ErrorProviderWrong.BlinkRate = 100;
            this.ErrorProviderWrong.ContainerControl = this;
            this.ErrorProviderWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderWrong.Icon")));
            // 
            // ErrorProviderAlert
            // 
            this.ErrorProviderAlert.BlinkRate = 100;
            this.ErrorProviderAlert.ContainerControl = this;
            this.ErrorProviderAlert.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderAlert.Icon")));
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Inventry_Management_System.Properties.Resources.poster_2x;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.linkLblChngpass);
            this.panel3.Controls.Add(this.btn_Login);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.cmd_clean);
            this.panel3.Controls.Add(this.TxtUserId);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.LblChangePass);
            this.panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(121, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 424);
            this.panel3.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(266, 307);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 35);
            this.panel7.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(266, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 47);
            this.panel6.TabIndex = 47;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(262, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 47);
            this.panel5.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 29);
            this.label14.TabIndex = 46;
            this.label14.Text = "LOGIN ";
            // 
            // linkLblChngpass
            // 
            this.linkLblChngpass.AutoSize = true;
            this.linkLblChngpass.DisabledLinkColor = System.Drawing.Color.Fuchsia;
            this.linkLblChngpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblChngpass.ForeColor = System.Drawing.Color.DeepPink;
            this.linkLblChngpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLblChngpass.LinkVisited = true;
            this.linkLblChngpass.Location = new System.Drawing.Point(503, 393);
            this.linkLblChngpass.Name = "linkLblChngpass";
            this.linkLblChngpass.Size = new System.Drawing.Size(107, 15);
            this.linkLblChngpass.TabIndex = 44;
            this.linkLblChngpass.TabStop = true;
            this.linkLblChngpass.Text = "Change Password";
            this.linkLblChngpass.Visible = false;
            this.linkLblChngpass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chkbShowpas);
            this.panel4.Location = new System.Drawing.Point(267, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 29);
            this.panel4.TabIndex = 42;
            // 
            // chkbShowpas
            // 
            this.chkbShowpas.AutoSize = true;
            this.chkbShowpas.BackColor = System.Drawing.Color.White;
            this.chkbShowpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbShowpas.ForeColor = System.Drawing.Color.Black;
            this.chkbShowpas.Location = new System.Drawing.Point(3, 5);
            this.chkbShowpas.Name = "chkbShowpas";
            this.chkbShowpas.Size = new System.Drawing.Size(127, 19);
            this.chkbShowpas.TabIndex = 39;
            this.chkbShowpas.Text = "Show Password";
            this.chkbShowpas.UseVisualStyleBackColor = false;
            this.chkbShowpas.CheckedChanged += new System.EventHandler(this.chkbShowpas_CheckedChanged);
            // 
            // cmd_clean
            // 
            this.cmd_clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(205)))), ((int)(((byte)(126)))));
            this.cmd_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_clean.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmd_clean.Location = new System.Drawing.Point(412, 348);
            this.cmd_clean.Name = "cmd_clean";
            this.cmd_clean.Size = new System.Drawing.Size(108, 41);
            this.cmd_clean.TabIndex = 40;
            this.cmd_clean.Text = " CLEAR";
            this.cmd_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmd_clean.UseVisualStyleBackColor = false;
            this.cmd_clean.Click += new System.EventHandler(this.cmd_clean_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(266, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "PASSWORD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(266, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "USER ID";
            // 
            // LblChangePass
            // 
            this.LblChangePass.AutoSize = true;
            this.LblChangePass.DisabledLinkColor = System.Drawing.Color.Fuchsia;
            this.LblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePass.ForeColor = System.Drawing.Color.DeepPink;
            this.LblChangePass.LinkVisited = true;
            this.LblChangePass.Location = new System.Drawing.Point(244, 477);
            this.LblChangePass.Name = "LblChangePass";
            this.LblChangePass.Size = new System.Drawing.Size(118, 16);
            this.LblChangePass.TabIndex = 5;
            this.LblChangePass.TabStop = true;
            this.LblChangePass.Text = "Change Password";
            this.LblChangePass.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 575);
            this.Controls.Add(this.panel3);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAlert)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.ErrorProvider ErrorProviderCorrect;
        private System.Windows.Forms.ErrorProvider ErrorProviderWrong;
        private System.Windows.Forms.ErrorProvider ErrorProviderAlert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmd_clean;
        private System.Windows.Forms.CheckBox chkbShowpas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLblChngpass;
        private System.Windows.Forms.LinkLabel LblChangePass;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}