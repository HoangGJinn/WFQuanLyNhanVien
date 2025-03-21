using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFQuanLyNhanVien
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var realadmin = false;

            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                label2.Text = "Login Success";
                label3.Text = "Welcome to QuanNet";
                // Đổi màu chữ thông báo
                label2.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
                realadmin = true;
            }
            else
            {
                txtusername.Text = "";
                txtpassword.Text = "";
                // Đổi màu chữ thông báo
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;

            }

            label2.Visible = true;
            label3.Visible = true;

            if (realadmin)
            {
                txtpassword.Enabled = false;
                txtusername.Enabled = false;
                this.Hide(); // Ẩn form đăng nhập

                frmNhanVien nhanvien = new frmNhanVien();
                nhanvien.ShowDialog(); // Chờ đến khi frmNhanVien đóng

                this.Show(); // Hiển thị lại frmLogin nếu frmNhanVien bị đóng
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
