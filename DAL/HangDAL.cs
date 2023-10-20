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
        public static void Them_HANG(HangDTO them)
        {
            string sql = "Insert into tblHang values('" + them.MaHang1 + "','" + them.TenHang1 + "','" + them.MaChatLieu1 + "','" + them.SoLuong1 + "','" + them.DonGiaNhap1 + "','" + them.DonGiaBan1 + "','" + them.GhiChu1 + "')";

            DBAccess.thucthi(sql);

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
    }
}
