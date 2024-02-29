using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MEMORY_MATCH
{
    public partial class Setting : Form
    {
        private MainGame mainGameForm2;

        public Setting(MainGame maingame2)
        {
            InitializeComponent();
            mainGameForm2 = maingame2;
        }

        private void btn_exit_setting_Click(object sender, EventArgs e)
        {
            Close();
            mainGameForm2.ResumeTimer(); // Tiếp tục đếm thời gian trong MainGame
        }

        private void rdb_on_CheckedChanged(object sender, EventArgs e)
        {
            // Tạo một đối tượng SoundPlayer và tải file nhạc từ resources
            //SoundPlayer player = new SoundPlayer(Properties.Resources.nhaccute);
            //player.Play();
        }
    }
}
