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
    public partial class Purchase : Form
    {
        public Int32 Id = 0;
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //ShowReport(1);
            this.reportViewer1.RefreshReport();
        }

        public void ShowReport(Int32 Trn_Id)
        {
            Id = Trn_Id;

            DAL.Connection dal_con = new DAL.Connection();
            ReportDataset.purchase_master Ds_PurchaseInfo = new ReportDataset.purchase_master();
            ReportDataset.purchase_details Ds_PurchaseDetailsInfo = new ReportDataset.purchase_details();

            // For Company Details
            if (dal_con.MakeConnection() != false)
            {
                try
                {
                    //Int32 Id = 1;
                    OleDbDataAdapter cmd = new OleDbDataAdapter("select * from purchase_master where Action!='N' and Id=" + Trn_Id, dal_con.connection);
                    cmd.Fill(Ds_PurchaseInfo, Ds_PurchaseInfo.Tables["purchase_master"].TableName);

                    OleDbDataAdapter cmd1 = new OleDbDataAdapter("select m.Material_Name as Purchase_MaterialId, pd.Purchase_Quantity,pd.Purchase_Price,pd.Purchase_PricePerPice from purchase_details pd, material_master m where pd.Action!='N' and pd.Purchase_MaterialId=m.Id and pd.Purchase_Id=" + Trn_Id, dal_con.connection);
                    cmd1.Fill(Ds_PurchaseDetailsInfo, Ds_PurchaseDetailsInfo.Tables["purchase_details"].TableName);

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
            ReportDataSource rds1 = new ReportDataSource("purchase_master", Ds_PurchaseInfo.Tables["purchase_master"]);
            ReportDataSource rds2 = new ReportDataSource("purchase_details", Ds_PurchaseDetailsInfo.Tables["purchase_details"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Show();

        }
    }
}
