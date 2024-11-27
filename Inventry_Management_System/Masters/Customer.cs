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

namespace Inventry_Management_System.Masters
{
    public partial class Customer : Form
    {
    
        DAL.Connection cn = new DAL.Connection();

        bool flag = false;

        public Customer(string Active_Button)
        {
            InitializeComponent();
            buttonVisibility(Active_Button);
        }

        public void buttonVisibility(string Btn_Title)
        {
            if (Btn_Title == "New")
            {
                BtnSave.Enabled = true;
                BtnUpdate.Enabled = false;
                Program.MdiEnable();
            }
            else if (Btn_Title == "Modify")
            {
                BtnSave.Enabled = false;
                BtnUpdate.Enabled = true;
                Program.MdiEnable();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
                      
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool MaterialNam = CustomerName();            
            
            if (MaterialNam)
            {
                //Call Customer Insert Option to Fill Data
                InsertData(TxtCustomerCode.Text.ToString(), TxtCustomerName.Text.ToString(), TxtAddress.Text.ToString(), TxtContactPerson.Text.ToString(), TxtEmailId.Text.ToString(), TxtMobileNo.Text.ToString(), TxtaltMobNo.Text.ToString());
                MessageBox.Show("Data Saved Successfully");
                Show_List_Details();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //bool MaterialNam = MaterialName();
            //bool MachineCod = MachineCode();
            //bool MaterialSpeacificatio = MaterialSpeacification();           
            //bool CMBUnitNam = CMBUnitName();
            //bool CMBMaterialHS = CMBMaterialHSN();           
            //if (MaterialNam && MachineCod && MaterialSpeacificatio && CMBUnitNam && CMBMaterialHS)
            //{
                //Call Bussiness Layer For Insert Records
                

                string Flag = "U"; //For Update Opration
                string ID = LBLId.Text.ToString();

                //Call Customer Insert Option to Fill Data
                UpdateData(Flag, ID,TxtCustomerCode.Text.ToString(),TxtCustomerName.Text.ToString(),TxtAddress.Text.ToString(),TxtContactPerson.Text.ToString(),TxtEmailId.Text.ToString(),TxtMobileNo.Text.ToString(),TxtaltMobNo.Text.ToString());
                MessageBox.Show("Data Updated Successfully");
                Show_List_Details();
                //Clear();
                //ClearErrorProvider();
            ////}
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Show_List_Details();
        }

        public void FetchRecordData(string Id)
        {
            //Call Bussiness Layer For Fetch Records            

            FillData(Id, this);
        }

        #region Db

        public void InsertData(string TxtCustomerCode, string TxtCustomer_Name, string TxtCustomerAddress, string Txtcustomercontactperson, string TxtCustomerEmail, string TxtCustomerMobNo, string TxtcustAltMobNo)
        {
            Int32 id = cn.GetMaxId("customer", "Id");
            Int32 PId = 0;
            if (cn.MakeConnection() != false)
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO customer(Id,CustomerCode,CustomerName,CustomerAddress,CustmerContactPerson,CustomerEmailId,CustomerMobileNo,CustomerAtlMobileNo,Action) values(@Id,@CustomerCode,@CustomerName,@CustomerAddress,@CustmerContactPerson,@CustomerEmailId,@CustomerMobileNo,@CustomerAtlMobileNo,@Action)", cn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@CustomerCode", TxtCustomerCode);
                    cmd.Parameters.AddWithValue("@CustomerName", TxtCustomer_Name);                    
                    cmd.Parameters.AddWithValue("@CustomerAddress", TxtCustomerAddress);
                    cmd.Parameters.AddWithValue("@CustmerContactPerson", Txtcustomercontactperson);
                    cmd.Parameters.AddWithValue("@CustomerEmailId", TxtCustomerEmail);
                    cmd.Parameters.AddWithValue("@CustomerMobileNo", TxtCustomerMobNo);
                    cmd.Parameters.AddWithValue("@CustomerAtlMobileNo", TxtcustAltMobNo);
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
        }
             
        public void UpdateData(string Flag, string Id, string TxtCustomerCode, string TxtCustomer_Name, string TxtCustomerAddress, string Txtcustomercontactperson, string TxtCustomerEmail, string TxtCustomerMobNo, string TxtcustAltMobNo)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE customer SET CustomerCode= @CustomerCode,CustomerName=@CustomerName,CustomerAddress= @CustomerAddress,CustmerContactPerson= @CustmerContactPerson,CustomerEmailId= @CustomerEmailId,CustomerMobileNo= @CustomerMobileNo,CustomerAtlMobileNo= @CustomerAtlMobileNo,Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@CustomerCode", TxtCustomerCode);
                    cmd.Parameters.AddWithValue("@CustomerName", TxtCustomer_Name);
                    cmd.Parameters.AddWithValue("@CustomerAddress", TxtCustomerAddress);
                    cmd.Parameters.AddWithValue("@CustmerContactPerson", Txtcustomercontactperson);
                    cmd.Parameters.AddWithValue("@CustomerEmailId", TxtCustomerEmail);
                    cmd.Parameters.AddWithValue("@CustomerMobileNo", TxtCustomerMobNo);
                    cmd.Parameters.AddWithValue("@CustomerAtlMobileNo", TxtcustAltMobNo);
                    
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
               
        public void FillData(string Id, Masters.Customer Mat)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from customer where Action!='N' and Id=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Mat.LBLId.Text = Id;
                    Mat.TxtCustomerCode.Text = dr["CustomerCode"].ToString();
                    Mat.TxtCustomerName.Text = dr["CustomerName"].ToString();                    
                    Mat.TxtAddress.Text = dr["CustomerAddress"].ToString();
                    Mat.TxtContactPerson.Text = dr["CustmerContactPerson"].ToString();
                    Mat.TxtEmailId.Text = dr["CustomerEmailId"].ToString();
                    Mat.TxtMobileNo.Text = dr["CustomerMobileNo"].ToString();
                    Mat.TxtaltMobNo.Text = dr["CustomerAtlMobileNo"].ToString();
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

        public DataTable ListMatTypeData()
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM customer where Action!='N'", cn.connection);
                    cmd.Fill(dt);
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
            return dt;

        }

