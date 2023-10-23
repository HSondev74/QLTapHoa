using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTapHoa.Class;

namespace QLTapHoa
{
    public partial class Form1 : Form
    {
        string tendangnhap = "", matkhau = "", quyen = "";

        private DataTable tblCTHDB;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
            public void Hienthi()
            {
                dataGridView1.DataSource = null;
                //DataTable dt = nhanvien.Tra_ds_KH();
                //dataGridView1.DataSource = dt;
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            textBox1.Text = Functions.CreateKey("NV");
            textBox1.Enabled = false;
            //DataTable dt = nhanvien.Tra_ds_KH();
            //dataGridView1.DataSource = dt;
            LoadInfoHoaDon();
            LoadDataGridView();
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = 'HDB6262022_091746'";
            dateTimePicker1.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MaNhanVien FROM tblHDBan WHERE MaHDBan = 'HDB6262022_091746'";
            textBox1.Text = Functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM tblHDBan WHERE MaHDBan = 'HDB6262022_091746'";
            textBox2.Text = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = 'HDB6262022_091746'";
            textBox3.Text = Functions.GetFieldValues(str);
        }
        //test loaddata hóa đơn bán
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.MaHDBan = 'HDB6262022_091746' AND a.MaHang=b.MaHang";
            tblCTHDB = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCTHDB;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Giảm giá %";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void button1_Click(object sender, EventArgs e)
        {   
           

         
            Hienthi();
            if (quyen == "admin")
            {
            }
            else
            {
                MessageBox.Show("sai r ban oi");
            }
        }
    }
}
