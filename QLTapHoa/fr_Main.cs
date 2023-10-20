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
        public fr_Main()
        {
            InitializeComponent();
        }

        private Form curentFormChild;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            label1.Text = button1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              if (curentFormChild != null)
            {
                curentFormChild.Close();
                label1.Text = "Admin";
            } 
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
