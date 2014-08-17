using PPMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPMS
{
    public partial class InflowAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    //get fuel types
                    FuelTypeBLL fuelTypeBll = new FuelTypeBLL();
                    DataTable dt = new DataTable();
                    dt = fuelTypeBll.GetFuelTypes();
                    //assign to the ddl
                    ddlFuelTypes.DataSource = dt;
                    ddlFuelTypes.DataTextField = "FuelTypeName";
                    ddlFuelTypes.DataValueField = "FuelTypeID";
                    ddlFuelTypes.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblSelectedValue.Text = ddlFuelTypes.SelectedValue +" = " + ddlFuelTypes.SelectedItem.Text;
        }
    }
}