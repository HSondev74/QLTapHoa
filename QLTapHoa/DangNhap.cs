using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
//using ComponentFactory.Krypton.Toolkit;

namespace QLTapHoa
{
    public partial class fr_DangNhap : Form
    {
        public static string username, password;
        public fr_DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void fr_DangNhap_Load(object sender, EventArgs e)
        {
           

            string sql = "select * from Quyen";
            DataTable dt = ketnoi.truyvan(sql);
            cmb_Quyen.DataSource = dt;
            cmb_Quyen.DisplayMember = "nguoidung";
            cmb_Quyen.ValueMember = "Type";

            txt_User.Text = Properties.Settings.Default.user;
            txt_pass.Text = Properties.Settings.Default.pass;

            if(txt_User.Text != "")
            {
                chb_remember.Checked = true;
            }else
            {
                chb_remember.Checked = false;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txt_User.Text;
            pass = txt_pass.Text;
            username = txt_User.Text;
            password = txt_pass.Text;
            string typeUser = cmb_Quyen.SelectedValue.ToString();
            string sql = $"select * from Account where type = N'{typeUser}' ";

            DataTable dt = ketnoi.truyvan(sql);
            bool kt = false;
            foreach(DataRow dr in dt.Rows)
            {

                if ((dr[1].ToString().Trim() == user) && (dr[2].ToString().Trim()== pass))
                {
                   //username  = dr[1].ToString();
                   // MessageBox.Show(username);
                    kt = true; 
                    break; 
                } 
            }
            if (kt == true)
            {
                // Tạo một instance của UserControl
                ToastUserControl userControl = new ToastUserControl();

                // Assuming you have an instance of the ToastUserControl named "toastUserControl" in your form
                userControl.ShowSuccessToast("Thành công!");

                    fr_Main main = new fr_Main(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    this.Hide();
                    main.Show();

            }

            else
            {
                MessageBox.Show("Ban nhap khong dung", "Thong Bao", MessageBoxButtons.OKCancel);
                txt_User.Focus();
            }
        }

        private void chb_remember_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_remember.Checked == true)
            {
                Properties.Settings.Default.user = txt_User.Text;
                Properties.Settings.Default.pass = txt_pass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
        }

        private void btn_openPass_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_ClosePass_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_openPass_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                txt_pass.PasswordChar = '*';
                btn_openPass.BackgroundImage = Properties.Resources.ShowPasswordImage; // Set the button icon for hiding the password
            }
            else
            {
                txt_pass.PasswordChar = '\0';
                btn_openPass.BackgroundImage = Properties.Resources.HidePasswordImage; // Set the button icon for showing the password
            }
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
