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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void LoadInfoHoaDon()
        {

        }
    }
}
