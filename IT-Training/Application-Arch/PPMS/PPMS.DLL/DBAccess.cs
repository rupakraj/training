using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
 
namespace PPMS.DLL
{
   public  class DBAccess
    {
        public static string ConnectionString = "";
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter sda;

        public DBAccess()
        {
            conn = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
        }
        public bool Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                return true;
            }
            else
            {
                return false;
            }            
        }
        public bool Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ExecuteNonQuery(string sql)
        {
            Open();
            cmd = new SqlCommand(sql, conn);
            int rows_affected = cmd.ExecuteNonQuery();
            Close();
            return rows_affected;
        }

        public DataTable ExecuteDataTable(string sql)
        {
            Open();
            sda = new SqlDataAdapter(sql, conn);
            DataTable dtResult = new DataTable();
            sda.Fill(dtResult);
            Close();
            return dtResult;
        }

    }
}
