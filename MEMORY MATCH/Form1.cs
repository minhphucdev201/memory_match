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

        private void btn_howtoplay_Click(object sender, EventArgs e)
        {
            Howtoplay btn_howtoplay = new Howtoplay();
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
            Exit exit=new Exit();
            exit.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            //Setting setting = new Setting();
            //setting.Show();
        }

        private void MainOption_Load(object sender, EventArgs e)
        {

        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            Record record= new Record();
            record.Show();
        }

    }
}
