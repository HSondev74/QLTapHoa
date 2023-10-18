using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string MaNhanVien;
        private string TenNhanVien;
        private string GioiTinh;
        private string DiaChi;
        private string DienThoai;
        private DateTime NgaySinh;

        public NhanVienDTO(string maNhanVien, string tenNhanVien, string gioiTinh, string diaChi, string dienThoai, DateTime ngaySinh)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            NgaySinh = ngaySinh;
        }

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }

        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }

        public NhanVienDTO()
        {

        }


    }
}
