using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORY_MATCH
{
    public partial class MainOption : Form
    {
        public TimeSpan ElapsedTime { get; private set; }
        
        public MainOption()
        {
            InitializeComponent();
           //BackgroundSound.PlayMusic();
        }

        //public SoundPlayer player;
        //public bool isPlaying = false;

        // Để chỉ được nhấn 1 lần ra 1 form
        private bool isButtonClicked = false;
        public void SetButtonClickedStatus(bool status)
        {
            isButtonClicked = status;
        }

        // Xử lý nút Howtoplay
        private void btn_howtoplay_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp vào nút "btn_howtoplay"
            }
            Howtoplay btn_howtoplay = new Howtoplay(this);
            btn_howtoplay.Show();
        }

        // Xử lý nút Play
        private void btn_play_Click(object sender, EventArgs e)
        {
            MainGame f = new MainGame();
            f.Show();
            ElapsedTime = TimeSpan.Zero; // bắt đầu tính thời gian chơi game 
       
        }

        // Xử lý nút Exit
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            Exit exit=new Exit(this);
            exit.Show();
        }

        //Xử lý nút Setting
        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting_1 setting_1= new Setting_1(this);
            setting_1.Show();
        }

        // Xử lý nút Record
        //private SoundPlayer recordPlayer; // Thêm biến recordPlayer để quản lý âm thanh của nút btn_record
        private void btn_record_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
            }
            else
            {
                return; // Không có hiệu lực nếu đã click liên tiếp 
            }
            //try
            //{
            //    SoundManager.Player = new SoundPlayer(Properties.Resources.win);
            //    SoundManager.Player.Play();
            //    SoundManager.IsPlaying = true;
            //}
            //catch (Exception ex)
            //{
            //    // Xử lý ngoại lệ và thông báo lỗi
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            //}
            Record record = new Record(this);
            record.Show();
        }

        // trình chạy MainOption
        private void MainOption_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SoundManager.Player = new SoundPlayer(Properties.Resources.nhacnen1);
            
            //    SoundManager.Player.Play();
            //    SoundManager.IsPlaying = true;



            //}
            //catch (Exception ex)
            //{
            //    // Xử lý ngoại lệ và thông báo lỗi
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            //}
        }
    }
}
