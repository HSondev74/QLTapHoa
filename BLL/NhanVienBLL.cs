using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        public DataTable Tra_ds_nhanvien()
        {
            return NhanVienDAL.Tra_ds_nhanvien();
        }
        //public DataTable Tra_ds_KH()
        //{
        //    return NhanVienDAL.Tra_ds_KH();
        //}
        //public void themNV(NhanVienDTO nhanvien)
        //{
        //    NhanVienDAL.ThemNV(nhanvien);
        //}
        public void Them_NV(NhanVienDTO nv)
        {
            NhanVienDAL.Them_NV(nv);
        }
        public void Xoa_NV(NhanVienDTO nv)
        {
            NhanVienDAL.Xoa_NV(nv);
        }
        public void Sua_NV(NhanVienDTO nv)
        {
            NhanVienDAL.Sua_NV(nv);
        }
    }
}
