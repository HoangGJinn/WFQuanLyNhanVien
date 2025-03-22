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
            this.btnPhongBang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDuAn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(363, 2);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1459, 869);
            this.panelContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnDuAn);
            this.panel2.Controls.Add(this.btnPhongBang);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 821);
            this.panel2.TabIndex = 0;
            // 
            // btnPhongBang
            // 
            this.btnPhongBang.Location = new System.Drawing.Point(117, 165);
            this.btnPhongBang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhongBang.Name = "btnPhongBang";
            this.btnPhongBang.Size = new System.Drawing.Size(100, 52);
            this.btnPhongBang.TabIndex = 1;
            this.btnPhongBang.Text = "Phòng Ban";
            this.btnPhongBang.UseVisualStyleBackColor = true;
            this.btnPhongBang.Click += new System.EventHandler(this.btnPhongBang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(117, 79);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(100, 52);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.Location = new System.Drawing.Point(117, 254);
            this.btnDuAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(100, 52);
            this.btnDuAn.TabIndex = 2;
            this.btnDuAn.Text = "Dự Án";
            this.btnDuAn.UseVisualStyleBackColor = true;
            this.btnDuAn.Click += new System.EventHandler(this.btnDuAn_Click);
            // 
            // FOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 880);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FOption";
            this.ShowInTaskbar = false;
            this.Text = "FOption";
            this.Load += new System.EventHandler(this.FOption_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBang;
        private System.Windows.Forms.Button btnDuAn;
    }
}