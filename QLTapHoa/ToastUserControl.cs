using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace QLTapHoa
{
    public partial class ToastUserControl : UserControl
    {
        public ToastUserControl()
        {
            InitializeComponent();
        }
       
        public void SetMessage(string message)
        {
            iconButton1.Text = message;
        }
        private void ToastUserControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }



        public void ShowSuccessToast(string message)
        {
            // Create a new Form to host the ToastUserControl
            Form toastForm = new Form();
            toastForm.Size = new Size(505, 118);
            toastForm.FormBorderStyle = FormBorderStyle.None;

            // Lấy kích thước của màn hình
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.WorkingArea.Width;
            int screenHeight = screen.WorkingArea.Height;

            // Tính toán vị trí để đặt toastForm vào trung tâm trên cùng của màn hình
            int left = (screenWidth - toastForm.Width) / 2;
            int top = 0; // Đặt 0 để đặt form ở trên cùng

            // Đặt vị trí cho toastForm
            toastForm.Location = new Point(left, top);
            // Create a new instance of ToastUserControl
            ToastUserControl successToast = new ToastUserControl();
            successToast.SetMessage(message);

            // Add the ToastUserControl to the Form
            toastForm.Controls.Add(successToast);

            // Configure the Form for the toast notification
            toastForm.FormBorderStyle = FormBorderStyle.None;
            toastForm.StartPosition = FormStartPosition.Manual;
            toastForm.ShowInTaskbar = false;
            toastForm.TopMost = true;

          

            // Show the Form and start a Timer to close it after a specified time
            toastForm.Show();

            // Create a Timer to automatically close the Form after a certain time (e.g., 3 seconds)
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += (sender, e) =>
            {
                timer.Stop();
                toastForm.Close();
            };
            timer.Start();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
        }

    }
}
