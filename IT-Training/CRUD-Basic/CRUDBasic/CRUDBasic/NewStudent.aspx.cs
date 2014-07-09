using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace CRUDBasic
{
    public partial class NewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            lblUserName.Text = username;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=RAJ\SQLEXPRESS; User ID=sa; Password=raj; Initial Catalog=ITTraingG3;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = "insert into tblStudent ";
            sql += " ( stuName, stuAddress, RollNo )";
            sql += @" values('" + txtName.Text.Trim() +
                @"','" + txtAddress.Text.Trim() +
                @"','" + txtRollNo.Text.Trim() + @"')";

            //SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            int rows_affected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows_affected == 1)
            {
                Response.Write("Saved Successfully");
            }
            else
            {
                Response.Write("Failed");
            }
        }
    }
}