        #endregion

        public void Show_List_Details()
        {
            Program.MdiActiv();
            CustomerDetails md = new CustomerDetails();
            md.MdiParent = this.MdiParent;
            md.WindowState = FormWindowState.Maximized;
            md.StartPosition = FormStartPosition.CenterParent;
            md.Show();
            this.Close();
            Clear();
            ClearErrorProvider();
        }

        public void Clear()
        {
            //Clear All Text Box Data
            TxtContactPerson.Text = "";
            TxtAddress.Text = "";
            TxtCustomerCode.Text = "";
            TxtCustomerName.Text = "";
            TxtaltMobNo.Text = "";
            TxtMobileNo.Text = "";
            TxtEmailId.Text = "";
        }

        public void ClearErrorProvider()
        {
            //ErrorProviderAlert.Clear();
            //ErrorProviderWrong.Clear();
            //ErrorProviderCorrect.Clear();
        }        

       
        private void Material_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MdiActiv();
        }

        private void TxtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            CustomerName();
        }

        public bool CustomerName()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(TxtCustomerName.Text))
            {
                // e.Cancel = true;
                TxtCustomerCode.Focus();
                ErrorProviderAlert.SetError(TxtCustomerName, "Customer Name should not be left blank!");
                ErrorProviderWrong.SetError(TxtCustomerName, "");
                ErrorProviderCorrect.SetError(TxtCustomerName, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtCustomerName.Text))
            {
                // e.Cancel = false;
                ErrorProviderCorrect.SetError(TxtCustomerName, "Correct");
                ErrorProviderAlert.SetError(TxtCustomerName, "");
                ErrorProviderWrong.SetError(TxtCustomerName, "");
                flag = true;
            }
            else
            {
                // e.Cancel = true;
                TxtCustomerName.Focus();
                ErrorProviderWrong.SetError(TxtCustomerName, "Customer Name should be Wrong!");
                ErrorProviderAlert.SetError(TxtCustomerName, "");
                ErrorProviderCorrect.SetError(TxtCustomerName, "");
                flag = false;
            }
            return flag;
        }

        private void TxtEmailId_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtMobileNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtaltMobNo_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
