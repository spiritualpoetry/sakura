using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sakura
{
    public class DBHerlper
    {
        public static string ConnString = "server=.;database=waimai;uid=sa;pwd=123456";
        public static DataTable GetDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        public static bool ExecuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int jieguo = cmd.ExecuteNonQuery();
            conn.Close();
            return jieguo > 0;
        }
    }
}