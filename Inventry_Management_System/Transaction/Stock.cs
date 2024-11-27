using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventry_Management_System.Transaction
{
    public partial class Stock : Form
    {
        DAL.Connection cn = new DAL.Connection();
        ////BAL.Material mat = new BAL.Material();
        ////BAL.ProductMaster pm = new BAL.ProductMaster();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            ProductionMaterialDetails();
            CMB_MaterialName.Visible = false;
            LblMaterialName.Visible = false;
        }

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

        public DataTable ListData()
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM stock_details where Action!='N'", cn.connection);
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

        public void ProductionMaterialDetails()
        {
            //Set AutoGenerateColumns False
            DGV_StockDetails.AutoGenerateColumns  = false;

            DGV_StockDetails.ColumnCount = 0;

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
            CMB_Prod_MaterialId.DataPropertyName = "Stock_MaterialId";
            CMB_Prod_MaterialId.DataSource = matListData();
            CMB_Prod_MaterialId.DisplayMember = "Material_Name";
            CMB_Prod_MaterialId.ValueMember = "Id";
            //CMB_Prod_MaterialId.ReadOnly = true;

            ////DataGridViewTextBoxColumn Prod_MaterialPrice = new DataGridViewTextBoxColumn();
            ////Prod_MaterialPrice.HeaderText = "Material Type";
            ////Prod_MaterialPrice.Name = "Material Type";
            ////Prod_MaterialPrice.DataPropertyName = "Stock_Material_Type_Id";
            ////Prod_MaterialPrice.SortMode = DataGridViewColumnSortMode.Programmatic;

            //2
            DataGridViewTextBoxColumn Prod_MaterialQty = new DataGridViewTextBoxColumn();
            Prod_MaterialQty.HeaderText = "Quantity";
            Prod_MaterialQty.Name = "Quantity";
            Prod_MaterialQty.DataPropertyName = "Stock_Quantity";
            Prod_MaterialQty.SortMode = DataGridViewColumnSortMode.Programmatic;

            //3
            DGV_StockDetails.Columns.AddRange(Prod_TranId);
            DGV_StockDetails.Columns.Add(CMB_Prod_MaterialId);
            //DGV_StockDetails.Columns.Add(Prod_MaterialPrice);
            DGV_StockDetails.Columns.Add(Prod_MaterialQty);

            DGV_StockDetails.DataSource = ListData();


        }


        public void StockDetails()
        {
            //Set AutoGenerateColumns False
            DGV_StockDetails.AutoGenerateColumns = false;
            DGV_StockDetails.ColumnCount = 0;

            //0
            DataGridViewTextBoxColumn Stock_MatCode = new DataGridViewTextBoxColumn();
            Stock_MatCode.HeaderText = "Material Code";
            Stock_MatCode.Name = "MachineCode";
            Stock_MatCode.DataPropertyName = "MachineCode";
            Stock_MatCode.SortMode = DataGridViewColumnSortMode.Programmatic;
            Stock_MatCode.ReadOnly = true;
            Stock_MatCode.Visible = false;
            Stock_MatCode.Width = 80;
            
            //1
            DataGridViewTextBoxColumn Stock_MaterialDesc = new DataGridViewTextBoxColumn();
            Stock_MaterialDesc.HeaderText = "Material Name";
            Stock_MaterialDesc.Name = "MaterialName";
            Stock_MaterialDesc.DataPropertyName = "Stock_MaterialId";
            Stock_MaterialDesc.SortMode = DataGridViewColumnSortMode.Programmatic;
            Stock_MaterialDesc.ReadOnly = true;
            //Stock_MatCode.Width = 80;

            //2
            DataGridViewTextBoxColumn Stock_MaterialType = new DataGridViewTextBoxColumn();
            Stock_MaterialType.HeaderText = "Material Type";
            Stock_MaterialType.Name = "Material Type";
            Stock_MaterialType.DataPropertyName = "Stock_Material_Type_Id";
            Stock_MaterialType.SortMode = DataGridViewColumnSortMode.Programmatic;
            Stock_MaterialType.ReadOnly = true;

            //3
            DataGridViewTextBoxColumn Stock_MaterialQty = new DataGridViewTextBoxColumn();
            Stock_MaterialQty.HeaderText = "Quantity";
            Stock_MaterialQty.Name = "Quantity";
            Stock_MaterialQty.DataPropertyName = "Stock_Quantity";
            Stock_MaterialQty.SortMode = DataGridViewColumnSortMode.Programmatic;
            Stock_MaterialQty.ReadOnly = true;

            DGV_StockDetails.Columns.Add(Stock_MatCode);
            DGV_StockDetails.Columns.Add(Stock_MaterialDesc);
            DGV_StockDetails.Columns.Add(Stock_MaterialType);
            DGV_StockDetails.Columns.Add(Stock_MaterialQty);
            
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DGV_StockDetails.Refresh();
            //DGV_StockDetails.DataSource = pm/*/*.*/*/StockData("All", 0);

            if (RBAllRecord.Checked == true)
            {
                DGV_StockDetails.Refresh();                
                //DGV_StockDetails.DataSource = pm.StockData("All", 0);
            }
            else
            {
                if (CMB_MaterialName.SelectedValue.ToString() != "")
                {
                    DGV_StockDetails.Refresh();
                    int no = Convert.ToInt32(CMB_MaterialName.SelectedValue.ToString());
                    //DGV_StockDetails.DataSource = pm.StockData("", no);
                }
                else
                {
                    MessageBox.Show("Select Material");
                }
            }
        }

        private void RBParticularRecord_CheckedChanged(object sender, EventArgs e)
        {
            CMB_MaterialName.Visible = true;
            LblMaterialName.Visible = true;

            //Load Material Combobox
            //CMB_MaterialName.BindingContext = new BindingContext();

            CMB_MaterialName.DataSource = null;
            CMB_MaterialName.Items.Clear();
            CMB_MaterialName.DisplayMember = "MaterialName";
            CMB_MaterialName.ValueMember = "Id";
            //CMB_MaterialName.DataSource = mat.ListData();
            CMB_MaterialName.SelectedIndex = -1;
            CMB_MaterialName.SelectedText = "--select--";
        }

        private void RBAllRecord_CheckedChanged(object sender, EventArgs e)
        {
            CMB_MaterialName.Visible = false;
            LblMaterialName.Visible = false;
        }

        private void Cmd_Report_Click(object sender, EventArgs e)
        {
            Reports.Stock RPt_Tran_Mat = new Reports.Stock();
            if (Application.OpenForms.OfType<Reports.Stock>().Count() == 1)
            {
                Application.OpenForms.OfType<Reports.Stock>().First().Close();
            }            
            RPt_Tran_Mat.MdiParent = this.MdiParent;
            RPt_Tran_Mat.WindowState = FormWindowState.Maximized;
            RPt_Tran_Mat.StartPosition = FormStartPosition.CenterParent;
            RPt_Tran_Mat.AutoScroll = true;
            RPt_Tran_Mat.ShowReport();
            RPt_Tran_Mat.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
