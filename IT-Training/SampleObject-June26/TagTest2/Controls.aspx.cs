using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TagTest2
{
    public partial class Controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status;
            status = CheckBox1.Checked;
            if (status == true)
            {
                DropDownList1.Visible = true; 
            }
            else
            {
                DropDownList1.Visible = false;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            text = DropDownList1.SelectedItem.Text;
            //lblSelected.Text = "Your Text is :" + text;
            lblSelected.Text = "Your selected Index is " + DropDownList1.SelectedIndex;
        }
    }
}