using QuanLyBanHang.Class;
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

        private Form curentFormChild;
        private Button currentButton;
        private int steps = 10; // Số bước chuyển đổi
        private int currentStep = 0;
        private Timer transitionTimer = new Timer();

        

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
            //label1.Text = tendangnhap.ToUpper();
            label1.Text = fr_DangNhap.username;
            if(quyen == "admin")
            {
                label3.Text = "Quản Lý";
            }else
            {
                label3.Text = "Nhân Viên";
            }
            transitionTimer.Interval = 100; // Thời gian giữa các bước chuyển đổi (50ms)
            transitionTimer.Tick += timer2_Tick;
            timer1.Start();
        }
      
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(239,68,68);
        }
        private void AnimateButton(Button button)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = button.BackColor;
            }

            currentButton = button;
            currentStep = 0;
            transitionTimer.Start();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            currentStep++;
            if (currentStep <= steps)
            {
                float stepRatio = (float)currentStep / steps;
                Color color = RGBColors.color1;
                currentButton.BackColor = color;
            }
            else
            {
                transitionTimer.Stop();
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            panel_body.Visible = true;

            // Hide other open forms
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this) // Exclude the current form
                {
                    frm.Hide();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(tendangnhap, matkhau, quyen));
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Show panel_body
            panel_body.Visible = true;

            // Hide other open forms
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this) // Exclude the current form
                {
                    frm.Hide();
                }
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            //label1.Text = button1.Text;
            //Activebutton(sender);
            AnimateButton((Button)sender);
        }
    }
}
