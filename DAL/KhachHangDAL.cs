using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        public static DataTable Tra_ds_khachhang()
        {
            string sql = "select * from tblKhach";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static void Them_ChiTietKH(KhachHangDTO them)
        {
            string sql = "Insert into tblKhach values('" + them.MaKhach1 + "','" + them.TenKhach1 + "','" + them.DiaChi1 + "','" + them.DienThoai1 + "')";

            DBAccess.thucthi(sql);

        }
        public static void Sua_KH(KhachHangDTO sua)
        {
            string sql = "update tblKhach set TenKhach='" + sua.TenKhach1 +
            "',DiaChi='" + sua.DiaChi1 +
            "',DienThoai='" + sua.DienThoai1 + "'  where MaKhach = '" + sua.MaKhach1 + "'";

            DBAccess.thucthi(sql);
        }
        public static void Xoa_KH(KhachHangDTO xoa)
        {
            string sql = "delete from tblKhach where MaKhach='" + xoa.MaKhach1 + "'";
            DBAccess.thucthi(sql);
        }
        public static DataTable Tim_Kiem_MaNhanVien(string makhach)
        {

            string sql = "select * from tblKhach where MaKhach='" + makhach + "'";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static bool kiemtratrungma(KhachHangDTO bien)
        {
            string sql = $"select MaKhach from tblKhach where MaKhach='{bien}'";
            DataTable dt = DBAccess.truyvan(sql);
            if (dt.Rows.Count == 1) return true;
            return false;
        }
    }
}
