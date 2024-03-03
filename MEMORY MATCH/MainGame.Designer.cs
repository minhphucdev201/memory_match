namespace MEMORY_MATCH
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_level = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_score = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_times = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_setting = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_pause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel_level.SuspendLayout();
            this.panel_score.SuspendLayout();
            this.panel_times.SuspendLayout();
        
            this.SuspendLayout();
            // 
            // panel_level
            // 
            this.panel_level.BackColor = System.Drawing.Color.Transparent;
            this.panel_level.BorderColor = System.Drawing.Color.Black;
            this.panel_level.BorderRadius = 20;
            this.panel_level.BorderThickness = 2;
            this.panel_level.Controls.Add(this.label1);
            this.panel_level.Location = new System.Drawing.Point(7, 10);
            this.panel_level.Margin = new System.Windows.Forms.Padding(2);
            this.panel_level.Name = "panel_level";
            this.panel_level.Size = new System.Drawing.Size(63, 67);
            this.panel_level.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // panel_score
            // 
            this.panel_score.BackColor = System.Drawing.Color.Transparent;
            this.panel_score.BorderColor = System.Drawing.Color.Black;
            this.panel_score.BorderRadius = 19;
            this.panel_score.BorderThickness = 2;
            this.panel_score.Controls.Add(this.label2);
            this.panel_score.Location = new System.Drawing.Point(74, 10);
            this.panel_score.Margin = new System.Windows.Forms.Padding(2);
            this.panel_score.Name = "panel_score";
            this.panel_score.Size = new System.Drawing.Size(168, 32);
            this.panel_score.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel_times
            // 
            this.panel_times.BackColor = System.Drawing.Color.Transparent;
            this.panel_times.BorderColor = System.Drawing.Color.Black;
            this.panel_times.BorderRadius = 19;
            this.panel_times.BorderThickness = 2;
            this.panel_times.Controls.Add(this.lbl_time);
            this.panel_times.Location = new System.Drawing.Point(74, 45);
            this.panel_times.Margin = new System.Windows.Forms.Padding(2);
            this.panel_times.Name = "panel_times";
            this.panel_times.Size = new System.Drawing.Size(168, 32);
            this.panel_times.TabIndex = 3;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(2, 4);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(60, 25);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Times";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(16, 91);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(575, 264);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_setting.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_setting.Image = global::MEMORY_MATCH.Properties.Resources.setting;
            this.btn_setting.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_setting.ImageRotate = 0F;
            this.btn_setting.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_setting.Location = new System.Drawing.Point(548, 7);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_setting.Size = new System.Drawing.Size(42, 51);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_pause.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_pause.Image = global::MEMORY_MATCH.Properties.Resources.pause;
            this.btn_pause.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_pause.ImageRotate = 0F;
            this.btn_pause.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_pause.Location = new System.Drawing.Point(502, 10);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_pause.Size = new System.Drawing.Size(42, 46);
            this.btn_pause.TabIndex = 6;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::MEMORY_MATCH.Properties.Resources.hinhnen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel_level);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel_times);
            this.Controls.Add(this.panel_score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGame";
            this.panel_level.ResumeLayout(false);
            this.panel_level.PerformLayout();
            this.panel_score.ResumeLayout(false);
            this.panel_score.PerformLayout();
            this.panel_times.ResumeLayout(false);
            this.panel_times.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_level;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panel_score;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panel_times;
        private System.Windows.Forms.Label lbl_time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_setting;
        private Guna.UI2.WinForms.Guna2ImageButton btn_pause;
    }
}