using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
