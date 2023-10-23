using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;

namespace QLTapHoa
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        NCC_BLL ncc = new NCC_BLL();

        public void Hienthi()
        {
            dgv_ncc.DataSource = null;
            DataTable dt = ncc.Tra_DS_NCC();
            dgv_ncc.DataSource = dt;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dt = ncc.Tra_DS_NCC();
            dgv_ncc.DataSource = dt;
            txt_mancc.Enabled = false; 
        }

        void XoaText()
        {
            txt_mancc.ResetText();
            txt_tncc.ResetText();
            txt_dienthoai.ResetText();
            txt_diachi.ResetText();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mancc.Text = Functions.CreateKey("MANCC");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhacungcap = new NhaCungCapDTO(txt_mancc.Text, txt_tncc.Text, txt_dienthoai.Text, txt_diachi.Text);
            ncc.sua_NCC(nhacungcap);
            Hienthi();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhacungcap = new NhaCungCapDTO(txt_mancc.Text, txt_tncc.Text, txt_dienthoai.Text, txt_diachi.Text);
            if(txt_tncc.Text == "" || txt_diachi.Text == "" || txt_dienthoai.Text == "")
            {
               MessageBox.Show("ban phai nhap du thong tin");
            }
            else
            {
                ncc.luu_NCC(nhacungcap);
                Hienthi();
                XoaText();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_ncc.DataSource = null;
            DataTable dt = ncc.timkiem_NCC(txt_mancc.Text);
            dgv_ncc.DataSource = dt;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhacungcap = new NhaCungCapDTO(txt_mancc.Text, txt_tncc.Text, txt_dienthoai.Text, txt_diachi.Text);
            ncc.xoa_NCC(nhacungcap);
            Hienthi();
        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_ncc.Rows.Count; i++)
                if (dgv_ncc.Rows[i].Selected == true)
                {
                    txt_mancc.Text = dgv_ncc.Rows[i].Cells[0].Value.ToString();
                    txt_tncc.Text = dgv_ncc.Rows[i].Cells[1].Value.ToString();
                    txt_dienthoai.Text = dgv_ncc.Rows[i].Cells[2].Value.ToString();
                    txt_diachi.Text = dgv_ncc.Rows[i].Cells[3].Value.ToString();
                }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ncc_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //e.Column.Width = 150; // Độ rộng cố định cho cột thứ 0

           
        }

        private void dgv_ncc_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach(DataGridViewColumn column in dgv_ncc.Columns)
            {
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //column.Width = 200;
            }
        }

       
    }
}
