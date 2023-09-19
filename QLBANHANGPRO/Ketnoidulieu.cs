using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBANHANGPRO
{
     public class Ketnoidulieu
    {
        
       public string strconn = "Data Source=TRUNG;Initial Catalog=QUANLYBANHANG;Integrated Security=True";
       public SqlConnection conn = null;
       

        public void Myopen()
        {
            if (conn==null)  conn = new SqlConnection(strconn);
            if (conn.State==ConnectionState.Closed) conn.Open();
        }
        public void Myclosed()
        {
            if(conn!=null) conn.Close();
            if(conn.State==ConnectionState.Open) conn.Close();
        }
        public DataTable Taobang(string sql)
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
            return dt;
        }
    }
}
