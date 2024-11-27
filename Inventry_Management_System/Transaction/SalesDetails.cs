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
//using MySql.Data.MySqlClient;


namespace Inventry_Management_System.Transaction
{
    public partial class SalesDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        private int CurrentPageIndex = 1;

        public SalesDetails()
        {
            InitializeComponent();
        }

        private void ProductionDetails_Load(object sender, EventArgs e)
        {
            ProductionMaterial();
        }

        public void ProductionMaterial()
        {
            this.KeyPreview = true;

            //Set AutoGenerateColumns False
            DGV_SalesDetails.AutoGenerateColumns = false;
            DGV_SalesDetails.AllowUserToAddRows = false;

            this.Width = DGV_SalesDetails.Width + 100;

            //Set Columns Count
            DGV_SalesDetails.ColumnCount = 5;

            DGV_SalesDetails.Columns[0].Name = "Id"; // name
            DGV_SalesDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_SalesDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_SalesDetails.Columns[0].Visible = false;
            DGV_SalesDetails.Columns[0].ReadOnly = true;

            DGV_SalesDetails.Columns[1].HeaderText = "Bill No";
            DGV_SalesDetails.Columns[1].Name = "Bill No";
            DGV_SalesDetails.Columns[1].DataPropertyName = "Sales_BileNo";
            DGV_SalesDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_SalesDetails.Columns[1].ReadOnly = true;

            DGV_SalesDetails.Columns[2].HeaderText = "Customer Name";
            DGV_SalesDetails.Columns[2].Name = "Customer Name";
            DGV_SalesDetails.Columns[2].DataPropertyName = "Sales_Customer_Name";
            DGV_SalesDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_SalesDetails.Columns[2].ReadOnly = true;

            DGV_SalesDetails.Columns[3].HeaderText = "Date";
            DGV_SalesDetails.Columns[3].Name = "Date";
            DGV_SalesDetails.Columns[3].DataPropertyName = "Sales_Date";
            DGV_SalesDetails.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_SalesDetails.Columns[3].ReadOnly = true;

            DGV_SalesDetails.Columns[4].HeaderText = "Total Amount";
            DGV_SalesDetails.Columns[4].Name = "Total Amount";
            DGV_SalesDetails.Columns[4].DataPropertyName = "Sales_Total";
            DGV_SalesDetails.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_SalesDetails.Columns[4].ReadOnly = true;

            DGV_SalesDetails.DataSource = ListData();

            DataGridViewImageColumn Report_Img = new DataGridViewImageColumn();
            Image Imge1 = Properties.Resources.iconfinder_Report_6699541;
            Report_Img.Image = Imge1;
            Report_Img.Name = "Report";
            DGV_SalesDetails.Columns.Add(Report_Img);
            Report_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Report_Img.Width = 80;

            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_SalesDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_SalesDetails.Columns.Add(Delete_Img);
            Delete_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Delete_Img.Width = 80;

            //Program.User_Button_Authorization(BtnCreate, Edit_Img, Delete_Img);
        }

        #region Db
        public DataTable ListData()
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM sales_master where Action!='N'", cn.connection);
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

        public DataTable ListSearchData(string SearcherText)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM sales_master WHERE Action!='N' and Purchase_Vendor_Name LIKE '%" + SearcherText + "%'", cn.connection);
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

        public void DeleteData(string Flag, string Id)
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

        #endregion 

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Sales Cf = new Sales("New");
            Cf.MdiParent = this.MdiParent;
            Cf.WindowState = FormWindowState.Maximized;
            Cf.StartPosition = FormStartPosition.CenterParent;
            Cf.Show();
            this.Close();
        }

        private void DGV_ProdMaterialDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_SalesDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_SalesDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);
                    DGV_SalesDetails.Refresh();
                    DAL.Connection cn = new DAL.Connection();
                    this.DGV_SalesDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "sales_master");
                    this.MdiParent = this.MdiParent;
                    this.WindowState = FormWindowState.Maximized;
                    this.StartPosition = FormStartPosition.CenterParent;
                    MessageBox.Show("Data Deleted Successfully");
                }
                else
                {
                    this.MdiParent = this.MdiParent;
                    this.WindowState = FormWindowState.Maximized;
                    this.StartPosition = FormStartPosition.CenterParent;
                    this.Show();
                }
            }

            else if (DGV_SalesDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Application.OpenForms.OfType<Sales>().Count() == 1)
                {
                    Application.OpenForms.OfType<Sales>().First().Close();
                }
                string RecordId = DGV_SalesDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Sales Mat = new Sales("Modify");
                Mat.MdiParent = this.MdiParent;
                Mat.WindowState = FormWindowState.Maximized;
                Mat.StartPosition = FormStartPosition.CenterParent;
                Mat.Show();
                Mat.FetchRecordData(RecordId);
                //this.Close();
            }
            else if (DGV_SalesDetails.Columns[e.ColumnIndex].Name == "Report")
            {
                Reports.Sales RPt_Tran_Mat = new Reports.Sales();
                if (Application.OpenForms.OfType<Reports.Sales>().Count() == 1)
                {
                    Application.OpenForms.OfType<Reports.Sales>().First().Close();
                }
                Int32 RecordId = Convert.ToInt32(DGV_SalesDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                RPt_Tran_Mat.MdiParent = this.MdiParent;
                //RPt_Tran_Mat.WindowState = FormWindowState.Normal;
                //RPt_Tran_Mat.StartPosition = FormStartPosition.CenterParent;
                RPt_Tran_Mat.WindowState = FormWindowState.Maximized;
                RPt_Tran_Mat.StartPosition = FormStartPosition.CenterParent;
                RPt_Tran_Mat.AutoScroll = true;

                RPt_Tran_Mat.ShowReport(RecordId);
                RPt_Tran_Mat.Show();


            }
            else
            {
                this.MdiParent = this.MdiParent;
                this.WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterParent;
            }

        }

        private void ToolStripButtonFirst_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = 1;
            this.DGV_SalesDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "sales_master");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_SalesDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "sales_master");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("sales_master", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_SalesDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "sales_master");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("sales_master", "Id");
            this.DGV_SalesDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "sales_master");
        }

        private void TxtSearchByProdMaterial_TextChanged(object sender, EventArgs e)
        {
            DGV_SalesDetails.DataSource = ListSearchData(TxtSearchByCustomer.Text);
        }
    }
}
