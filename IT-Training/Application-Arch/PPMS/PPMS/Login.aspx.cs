using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPMS.DTO;
using PPMS.BLL;

namespace PPMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();
            //LoginDTO loginDTO = new LoginDTO();
            //loginDTO.UserName = txtUserName.Text;
            //loginDTO.PassWord = txtPassWord.Text;
            LoginDTO loginDTO = new LoginDTO
            {
                UserName = txtUserName.Text,
                PassWord = txtPassWord.Text
            };
           // bool ret_val = loginBLL.VerifyUser(loginDTO);
            bool ret_val = loginBLL.VerifyUser(new LoginDTO
                                {
                                    UserName = txtUserName.Text,
                                    PassWord = txtPassWord.Text
                                });

            if (ret_val == true)
            {
                Response.Write("Login success");
            }
            else
            {
                Response.Write("Login failed");
            }


        }
    }
}