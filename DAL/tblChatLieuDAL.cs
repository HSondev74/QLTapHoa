using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class tblChatLieuDAL
    {
        public static DataTable Tra_DS_CL()
        {
            string sql = "select * from tblChatLieu";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }

        public static DataTable timkiem(string ma)
        {
            string sql = "select * from tblChatLieu where MaChatLieu = '" + ma + "' ";
            //DBAccess db = new DBAccess();
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }

        public static void luu_CL(tblChatLieuDTO cl)
        {
            string chuoikn = @"Data Source=DESKTOP-6S7IODU;Initial Catalog=QLTapHoa1;Integrated Security=True";
            string sql = "select * from tblChatLieu where MaChatLieu = '" + cl.MaChatLieu1 + "' ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, chuoikn);
            DataTable dt = DBAccess.truyvan(sql);
            dap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ma da ton tai");
                return;
            }
            string sql1 = $"insert into tblChatLieu values(N'" + cl.MaChatLieu1 + "', N'" + cl.TenChatLieu1 + "')";
            DBAccess.thucthi(sql1);
        }

        public static void sua_CL(tblChatLieuDTO cl)
        {
            string sql = "update tblChatLieu set TenChatLieu = N'" + cl.TenChatLieu1 + "' where MaChatLieu = '" + cl.MaChatLieu1 + "' ";
            DBAccess.thucthi(sql);
        }

        public static void xoa_CL(tblChatLieuDTO cl)
        {
            //string sql2 = "delete from tblHang where MaChatLieu = '" + cl.MaChatLieu1 + "' ";
            //DBAccess.thucthi(sql2);
            string sql = "delete from tblChatLieu where MaChatLieu = '" + cl.MaChatLieu1 + "' ";
            DBAccess.thucthi(sql);
        }
    }
}
