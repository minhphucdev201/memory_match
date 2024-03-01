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
    public partial class Pause : Form
    {
        private MainGame maingame;
        public Pause(MainGame mainGame)
        {
            InitializeComponent();
            maingame = mainGame;
            
        }
       
        private void btn_quit_pause_Click(object sender, EventArgs e)
        {
            this.Close();
            maingame.Close();
            maingame.SetButtonClickedStatus(false);
        }

        private void btn_continue_pause_Click(object sender, EventArgs e)
        {
            Close();
            maingame.ResumeTimer(); // Tiếp tục đếm thời gian trong MainGame
            maingame.SetButtonClickedStatus(false);
        }

    }
}
