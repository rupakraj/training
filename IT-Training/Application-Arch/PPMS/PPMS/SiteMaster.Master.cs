using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPMS
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                lblUsername.Text = "Welcome: " + Session["username"].ToString();
                lblUsername.Text += " <a href='Login.aspx'> Logout</a>";
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}