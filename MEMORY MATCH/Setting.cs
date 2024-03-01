﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace MEMORY_MATCH
{
    public partial class Setting : Form
    {
        private MainGame maingame;

        public Setting(MainGame maingame2)
        {
            InitializeComponent();
            maingame = maingame2;
        }

        private void btn_exit_setting_Click(object sender, EventArgs e)
        {
            Close();
            maingame.ResumeTimer(); // Tiếp tục đếm thời gian trong MainGame
            maingame.SetButtonClickedStatus(false);
        }
     
        private void rdb_on_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_on.Checked == true)
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
            if (SoundManager.Player != null && SoundManager.IsPlaying)
            {
                SoundManager.Player.Stop();
                SoundManager.IsPlaying = false;
            }
        }

        private void volumetrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            // Lấy giá trị mới của scrollbar
            int volume = volumetrackbar.Value;

            BackgroundSound.ChangeVolume(volume);
        }

       
       
    }
}
