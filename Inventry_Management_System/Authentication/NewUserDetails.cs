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

namespace Inventry_Management_System.Authentication
{
    public partial class NewUserDetails : Form
    {
        DAL.Connection cn = new DAL.Connection();
        private int CurrentPageIndex = 1;

        public NewUserDetails()
        {
            InitializeComponent();
        }

        private void NewUserDetails_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            //Set AutoGenerateColumns False
            DGV_NewUserDetails.AutoGenerateColumns = false;
            DGV_NewUserDetails.AllowUserToAddRows = false;
            this.Width = DGV_NewUserDetails.Width + 100;

            //Set Columns Count
            DGV_NewUserDetails.ColumnCount = 3;

            //Add Columns
            DGV_NewUserDetails.Columns[0].Name = "Id"; // name
            DGV_NewUserDetails.Columns[0].HeaderText = "Id"; // header text
            DGV_NewUserDetails.Columns[0].DataPropertyName = "Id"; // field name
            DGV_NewUserDetails.Columns[0].Visible = false;

            DGV_NewUserDetails.Columns[1].HeaderText = "User Id";
            DGV_NewUserDetails.Columns[1].Name = "User Id";
            DGV_NewUserDetails.Columns[1].DataPropertyName = "UserName";
            DGV_NewUserDetails.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;

            DGV_NewUserDetails.Columns[2].HeaderText = "User Name";
            DGV_NewUserDetails.Columns[2].Name = "User Name";
            DGV_NewUserDetails.Columns[2].DataPropertyName = "UserDetailName";
            DGV_NewUserDetails.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;

            //Add Data to DataGried Datasource
            DGV_NewUserDetails.Refresh();
            DGV_NewUserDetails.DataSource = ListData();

            DataGridViewImageColumn Edit_Img = new DataGridViewImageColumn();
            Image Imge = Properties.Resources.Edit_icon2;
            Edit_Img.Image = Imge;
            Edit_Img.Name = "Edit";
            DGV_NewUserDetails.Columns.Add(Edit_Img);
            Edit_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Edit_Img.Width = 80;

            DataGridViewImageColumn Delete_Img = new DataGridViewImageColumn();
            Image Imge2 = Properties.Resources.delete2;
            Delete_Img.Image = Imge2;
            Delete_Img.Name = "Delete";
            DGV_NewUserDetails.Columns.Add(Delete_Img);
            Delete_Img.ImageLayout = DataGridViewImageCellLayout.Normal;
            Delete_Img.Width = 80;
        }

        #region db
        public DataTable ListData()
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM user where Action!='N'", cn.connection);
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
                    OleDbCommand cmd = new OleDbCommand("UPDATE user SET Action = @Action where Id = " + Id, cn.connection);
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

        public DataTable ListSearchData(string SearcherText)
        {
            DataTable dt = new DataTable();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM user WHERE Action!='N' and UserDetailName LIKE '%" + SearcherText + "%'", cn.connection);
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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string ActiveBtn = "New";
            NewUser Cf = new NewUser(ActiveBtn);
            Cf.MdiParent = this.MdiParent;
            Cf.WindowState = FormWindowState.Maximized;
            Cf.StartPosition = FormStartPosition.CenterParent;
            Cf.Show();
            //Visible = false;
            this.Close();
        }

        private void DGV_NewUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_NewUserDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Existing Record is Deleted ?", " Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string RecordId = DGV_NewUserDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DeleteData("D", RecordId);                    
                    DGV_NewUserDetails.Refresh();                    
                    DGV_NewUserDetails.DataSource= cn.GetPageData(this.CurrentPageIndex, "user");
                    this.Show();
                }
            }

            else if (DGV_NewUserDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                string RecordId = DGV_NewUserDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                NewUser Mf = new NewUser("Modify");
                Mf.MdiParent = this.MdiParent;
                Mf.WindowState = FormWindowState.Maximized;
                Mf.StartPosition = FormStartPosition.CenterParent;
                Mf.Show();
                Mf.FetchRecordData(RecordId);
                //this.Close();
            }
            else
            {
                if (Application.OpenForms.OfType<NewUser>().Count() == 1)
                {
                    Application.OpenForms.OfType<NewUser>().First().Close();
                }
                string RecordId = DGV_NewUserDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                NewUser Mf = new NewUser("Modify");
                Mf.MdiParent = this.MdiParent;
                Mf.WindowState = FormWindowState.Maximized;
                Mf.StartPosition = FormStartPosition.CenterParent;
                Mf.Show();
                Mf.FetchRecordData(RecordId);
                //this.Close();
            }
        }

        private void TxtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            //BAL.Auth cust = new BAL.Auth();
            DGV_NewUserDetails.DataSource = ListSearchData(TxtSearchByUserName.Text);
        }

        private void ToolStripButtonFirst_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = 1;
            this.DGV_NewUserDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "user");
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.DGV_NewUserDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "user");
            }
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            DAL.Connection cn = new DAL.Connection();
            int count = cn.GetTotalPageCount("user", "Id");
            if (this.CurrentPageIndex < count)
            {
                this.CurrentPageIndex++;
                this.DGV_NewUserDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "user");
            }
        }

        private void ToolStripButtonLast_Click(object sender, EventArgs e)
        {
            
            DAL.Connection cn = new DAL.Connection();
            this.CurrentPageIndex = cn.GetTotalPageCount("user", "Id");
            this.DGV_NewUserDetails.DataSource = cn.GetPageData(this.CurrentPageIndex, "user");
        }

        private void LblChemicalName_Click(object sender, EventArgs e)
        {

        }

        private void lbluserdtl_Click(object sender, EventArgs e)
        {

        }
    }
}
