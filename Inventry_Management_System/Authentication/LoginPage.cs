using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

//using MySql.Data.MySqlClient;

namespace Inventry_Management_System.Authentication
{
    public partial class LoginPage : Form
    {
        DAL.Connection cn = new DAL.Connection();
        bool flag = false;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //this.TopLevel = false;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizes(this.Width, this.Height);
            //string abc= Program.globalString;
            //Pnl_Config.Hide();            
        }

        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            //Shourcut Key For Login Button
            if (e.KeyCode == Keys.L)
            {
                btn_Login.PerformClick();
            }

            //Shourcut Key For cancel Button
            if (e.KeyCode == Keys.Escape)
            {
                //btn_Cancel.PerformClick();
            }

            //Shourcut Key For cancel Button
            if (e.KeyCode == Keys.F12)
            {
                //Pnl_Config.Show();
            }
        }

        public void AutoSizes(int Width, int Height)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Panel))
                {
                    Panel objGroupBox = (Panel)ctrl;
                    //if (objGroupBox.Name.ToUpper() == "GrpBoxCustomerDetails".ToUpper())
                    //objGroupBox.Location = new System.Drawing.Point((Width / 2) - (objGroupBox.Width / 2), objGroupBox.Top);
                    objGroupBox.Location = new System.Drawing.Point((Width / 2) - (objGroupBox.Width / 2), (Height / 2) - (objGroupBox.Height / 2));

                    //else if (objGroupBox.Name.ToUpper() == "gpBoxBtn".ToUpper())
                    //    objGroupBox.Location = new System.Drawing.Point((Width / 2) - (objGroupBox.Width / 2), objGroupBox.Top);

                }
                //if (ctrl.HasChildren)
                //    ctrl.AutoSize(Width);
            }
        }

        private void LblCreateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ////Authentication.NewUser cd = new Authentication.NewUser("New");
            //Authentication.ChangePassword cd = new Authentication.ChangePassword();
            //cd.WindowState = FormWindowState.Maximized;
            //cd.StartPosition = FormStartPosition.CenterParent;
            ////cd.MdiParent = this;
            //this.Hide();
            //cd.Show();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool UserId_Valid = UserId_Valide();
            bool Password_Valid = Password_Valide();            
            if (UserId_Valid && Password_Valid)
            {
                Program.globalString = TxtUserId.Text.ToString();
                //Program.userAuth = usr;
                Program.UserId = TxtUserId.Text.ToString();
                Inventry_Management_SystemMDI tcMdi = new Inventry_Management_SystemMDI();
                Program.log_Dt_Tim = DateTime.Now.ToString("HH:mm tt");
                //this.Close();
                //tcMdi.MdiParent = this.Parent;
                tcMdi.Show();
                this.Hide();
                TxtUserId.Text = "";
                txtPassword.Text = "";
            }
            
            //this.Close();
        }

        #region DbData
                
        //For Validate User Id
        public string VerifyUserId(string UId)
        {
            OleDbDataReader dr = null;
            string OldGrade = "";
            string OldGrade1 = "";
            DataTable dt = new DataTable();

            //This Connection For Fill Only Grade Containt
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select UserName from User where (Action!='N' and UserName LIKE '%" + UId + "')", cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        OldGrade = "Y";
                        OldGrade1 = dr[0].ToString();
                    }
                    else
                    {
                        OldGrade = "N";
                    }
                    //OldGrade = dr[0].ToString();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    cn.connection.Close();
                }
            }
            return OldGrade;
        }

        //For Validate Pasward
        public string VerifyPassword(string UId)
        {
            OleDbDataReader dr = null;
            //string OldGrade = "";
            string OldGrade1 = "";
            DataTable dt = new DataTable();

            //This Connection For Fill Only Grade Containt
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select Passwords from user where Action!='N' and UserName LIKE '%" + UId + "'", cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        //OldGrade = "Y";
                        OldGrade1 = dr[0].ToString();
                        //cp.lblAlreadyCorrect.Text= dr[1].ToString();
                    }
                    else
                    {
                        //OldGrade = "N";
                    }
                    //OldGrade = dr[0].ToString();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    cn.connection.Close();
                }
            }
            return OldGrade1;
        }

        #endregion

        #region Validation
        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            UserId_Valide();
        }

        public bool UserId_Valide()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(TxtUserId.Text))
            {
                // e.Cancel = true;
                TxtUserId.Focus();
                ErrorProviderAlert.SetError(TxtUserId, "User ID should not be left blank!");
                ErrorProviderWrong.SetError(TxtUserId, "");
                ErrorProviderCorrect.SetError(TxtUserId, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtUserId.Text))
            {
                
                string compr1 = TxtUserId.Text.ToString();
                string compr2 = VerifyUserId(TxtUserId.Text);
                if (compr2 == "N")
                {
                    TxtUserId.Focus();
                    ErrorProviderAlert.SetError(TxtUserId, "User Id Not Found!");
                    ErrorProviderWrong.SetError(TxtUserId, "");
                    ErrorProviderCorrect.SetError(TxtUserId, "");
                    flag = false;
                }
                else
                {
                    // e.Cancel = false;
                    ErrorProviderCorrect.SetError(TxtUserId, "Correct");
                    ErrorProviderAlert.SetError(TxtUserId, "");
                    ErrorProviderWrong.SetError(TxtUserId, "");
                    flag = true;
                }
            }
            else
            {
                // e.Cancel = true;
                TxtUserId.Focus();
                ErrorProviderWrong.SetError(TxtUserId, "User Id should be Wrong!");
                ErrorProviderAlert.SetError(TxtUserId, "");
                ErrorProviderCorrect.SetError(TxtUserId, "");
                flag = false;
            }
            return flag;
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Password_Valide();
        }        

        public bool Password_Valide()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // e.Cancel = true;
                //txtPassword.Focus();
                ErrorProviderAlert.SetError(txtPassword, "Password should not be left blank!");
                ErrorProviderWrong.SetError(txtPassword, "");
                ErrorProviderCorrect.SetError(txtPassword, "");
                flag = false;
            }
            else if (strCher.IsMatch(txtPassword.Text))
            {                
                string compr1 = TxtUserId.Text.ToString();
                string compr2 = VerifyPassword(compr1);
                if (compr2 != txtPassword.Text)
                {
                    //txtPassword.Focus();
                    ErrorProviderWrong.SetError(txtPassword, "Password should be Wrong!");
                    ErrorProviderAlert.SetError(txtPassword, "");
                    ErrorProviderCorrect.SetError(txtPassword, "");
                    flag = false;
                }
                else
                {
                    // e.Cancel = false;
                    ErrorProviderCorrect.SetError(txtPassword, "Correct");
                    ErrorProviderAlert.SetError(txtPassword, "");
                    ErrorProviderWrong.SetError(txtPassword, "");
                    flag = true;
                }
            }
            else
            {
                // e.Cancel = true;
                TxtUserId.Focus();
                ErrorProviderWrong.SetError(TxtUserId, "Password should be Wrong!");
                ErrorProviderAlert.SetError(TxtUserId, "");
                ErrorProviderCorrect.SetError(TxtUserId, "");
                flag = false;
            }
            return flag;
        }

        #endregion

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chkbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowpas.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                chkbShowpas.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                chkbShowpas.Text = "Show Password";
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Pnl_Config.Hide();
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                //TxtBackup.Text = sSelectedPath;
            }
        }

        private void Cmd_Clear_Click(object sender, EventArgs e)
        {
            ClearErrorProvider();
            TxtUserId.Text = "";
            txtPassword.Text = "";
            TxtUserId.Focus();
        }
        
        public void ClearErrorProvider()
        {
            ErrorProviderAlert.Clear();
            ErrorProviderWrong.Clear();
            ErrorProviderCorrect.Clear();
        }

        private void cmd_clean_Click(object sender, EventArgs e)
        {
            ClearErrorProvider();
            TxtUserId.Text = "";
            txtPassword.Text = "";
            TxtUserId.Focus();
        }
               
        private void chkbShowpas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowpas.Checked == true)
            {
               txtPassword.PasswordChar = '\0';
                chkbShowpas.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                chkbShowpas.Text = "Show Password";
            }
        }
    }
}
