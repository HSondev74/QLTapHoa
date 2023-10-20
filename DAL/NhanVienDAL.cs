using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class NhanVienDAL
    {
        // Lấy toàn bộ danh sách khách hàng 
        public static DataTable Tra_ds_nhanvien()
        {
            string sql = "select * from tblNhanVien";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static void Them_NV(NhanVienDTO them)
        {
            string sql = "Insert into tblNhanVien values('" + them.MaNhanVien1 + "','" + them.TenNhanVien1 + "','" + them.GioiTinh1 + "','" + them.DiaChi1 + "','" + them.DienThoai1 + "','" + them.NgaySinh1 + "')";

            DBAccess.thucthi(sql);

        }
        public static void Sua_NV(NhanVienDTO sua)
        {
            string sql = "update tblNhanVien set TenNhanVien='" + sua.TenNhanVien1 +
            "',GioiTinh='" + sua.GioiTinh1 +
            "',DiaChi='" + sua.DiaChi1 +
            "',DienThoai='" + sua.DienThoai1 +
            "',NgaySinh='" + sua.NgaySinh1 + "'  where MaNhanVien = '" + sua.MaNhanVien1 + "'";

            DBAccess.thucthi(sql);
        }
        public static void Xoa_NV(NhanVienDTO xoa)
        {
            

            string sql = "delete from tblNhanVien where MaNhanVien='" + xoa.MaNhanVien1 + "'";
            DBAccess.thucthi(sql);
        }

    }
}
