using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class NhanVienDAL
    {
        // Lấy toàn bộ danh sách khách hàng 
        public static DataTable Tra_ds_KH()
        {
            string sql = "select * from tblNhanVien";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static void ThemNV(NhanVien nhanvien)
        {
            string sql = "Insert into tblNhanVien values(N'" + nhanvien.MaNhanVien1 +"',N'" + nhanvien.TenNhanVien1 + "',N'" + nhanvien.GioiTinh1 + "','" + nhanvien.DiaChi1 + "', '" + nhanvien.DienThoai1 + "', '" + nhanvien.NgaySinh1 + "')";
            DBAccess.thucthi(sql);
        }
    }
}
