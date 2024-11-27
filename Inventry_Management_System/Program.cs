using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskScheduler;

using System.Threading;

namespace Inventry_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentication.LoginPage());
        }

       
        public static void MdiEnable()
        {

        }

        public static void MdiActiv()
        {

        }
               

        public static string globalString = "";
        public static string log_Dt_Tim = "";
        public static string Temp_Daily_Att_Date = "";

        public static string userAuth = "";
        public static string UserId = "";
        public static List<ToolStripMenuItem> allMenuStripItems = new List<ToolStripMenuItem>();
    }
}
