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
    public partial class Vendor : Form
    {
    
        DAL.Connection cn = new DAL.Connection();

        bool flag = false;

        public Vendor(string Active_Button)
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

        private void Vendor_Load(object sender, EventArgs e)
        {
                      
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool MaterialNam = VendorName();            
            
            if (MaterialNam)
            {
                //Call Customer Insert Option to Fill Data
                InsertData(TxtVendorCode.Text.ToString(), TxtVendorName.Text.ToString(), TxtAddress.Text.ToString(), TxtContactPerson.Text.ToString(), TxtEmailId.Text.ToString(), TxtMobileNo.Text.ToString(), TxtaltMobNo.Text.ToString());
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
                UpdateData(Flag, ID,TxtVendorCode.Text.ToString(),TxtVendorName.Text.ToString(),TxtAddress.Text.ToString(),TxtContactPerson.Text.ToString(),TxtEmailId.Text.ToString(),TxtMobileNo.Text.ToString(),TxtaltMobNo.Text.ToString());
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

        public void InsertData(string TxtSupplierCode, string TxtSupplier_Name, string TxtSupplierAddress, string TxtSuppliercontactperson, string TxtSupplierEmail, string TxtSupplierMobNo, string TxtSupplierAltMobNo)
        {
            Int32 id = cn.GetMaxId("supplier", "Id");
            if (cn.MakeConnection() != false)
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO supplier(Id,SupplierCode,SupplierName,SupplierAddress,SupplierContactPerson,SupplierEmailId,SupplierMobileNo,SupplierAtlMobileNo,Action) values(@Id,@SupplierCode,@SupplierName,@SupplierAddress,@SupplierContactPerson,@SupplierEmailId,@SupplierMobileNo,@SupplierAtlMobileNo,@Action)", cn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@SupplierCode", TxtSupplierCode);
                    cmd.Parameters.AddWithValue("@SupplierName", TxtSupplier_Name);
                    cmd.Parameters.AddWithValue("@SupplierAddress", TxtSupplierAddress);
                    cmd.Parameters.AddWithValue("@SupplierContactPerson", TxtSuppliercontactperson);
                    cmd.Parameters.AddWithValue("@SupplierEmailId", TxtSupplierEmail);
                    cmd.Parameters.AddWithValue("@SupplierMobileNo", TxtSupplierMobNo);
                    cmd.Parameters.AddWithValue("@SupplierAtlMobileNo", TxtSupplierAltMobNo);
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
             
        public void UpdateData(string Flag, string Id, string TxtSupplierCode, string TxtSupplier_Name, string TxtSupplierAddress, string TxtSuppliercontactperson, string TxtSupplierEmail, string TxtSupplierMobNo, string TxtSupplierAltMobNo)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE supplier SET SupplierCode= @SupplierCode,SupplierName=@SupplierName,SupplierAddress= @SupplierAddress,SupplierContactPerson= @SupplierContactPerson,SupplierEmailId= @SupplierEmailId,SupplierMobileNo= @SupplierMobileNo,SupplierAtlMobileNo= @SupplierAtlMobileNo,Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@SupplierCode", TxtSupplierCode);
                    cmd.Parameters.AddWithValue("@SupplierName", TxtSupplier_Name);
                    cmd.Parameters.AddWithValue("@SupplierAddress", TxtSupplierAddress);
                    cmd.Parameters.AddWithValue("@SupplierContactPerson", TxtSuppliercontactperson);
                    cmd.Parameters.AddWithValue("@SupplierEmailId", TxtSupplierEmail);
                    cmd.Parameters.AddWithValue("@SupplierMobileNo", TxtSupplierMobNo);
                    cmd.Parameters.AddWithValue("@SupplierAtlMobileNo", TxtSupplierAltMobNo);
                    
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
               
        public void FillData(string Id, Masters.Vendor Mat)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from supplier where Action!='N' and Id=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Mat.LBLId.Text = Id;
                    Mat.TxtVendorCode.Text = dr["SupplierCode"].ToString();
                    Mat.TxtVendorName.Text = dr["SupplierName"].ToString();                    
                    Mat.TxtAddress.Text = dr["SupplierAddress"].ToString();
                    Mat.TxtContactPerson.Text = dr["SupplierContactPerson"].ToString();
                    Mat.TxtEmailId.Text = dr["SupplierEmailId"].ToString();
                    Mat.TxtMobileNo.Text = dr["SupplierMobileNo"].ToString();
                    Mat.TxtaltMobNo.Text = dr["SupplierAtlMobileNo"].ToString();
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
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM supplier where Action!='N'", cn.connection);
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
            VendorDetails md = new VendorDetails();
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
            TxtVendorCode.Text = "";
            TxtVendorName.Text = "";
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

       

        private void TxtEmailId_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtMobileNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtaltMobNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtVendorName_Validating(object sender, CancelEventArgs e)
        {
            VendorName();
        }

         public bool VendorName()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(TxtVendorName.Text))
            {
                // e.Cancel = true;
                TxtVendorCode.Focus();
                ErrorProviderAlert.SetError(TxtVendorName, "Vendor Name should not be left blank!");
                ErrorProviderWrong.SetError(TxtVendorName, "");
                ErrorProviderCorrect.SetError(TxtVendorName, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtVendorName.Text))
            {
                // e.Cancel = false;
                ErrorProviderCorrect.SetError(TxtVendorName, "Correct");
                ErrorProviderAlert.SetError(TxtVendorName, "");
                ErrorProviderWrong.SetError(TxtVendorName, "");
                flag = true;
            }
            else
            {
                // e.Cancel = true;
                TxtVendorName.Focus();
                ErrorProviderWrong.SetError(TxtVendorName, "Vendor Name should be Wrong!");
                ErrorProviderAlert.SetError(TxtVendorName, "");
                ErrorProviderCorrect.SetError(TxtVendorName, "");
                flag = false;
            }
            return flag;
        }
    }
}
