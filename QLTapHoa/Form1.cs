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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NhanVienBLL nhanvien = new NhanVienBLL();
            public void Hienthi()
            {
                dataGridView1.DataSource = null;
                DataTable dt = nhanvien.Tra_ds_KH();
                dataGridView1.DataSource = dt;
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = nhanvien.Tra_ds_KH();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanviendto = new NhanVien(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,dateTimePicker1.Value);
            nhanvien.themNV(nhanviendto);
            Hienthi();
        }
    }
}
