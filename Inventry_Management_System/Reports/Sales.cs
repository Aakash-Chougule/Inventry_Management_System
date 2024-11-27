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
    public partial class Sales : Form
    {
        public Int32 Id = 0;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            //ShowReport(1);
            this.reportViewer1.RefreshReport();
        }

        public void ShowReport(Int32 Trn_Id)
        {
            Id = Trn_Id;

            DAL.Connection dal_con = new DAL.Connection();
            ReportDataset.sales_master Ds_SalesInfo = new ReportDataset.sales_master();
            ReportDataset.sales_details Ds_SalesDetailsInfo = new ReportDataset.sales_details();

            // For Company Details
            if (dal_con.MakeConnection() != false)
            {
                try
                {
                    //Int32 Id = 1;
                    OleDbDataAdapter cmd = new OleDbDataAdapter("select * from sales_master where Action!='N' and Id=" + Trn_Id, dal_con.connection);
                    cmd.Fill(Ds_SalesInfo, Ds_SalesInfo.Tables["sales_master"].TableName);

                    OleDbDataAdapter cmd1 = new OleDbDataAdapter("select m.Material_Name as Sales_MaterialId, pd.Sales_Quantity,pd.Sales_Price,pd.Sales_PricePerPice from sales_details pd, material_master m where pd.Action!='N' and pd.Sales_MaterialId=m.Id and pd.Sales_Id=" + Trn_Id, dal_con.connection);
                    cmd1.Fill(Ds_SalesDetailsInfo, Ds_SalesDetailsInfo.Tables["sales_details"].TableName);

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
            ReportDataSource rds1 = new ReportDataSource("sales_master", Ds_SalesInfo.Tables["sales_master"]);
            ReportDataSource rds2 = new ReportDataSource("sales_details", Ds_SalesDetailsInfo.Tables["sales_details"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();

        }
    }
}
