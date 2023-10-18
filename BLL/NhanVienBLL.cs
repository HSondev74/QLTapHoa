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
    }
}
