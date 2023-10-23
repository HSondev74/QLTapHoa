using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class CL_BLL
    {
        public DataTable Tra_DS_CL()
        {
            return tblChatLieuDAL.Tra_DS_CL();
        }

        public DataTable timkiem_CL(string ma)
        {
            return tblChatLieuDAL.timkiem(ma);
        }

        public void luu_CL(tblChatLieuDTO cl)
        {
            tblChatLieuDAL.luu_CL(cl);
        }

        public void sua_CL(tblChatLieuDTO cl)
        {
            tblChatLieuDAL.sua_CL(cl);
        }

        public void xoa_CL(tblChatLieuDTO cl)
        {
            tblChatLieuDAL.xoa_CL(cl);
        }
    }
}
