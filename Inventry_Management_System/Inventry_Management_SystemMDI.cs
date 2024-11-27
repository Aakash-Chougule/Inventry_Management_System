using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventry_Management_System
{
    public partial class Inventry_Management_SystemMDI : Form
    {
        
        private int childFormNumber = 0;

        public Inventry_Management_SystemMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        

        private void Inventry_Management_SystemMDI_Load(object sender, EventArgs e)
        {
            FormResolution(this);
        }

        public void LoadPgCodeNme()
        {
            foreach (ToolStripMenuItem MainMenu in MenuStrip_Master.Items)
            {
                string Nam = MainMenu.Name;
                string txt = MainMenu.Text;

                Program.allMenuStripItems.Add(MainMenu);
                //TreeViewMDI.Nodes.Add(MainMenu.Text);

                foreach (ToolStripMenuItem CHildMenu in MainMenu.DropDownItems)
                {
                    string Nam1 = CHildMenu.Name;
                    string txt1 = CHildMenu.Text;

                    Program.allMenuStripItems.Add(CHildMenu);

                    foreach (ToolStripMenuItem SubChildMneu in CHildMenu.DropDownItems)
                    {
                        string Nam2 = SubChildMneu.Name;
                        string txt2 = SubChildMneu.Text;

                        Program.allMenuStripItems.Add(SubChildMneu);
                    }
                }
            }
        }

      

        public void FormResolution(Form frm)
        {
            frm.WindowState = FormWindowState.Maximized;
            frm.StartPosition = FormStartPosition.CenterParent;
        }

        public void FormCLose()
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
        }

        #region Master

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Masters.MaterialDetails cd = new Masters.MaterialDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Masters.MaterialDetails cd = new Masters.MaterialDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Masters.VendorDetails cd = new Masters.VendorDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCLose();
            Masters.CustomerDetails cd = new Masters.CustomerDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        #endregion

        #region Transaction

        private void accountledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Transaction.PurchaseDetails cd = new Transaction.PurchaseDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Transaction.SalesDetails cd = new Transaction.SalesDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////FormCLose();
            ////Transaction.ProductionDetails cd = new Transaction.ProductionDetails();
            ////FormResolution(cd);
            ////cd.MdiParent = this;
            //////cd.Dock = DockStyle.Fill;
            ////cd.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Transaction.Stock cd = new Transaction.Stock();
            FormResolution(cd);
            cd.MdiParent = this;
            //cd.Dock = DockStyle.Fill;
            cd.Show();
        }

        #endregion

        #region Configuration

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLose();
            Authentication.NewUserDetails cd = new Authentication.NewUserDetails();
            FormResolution(cd);
            cd.MdiParent = this;
            cd.Show();
        }

        private void userAutherisationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Program.globalString = "";
            Authentication.LoginPage log = new Authentication.LoginPage();
            log.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mastersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
