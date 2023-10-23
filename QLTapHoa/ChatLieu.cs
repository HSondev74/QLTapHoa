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
    public partial class ChatLieu : Form
    {
        public ChatLieu()
        {
            InitializeComponent();
        }

        CL_BLL cl = new CL_BLL();

        public void Hienthi()
        {
            dgv_cl.DataSource = null;
            DataTable dt = cl.Tra_DS_CL();
            dgv_cl.DataSource = dt;
        }

        private void ChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dt = cl.Tra_DS_CL();
            dgv_cl.DataSource = dt;
            txt_mcl.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_cl.DataSource = null;
            DataTable dt = cl.timkiem_CL(txt_mcl.Text);
            dgv_cl.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mcl.Text = Functions.CreateKey("MACL");
        }

        void XoaText()
        {
            txt_mcl.ResetText();
            txt_tcl.ResetText();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            tblChatLieuDTO chatlieu = new tblChatLieuDTO(txt_mcl.Text, txt_tcl.Text);
            cl.sua_CL(chatlieu);
            Hienthi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tblChatLieuDTO chatlieu = new tblChatLieuDTO(txt_mcl.Text, txt_tcl.Text);
            txt_mcl.Text = null;
            txt_tcl.Text = null;
            cl.xoa_CL(chatlieu);
            Hienthi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            tblChatLieuDTO chatlieu = new tblChatLieuDTO(txt_mcl.Text, txt_tcl.Text);
            if (txt_tcl.Text == "")
            {
                MessageBox.Show("ban phai nhap du thong tin");
            }
            else
            {
                cl.luu_CL(chatlieu);
                Hienthi();
                XoaText();
            }
        }

        private void dgv_cl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_cl.Rows.Count; i++)
                if (dgv_cl.Rows[i].Selected == true)
                {
                    txt_mcl.Text = dgv_cl.Rows[i].Cells[0].Value.ToString();
                    txt_tcl.Text = dgv_cl.Rows[i].Cells[1].Value.ToString();
                }
        }

        private void dgv_cl_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //e.Column.Width = 150; // Độ rộng cố định cho cột thứ 0
        }

        private void dgv_cl_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //foreach (DataGridViewColumn column in dgv_cl.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    column.Width = 200;
            //}
        }

        private void dgv_cl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

