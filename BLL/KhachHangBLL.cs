using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class KhachHangBLL
    {
        public DataTable Tra_ds_khachhang()
        {
            return KhachHangDAL.Tra_ds_khachhang();
        }
        public void Them_ChiTietKH(KhachHangDTO kh)
        {
            KhachHangDAL.Them_ChiTietKH(kh);
        }
        public void Sua_KH(KhachHangDTO kh)
        {
            KhachHangDAL.Sua_KH(kh);
        }
        public void Xoa_KH(KhachHangDTO kh)
        {
            KhachHangDAL.Xoa_KH(kh);
        }
        public DataTable Tim_Kiem(string ma)
        {
            return KhachHangDAL.Tim_Kiem_MaNhanVien(ma);
        }
        public void kiemtratrungma(KhachHangDTO kh)
        {
            KhachHangDAL.kiemtratrungma(kh);
        }

        public void SaveKH(KhachHangDTO kh)
        {
            KhachHangDAL.SaveKH(kh);
        }

        
    }
}
