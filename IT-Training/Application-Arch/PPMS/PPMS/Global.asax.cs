using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using PPMS.BLL;

namespace PPMS
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            string connString = PPMS.Properties.Settings.Default.ConnString;
            DBInit.InitDatabase(connString);
        }
    }
}