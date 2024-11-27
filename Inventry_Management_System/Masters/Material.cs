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
    public partial class Material : Form
    {
    
        DAL.Connection cn = new DAL.Connection();

        bool flag = false;

        public Material(string Active_Button)
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

        private void Material_Load(object sender, EventArgs e)
        {
                      
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool MaterialNam = MaterialName();            
            
            if (MaterialNam)
            {
                //Call Customer Insert Option to Fill Data
                Int32 stck= InsertData(TxtMaterialCode.Text, TxtMaterialName.Text.ToString(),TxtPrice.Text.ToString(),txtSalePrice.Text.ToString(), TxtMaterialDetails.Text.ToString());
                InsertStockData(stck.ToString(), 0.ToString());
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
                UpdateData(Flag, ID, TxtMaterialCode.Text,TxtMaterialName.Text.ToString(), TxtPrice.Text.ToString(), txtSalePrice.Text.ToString(), TxtMaterialDetails.Text.ToString());
                //UpdateStockData(Flag, ID, 0.ToString());
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

        public Int32 InsertData(string TxtMaterialCode, string TxtMaterial_Name, string TxtMaterial_Price,string txtSalePrice, string TxtMaterial_Details)
        {
            Int32 id = cn.GetMaxId("material_master", "Id");
            Int32 PId = 0;
            if (cn.MakeConnection() != false)
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO material_master(Id,Material_Name,Material_Code,Material_Price,Material_SalePrice,Material_Details,Action) values(@Id,@Material_Name,@Material_Code,@Material_Price,@Material_SalePrice,@Material_Details,@Action)", cn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Material_Code", TxtMaterialCode);
                    cmd.Parameters.AddWithValue("@Material_Name", TxtMaterial_Name);                    
                    cmd.Parameters.AddWithValue("@Material_Price", TxtMaterial_Price);
                    cmd.Parameters.AddWithValue("@Material_SalePrice", txtSalePrice);
                    cmd.Parameters.AddWithValue("@Material_Details", TxtMaterial_Details);
                    cmd.Parameters.AddWithValue("@Action", "Y");
                    cmd.ExecuteNonQuery();
                    PId = id;
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
            return PId;
        }

        public void InsertStockData(string TxtStock_MaterialId, string TxtStock_Quantity)
        {
            Int32 id = cn.GetMaxId("stock_details", "Id");
            if (cn.MakeConnection() != false)
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO stock_details(Id,Stock_MaterialId,Stock_Quantity,Action) values(@Id,@Stock_MaterialId,@Stock_Quantity,@Action)", cn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Stock_MaterialId", TxtStock_MaterialId);
                    cmd.Parameters.AddWithValue("@Stock_Quantity", TxtStock_Quantity);
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

        public void UpdateData(string Flag, string Id, string TxtMaterial_Code, string TxtMaterial_Name, string TxtMaterial_Price, string txtSalePrice, string TxtMaterial_Details)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE material_master SET Material_Name=@Material_Name ,Material_Code=@Material_Code ,Material_Price=@Material_Price,Material_SalePrice=@Material_SalePrice ,Material_Details=@Material_Details ,Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@Material_Code", TxtMaterial_Code);
                    cmd.Parameters.AddWithValue("@Material_Name", TxtMaterial_Name);
                    cmd.Parameters.AddWithValue("@Material_Price", TxtMaterial_Price);
                    cmd.Parameters.AddWithValue("@Material_SalePrice", txtSalePrice);
                    cmd.Parameters.AddWithValue("@Material_Details", TxtMaterial_Details);
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

        public void UpdateStockData(string Flag, string Id, string TxtStock_Material_Type_Id, string TxtStock_Quantity)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE stock_details SET Stock_MaterialId=@Stock_MaterialId ,Stock_Quantity=@Stock_Quantity ,Action=@Action where Stock_MaterialId=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@Stock_MaterialId", Id);
                    cmd.Parameters.AddWithValue("@Stock_Quantity", TxtStock_Quantity);
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

        public void FillData(string Id, Masters.Material Mat)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from material_master where Action!='N' and Id=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Mat.LBLId.Text = Id;
                    Mat.TxtMaterialCode.Text = dr["Material_Code"].ToString();
                    Mat.TxtMaterialName.Text = dr["Material_Name"].ToString();                    
                    Mat.TxtPrice.Text = dr["Material_Price"].ToString();
                    Mat.txtSalePrice.Text = dr["Material_SalePrice"].ToString();
                    Mat.TxtMaterialDetails.Text = dr["Material_Details"].ToString();
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
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM material_type where Action!='N'", cn.connection);
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
            MaterialDetails md = new MaterialDetails();
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
            TxtPrice.Text = "";
            TxtMaterialDetails.Text = "";
            TxtMaterialCode.Text = "";
            TxtMaterialName.Text = "";
        }

        public void ClearErrorProvider()
        {
            //ErrorProviderAlert.Clear();
            //ErrorProviderWrong.Clear();
            //ErrorProviderCorrect.Clear();
        }

      

        private void TxtMaterialName_Validating(object sender, CancelEventArgs e)
        {
            MaterialName();
        }

        public bool MaterialName()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(TxtMaterialName.Text))
            {
                // e.Cancel = true;
                TxtMaterialCode.Focus();
                ErrorProviderAlert.SetError(TxtMaterialName, "Material Name should not be left blank!");
                ErrorProviderWrong.SetError(TxtMaterialName, "");
                ErrorProviderCorrect.SetError(TxtMaterialName, "");
                flag = false;
            }
            else if (strCher.IsMatch(TxtMaterialName.Text))
            {
                // e.Cancel = false;
                ErrorProviderCorrect.SetError(TxtMaterialName, "Correct");
                ErrorProviderAlert.SetError(TxtMaterialName, "");
                ErrorProviderWrong.SetError(TxtMaterialName, "");
                flag = true;
            }
            else
            {
                // e.Cancel = true;
                TxtMaterialName.Focus();
                ErrorProviderWrong.SetError(TxtMaterialName, "Material Name should be Wrong!");
                ErrorProviderAlert.SetError(TxtMaterialName, "");
                ErrorProviderCorrect.SetError(TxtMaterialName, "");
                flag = false;
            }
            return flag;
        }

        private void TxtMaterialSpecification_Validating(object sender, CancelEventArgs e)
        {
            MaterialSpeacification();
        }

        public bool MaterialSpeacification()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (strCher.IsMatch(TxtMaterialDetails.Text))
            {
                //e.Cancel = false;
                ErrorProviderCorrect.SetError(TxtMaterialDetails, "Correct");
                ErrorProviderAlert.SetError(TxtMaterialDetails, "");
                ErrorProviderWrong.SetError(TxtMaterialDetails, "");
                flag = true;
            }
            else
            {
                // e.Cancel = true;
                TxtMaterialDetails.Focus();
                ErrorProviderWrong.SetError(TxtMaterialDetails, "Material Speacification should be Wrong!");
                ErrorProviderAlert.SetError(TxtMaterialDetails, "");
                ErrorProviderCorrect.SetError(TxtMaterialDetails, "");
                flag = false;
            }
            return flag;
        }

        private void CMB_UnitName_Validating(object sender, CancelEventArgs e)
        {
            //CMBUnitName();
        }

       

       
        private void Material_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MdiActiv();
        }

        private void GrpBoxCustomerDetails_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_MaterialHSN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblhsn_Click(object sender, EventArgs e)
        {

        }

        private void LblMaterialUnit_Click(object sender, EventArgs e)
        {

        }

        private void TxtMaterialSpecification_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
