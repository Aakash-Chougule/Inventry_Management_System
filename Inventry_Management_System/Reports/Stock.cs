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
using Microsoft.Reporting.WinForms;

namespace Inventry_Management_System.Reports
{
    public partial class Stock : Form
    {
        public Int32 Id = 0;
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //ShowReport(1);
            this.reportViewer1.RefreshReport();
        }

        public void ShowReport()
        {
            DAL.Connection dal_con = new DAL.Connection();
            ReportDataset.stock_details Ds_StockInfo = new ReportDataset.stock_details();

            // For Company Details
            if (dal_con.MakeConnection() != false)
            {
                try
                {

                    OleDbDataAdapter cmd = new OleDbDataAdapter("select m.Material_Name, pd.Stock_Quantity from stock_details pd, material_master m where pd.Action!='N' and pd.Stock_MaterialId=m.Id", dal_con.connection);
                    cmd.Fill(Ds_StockInfo, Ds_StockInfo.Tables["stock_details"].TableName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    dal_con.connection.Close();
                }
            }
            ReportDataSource rds1 = new ReportDataSource("stock_details", Ds_StockInfo.Tables["stock_details"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();

        }
    }
}
