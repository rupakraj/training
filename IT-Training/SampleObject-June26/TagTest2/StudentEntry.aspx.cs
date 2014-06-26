using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TagTest2.Code;

namespace TagTest2
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //TagTest2.Code.Student
            Student objStudent = new Student();
            objStudent.ClassName = ddlClass.SelectedItem.Text;
            objStudent.StudentID = Convert.ToInt32( txtID.Text);
            objStudent.StudentName = txtName.Text.Trim();

            if (rdoMale.Checked == true)
            {
                objStudent.Gender = "Male";
            }
            else
            {
                objStudent.Gender = "Female";
            }

            Response.Write(objStudent.StudentName);

            
        }
    }
}