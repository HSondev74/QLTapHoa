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
            cboMaChatLieu.ValueMember = "MaChatLieu";
        }
        public void Hienthi()
        {
            dgv_Hang.DataSource = null;
            DataTable dt = hangbll.Tra_ds_hang();
            dgv_Hang.DataSource = dt;
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
                txtTenHang.Text = dgv_Hang.Rows[i].Cells[1].Value.ToString();
                cboMaChatLieu.Text = dgv_Hang.Rows[i].Cells[2].Value.ToString();
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

         

        private void btnThem_Click(object sender, EventArgs e)

        {
            float soluong = float.Parse(txtSoLuong.Text);
            float dongianhap = float.Parse(txtDonGiaNhap.Text);
            float dongiaban = float.Parse(txtDonGiaBan.Text);

            HangDTO hangdto = new HangDTO(txtMaHang.Text, txtTenHang.Text, cboMaChatLieu.Text, soluong, dongianhap, dongiaban, txtGhiChu.Text);
            hangbll.Them_HANG(hangdto);


            Hienthi();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
