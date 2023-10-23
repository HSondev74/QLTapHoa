using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string MaKhach;
        private string TenKhach;
        private string DiaChi;
        private string DienThoai;

        public KhachHangDTO(string maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            MaKhach1 = maKhach;
            TenKhach1 = tenKhach;
            DiaChi1 = diaChi;
            DienThoai1 = dienThoai;
        }

        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public string TenKhach1 { get => TenKhach; set => TenKhach = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }

        public KhachHangDTO()
        {

        }
    }
}
