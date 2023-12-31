﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NCC_BLL
    {
        public DataTable Tra_DS_NCC()
        {
            return NhaCungCapDAL.Tra_DS_NCC();
        }

        public DataTable timkiem_NCC(string ma)
        {
            return NhaCungCapDAL.timkiem(ma);
        }

        public void luu_NCC(NhaCungCapDTO ncc)
        {
            NhaCungCapDAL.luu_NCC(ncc);
        }

        public void sua_NCC(NhaCungCapDTO ncc)
        {
            NhaCungCapDAL.sua_NCC(ncc);
        }

        public void xoa_NCC(NhaCungCapDTO ncc)
        {
            NhaCungCapDAL.xoa_NCC(ncc);
        }
    }
}
