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
    public partial class CustomerDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        private int CurrentPageIndex = 1;

        public CustomerDetails()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //BAL.Material Mat = new BAL.Material();

            //Set AutoGenerateColumns False
            DGV_CustomerDetails.AutoGenerateColumns = false;
            DGV_CustomerDetails.AllowUserToAddRows = false;

            this.Width = DGV_CustomerDetails.Width + 100;

            //Set Columns Count
            DGV_CustomerDetails.ColumnCount = 4;

            //Add Columns
            DGV_CustomerDetails.Columns[0].Name = "Id"; // name
            DGV_CustomerDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_CustomerDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_CustomerDetails.Columns[0].Visible = false;

            DGV_CustomerDetails.Columns[1].HeaderText = "Customer Code";
            DGV_CustomerDetails.Columns[1].Name = "Customer Code";
            DGV_CustomerDetails.Columns[1].DataPropertyName = "CustomerCode";
            DGV_CustomerDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;

            DGV_CustomerDetails.Columns[2].HeaderText = "Customer Name";
            DGV_CustomerDetails.Columns[2].Name = "Customer Name";
            DGV_CustomerDetails.Columns[2].DataPropertyName = "CustomerName";
            DGV_CustomerDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            //Add Data to DataGried Datasource
            DGV_CustomerDetails.DataSource = ListData();


            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_CustomerDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_CustomerDetails.Columns.Add(Delete_Img);
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

        public DataTable ListSearchData(string SearcherText)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM customer WHERE Action!='N' and CustomerName LIKE '%" + SearcherText + "%'", cn.connection);
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
                    OleDbCommand cmd = new OleDbCommand("UPDATE customer SET Action = @Action where Id = " + Id, cn.connection);
                    
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
            Customer Cf = new Customer("New");
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
            this.DGV_CustomerDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "customer");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_CustomerDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "customer");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("customer", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_CustomerDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "customer");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("customer", "Id");
            this.DGV_CustomerDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "customer");
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
            DGV_CustomerDetails.DataSource = ListSearchData(TxtSearchByCustomer.Text);
        }

        private void DGV_CustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////BAL.Material TM = new BAL.Material();

            //Check For Delete Column
            if (DGV_CustomerDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_CustomerDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);
                    DGV_CustomerDetails.Refresh();
                    DAL.Connection cn = new DAL.Connection();
                    this.DGV_CustomerDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "customer");
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

            else if (DGV_CustomerDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Application.OpenForms.OfType<Customer>().Count() == 1)
                {
                    Application.OpenForms.OfType<Customer>().First().Close();
                }
                string RecordId = DGV_CustomerDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                Customer Mat = new Customer("Modify");
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
