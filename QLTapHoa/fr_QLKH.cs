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
    public partial class fr_QLKH : Form
    {
        public fr_QLKH()
        {
            InitializeComponent();
        }
        KhachHangBLL khachhangbll = new KhachHangBLL();
        private void fr_QLKH_Load(object sender, EventArgs e)
        {
            DataTable dt = khachhangbll.Tra_ds_khachhang();
            dgvKhachhang.DataSource = dt;
        }
        public void Hienthi()
        {
            dgvKhachhang.DataSource = null;
            DataTable dt = khachhangbll.Tra_ds_khachhang();
            dgvKhachhang.DataSource = dt;
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i > -1)
            {
                txt_MaKhach.Text = dgvKhachhang.Rows[i].Cells[0].Value.ToString();
                txt_TenKhach.Text = dgvKhachhang.Rows[i].Cells[1].Value.ToString();
                txt_DiaChi.Text = dgvKhachhang.Rows[i].Cells[2].Value.ToString();
                txt_Sodienthoai.Text = dgvKhachhang.Rows[i].Cells[3].Value.ToString();

            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
