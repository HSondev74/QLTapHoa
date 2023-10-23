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
            txt_MaKhach.Enabled = false;
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
        void XoaText()
        {
            txt_MaKhach.ResetText();
            txt_TenKhach.ResetText();
            txt_DiaChi.ResetText();
            txt_Sodienthoai.ResetText();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }
         
        private void btn_Luu_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            txt_MaKhach.Text = Functions.CreateKey("KH");
            MessageBox.Show("Bạn đã thêm mã khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Them.Enabled = false;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {

            if (txt_MaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaKhach.Focus();
                return;
            }
            if (txt_TenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenKhach.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Sodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Sodienthoai.Focus();
                return;
            }

            KhachHangDTO hangdto = new KhachHangDTO(txt_MaKhach.Text, txt_TenKhach.Text, txt_DiaChi.Text, txt_Sodienthoai.Text);
            khachhangbll.Sua_KH(hangdto);
            Hienthi();
            MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaText();
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (txt_MaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaKhach.Focus();
                return;
            }
            if (txt_TenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenKhach.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Sodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Sodienthoai.Focus();
                return;
            }

            KhachHangDTO hangdto = new KhachHangDTO(txt_MaKhach.Text, txt_TenKhach.Text, txt_DiaChi.Text, txt_Sodienthoai.Text);
            khachhangbll.Them_ChiTietKH(hangdto);
            Hienthi();
            MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaText();
            btn_Them.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            KhachHangDTO hangdto = new KhachHangDTO(txt_MaKhach.Text, txt_TenKhach.Text, txt_DiaChi.Text, txt_Sodienthoai.Text);
            khachhangbll.Xoa_KH(hangdto);


            Hienthi();
        }

        private void btn_Dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
