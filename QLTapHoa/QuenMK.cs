using QLTapHoa.QLTapHoaDataSetTableAdapters;
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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            fr_DangNhap dangNhap = new fr_DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
            ChatLieuBLL chatlieuBLL = new ChatLieuBLL();
            ChatLieuDTO ChatLieuDTO = new ChatLieuDTO();
        private void QuenMK_Load(object sender, EventArgs e)
        {
            DataTable dt = chatlieuBLL.Tra_ds_CL();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "delete from tblChatLieu where MaChatLieu = '" + kryptonTextBox1.Text + "' ";

            ketnoi.thucthi(sql1);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



        }
    }
}
