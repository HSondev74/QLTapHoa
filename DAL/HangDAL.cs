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
        public static void Them_HANG(HangDTO them)
        {
            string con = @"Data Source=DESKTOP-D5DH8VK\SQLEXPRESS;Initial Catalog=QLTapHoa;Integrated Security=True";
            string sql1 = "select * from tblHang where MaHang='" + them.MaHang1 + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã Đã Tồn Tại");
                return;
            }
            string sql = "Insert into tblHang values('" + them.MaHang1 + "','" + them.TenHang1 + "','" + them.MaChatLieu1 + "','" + them.SoLuong1 + "','" + them.DonGiaNhap1 + "','" + them.DonGiaBan1 + "','" + them.GhiChu1 + "')";
            DBAccess.thucthi(sql);
            MessageBox.Show("Bạn đã lưu hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Sua_Hang(HangDTO sua)
        {
            string sql = "update tblHang set TenHang='" + sua.TenHang1 +
            "',MaChatLieu='" + sua.MaChatLieu1 +
            "',SoLuong='" + sua.SoLuong1 +
            "',DonGiaNhap='" + sua.DonGiaNhap1 +

            "',DonGiaBan='" + sua.DonGiaBan1 +
            "',GhiChu='" + sua.GhiChu1 + "'  where MaHang = '" + sua.MaHang1 + "'";

            DBAccess.thucthi(sql);
        }
        public static void Xoa_Hang(HangDTO xoa)
        {


            string sql = "delete from tblHang where MaHang='" + xoa.MaHang1 + "'";
            DBAccess.thucthi(sql);
        }
        //public static string Check_MaHang(HangDTO mahang)
        //{

        //    string sql = "select * from tblHang where MaHang='" + mahang.MaHang1 + "'";


        //    return sql;
        //}
    }
}
