using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPMS.BLL;

namespace PPMS.WIN
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

            string connString = PPMS.WIN.Properties.Settings.Default.connString;
            DBInit.InitDatabase(connString);

            Application.Run(new Form1());
        }
    }
}
