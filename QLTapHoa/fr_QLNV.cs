using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLTapHoa
{
    public partial class fr_QLNV : Form
    {
        public fr_QLNV()
        {
            InitializeComponent();
        }
        NhanVienBLL nhanvienbll = new NhanVienBLL();

        private void dgv_QLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i > -1)
            {
                txt_MaNhanVien.Text = dgv_QLNV.Rows[i].Cells[0].Value.ToString();
                txt_TenNhanVien.Text = dgv_QLNV.Rows[i].Cells[1].Value.ToString();
                txtGioiTinh.Text = dgv_QLNV.Rows[i].Cells[2].Value.ToString();
                txt_DiaChi.Text = dgv_QLNV.Rows[i].Cells[3].Value.ToString();
                txt_Sodienthoai.Text = dgv_QLNV.Rows[i].Cells[4].Value.ToString();
                dtp_NgaySinh.Text = dgv_QLNV.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void fr_QLNV_Load(object sender, EventArgs e)
        {
            DataTable dt = nhanvienbll.Tra_ds_nhanvien();
            dgv_QLNV.DataSource = dt;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
