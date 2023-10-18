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

namespace QLTapHoa
{
    public partial class fr_QLH : Form
    {
        public fr_QLH()
        {
            InitializeComponent();
        }

        HangBLL hangbll = new HangBLL();

        void Dua_MaKH_Combo()
        {
            cboMaChatLieu.DataSource = hangbll.Tra_ds_hang();
            cboMaChatLieu.ValueMember = "MaHang";
        }
        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            DataTable dt = hangbll.Tra_ds_hang();
            dgv_Hang.DataSource = dt;
        }

        private void fr_QLH_Load(object sender, EventArgs e)
        {
            Dua_MaKH_Combo();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgv_Hang.DataSource = null;
            DataTable dt = hangbll.Tim_Kiem(txtMaHang.Text);
            dgv_Hang.DataSource = dt;
        }

        private void dgv_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            if (i > -1)
            {
                txtMaHang.Text = dgv_Hang.Rows[i].Cells[0].Value.ToString();
                cboMaChatLieu.Text = dgv_Hang.Rows[i].Cells[1].Value.ToString();
                txtTenHang.Text = dgv_Hang.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgv_Hang.Rows[i].Cells[3].Value.ToString();
                txtDonGiaNhap.Text = dgv_Hang.Rows[i].Cells[4].Value.ToString();
                txtDonGiaBan.Text = dgv_Hang.Rows[i].Cells[5].Value.ToString();
                txtGhiChu.Text = dgv_Hang.Rows[i].Cells[6].Value.ToString();

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
