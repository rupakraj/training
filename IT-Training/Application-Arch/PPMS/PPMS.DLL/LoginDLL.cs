using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMS.DTO;
using System.Data;

namespace PPMS.DLL
{
    public class LoginDLL
    {
        DBAccess db;

        public bool VerifyUser(LoginDTO loginDTO)
        {
            db = new DBAccess();
            string sql = @"Select * from Users where 
            username='" + loginDTO.UserName + "' and password = '" + loginDTO.PassWord + "'";
            DataTable dtUsers = new DataTable();
            dtUsers = db.ExecuteDataTable(sql);
            if (dtUsers.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
