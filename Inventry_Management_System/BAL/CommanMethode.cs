using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Data.OleDb;

namespace Inventry_Management_System.BAL
{
    class CommanMethode
    {
        DAL.Connection cn = new DAL.Connection();
        OleDbDataReader dr = null;
        DataTable dt = new DataTable();

        public void FormCLose()
        {
            //OleDbCommand cmd1 = new OleDbCommand("SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'tc_certificate'", cn.connection);


            //Masters.Customer.ActiveForm.Close();
            //Masters.CustomerDetails.ActiveForm.Close();
            //Masters.MaterialDetails.ActiveForm.Close();
            //Masters.Material.ActiveForm.Close();
            //Masters.ChemicalForm.ActiveForm.Close();
            //Masters.ChemicalDetails.ActiveForm.Close();
            //Masters.MechanicalForm.ActiveForm.Close();
            //Masters.MechanicalDetails.ActiveForm.Close();
            //Masters.GradeDetails.ActiveForm.Close();
            //Masters.Grade.ActiveForm.Close();
        }

        public AutoCompleteStringCollection ValueDataSuggestion(string TableName, string FieldName)
        {            
            AutoCompleteStringCollection Coll = new AutoCompleteStringCollection();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT " + FieldName + " FROM " + TableName, cn.connection);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //Coll.Add(dr.GetString(FieldName.ToString()));
                    }
                    dr.Close();
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
            return Coll;
        }

        public AutoCompleteStringCollection ValueDataSuggestionTransaction(string TableName, string FieldName1, string FieldName2, string FieldName3,string grade)            
        {
            AutoCompleteStringCollection Coll = new AutoCompleteStringCollection();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT " + FieldName1 + " , " + FieldName2 + " , " + FieldName3 + " FROM " + TableName + " WHERE Action!='N' and GradeId = " + grade + " group by " + FieldName1 + " , " + FieldName2 + " , " + FieldName3, cn.connection);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (!string.IsNullOrEmpty(dr[FieldName1].ToString()))
                        {
                            Coll.Add(dr[FieldName1].ToString());
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName2].ToString()))
                        {
                            Coll.Add(dr[FieldName2].ToString());
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName3].ToString()))
                        {
                            Coll.Add(dr[FieldName3].ToString());
                        }
                    }
                    dr.Close();
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
            return Coll;
        }


        public DataTable ValueDataSuggestiondataRow(string TableName, string FieldName1, string FieldName2, string FieldName3, string grade, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("HCN");
            //DataSet ds = new DataSet();
            if (cn.MakeConnection() != false)
            {
                try
                {
                    //OleDbDataAdapter da = new OleDbDataAdapter("SELECT " + FieldName1 + " , " + FieldName2 + " , " + FieldName3 + " FROM " + TableName + " WHERE Action!='N' and GradeId = " + grade + " group by " + FieldName1 + " , " + FieldName2 + " , " + FieldName3, cn.connection);
                    OleDbCommand cmd = new OleDbCommand("SELECT " + FieldName1 + " , " + FieldName2 + " , " + FieldName3 + " FROM " + TableName + " WHERE Action!='N' and GradeId = " + grade + " group by " + FieldName1 + " , " + FieldName2 + " , " + FieldName3, cn.connection);
                    //cmd.Fill(dt1);
                    //da.Fill(ds, "Hcnumber");

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (!string.IsNullOrEmpty(dr[FieldName1].ToString()))
                        {
                            DataRow dr1 = dt1.NewRow();
                            dr1[0]= dr[FieldName1].ToString();                            
                            dt1.Rows.Add(dr1);
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName2].ToString()))
                        {
                            DataRow dr1 = dt1.NewRow();
                            dr1[0] = dr[FieldName2].ToString();
                            dt1.Rows.Add(dr1);
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName3].ToString()))
                        {
                            DataRow dr1 = dt1.NewRow();
                            dr1[0] = dr[FieldName3].ToString();
                            dt1.Rows.Add(dr1);
                        }
                    }
                    dr.Close();

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
            return dt1;
        }

        public AutoCompleteStringCollection ValueDataSuggestionTransaction1(string TableName, string FieldName1, string FieldName2, string FieldName3, string grade, string SearcherText)
        {
            AutoCompleteStringCollection Coll = new AutoCompleteStringCollection();
            if (cn.MakeConnection() != false)
            {
                try
                {                    
                    OleDbCommand cmd = new OleDbCommand("SELECT " + FieldName1 + " , " + FieldName2 + " , " + FieldName3 + " FROM " + TableName + " WHERE Action!='N' and GradeId = " + grade + " group by " + FieldName1 + " , " + FieldName2 + " , " + FieldName3, cn.connection);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (!string.IsNullOrEmpty(dr[FieldName1].ToString()))
                        {
                            Coll.Add(dr[FieldName1].ToString());
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName2].ToString()))
                        {
                            Coll.Add(dr[FieldName2].ToString());
                        }
                        if (!string.IsNullOrEmpty(dr[FieldName3].ToString()))
                        {
                            Coll.Add(dr[FieldName3].ToString());
                        }
                    }
                    dr.Close();
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
            return Coll;
        }

        public string reletionInfo(string tableName, string columnName, int refId)
        {
            string rt = "";
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();

            //This Connection For Fill Only Grade Containt
            if (cn.MakeConnection() != false)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select Id from " + tableName + " where Action!='N' and " + columnName + " = " + refId, cn.connection);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        rt = "Y";
                        //OldGrade1 = dr[0].ToString();
                    }
                    else
                    {
                        rt = "N";
                    }
                    dr.Close();
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
            return rt;
        }

        //public void AutoSize(this Control objForm, int Width)
        //{
        //    foreach (Control ctrl in objForm.Controls)
        //    {
        //        //if (ctrl.GetType() == typeof(SunGroupBox))
        //        //{
        //        //    SunGroupBox objSunGroupBox = (SunGroupBox)ctrl;
        //        //    if (objSunGroupBox.Name.ToUpper() == "gpBoxMain".ToUpper())
        //        //        objSunGroupBox.Location = new System.Drawing.Point((Width / 2) - (objSunGroupBox.Width / 2), objSunGroupBox.Top);
        //        //    else if (objSunGroupBox.Name.ToUpper() == "gpBoxBtn".ToUpper())
        //        //        objSunGroupBox.Location = new System.Drawing.Point((Width / 2) - (objSunGroupBox.Width / 2), objSunGroupBox.Top);

        //        //}
        //        //if (ctrl.HasChildren)
        //        //    ctrl.AutoSize(Width);
        //    }
        //}
    }
}
