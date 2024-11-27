using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;

namespace Inventry_Management_System.DAL
{

    public class Connection
    {
        public OleDbConnection connection;
        private string server;
        private string database;
        private string port;
        private string uid;
        private string password;
        private int PageSize = 10; // 10 rows per page
        private int TotalPage;
               

    public Connection()
    {
            //        server = System.Configuration.ConfigurationManager.AppSettings["SERVER"];//"127.0.0.1";
            //            database = "inventry_management_system";//"tc_certificate";
            //        uid = System.Configuration.ConfigurationManager.AppSettings["UID"];//"root";
            //        password = System.Configuration.ConfigurationManager.AppSettings["PASSWORD"];//"";
            //            port = System.Configuration.ConfigurationManager.AppSettings["PORT"];//""; 

            //                string connectionString;
            //            connectionString = "SERVER=" + server + ";PORT=" + port + ";" + "DATABASE=" +
            //database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=Preferred;";
            //server = "Microsoft.ACE.OLEDB.12.0";
            //port = "H:\\BCA Projects\\Akash BCA Mini Project  New\\inventry_management_system.accdb";
            string connectionString;
            //connectionString = @"PROVIDER = " + server + ";DATA SOURCE=" + port + ";" ;
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\\Final Invetry\\Inventry_Management_SystemFinal\\Inventry_Management_System\\bin\\Debug\\inventry_management_system.mdb'";
            connection = new OleDbConnection(connectionString);
    }

    public bool MakeConnection()
    {
        try
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        catch(Exception)
        {
            DialogResult result = MessageBox.Show("Are You are Not Connected With database. Are You to Restore New DB ???? " , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string file;
                file = @"C:\\Program Files(x86)\\Total\\TC Certificate\\tc_certificate.sql";
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.WorkingDirectory = @"C:\\MySQL\\bin\\";
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.Start();
                StreamWriter myStreamWriter = myProcess.StandardInput;
                StreamReader mystreamreader = myProcess.StandardOutput;
                myStreamWriter.WriteLine("mysql -u " + uid + " --password=" + password + " -h " + server + " \" " + database + "\" < \"" + file + "\" ");
                myStreamWriter.Close();
                myProcess.WaitForExit();
                myProcess.Close();
                MessageBox.Show("Database Restoration Successfully!");
            }
        }
        return true;
    }

    public void Backup(string Path)
    {
        string database = connection.Database.ToString();
        try
        {                
            using (OleDbCommand cmd = new OleDbCommand())
            {
                //using (MySqlBackup mb = new MySqlBackup(cmd))
                //{
                //    cmd.Connection = connection;
                //    if (MakeConnection() != false)
                //    {
                //        mb.ExportToFile(Path);
                //    }
                //}
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Your Error : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

            //For Get Max Id
    public Int32 GetMaxId(string table,string field)
    {
        Int32 maxid = 0;
        if (MakeConnection())
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT MAX(" + field + ") FROM " + table, connection);
                
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (string.IsNullOrEmpty(dr[0].ToString()))
                {
                    maxid = 1;
                }
                else
                {
                    maxid = Convert.ToInt32(dr[0].ToString()) + 1;
                    dr.Close();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Your Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        return maxid;
    }

        //For Get Total Page Count
    public Int32 GetTotalPageCount(string table, string field)
    {
        if (MakeConnection())
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT MAX(" + field + ") FROM " + table, connection);
                //int rowCount = (int)cmd.ExecuteScalar();
                OleDbDataReader dr;//= new OleDbDataReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                int rowCount = Convert.ToInt32(dr[0].ToString());
                dr.Close();
                    this.TotalPage = rowCount / PageSize;

                    if (rowCount % PageSize > 0)
                    {
                        this.TotalPage += 1;
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Your Error : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return TotalPage;
        }

        //For Get Page Data
        public DataTable GetPageData(int page, string table)
        {
            DataTable dt = new DataTable();
            if (MakeConnection())
            {
                try
                {
                    if (page == 1)
                    {
                        OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM " + table + " where Action!='N' Order By Id Limit " + PageSize, connection);
                        cmd.Fill(dt);
                    }
                    else
                    {
                        int lowerPageBoundary = (page - 1) * PageSize;
                        OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * FROM "+ table + " where Action!='N' ORDER BY Id LIMIT " + PageSize + " OFFSET "+ PageSize, connection);
                        cmd.Fill(dt);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;            
        }
    }
}
