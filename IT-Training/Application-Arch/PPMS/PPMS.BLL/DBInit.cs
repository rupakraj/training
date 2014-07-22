using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMS.DLL;

namespace PPMS.BLL
{
    public class DBInit
    {
        public static void InitDatabase(string connString){
            DBAccess.ConnectionString = connString;
        }
    }
}
