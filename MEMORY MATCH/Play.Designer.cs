﻿namespace MEMORY_MATCH
{
    partial class Play
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yes_play = new Guna.UI2.WinForms.Guna2Button();
            this.btn_no_play = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit_play = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 146);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Do you want to\ncontinue playing?";
            // 
            // btn_yes_play
            // 
            this.btn_yes_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_yes_play.BorderRadius = 15;
            this.btn_yes_play.BorderThickness = 2;
            this.btn_yes_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_yes_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_yes_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_yes_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_yes_play.FillColor = System.Drawing.Color.OldLace;
            this.btn_yes_play.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes_play.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_yes_play.Location = new System.Drawing.Point(111, 203);
            this.btn_yes_play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_yes_play.Name = "btn_yes_play";
            this.btn_yes_play.Size = new System.Drawing.Size(152, 62);
            this.btn_yes_play.TabIndex = 1;
            this.btn_yes_play.Text = "YES";
            this.btn_yes_play.Click += new System.EventHandler(this.btn_yes_play_Click);
            // 
            // btn_no_play
            // 
            this.btn_no_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_no_play.BorderRadius = 15;
            this.btn_no_play.BorderThickness = 2;
            this.btn_no_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_no_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_no_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_no_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_no_play.FillColor = System.Drawing.Color.OldLace;
            this.btn_no_play.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no_play.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_no_play.Location = new System.Drawing.Point(352, 203);
            this.btn_no_play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_no_play.Name = "btn_no_play";
            this.btn_no_play.Size = new System.Drawing.Size(152, 62);
            this.btn_no_play.TabIndex = 2;
            this.btn_no_play.Text = "NO";
            this.btn_no_play.Click += new System.EventHandler(this.btn_no_play_Click);
            // 
            // btn_exit_play
            // 
            this.btn_exit_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit_play.BorderRadius = 19;
            this.btn_exit_play.BorderThickness = 2;
            this.btn_exit_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit_play.FillColor = System.Drawing.Color.OldLace;
            this.btn_exit_play.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit_play.ForeColor = System.Drawing.Color.Red;
            this.btn_exit_play.Location = new System.Drawing.Point(506, 14);
            this.btn_exit_play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit_play.Name = "btn_exit_play";
            this.btn_exit_play.Size = new System.Drawing.Size(76, 67);
            this.btn_exit_play.TabIndex = 3;
            this.btn_exit_play.Text = "X";
            this.btn_exit_play.Click += new System.EventHandler(this.btn_exit_play_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(600, 312);
            this.Controls.Add(this.btn_exit_play);
            this.Controls.Add(this.btn_no_play);
            this.Controls.Add(this.btn_yes_play);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_yes_play;
        private Guna.UI2.WinForms.Guna2Button btn_no_play;
        private Guna.UI2.WinForms.Guna2Button btn_exit_play;
    }
}