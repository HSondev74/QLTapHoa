using QLTapHoa.Class;
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
    public partial class fr_Main : Form
    {
        private Form curentFormChild;
        private Button previousButton;
        private Button currentButton;
        string tendangnhap = "", matkhau = "", quyen = "";
        public fr_Main()
        {
            InitializeComponent();
        }

        public fr_Main(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }

        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(curentFormChild);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void fr_Main_Load(object sender, EventArgs e)
        {
            //label1.Text = fr_DangNhap.username;
            if (quyen == "admin")
            {
                label3.Text = "Quản Lý";
            }
            else
            {
                label3.Text = "Nhân Viên";
            }
            //timer1.Start();
        }

        private void AnimateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    if (previousButton != null)
                    {
                        previousButton.BackColor = Color.FromArgb(64, 64, 64);
                        previousButton.ForeColor = Color.RosyBrown;
                    }

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(11, 7, 17);
                    currentButton.ForeColor = Color.White;

                    previousButton = currentButton;
                }
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
                label1.Text = "Hello Guy!";
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }



        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            panel_body.Visible = true;

            // Hide other open forms
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this)
                {
                    frm.Hide();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AnimateButton((Button)sender);
            OpenChildForm(new Form1(tendangnhap, matkhau, quyen));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new Form1());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new fr_BanHang());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new Form1());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new Form1());
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel_body.Visible = true;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this)
                {
                    frm.Hide();
                }
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new Form1());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AnimateButton(sender);
            OpenChildForm(new Form1());
        }
        private void iconButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenChildForm(new fr_QLNV());
            label1.Text = button1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QLH());
            label1.Text = button1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QLKH());
            label1.Text = button1.Text;
        }
    }
}
