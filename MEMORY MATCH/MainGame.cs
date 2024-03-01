using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MEMORY_MATCH
{
    public partial class MainGame : Form
    {
        public Timer timer;
        private TimeSpan elapsedTime;
        private bool isPaused;
        private MainOption mainoption;
        public MainGame()
        {
            InitializeComponent();
            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 1000; // Mỗi giây
            timer.Tick += Timer_Tick;
        }
        // Để chỉ được nhấn 1 lần ra 1 form
        private bool isButtonClicked = false;
        public void SetButtonClickedStatus(bool status)
        {
            isButtonClicked = status;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Image  = Properties.Resources.card1;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources.card2;
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = Properties.Resources.card1;
        }
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox4.Image = Properties.Resources.card3;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            guna2PictureBox5.Image = Properties.Resources.card2;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            guna2PictureBox6.Image = Properties.Resources.card3;
        }
        //Tính thời gian chơi
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));

                // Hiển thị thời gian lên Label
                lbl_time.Text = "Times: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
        }
        private void MainGame_Load(object sender, EventArgs e)
        {
            MainGame maingame = (MainGame)Application.OpenForms["MainGame"];
            elapsedTime = maingame.elapsedTime;
            isPaused = false;
            // Bắt đầu đếm thời gian
            timer.Start();
        }
        // Nút Pause
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            Pause pause = new Pause(this);
            pause.Show();
            isPaused = !isPaused;
            timer.Stop();
        }
        public void ResumeTimer()
        {
            isPaused = false;
            timer.Start();
        }
        // Nút Setting
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            Setting setting = new Setting(this);
            setting.Show();
            isPaused = !isPaused;
            timer.Stop();
        }

        private void panel_score_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
