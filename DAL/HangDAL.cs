using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class HangDAL
    {
        public static DataTable Tra_ds_hang()
        {
            string sql = "select * from tblHang";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static DataTable Tim_Kiem_MaHang(string mahang)
        {

            string sql = "select * from tblHang where MaHang='" + mahang + "'";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
    }
}
