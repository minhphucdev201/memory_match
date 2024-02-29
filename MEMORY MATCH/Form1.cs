using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        // Để chỉ được nhấn 1 lần ra 1 form
        private bool isButtonClicked = false;
        public void SetButtonClickedStatus(bool status)
        {
            isButtonClicked = status;
        }
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
        
        private void btn_play_Click(object sender, EventArgs e)
        {
            MainGame f = new MainGame();
            f.Show();
            ElapsedTime = TimeSpan.Zero; // bắt đầu tính thời gian chơi game 
       
        }

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

        private void btn_setting_Click(object sender, EventArgs e)
        {
            //Setting setting = new Setting(maingame);
            //setting.Show();
        }
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
            Record record = new Record(this);
            record.Show();
        }
        private void MainOption_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
