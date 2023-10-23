using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public static DataTable Tra_DS_NCC()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }

        public static DataTable timkiem(string ma)
        {
            string sql = "select * from NhaCungCap where MaNCC = '" + ma + "' ";
            //DBAccess db = new DBAccess();
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }

        public static void luu_NCC(NhaCungCapDTO ncc)
        {
            string chuoikn = @"Data Source=DESKTOP-6S7IODU;Initial Catalog=QLTapHoa1;Integrated Security=True";
            string sql = "select * from NhaCungCap where MaNCC = '" + ncc.MaNCC1 + "' ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, chuoikn);
            DataTable dt = DBAccess.truyvan(sql);
            dap.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("ma da ton tai");
                return;
            }
            string sql1 = $"insert into NhaCungCap values(N'" + ncc.MaNCC1 + "', N'" + ncc.TenNCC1 + "', N'" + ncc.DienThoai1 + "', N'" + ncc.DiaChi1 + "' )";
            DBAccess.thucthi(sql1);
        }

        public static void sua_NCC(NhaCungCapDTO ncc)
        {
            string sql = "update NhaCungCap set TenNCC = N'" + ncc.TenNCC1 + "', DienThoai = '" + ncc.DienThoai1 + "', DiaChi = '" + ncc.DiaChi1 + "' where MaNCC = '" + ncc.MaNCC1 + "' ";
            DBAccess.thucthi(sql);
        }

        public static void xoa_NCC(NhaCungCapDTO ncc)
        {
            string sql = "delete from NhaCungCap where MaNCC = '" + ncc.MaNCC1 + "' ";
            DBAccess.thucthi(sql);
        }
    }
}
