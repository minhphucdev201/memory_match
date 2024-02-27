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
     
        }
    }
}
