using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPMS.BLL;
using PPMS.DTO;
using System.Data;

namespace PPMS
{
    public partial class FuleType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FuelTypeBLL fuelTypeBLL = new FuelTypeBLL();
            // alt 1
            gvTable.DataSource = fuelTypeBLL.GetFuelTypes();
            gvTable.DataBind();

            //alt 2
            DataTable dt = fuelTypeBLL.GetFuelTypes();

            string table = "<table id ='data-table'><tr><th>SN</th><th>Name</th><th></th></tr>";
            int sn=0;
            foreach (DataRow dr in dt.Rows)
            {
                sn++;
                table += "<tr><td>" + sn + "</td>"+
                    "<td><strong>"+dr["FuelTypeName"]+"</strong></td>"+
                    "<td><a href='#'>Edit</a></td>"+
                    "<td><a href='#' onclick=\"return confirm('Do you want to delete?')\">Delete</a></td>" +
                    "</tr>";
            }
            table += "</table>";
            lblTable.Text = table;
        }
    }
}