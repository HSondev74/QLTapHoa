using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDBanDTO
    {
        private string MaHDBan;
        private string MaNhanVien;
        private DateTime NgayBan;
        private string MaKhach;
        private float TongTien;

        public HDBanDTO(string maHDBan, string maNhanVien, DateTime ngayBan, string maKhach, float tongTien)
        {
            MaHDBan1 = maHDBan;
            MaNhanVien1 = maNhanVien;
            NgayBan1 = ngayBan;
            MaKhach1 = maKhach;
            TongTien1 = tongTien;
        }

        public string MaHDBan1 { get => MaHDBan; set => MaHDBan = value; }
        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
        public HDBanDTO()
        {

        }
    }
}
