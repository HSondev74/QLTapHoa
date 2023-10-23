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
        void XoaText()
        {
            txt_MaNhanVien.ResetText();
            txt_TenNhanVien.ResetText();
            txtGioiTinh.ResetText();
            txt_DiaChi.ResetText();
            txt_Sodienthoai.ResetText();
            dtp_NgaySinh.ResetText();


        }
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
        public void Hienthi()
        {
            dgv_QLNV.DataSource = null;
            DataTable dt = nhanvienbll.Tra_ds_nhanvien();
            dgv_QLNV.DataSource = dt;
        }
        private void fr_QLNV_Load(object sender, EventArgs e)
        {
            DataTable dt = nhanvienbll.Tra_ds_nhanvien();
            dgv_QLNV.DataSource = dt;
            txt_MaNhanVien.Enabled = false;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            



        }

        private void btn_Dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            NhanVienDTO nhanviendto = new NhanVienDTO(txt_MaNhanVien.Text, txt_TenNhanVien.Text, txtGioiTinh.Text, txt_DiaChi.Text, txt_Sodienthoai.Text, dtp_NgaySinh.Value);

            nhanvienbll.Xoa_NV(nhanviendto);
            Hienthi();
            MessageBox.Show("Bạn đã xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (txt_MaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                return;
            }
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Sodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Sodienthoai.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập gioi tinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioiTinh.Focus();
                return;
            }
            NhanVienDTO nhanviendto = new NhanVienDTO(txt_MaNhanVien.Text, txt_TenNhanVien.Text, txtGioiTinh.Text, txt_DiaChi.Text, txt_Sodienthoai.Text, dtp_NgaySinh.Value);
            nhanvienbll.Them_NV(nhanviendto);
            MessageBox.Show("Bạn đã thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hienthi();
            XoaText();
            btn_Them.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            if (txt_MaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                return;
            }
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Sodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Sodienthoai.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập gioi tinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioiTinh.Focus();
                return;
            }
            NhanVienDTO nhanviendto = new NhanVienDTO(txt_MaNhanVien.Text, txt_TenNhanVien.Text, txtGioiTinh.Text, txt_DiaChi.Text, txt_Sodienthoai.Text, dtp_NgaySinh.Value);
            nhanvienbll.Sua_NV(nhanviendto);
            MessageBox.Show("Bạn đã sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hienthi();
            XoaText();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = Functions.CreateKey("NV");
            MessageBox.Show("Bạn đã thêm mã nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Them.Enabled = false;
        }
    }
}
