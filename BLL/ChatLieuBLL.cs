using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChatLieuBLL
    {
        public DataTable Tra_ds_CL()
        {
            return ChatLieuDAL.Tra_ds_CL();
        }
        public void xoaCL(ChatLieuDTO chatlieu)
        {
            ChatLieuDAL.XoaCl(chatlieu);
        }
    }
}
