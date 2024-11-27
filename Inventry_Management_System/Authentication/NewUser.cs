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
using System.Data.OleDb;
//using MySql.Data.MySqlClient;


namespace Inventry_Management_System.Authentication
{
    public partial class NewUser : Form
    {
        DAL.Connection cn = new DAL.Connection();

        bool flag = false;

        public NewUser(string Active_Button)
        {
            InitializeComponent();
            ButtonVisibility(Active_Button);
        }

        public void ButtonVisibility(string Btn_Title)
        {
            if (Btn_Title == "New")
            {
                BtnSave.Enabled = true;
                BtnUpdate.Enabled = false;
            }
            else if (Btn_Title == "Modify")
            {
                BtnSave.Enabled = false;
                BtnUpdate.Enabled = true;
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            //for Shortcuts
            this.KeyPreview = true;

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;

            //For clear All Data
            Clear();
        }                

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool UserId_Validate = UserId_Validated();
            bool Passward_Validate = Passward_Validated();
            bool ConfirmPassward_Validate = ConfirmPassward_Validated();
            if (UserId_Validate && Passward_Validate && ConfirmPassward_Validate)
            {
                //Call Customer Insert Option to Fill Data
                InsertData(TxtUserId.Text.ToString(),TxtPassward.Text.ToString(),txtuserName.Text.ToString());

                MessageBox.Show("Data Saved Successfully");
                Show_List_Details();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //bool UserName_Validate = UserName_Validated();
            bool UserId_Validate = UserId_Validated();
            bool Passward_Validate = Passward_Validated();
            bool ConfirmPassward_Validate = ConfirmPassward_Validated();
            //bool Group_Validate = Group_Validated();
            
            if (UserId_Validate && Passward_Validate && ConfirmPassward_Validate)
            {                
                string Flag = "U"; //For Update Opration
                string ID = LBLId.Text.ToString();

                //Call Customer Update Option to Modfify Data
                UpdateData(Flag, ID, TxtUserId.Text.ToString(), TxtPassward.Text.ToString(), txtuserName.Text.ToString());                
                MessageBox.Show("Data Updated Successfully");
                Show_List_Details();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Show_List_Details();
        }

        #region Db
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
                    OleDbCommand cmd = new OleDbCommand("select UserName from user where Action!='N' and UserName LIKE '%" + UId + "'", cn.connection);
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

        public Int32 InsertData(string TxtUserName, string TxtPasswords, string TxtUserDetailName)
        {
            Int32 id = cn.GetMaxId("user", "Id");
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO user(Id,UserName,Passwords,UserDetailName,Action) values(@Id,@UserName,@Passwords,@UserDetailName,@Action)", cn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@UserName", TxtUserName);                    
                    cmd.Parameters.AddWithValue("@Passwords", TxtPasswords);
                    cmd.Parameters.AddWithValue("@UserDetailName", TxtUserDetailName);
                    cmd.Parameters.AddWithValue("@Action", "Y");
                    cmd.ExecuteNonQuery();
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
            return id;
        }

        public void UpdateData(string Flag, string Id, string TxtUserName, string TxtPasswords, string TxtUserDetailName)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE user SET UserName=@UserName, Passwords=@Passwords, UserDetailName=@UserDetailName, Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@UserName", TxtUserName);
                    cmd.Parameters.AddWithValue("@Passwords", TxtPasswords);
                    cmd.Parameters.AddWithValue("@UserDetailName", TxtUserDetailName);

                    if (Flag == "U")
                    {
                        cmd.Parameters.AddWithValue("@Action", "Y");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Action", "N");
                    }
                    cmd.ExecuteNonQuery();
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
        }

        public void FillData(string Id, Inventry_Management_System.Authentication.NewUser User)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();

            //This Connection For Fill Only CHEMICAL Containt
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from user where Action!='N' and Id=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    
                    User.TxtUserId.Text = dr["UserName"].ToString();
                    User.lblAlreadyCorrect.Text = dr["UserName"].ToString();
                    User.TxtPassward.Text = dr["Passwords"].ToString();
                    User.TxtConfirmPassward.Text = dr["Passwords"].ToString();
                    User.txtuserName.Text = dr["UserDetailName"].ToString();                   
                    User.LBLId.Text = dr["Id"].ToString();
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

        }

        #endregion

        public void Show_List_Details()
        {
            NewUserDetails md;
            md = new NewUserDetails();
            md.MdiParent = this.MdiParent;
            md.WindowState = FormWindowState.Maximized;
            md.StartPosition = FormStartPosition.CenterParent;
            md.Show();
            //this.Close();
            Clear();
            ClearErrorProvider();
        }

        public void FetchRecordData(string Id)
        {
            //Call Bussiness Layer For Fetch Records            
            FillData(Id, this);
        }

        public void Clear()
        {
            //Clear All Text Box Data            
            TxtUserId.Text = "";
            TxtPassward.Text = "";
            TxtConfirmPassward.Text = "";            
            txtuserName.Text = "";
        }

        public void ClearErrorProvider()
        {
            ErrorProviderAlert.Clear();
            ErrorProviderWrong.Clear();
            ErrorProviderCorrect.Clear();
        }

        private void NewUser_KeyDown(object sender, KeyEventArgs e)
        {
            //Shourcut Key For Save Button
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                BtnSave.PerformClick();
            }

