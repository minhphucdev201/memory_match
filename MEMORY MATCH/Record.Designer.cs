﻿namespace MEMORY_MATCH
{
    partial class Record
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
            this.lbl_record = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.btn_exit_record = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_record
            // 
            this.lbl_record.AutoSize = true;
            this.lbl_record.BackColor = System.Drawing.Color.Transparent;
            this.lbl_record.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_record.Location = new System.Drawing.Point(99, 9);
            this.lbl_record.Name = "lbl_record";
            this.lbl_record.Size = new System.Drawing.Size(190, 57);
            this.lbl_record.TabIndex = 0;
            this.lbl_record.Text = "RECORD";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(24, 66);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(104, 50);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.BackColor = System.Drawing.Color.Transparent;
            this.lbl_level.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(24, 116);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(105, 50);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "Level";
            // 
            // btn_exit_record
            // 
            this.btn_exit_record.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit_record.BorderRadius = 19;
            this.btn_exit_record.BorderThickness = 2;
            this.btn_exit_record.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit_record.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit_record.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit_record.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit_record.FillColor = System.Drawing.Color.OldLace;
            this.btn_exit_record.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit_record.ForeColor = System.Drawing.Color.Red;
            this.btn_exit_record.Location = new System.Drawing.Point(348, 9);
            this.btn_exit_record.Name = "btn_exit_record";
            this.btn_exit_record.Size = new System.Drawing.Size(40, 40);
            this.btn_exit_record.TabIndex = 3;
            this.btn_exit_record.Text = "X";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btn_exit_record);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_record);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Record";
            this.Text = "Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_record;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_level;
        private Guna.UI2.WinForms.Guna2Button btn_exit_record;
    }
}