using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Inventry_Management_System.Transaction
{
    public partial class Sales : Form
    {
        DAL.Connection cn = new DAL.Connection();
        bool Flag = false;

        public Sales(string Active_Button)
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
                Program.MdiEnable();
            }
            else if (Btn_Title == "Modify")
            {
                Btn_Material_Delete.Enabled = false;
                BtnSave.Enabled = false;
                BtnUpdate.Enabled = true;
                Program.MdiEnable();
            }
        }

        private void Production_Load(object sender, EventArgs e)
        {
            ProductionMaterialDetails();
        }

        #region db
        public DataTable matListData()
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM material_master where Action!='N'", cn.connection);
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

        public DataTable Specific_Prodct_Data(string id)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    Int32 id1 = Convert.ToInt32(id);
                    //OleDbDataAdapter cmd = new OleDbDataAdapter("select m.Id,m.MaterialName from bill_of_material_detail bmd, material m where bmd.Action!='N' and bmd.Main_Mat_Code= " + id1 + " and bmd.MaterialCode=m.Id", cn.connection);
                    //OleDbDataAdapter cmd = new OleDbDataAdapter("select MaterialCode as Prod_Mat_Code,Mat_Description as Prod_Mat_Description,Mat_Unit,Mat_Qty as Prod_Mat_Qty from bill_of_material_detail where Action!='N' and Main_Mat_Code = "+ id1, cn.connection);
                    OleDbDataAdapter cmd = new OleDbDataAdapter("select MaterialCode, Mat_Description, Mat_Unit, Mat_Qty from bill_of_material_detail where Action!='N' and Main_Mat_Code = " + id1, cn.connection);
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

        public Int32 ProductMact_InsertData(DAL.Connection cnn, string TxtSales_BileNo, string TxtSales_Customer_Name, string TxtSales_Details, string TxtSales_CustomerCode, string TxtSales_Date, double TxtSales_Total)
        {
            Int32 id = cn.GetMaxId("sales_master", "Id");
            //if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO sales_master(Id,Sales_BileNo,Sales_Customer_Name,Sales_Details,Sales_CustomerCode,Sales_Date,Sales_Total,Action) values(@Id,@Sales_BileNo,@Sales_Customer_Name,@Sales_Details,@Sales_CustomerCode,@Sales_Date,@Sales_Total,@Action)", cnn.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Sales_BileNo", TxtSales_BileNo);
                    cmd.Parameters.AddWithValue("@Sales_Customer_Name", TxtSales_Customer_Name);
                    cmd.Parameters.AddWithValue("@Sales_Details", TxtSales_Details);
                    cmd.Parameters.AddWithValue("@Sales_CustomerCode", TxtSales_CustomerCode);
                    cmd.Parameters.AddWithValue("@Sales_Date", TxtSales_Date);
                    cmd.Parameters.AddWithValue("@Sales_Total", TxtSales_Total);
                    cmd.Parameters.AddWithValue("@Action", "Y");
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    //cn.connection.Close();
                }
            }
            return id;
        }

        public void ProductMact_UpdateData(string Flag, string Id, string TxtSales_BileNo, string TxtSales_Customer_Name, string TxtSales_Details, string TxtSales_CustomerCode, string TxtSales_Date, double TxtSales_Total)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE sales_master SET Sales_BileNo=@Sales_BileNo ,Sales_Customer_Name=@Sales_Customer_Name ,Sales_Details=@Sales_Details ,Sales_CustomerCode=@Sales_CustomerCode,Sales_Date=@Sales_Date,Sales_Total=@Sales_Total,Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@Sales_BileNo", TxtSales_BileNo);
                    cmd.Parameters.AddWithValue("@Sales_Customer_Name", TxtSales_Customer_Name);
                    cmd.Parameters.AddWithValue("@Sales_Details", TxtSales_Details);
                    cmd.Parameters.AddWithValue("@Sales_CustomerCode", TxtSales_CustomerCode);
                    cmd.Parameters.AddWithValue("@Sales_Date", TxtSales_Date);
                    cmd.Parameters.AddWithValue("@Sales_Total", TxtSales_Total);

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

        public void ProductMact_DeleteData(string Flag, string Id)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    Int32 id1 = Convert.ToInt32(Id);
                    OleDbCommand cmd = new OleDbCommand("UPDATE sales_master SET Action = @Action where Id = " + Id, cn.connection);
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

        public void ProductMact_FillData(string Id, Transaction.Sales Prod)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from sales_master where Action!='N' and Id=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Prod.lblId.Text = Id;
                    Prod.txtBillNo.Text = dr["Sales_BileNo"].ToString();
                    Prod.DTPDate.Text = dr["Sales_Date"].ToString();
                    Prod.txtCustomerName.Text = dr["Sales_Customer_Name"].ToString();
                    Prod.txtCustomerCode.Text = dr["Sales_CustomerCode"].ToString();
                    Prod.txtMatDescription.Text = dr["Sales_Details"].ToString();
                    Prod.txtTotal.Text = dr["Sales_Total"].ToString();
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

            //This Connection For Only Fill BILL_OF_MATERIAL_DETAILS DataGrid
            if (cn.MakeConnection() != false)
            {
                DataTable dt1 = new DataTable();
                try
                {
                    Int32 id1 = Convert.ToInt32(Id);
                    OleDbDataAdapter cmd = new OleDbDataAdapter("select * from sales_details where Sales_Id = " + id1 + " GROUP by id", cn.connection);
                    cmd.Fill(dt1);
                    Prod.ProductionMaterialDetails();
                    for (int i = 0; i <= dt1.Rows.Count-1; i++)
                    {
                        Prod.DVG_Material.Rows.Add();
                        Prod.DVG_Material.Rows[i].Cells[0].Value = dt1.Rows[i]["Id"];
                        Prod.DVG_Material.Rows[i].Cells[1].Value = dt1.Rows[i]["Sales_MaterialId"];
                        Prod.DVG_Material.Rows[i].Cells[2].Value = dt1.Rows[i]["Sales_Quantity"];
                        Prod.DVG_Material.Rows[i].Cells[3].Value = dt1.Rows[i]["Sales_PricePerPice"];
                        Prod.DVG_Material.Rows[i].Cells[4].Value = dt1.Rows[i]["Sales_Price"];
                    }
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

        public void ProductDetails_InsertData(DAL.Connection cnn, string TxtSales_Id, string TxtSales_MaterialId, string TxtSales_Quantity, string txtSales_PricePerPice, double TxtSales_Price)
        {
            //Int32 id = cn.GetMaxId("BILL_OF_MATERIAL_DETAIL",Production_Details PRODUCTION_DETAILS "Id");
            //if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO sales_details(Sales_Id,Sales_MaterialId,Sales_Quantity,Sales_PricePerPice,Sales_Price,Action) values(@Sales_Id,@Sales_MaterialId,@Sales_Quantity,@Sales_PricePerPice,@Sales_Price,@Action)", cnn.connection);
                    //cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Sales_Id", TxtSales_Id);
                    cmd.Parameters.AddWithValue("@Sales_MaterialId", TxtSales_MaterialId);
                    cmd.Parameters.AddWithValue("@Sales_Quantity", TxtSales_Quantity);
                    cmd.Parameters.AddWithValue("@Sales_PricePerPice", txtSales_PricePerPice);
                    cmd.Parameters.AddWithValue("@Sales_Price", TxtSales_Price);
                    cmd.Parameters.AddWithValue("@Action", "Y");
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    //cn.connection.Close();
                }
            }
        }

        public void ProductDetails_UpdateData(string Flag, string Id, string TxtSales_Id, string TxtSales_MaterialId, string TxtSales_Quantity, string txtSales_PricePerPice, double TxtSales_Price)
        {
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE sales_details SET Sales_Id=@Sales_Id ,Sales_MaterialId=@Sales_MaterialId ,Sales_Quantity=@Sales_Quantity,Sales_PricePerPice=@Sales_PricePerPice ,Sales_Price=@Sales_Price,Action=@Action where Id=" + Id, cn.connection);
                    cmd.Parameters.AddWithValue("@Sales_Id", TxtSales_Id);
                    cmd.Parameters.AddWithValue("@Sales_MaterialId", TxtSales_MaterialId);
                    cmd.Parameters.AddWithValue("@Sales_Quantity", TxtSales_Quantity);
                    cmd.Parameters.AddWithValue("@Sales_PricePerPice", txtSales_PricePerPice);
                    cmd.Parameters.AddWithValue("@Sales_Price", TxtSales_Price);
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

        public void ProductDetails_specDeleteData(DAL.Connection cnn, string Id)
        {
            //Int32 id = cn.GetMaxId("TRANSACTION_SPECIFICATION", "Id");

            // if (cn.MakeConnection() != false)
            {
                try
                {
                    Int32 id1 = Convert.ToInt32(Id);
                    OleDbCommand cmd = new OleDbCommand("delete from sales_details where Sales_Id=" + id1, cnn.connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    //cn.connection.Close();
                }
            }
        }

        public DataTable ProductDetails_specSelectData(string Id)
        {
            //Int32 id = cn.GetMaxId("TRANSACTION_SPECIFICATION", "Id");
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    Int32 id1 = Convert.ToInt32(Id);
                    OleDbDataAdapter cmd = new OleDbDataAdapter("Select * from sales_details where Sales_Id=" + id1, cn.connection);
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

        public void UpdateStockData(string Flag, string Id, string TxtStock_Quantity)
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

        public string Getstock(string UId)
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
                    OleDbCommand cmd = new OleDbCommand("select Stock_Quantity from stock_details where Action!='N' and Stock_MaterialId=" + UId, cn.connection);
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
            return OldGrade1;
        }

        public void CustomerName_FillData(string Id, Transaction.Sales Prod)
        {
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from customer where Action!='N' and CustomerCode=" + Id, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Prod.txtCustomerName.Text = dr["CustomerName"].ToString();
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

            //This Connection For Only Fill BILL_OF_MATERIAL_DETAILS DataGrid
            if (cn.MakeConnection() != false)
            {
                DataTable dt1 = new DataTable();
                try
                {
                    Int32 id1 = Convert.ToInt32(Id);
                    OleDbDataAdapter cmd = new OleDbDataAdapter("select * from purchase_details where Purchase_Id = " + id1 + " GROUP by id", cn.connection);
                    cmd.Fill(dt1);
                    Prod.ProductionMaterialDetails();
                    for (int i = 0; i <= dt1.Rows.Count - 1; i++)
                    {
                        Prod.DVG_Material.Rows.Add();
                        Prod.DVG_Material.Rows[i].Cells[0].Value = dt1.Rows[i]["Id"];
                        Prod.DVG_Material.Rows[i].Cells[1].Value = dt1.Rows[i]["Purchase_MaterialId"];
                        Prod.DVG_Material.Rows[i].Cells[2].Value = dt1.Rows[i]["Purchase_Quantity"];
                        Prod.DVG_Material.Rows[i].Cells[3].Value = dt1.Rows[i]["Purchase_PricePerPice"];
                        Prod.DVG_Material.Rows[i].Cells[4].Value = dt1.Rows[i]["Purchase_Price"];
                    }
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


        public string Material_Rate_Per_Pis_ListData(int MatId)
        {
            DataTable dt = new DataTable();
            OleDbDataReader dr = null;
            string activet = "";
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select Material_SalePrice from material_master where ACTION!='N' and Id = " + MatId, cn.connection);

                    dr = cmd.ExecuteReader();
                    dr.Read();
                    activet = dr["Material_SalePrice"].ToString();
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
            return activet;
        }
        #endregion

        public void ProductionMaterialDetails()
        {
            txtTotal.ReadOnly = true;
            //Set AutoGenerateColumns False
            DVG_Material.AutoGenerateColumns = false;

            DVG_Material.ColumnCount = 0;

            //0
            DataGridViewTextBoxColumn Prod_TranId = new DataGridViewTextBoxColumn();
            Prod_TranId.HeaderText = "Id";
            Prod_TranId.Name = "Id";
            Prod_TranId.DataPropertyName = "Id";
            Prod_TranId.SortMode = DataGridViewColumnSortMode.Programmatic;
            Prod_TranId.Visible = false;
            //CS_MaterialDesc.ReadOnly = true;

            //1
            DataGridViewComboBoxColumn CMB_Prod_MaterialId = new DataGridViewComboBoxColumn();
            CMB_Prod_MaterialId.HeaderText = "Material Name";
            CMB_Prod_MaterialId.Name = "MaterialName";
            CMB_Prod_MaterialId.DataPropertyName = "Sales_MaterialId";
            CMB_Prod_MaterialId.DataSource = matListData();
            CMB_Prod_MaterialId.DisplayMember = "Material_Name";
            CMB_Prod_MaterialId.ValueMember = "Id";
            ////CMB_Prod_MaterialId.ReadOnly = true;

            //2
            DataGridViewTextBoxColumn Prod_MaterialQty = new DataGridViewTextBoxColumn();
            Prod_MaterialQty.HeaderText = "Quantity";
            Prod_MaterialQty.Name = "Quantity";
            Prod_MaterialQty.DataPropertyName = "Sales_Quantity";
            Prod_MaterialQty.SortMode = DataGridViewColumnSortMode.Programmatic;

            //3
            DataGridViewTextBoxColumn Prod_PricePerPis = new DataGridViewTextBoxColumn();
            Prod_PricePerPis.HeaderText = "Price Per Pis";
            Prod_PricePerPis.Name = "Price Per Pis";
            Prod_PricePerPis.DataPropertyName = "Sales_PricePerPice";
            Prod_PricePerPis.SortMode = DataGridViewColumnSortMode.Programmatic;
            Prod_PricePerPis.ReadOnly = true;


            //3
            DataGridViewTextBoxColumn Prod_MaterialPrice = new DataGridViewTextBoxColumn();
            Prod_MaterialPrice.HeaderText = "Amount";
            Prod_MaterialPrice.Name = "Amount";
            Prod_MaterialPrice.DataPropertyName = "Sales_Price";
            Prod_MaterialPrice.SortMode = DataGridViewColumnSortMode.Programmatic;
            Prod_MaterialPrice.ReadOnly = true;
            //Prod_MaterialQty.ReadOnly = true;

            DVG_Material.Columns.AddRange(Prod_TranId);
            DVG_Material.Columns.Add(CMB_Prod_MaterialId);
            DVG_Material.Columns.Add(Prod_MaterialQty);
            DVG_Material.Columns.Add(Prod_PricePerPis);
            DVG_Material.Columns.Add(Prod_MaterialPrice);
        }

        private void CMB_MaterialName_Leave(object sender, EventArgs e)
        {
            //if (//CMB_MaterialName.SelectedItem.ToString() != "")
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                string vi = "";// CMB_MaterialName.SelectedValue.ToString();
                dt = Specific_Prodct_Data(vi);

                //Laod Grade Wise Datargrid Chemical Specification ComboBox                    
                DVG_Material.AutoGenerateColumns = false;
                ProductionMaterialDetails();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    DVG_Material.Rows.Add();
                    DVG_Material.Rows[i].Cells[1].Value = dt.Rows[i]["MaterialCode"];
                    DVG_Material.Rows[i].Cells[2].Value = dt.Rows[i]["Mat_Description"];
                    DVG_Material.Rows[i].Cells[3].Value = dt.Rows[i]["Mat_Unit"];
                    DVG_Material.Rows[i].Cells[4].Value = dt.Rows[i]["Mat_Qty"];
                }
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < DVG_Material.Rows.Count; i++)
            {
                //DVG_Material.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToDouble(DVG_Material.Rows[i].Cells[4].Value.ToString()) * Convert.ToDouble(txtMobileNo.Text));
            }
            DVG_Material.Refresh();
        }

        private void Btn_Material_Delete_Click(object sender, EventArgs e)
        {
            if (this.DVG_Material.SelectedRows.Count > 0)
            {
                //Remove Record From regular datagrid
                DVG_Material.Rows.RemoveAt(this.DVG_Material.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Select Removable Material");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        { 
            OleDbTransaction objTrans = null;
            DAL.Connection cn = new DAL.Connection();
            if (cn.MakeConnection() != false)
            {
                objTrans = cn.connection.BeginTransaction();
                try
                {
                    DateTime dtmgf = Convert.ToDateTime(DTPDate.Text.ToString());
                    //   DateTime dtexp = Convert.ToDateTime(DTPExpDate.Text.ToString());
                    //Insert Option to Fill Data
                    Int32 ProdId = ProductMact_InsertData(cn, txtBillNo.Text.ToString(), txtCustomerName.Text.ToString(), txtMatDescription.Text.ToString(), txtCustomerCode.Text.ToString(), DTPDate.Text.ToString(), Convert.ToDouble(txtTotal.Text.ToString()));
                    if (DVG_Material.Rows.Count != 0)
                    {
                        for (int i = 0; i < DVG_Material.Rows.Count-1; i++)
                        {
                            if (DVG_Material.Rows[i].Cells[2].Value.ToString() != "")
                            {
                                ProductDetails_InsertData(cn, ProdId.ToString(), DVG_Material.Rows[i].Cells[1].Value.ToString(), DVG_Material.Rows[i].Cells[2].Value.ToString(), DVG_Material.Rows[i].Cells[3].Value.ToString(), Convert.ToDouble(DVG_Material.Rows[i].Cells[4].Value.ToString()));
                                string Flag = "U";
                                double stck = Convert.ToDouble(Getstock(DVG_Material.Rows[i].Cells[1].Value.ToString()));
                                double a = Convert.ToDouble(DVG_Material.Rows[i].Cells[2].Value);
                                UpdateStockData(Flag, DVG_Material.Rows[i].Cells[1].Value.ToString(), Convert.ToString(stck - a));
                            }
                        }
                    }
                    objTrans.Commit();
                }
                catch (Exception)
                {
                    objTrans.Rollback();
                }
                finally
                {
                    cn.connection.Close();
                }
            }
            MessageBox.Show("Data Saved Successfully");
            Show_List_Details();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            OleDbTransaction objTrans = null;
            DAL.Connection cn = new DAL.Connection();
            if (cn.MakeConnection() != false)
            {
                objTrans = cn.connection.BeginTransaction();
                try
                {
                    DateTime dtmgf = Convert.ToDateTime(DTPDate.Text.ToString());
                   // DateTime dtexp = Convert.ToDateTime(DTPExpDate.Text.ToString());
                    //Permantly Delete Data
                    if (DVG_Material.Rows.Count != 0)
                    {
                        DataTable dt_Stock = ProductDetails_specSelectData(lblId.Text);
                        for (int i = 0; i < dt_Stock.Rows.Count; i++)
                        {
                            string Mat = dt_Stock.Rows[i].ItemArray[2].ToString();
                            double Qty = Convert.ToDouble(dt_Stock.Rows[i].ItemArray[3].ToString());
                            double stck = Convert.ToDouble(Getstock(Mat));
                            UpdateStockData("U", DVG_Material.Rows[i].Cells[1].Value.ToString(), Convert.ToString(stck + Qty));
                        }
                        ProductDetails_specDeleteData(cn, lblId.Text);
                    }

                    string Flag = "U"; //For Update Opration
                    string ID = lblId.Text.ToString();

                    //Call Customer Insert Option to Fill Data
                    ProductMact_UpdateData(Flag, ID, txtBillNo.Text.ToString(), txtCustomerName.Text.ToString(), txtMatDescription.Text.ToString(), txtCustomerCode.Text.ToString(), DTPDate.Text.ToString(), Convert.ToDouble(txtTotal.Text.ToString()));
                    if (DVG_Material.Rows.Count != 0)
                    {
                        for (int i = 0; i <= DVG_Material.Rows.Count-1; i++)
                        {
                            if (DVG_Material.Rows[i].Cells[0].Value.ToString() != "")
                            {
                                ProductDetails_InsertData(cn, ID.ToString(), DVG_Material.Rows[i].Cells[1].Value.ToString(), DVG_Material.Rows[i].Cells[2].Value.ToString(), DVG_Material.Rows[i].Cells[3].Value.ToString(), Convert.ToDouble(DVG_Material.Rows[i].Cells[4].Value.ToString()));
                                
                                double stck = Convert.ToDouble(Getstock(DVG_Material.Rows[i].Cells[1].Value.ToString()));
                                double a = Convert.ToDouble(DVG_Material.Rows[i].Cells[2].Value);
                                UpdateStockData(Flag, DVG_Material.Rows[i].Cells[1].Value.ToString(), Convert.ToString(stck - a));
                            }
                        }
                    }
                    objTrans.Commit();
                }
                catch (Exception)
                {
                    //MessageBox.Show("123 : - " + ex.Message);
                    objTrans.Rollback();
                }
                finally
                {
                    cn.connection.Close();
                }
            }
            MessageBox.Show("Data Saved Successfully");
            Show_List_Details();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Show_List_Details();
        }

        public void FetchRecordData(string Id)
        {
            //Call Bussiness Layer For Fetch Records            

            ProductMact_FillData(Id, this);
        }

        public void Show_List_Details()
        {
            Program.MdiActiv();
            SalesDetails md = new SalesDetails();
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
            DTPDate.Text = "";
            txtBillNo.Text = "";
            txtMatDescription.Text = "";
            txtCustomerName.Text = "";
            txtCustomerCode.Text = "";
            txtTotal.Text = "";
        }

        public void ClearErrorProvider()
        {
            ErrorProviderAlert.Clear();
            ErrorProviderWrong.Clear();
            ErrorProviderCorrect.Clear();
        }

        private void CMB_MaterialName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        

        private void txtQty_Validating(object sender, CancelEventArgs e)
        {
            Qty();
        }

        public bool Qty()
        {
            Regex strCher = new Regex(@"^[0-9 .]*$"); //Regex("^\\+[0-9]{1,3}-[0-9]{3}-[0-9]{7}$");
            if (string.IsNullOrWhiteSpace(txtCustomerCode.Text))
            {
                //e.Cancel = true;
                txtCustomerCode.Focus();
                ErrorProviderAlert.SetError(txtCustomerCode, "Quantity Should not be left blank!");
                ErrorProviderWrong.SetError(txtCustomerCode, "");
                ErrorProviderCorrect.SetError(txtCustomerCode, "");
                Flag = false;

            }
            else if (strCher.IsMatch(txtCustomerCode.Text))
            {
                //e.Cancel = false;
                ErrorProviderCorrect.SetError(txtCustomerCode, "Correct");
                ErrorProviderAlert.SetError(txtCustomerCode, "");
                ErrorProviderWrong.SetError(txtCustomerCode, "");
                Flag = true;

            }
            else
            {
                //e.Cancel = true;
                txtCustomerCode.Focus();
                ErrorProviderWrong.SetError(txtCustomerCode, "Quantity Should be Wrong!");
                ErrorProviderAlert.SetError(txtCustomerCode, "");
                ErrorProviderCorrect.SetError(txtCustomerCode, "");
                Flag = false;

            }
            return Flag;
        }

        private void txtStatus_Validating(object sender, CancelEventArgs e)
        {
            Materialstatus();
        }

        public bool Materialstatus()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            if (string.IsNullOrWhiteSpace(txtBillNo.Text))
            {
                //e.Cancel = true;
                txtBillNo.Focus();
                Flag = false;
                ErrorProviderAlert.SetError(txtBillNo, "Material Status not be left blank!");
                ErrorProviderWrong.SetError(txtBillNo, "");
                ErrorProviderCorrect.SetError(txtBillNo, "");
            }
            else if (strCher.IsMatch(txtBillNo.Text))
            {
                //e.Cancel = false;    
                Flag = true;
                ErrorProviderCorrect.SetError(txtBillNo, "Correct");
                ErrorProviderAlert.SetError(txtBillNo, "");
                ErrorProviderWrong.SetError(txtBillNo, "");
            }
            else
            {
                //e.Cancel = true;
                txtBillNo.Focus();
                Flag = false;
                ErrorProviderWrong.SetError(txtBillNo, "Material Status should be Wrong!");
                ErrorProviderAlert.SetError(txtBillNo, "");
                ErrorProviderCorrect.SetError(txtBillNo, "");
            }
            return Flag;
        }

        private void CMB_MaterialUnit_Validating(object sender, CancelEventArgs e)
        {
           
        }
        
        private void txtMatDescription_Validating(object sender, CancelEventArgs e)
        {
            MaterialDescription();
        }

        public bool MaterialDescription()
        {
            Regex strCher = new Regex(@"^[a-zA-Z0-9 ~`!@&*()+=|\':;.,/[\]""_-]*$");
            //if (string.IsNullOrWhiteSpace(txtMatDescription.Text))
            //{
            //    //e.Cancel = true;
            //    txtMatDescription.Focus();
            //    Flag = false;
            //    ErrorProviderAlert.SetError(txtMatDescription, "Material Description not be left blank!");
            //    ErrorProviderWrong.SetError(txtMatDescription, "");
            //    ErrorProviderCorrect.SetError(txtMatDescription, "");
            //}
            //else 
            if (strCher.IsMatch(txtMatDescription.Text))
            {
                //e.Cancel = false;    
                Flag = true;
                ErrorProviderCorrect.SetError(txtMatDescription, "Correct");
                ErrorProviderAlert.SetError(txtMatDescription, "");
                ErrorProviderWrong.SetError(txtMatDescription, "");
            }
            else
            {
                //e.Cancel = true;
                txtMatDescription.Focus();
                Flag = false;
                ErrorProviderWrong.SetError(txtMatDescription, "Material Description should be Wrong!");
                ErrorProviderAlert.SetError(txtMatDescription, "");
                ErrorProviderCorrect.SetError(txtMatDescription, "");
            }
            return Flag;
        }

        private void Production_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MdiActiv();
        }

        private void DVG_Material_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (!string.IsNullOrEmpty(DVG_Material[1, e.RowIndex].FormattedValue.ToString()))
                {
                    DVG_Material.Rows[e.RowIndex].Cells[3].Value = Material_Rate_Per_Pis_ListData(Convert.ToInt32(DVG_Material[1, e.RowIndex].Value.ToString()));
                    //DVG_Material[4, e.RowIndex].ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Select Material");
                }
            }
            else if (e.ColumnIndex == 2)
            {
                DataGridViewTextBoxCell TotalCost = (DataGridViewTextBoxCell)DVG_Material.Rows[e.RowIndex].Cells[4];
                if (txtTotal.Text == "")
                {
                    txtTotal.Text = "0";
                }
                TotalCost.Value = Convert.ToDouble(Convert.ToDouble(DVG_Material.Rows[e.RowIndex].Cells[2].Value) * Convert.ToDouble(DVG_Material.Rows[e.RowIndex].Cells[3].Value));
                Total_Cal();
            }
        }

        public void Total_Cal()
        {
            double Total = default(double);
            if (DVG_Material.Rows[0].Cells[1].Value != null)
            {
                for (int i = 0; i < DVG_Material.RowCount - 1; i++)
                {
                    Total = Total + Convert.ToDouble(DVG_Material.Rows[i].Cells[4].Value);
                }
            }
            txtTotal.Text = Convert.ToString(Total);
        }

        private void txtCustomerCode_Leave(object sender, EventArgs e)
        {
            CustomerName_FillData(txtCustomerCode.Text, this);
        }
    }
}
