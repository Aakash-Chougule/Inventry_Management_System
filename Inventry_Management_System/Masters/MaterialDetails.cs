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
    public partial class MaterialDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        private int CurrentPageIndex = 1;

        public MaterialDetails()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void MaterialDetails_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //BAL.Material Mat = new BAL.Material();

            //Set AutoGenerateColumns False
            DGV_MaterialDetails.AutoGenerateColumns = false;
            DGV_MaterialDetails.AllowUserToAddRows = false;

            this.Width = DGV_MaterialDetails.Width + 100;

            //Set Columns Count
            DGV_MaterialDetails.ColumnCount = 4;

            //Add Columns
            DGV_MaterialDetails.Columns[0].Name = "Id"; // name
            DGV_MaterialDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_MaterialDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_MaterialDetails.Columns[0].Visible = false;

            DGV_MaterialDetails.Columns[1].HeaderText = "Material Name";
            DGV_MaterialDetails.Columns[1].Name = "Material Name";
            DGV_MaterialDetails.Columns[1].DataPropertyName = "Material_Name";
            DGV_MaterialDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;

            DGV_MaterialDetails.Columns[2].HeaderText = "Material Purchase Price";
            DGV_MaterialDetails.Columns[2].Name = "Material Purchase Price";
            DGV_MaterialDetails.Columns[2].DataPropertyName = "Material_Price";
            DGV_MaterialDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;

            DGV_MaterialDetails.Columns[3].HeaderText = "Material Sales Price";
            DGV_MaterialDetails.Columns[3].Name = "Material Sales Price";
            DGV_MaterialDetails.Columns[3].DataPropertyName = "Material_SalePrice";
            DGV_MaterialDetails.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
            //Add Data to DataGried Datasource
            DGV_MaterialDetails.DataSource = ListData();


            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_MaterialDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_MaterialDetails.Columns.Add(Delete_Img);
            Delete_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Delete_Img.Width = 80;

            //Program.User_Button_Authorization(BtnCreate, Edit_Img, Delete_Img);
        }

        private void TxtSearchByMaterial_TextChanged(object sender, EventArgs e)
        {            
            DGV_MaterialDetails.DataSource = ListSearchData(TxtSearchByMaterial.Text);
        }

        #region Db
        public DataTable ListData()
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

        public DataTable ListSearchData(string SearcherText)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM material_master WHERE Action!='N' and Material_Name LIKE '%" + SearcherText + "%'", cn.connection);
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
                    OleDbCommand cmd = new OleDbCommand("UPDATE material_master SET Action = @Action where Id = " + Id, cn.connection);
                    
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

        private void DGV_MaterialDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////BAL.Material TM = new BAL.Material();

            //Check For Delete Column
            if (DGV_MaterialDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_MaterialDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);
                    DGV_MaterialDetails.Refresh();
                    DAL.Connection cn = new DAL.Connection();
                    this.DGV_MaterialDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "material_master");
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

            else if (DGV_MaterialDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Application.OpenForms.OfType<Material>().Count() == 1)
                {
                    Application.OpenForms.OfType<Material>().First().Close();
                }
                string RecordId = DGV_MaterialDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Material Mat = new Material("Modify");
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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Material Cf = new Material("New");
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
            this.DGV_MaterialDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "material_master");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_MaterialDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "material_master");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("material_master", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_MaterialDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "material_master");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("material_master", "Id");
            this.DGV_MaterialDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "material_master");
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

        private void DGV_MaterialDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
