using System;

namespace WFQuanLyNhanVien
{
    partial class FOption
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThanNhan = new System.Windows.Forms.Button();
            this.btnDuAn = new System.Windows.Forms.Button();
            this.btnPhongBang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(272, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1094, 706);
            this.panelContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnThanNhan);
            this.panel2.Controls.Add(this.btnDuAn);
            this.panel2.Controls.Add(this.btnPhongBang);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Location = new System.Drawing.Point(2, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 511);
            this.panel2.TabIndex = 0;
            // 
            // btnThanNhan
            // 
            this.btnThanNhan.Location = new System.Drawing.Point(88, 238);
            this.btnThanNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanNhan.Name = "btnThanNhan";
            this.btnThanNhan.Size = new System.Drawing.Size(75, 42);
            this.btnThanNhan.TabIndex = 3;
            this.btnThanNhan.Text = "Thân Nhân";
            this.btnThanNhan.UseVisualStyleBackColor = true;
            this.btnThanNhan.Click += new System.EventHandler(this.btnThanNhan_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.Location = new System.Drawing.Point(88, 169);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(75, 42);
            this.btnDuAn.TabIndex = 2;
            this.btnDuAn.Text = "Dự Án";
            this.btnDuAn.UseVisualStyleBackColor = true;
            this.btnDuAn.Click += new System.EventHandler(this.btnDuAn_Click);
            // 
            // btnPhongBang
            // 
            this.btnPhongBang.Location = new System.Drawing.Point(88, 97);
            this.btnPhongBang.Name = "btnPhongBang";
            this.btnPhongBang.Size = new System.Drawing.Size(75, 42);
            this.btnPhongBang.TabIndex = 1;
            this.btnPhongBang.Text = "Phòng Ban";
            this.btnPhongBang.UseVisualStyleBackColor = true;
            this.btnPhongBang.Click += new System.EventHandler(this.btnPhongBang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(88, 27);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 42);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFQuanLyNhanVien.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(88, 427);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContainer);
            this.Name = "FOption";
            this.ShowInTaskbar = false;
            this.Text = "FOption";
            this.Load += new System.EventHandler(this.FOption_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBang;
        private System.Windows.Forms.Button btnDuAn;
        private System.Windows.Forms.Button btnThanNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}