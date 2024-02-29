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
        private MainGame mainGameForm;
        public Pause(MainGame mainGame)
        {
            InitializeComponent();
            mainGameForm = mainGame;
            
        }
       
        private void btn_quit_pause_Click(object sender, EventArgs e)
        {
            this.Close();
            mainGameForm.Close();
        }

        private void btn_continue_pause_Click(object sender, EventArgs e)
        {
            Close();
            mainGameForm.ResumeTimer(); // Tiếp tục đếm thời gian trong MainGame
        }

    }
}
