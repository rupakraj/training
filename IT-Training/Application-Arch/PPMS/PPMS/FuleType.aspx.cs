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

            if (!IsPostBack)
            {
                string act = "";
                if (!string.IsNullOrEmpty(Request.QueryString["act"]))
                { act = Request.QueryString["act"]; }
                else
                {
                    act = "list";
                }

                if (act == "add") ResetControls();
                else if (act == "edit")
                {
                    string id = "";
                    if (string.IsNullOrEmpty(Request.QueryString["id"]))
                    {
                        Response.Redirect("FuleType.aspx?act=list", true);
                    }
                    else
                    {
                        id = Request.QueryString["id"];
                        FuelTypeBLL bll = new FuelTypeBLL();
                        FuelTypeDTO dto = bll.GetFuelType(Convert.ToInt32(id));
                        txtFuelTypeName.Text = dto.FuleTypeName;
                        btnSave.Text = "Update";
                    }
                }
                else if (act == "del")
                {
                    string id = "";
                    if (string.IsNullOrEmpty(Request.QueryString["id"]))
                    {
                        Response.Redirect("FuleType.aspx?act=list", true);
                    }
                    else
                    {
                        id = Request.QueryString["id"];
                         
                        FuelTypeBLL bll = new FuelTypeBLL();

                        try
                        {
                            if (bll.DeleteFuelType(Convert.ToInt32(id)))
                            {
                                Session["Info"] = "Fuel Type Sucessfully deleted.";
                                Response.Redirect("FuleType.aspx?act=list", true); 
                            }
                            else
                            {
                                Session["Error"] = "Delete Failed.";
                                Response.Redirect("FuleType.aspx?act=list", true); 
                            }
                        }
                        catch (Exception ex)
                        {
                                Session["Error"] = "Delete Failed."+ ex.Message;
                                Response.Redirect("FuleType.aspx?act=list", true); 
                        }
                    }
                }
                else LoadList();
            }            
        }
        private void ResetControls()
        {
            txtFuelTypeName.Text = "";
            btnSave.Text = "Save";
        }
        private void LoadFuelType(string id)
        {
            //ToDo
        }
        private void LoadList()
        {
            FuelTypeBLL fuelTypeBLL = new FuelTypeBLL();
            // alt 1
            gvTable.DataSource = fuelTypeBLL.GetFuelTypes();
            gvTable.DataBind();

            //alt 2
            DataTable dt = fuelTypeBLL.GetFuelTypes();

            string table = "<table id ='data-table'><tr><th>SN</th><th>Name</th><th></th></tr>";
            int sn = 0;
            foreach (DataRow dr in dt.Rows)
            {
                sn++;
                table += "<tr><td>" + sn + "</td>" +
                    "<td><strong>" + dr["FuelTypeName"] + "</strong></td>" +
                    "<td><a href='FuleType.aspx?act=edit&id=" + dr["FuelTypeID"].ToString() + "'>Edit</a></td>" +
                    "<td><a href='FuleType.aspx?act=del&id=" + dr["FuelTypeID"].ToString() + "' onclick=\"return confirm('Do you want to delete?')\">Delete</a></td>" +
                    "</tr>";
            }
            table += "</table>";
            lblTable.Text = table;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                // Add new Fuel Types
                
            }
            else
            {
                 string id = "";
                 if (string.IsNullOrEmpty(Request.QueryString["id"]))
                 {
                     Response.Redirect("FuleType.aspx?act=list", true);
                 }
                 else
                 {
                     id = Request.QueryString["id"];
                     //update
                     FuelTypeDTO dto = new FuelTypeDTO();
                     dto.FuelTypeID = Convert.ToInt32(id);
                     dto.FuleTypeName = txtFuelTypeName.Text;
                     FuelTypeBLL bll = new FuelTypeBLL();
                     if (bll.UpdateFuelType(dto))
                     {
                         Session["Info"] = "Date Edited Successfully";
                         Response.Redirect("FuleType.aspx?act=list", true);
                     }
                     else
                     {
                         Response.Redirect("FuleType.aspx?act=edit&id="+id, true);
                     } 
                 }
            }
        }
    }
}