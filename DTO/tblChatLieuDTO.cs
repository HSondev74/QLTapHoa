﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblChatLieuDTO
    {
        private string MaChatLieu;
        private string TenChatLieu;

        public tblChatLieuDTO(string maChatLieu, string tenChatLieu)
        {
            MaChatLieu = maChatLieu;
            TenChatLieu = tenChatLieu;
        }

        public string MaChatLieu1 { get => MaChatLieu; set => MaChatLieu = value; }
        public string TenChatLieu1 { get => TenChatLieu; set => TenChatLieu = value; }
        public tblChatLieuDTO()
        {

        }
    }
}
