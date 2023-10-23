﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBAccess
    {
        

        public static SqlConnection taoketnoi()
        {
            string chuoikn = @"Data Source=DESKTOP-6S7IODU;Initial Catalog=QLTapHoa1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            return conn;
        }
        public static DataTable truyvan(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = taoketnoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public static void thucthi(string sql)
        {
            SqlConnection conn = taoketnoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

      
    }
}
