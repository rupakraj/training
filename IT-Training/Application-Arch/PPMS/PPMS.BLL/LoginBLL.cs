using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMS.DTO;
using PPMS.DLL;

using System.IO;


namespace PPMS.BLL
{
   public  class LoginBLL
    {
       LoginDLL loginDLL;

       public bool VerifyUser(LoginDTO loginDTO)
       {
           //string val= File.ReadAllText("abc.txt");

           loginDLL = new LoginDLL();
          //bool ret_val = loginDLL.VerifyUser(loginDTO);
          //return ret_val;
           return loginDLL.VerifyUser(loginDTO);
       }
    }
}