            //Shourcut Key For Update Button
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                BtnUpdate.PerformClick();
            }

            //Shourcut Key For Exit Button
            if (e.KeyCode == Keys.Escape)
            {
                BtnExit.PerformClick();
            }
        }
                
        private void TxtUserId_Validating(object sender, CancelEventArgs e)
        {
            UserId_Validated();
        }

        public bool UserId_Validated()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");

            if (string.IsNullOrWhiteSpace(TxtUserId.Text))
            {
                //e.Cancel = true;
                TxtUserId.Focus();
                ErrorProviderAlert.SetError(TxtUserId, "User Id should not be left blank!");
                ErrorProviderWrong.SetError(TxtUserId, "");
                ErrorProviderCorrect.SetError(TxtUserId, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtUserId.Text))
            {
                string compr1 = TxtUserId.Text.ToString();
                string compr2 = VerifyUserId(TxtUserId.Text);
                if (compr2 == "Y" && lblAlreadyCorrect.Text != TxtUserId.Text) 
                {
                    TxtUserId.Focus();
                    ErrorProviderAlert.SetError(TxtUserId, "User Id should not be Duplicate!");
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
                //e.Cancel = true;
                TxtUserId.Focus();
                ErrorProviderWrong.SetError(TxtUserId, "User Id should be Wrong!");
                ErrorProviderAlert.SetError(TxtUserId, "");
                ErrorProviderCorrect.SetError(TxtUserId, "");
                flag = false;
            }
            return flag;
        }

        private void TxtPassward_Validating(object sender, CancelEventArgs e)
        {
            Passward_Validated();
        }

        public bool Passward_Validated()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");

            if (string.IsNullOrWhiteSpace(TxtPassward.Text))
            {
                //e.Cancel = true;
                TxtPassward.Focus();
                ErrorProviderAlert.SetError(TxtPassward, "Passward should not be left blank!");
                ErrorProviderWrong.SetError(TxtPassward, "");
                ErrorProviderCorrect.SetError(TxtPassward, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtPassward.Text))
            {
                //e.Cancel = false;
                ErrorProviderCorrect.SetError(TxtPassward, "Correct");
                ErrorProviderAlert.SetError(TxtPassward, "");
                ErrorProviderWrong.SetError(TxtPassward, "");
                flag = true;
            }
            else
            {
                //e.Cancel = true;
                TxtPassward.Focus();
                ErrorProviderWrong.SetError(TxtPassward, "Passward should be Wrong!");
                ErrorProviderAlert.SetError(TxtPassward, "");
                ErrorProviderCorrect.SetError(TxtPassward, "");
                flag = false;
            }
            return flag;
        }

        private void TxtConfirmPassward_Validating(object sender, CancelEventArgs e)
        {
            ConfirmPassward_Validated();
        }

        public bool ConfirmPassward_Validated()
        {
           Regex strCher = new Regex(TxtPassward.Text);

            if (string.IsNullOrWhiteSpace(TxtConfirmPassward.Text))
            {
                //e.Cancel = true;
                TxtConfirmPassward.Focus();
                ErrorProviderAlert.SetError(TxtConfirmPassward, "Confirm Passward should not be left blank!");
                ErrorProviderWrong.SetError(TxtConfirmPassward, "");
                ErrorProviderCorrect.SetError(TxtConfirmPassward, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtConfirmPassward.Text))
            {
                if (TxtConfirmPassward.Text != TxtPassward.Text)
                {
                    TxtConfirmPassward.Focus();
                    ErrorProviderAlert.SetError(TxtConfirmPassward, "Confirm Passward Not Match with regular Passward!");
                    ErrorProviderWrong.SetError(TxtConfirmPassward, "");
                    ErrorProviderCorrect.SetError(TxtConfirmPassward, "");
                    flag = false;
                }
                else
                {
                    //e.Cancel = false;
                    ErrorProviderCorrect.SetError(TxtConfirmPassward, "Correct");
                    ErrorProviderAlert.SetError(TxtConfirmPassward, "");
                    ErrorProviderWrong.SetError(TxtConfirmPassward, "");
                    flag = true;
                }
            }
            else
            {
                //e.Cancel = true;
                TxtConfirmPassward.Focus();
                ErrorProviderWrong.SetError(TxtConfirmPassward, "Confirm Passward should be Wrong!");
                ErrorProviderAlert.SetError(TxtConfirmPassward, "");
                ErrorProviderCorrect.SetError(TxtConfirmPassward, "");
                flag = false;
            }
            return flag;
        }

       

        private void NewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtempCode_Leave(object sender, EventArgs e)
        {

        }

        private void Chkbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbshowpassword.Checked == true)
            {
                TxtPassward.PasswordChar = '\0';
                chkbshowpassword.Text = "Hide Password";
            }
            else
            {
                TxtPassward.PasswordChar = '*';
                chkbshowpassword.Text = "Show Password";
            }
        }

        private void chkbshowpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbshowpassword.Checked == true)
            {
                TxtPassward.PasswordChar = '\0';
                chkbshowpassword.Text = "Hide Password";
            }
            else
            {
                TxtPassward.PasswordChar = '*';
                chkbshowpassword.Text = "Show Password";
            }
        }

       
    }
}
