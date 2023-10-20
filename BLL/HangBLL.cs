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
    public class HangBLL
    {
        public DataTable Tra_ds_hang()
        {
            return HangDAL.Tra_ds_hang();
        }

        public DataTable Tim_Kiem(string ma)
        {
            return HangDAL.Tim_Kiem_MaHang(ma);
        }

        public void Them_HANG(HangDTO kh)
        {
            HangDAL.Them_HANG(kh);
        }
        public void Sua_Hang(HangDTO kh)
        {
            HangDAL.Sua_Hang(kh);
        }
        


    }
}
