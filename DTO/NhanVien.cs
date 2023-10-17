using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string MaNhanVien;
        private string TenNhanVien;
        private string GioiTinh;
        private string DiaChi;
        private string DienThoai;
        private DateTime NgaySinh;
        

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
       

        public NhanVien()
        { }
        public NhanVien(string maNhanVien, string tenNhanVien, string gioiTinh, string diaChi, string dienThoai, DateTime ngaySinh)
        {
            MaNhanVien1 = maNhanVien;
            TenNhanVien1 = tenNhanVien;
            GioiTinh1 = gioiTinh;
            DiaChi1 = diaChi;
            DienThoai1 = dienThoai;
            NgaySinh1 = ngaySinh;
        }

       
    }
}
