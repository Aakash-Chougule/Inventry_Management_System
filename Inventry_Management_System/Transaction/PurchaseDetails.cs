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
    public partial class PurchaseDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        //BAL.ProductMaster Pm = new BAL.ProductMaster();
        private int CurrentPageIndex = 1;

        public PurchaseDetails()
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
            DGV_PurchaseDetails.AutoGenerateColumns = false;
            DGV_PurchaseDetails.AllowUserToAddRows = false;

            this.Width = DGV_PurchaseDetails.Width + 100;

            //Set Columns Count
            DGV_PurchaseDetails.ColumnCount = 5;

            DGV_PurchaseDetails.Columns[0].Name = "Id"; // name
            DGV_PurchaseDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_PurchaseDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_PurchaseDetails.Columns[0].Visible = false;
            DGV_PurchaseDetails.Columns[0].ReadOnly = true;

            DGV_PurchaseDetails.Columns[1].HeaderText = "Bill No";
            DGV_PurchaseDetails.Columns[1].Name = "Bill No";
            DGV_PurchaseDetails.Columns[1].DataPropertyName = "Purchase_BileNo";
            DGV_PurchaseDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_PurchaseDetails.Columns[1].ReadOnly = true;

            DGV_PurchaseDetails.Columns[2].HeaderText = "Vendor Name";
            DGV_PurchaseDetails.Columns[2].Name = "Vendor Name";
            DGV_PurchaseDetails.Columns[2].DataPropertyName = "Purchase_Vendor_Name";
            DGV_PurchaseDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_PurchaseDetails.Columns[2].ReadOnly = true;

            DGV_PurchaseDetails.Columns[3].HeaderText = "Date";
            DGV_PurchaseDetails.Columns[3].Name = "Date";
            DGV_PurchaseDetails.Columns[3].DataPropertyName = "Purchase_Date";
            DGV_PurchaseDetails.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_PurchaseDetails.Columns[3].ReadOnly = true;

            DGV_PurchaseDetails.Columns[4].HeaderText = "Total Amount";
            DGV_PurchaseDetails.Columns[4].Name = "Total Amount";
            DGV_PurchaseDetails.Columns[4].DataPropertyName = "Purchase_Total";
            DGV_PurchaseDetails.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
            DGV_PurchaseDetails.Columns[4].ReadOnly = true;
            
            DGV_PurchaseDetails.DataSource = ListData();

            DataGridViewImageColumn Report_Img = new DataGridViewImageColumn();
            Image Imge1 = Properties.Resources.iconfinder_Report_6699541;
            Report_Img.Image = Imge1;
            Report_Img.Name = "Report";
            DGV_PurchaseDetails.Columns.Add(Report_Img);
            Report_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Report_Img.Width = 80;

            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_PurchaseDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_PurchaseDetails.Columns.Add(Delete_Img);
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
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM purchase_master where Action!='N'", cn.connection);
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
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM purchase_master WHERE Action!='N' and Purchase_Vendor_Name LIKE '%" + SearcherText + "%'", cn.connection);
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
                    OleDbCommand cmd = new OleDbCommand("UPDATE purchase_master SET Action = @Action where Id = " + Id, cn.connection);

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
            Purchase Cf = new Purchase("New");
            Cf.MdiParent = this.MdiParent;
            Cf.WindowState = FormWindowState.Maximized;
            Cf.StartPosition = FormStartPosition.CenterParent;
            Cf.Show();
            this.Close();
        }

        private void DGV_ProdMaterialDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_PurchaseDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_PurchaseDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);
                    DGV_PurchaseDetails.Refresh();
                    DAL.Connection cn = new DAL.Connection();
                    this.DGV_PurchaseDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "purchase_master");
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

            else if (DGV_PurchaseDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Application.OpenForms.OfType<Purchase>().Count() == 1)
                {
                    Application.OpenForms.OfType<Purchase>().First().Close();
                }
                string RecordId = DGV_PurchaseDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Purchase Mat = new Purchase("Modify");
                Mat.MdiParent = this.MdiParent;
                Mat.WindowState = FormWindowState.Maximized;
                Mat.StartPosition = FormStartPosition.CenterParent;
                Mat.Show();
                Mat.FetchRecordData(RecordId);
                //this.Close();
            }
            //Reports.Purchase RPt_Tran_Mat = new Reports.Purchase();
            else if (DGV_PurchaseDetails.Columns[e.ColumnIndex].Name == "Report")
            {
                Reports.Purchase RPt_Tran_Mat = new Reports.Purchase();
                if (Application.OpenForms.OfType<Reports.Purchase>().Count() == 1)
                {
                    Application.OpenForms.OfType<Reports.Purchase>().First().Close();
                }
                Int32 RecordId = Convert.ToInt32(DGV_PurchaseDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            this.DGV_PurchaseDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "purchase_master");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_PurchaseDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "purchase_master");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("purchase_master", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_PurchaseDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "purchase_master");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("purchase_master", "Id");
            this.DGV_PurchaseDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "purchase_master");
        }

        private void TxtSearchByProdMaterial_TextChanged(object sender, EventArgs e)
        {
            DGV_PurchaseDetails.DataSource = ListSearchData(TxtSearchByVendor.Text);
        }
    }
}
