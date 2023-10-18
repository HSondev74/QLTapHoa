using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChatLieuDAL
    {
        public static DataTable Tra_ds_CL()
        {
            string sql = "select * from tblChatLieu";
            DataTable dt = DBAccess.truyvan(sql);
            return dt;
        }
        public static void XoaCl(ChatLieuDTO chatlieu)
        {
            string sql = "delete from tblChatLieu where = '" + chatlieu.MaChatLieu1 +"' ";
            DBAccess.thucthi(sql);
        }
    }
}
