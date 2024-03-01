using System;
using NAudio.Wave;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;

namespace MEMORY_MATCH
{
    public partial class Setting_1 : Form
    {
        private MainOption mainoption;
        public Setting_1(MainOption mainoption)
        {
            InitializeComponent();
            this.mainoption = mainoption;
        }
        //private SoundPlayer player;
        //private bool isPlaying = false;

        private void rdb_on_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(rdb_on.Checked == true)
                {
                    BackgroundSound.PlayMusic();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void rdb_off_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_off.Checked == true)
            {
                BackgroundSound.StopMusic();
            }


        }

        private void btn_exit_setting_Click(object sender, EventArgs e)
        {
            Close();
            mainoption.SetButtonClickedStatus(false);
        }
      
       
        //private AudioFileReader audioFileReader;
        private void volumetrackbar_Scroll(object sender, ScrollEventArgs e)
        {

            // Lấy giá trị mới của scrollbar
            int volume = volumetrackbar.Value; 

           BackgroundSound.ChangeVolume(volume);
        }

       

    }
}
