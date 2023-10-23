 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string MaNCC;
        private string TenNCC;
        private string DienThoai;
        private string DiaChi;

        public NhaCungCapDTO(string maNCC, string tenNCC, string dienThoai, string diaChi)
        {
            MaNCC1 = maNCC;
            TenNCC1 = tenNCC;
            DienThoai1 = dienThoai;
            DiaChi1 = diaChi;
        }

        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

        public NhaCungCapDTO()
        {

        }
    }
}
