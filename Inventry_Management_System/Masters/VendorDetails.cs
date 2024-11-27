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

namespace Inventry_Management_System.Masters
{
    public partial class VendorDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        private int CurrentPageIndex = 1;

        public VendorDetails()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void VendorDetails_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //BAL.Material Mat = new BAL.Material();

            //Set AutoGenerateColumns False
            DGV_VendorDetails.AutoGenerateColumns = false;
            DGV_VendorDetails.AllowUserToAddRows = false;

            this.Width = DGV_VendorDetails.Width + 100;

            //Set Columns Count
            DGV_VendorDetails.ColumnCount = 4;

            //Add Columns
            DGV_VendorDetails.Columns[0].Name = "Id"; // name
            DGV_VendorDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_VendorDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_VendorDetails.Columns[0].Visible = false;

            DGV_VendorDetails.Columns[1].HeaderText = "Vendor Code";
            DGV_VendorDetails.Columns[1].Name = "Vendor Code";
            DGV_VendorDetails.Columns[1].DataPropertyName = "SupplierCode";
            DGV_VendorDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;

            DGV_VendorDetails.Columns[2].HeaderText = "Vendor Name";
            DGV_VendorDetails.Columns[2].Name = "Vendor Name";
            DGV_VendorDetails.Columns[2].DataPropertyName = "SupplierName";
            DGV_VendorDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            //Add Data to DataGried Datasource
            DGV_VendorDetails.DataSource = ListData();


            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_VendorDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_VendorDetails.Columns.Add(Delete_Img);
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

        public DataTable ListSearchData(string SearcherText)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM supplier WHERE Action!='N' and SupplierName LIKE '%" + SearcherText + "%'", cn.connection);
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
                    OleDbCommand cmd = new OleDbCommand("UPDATE supplier SET Action = @Action where Id = " + Id, cn.connection);
                    
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
            Vendor Cf = new Vendor("New");
            Cf.MdiParent = this.MdiParent;
            Cf.WindowState = FormWindowState.Maximized;
            Cf.StartPosition = FormStartPosition.CenterParent;
            Cf.Show();
            this.Close();
        }

        private void ToolStripButtonFirst_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = 1;
            this.DGV_VendorDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "supplier");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_VendorDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "supplier");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("supplier", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_VendorDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "supplier");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("supplier", "Id");
            this.DGV_VendorDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "supplier");
        }

        private void MaterialDetails_KeyDown(object sender, KeyEventArgs e)
        {
            //Shourcut Key For Create Button
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                BtnCreate.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TxtSearchByCustomer_TextChanged(object sender, EventArgs e)
        {
            DGV_VendorDetails.DataSource = ListSearchData(TxtSearchByVendor.Text);
        }

        private void DGV_CustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////BAL.Material TM = new BAL.Material();

            //Check For Delete Column
            if (DGV_VendorDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_VendorDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);
                    DGV_VendorDetails.Refresh();
                    DAL.Connection cn = new DAL.Connection();
                    this.DGV_VendorDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "supplier");
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

            else if (DGV_VendorDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Application.OpenForms.OfType<Customer>().Count() == 1)
                {
                    Application.OpenForms.OfType<Customer>().First().Close();
                }
                string RecordId = DGV_VendorDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Vendor Mat = new Vendor("Modify");
                Mat.MdiParent = this.MdiParent;
                Mat.WindowState = FormWindowState.Maximized;
                Mat.StartPosition = FormStartPosition.CenterParent;
                Mat.Show();
                Mat.FetchRecordData(RecordId);
                //this.Close();
            }
            else
            {
                this.MdiParent = this.MdiParent;
                this.WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }
    }
}
