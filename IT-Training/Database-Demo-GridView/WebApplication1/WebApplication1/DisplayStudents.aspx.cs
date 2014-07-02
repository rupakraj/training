using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class DisplayStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("User ID=sa;Initial Catalog=ITTraingG3;Data Source=RAJ\\SQLEXPRESS;Password=raj;");
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblStudent where StuAddress ='ktm' ", conn);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}