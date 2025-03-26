using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFQuanLyNhanVien
{
    public partial class FOption : Form
    {
        public FOption()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FOption_Load(object sender, EventArgs e)
        {

        }
        private void LoadFormIntoPanel(Form form) //LOad Form Ở đây, Giải thích thôi chứ không cần đụng vào đây !
        {
            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls[0].Dispose(); // Câu lệnh này chỉ để cấm việc load quá nhiều form 1 lúc 

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);  // tham chiếu
            panelContainer.Tag = form;
            form.Show();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnhanvien = new frmNhanVien();
            LoadFormIntoPanel(frmnhanvien);
        }

        private void btnPhongBang_Click(object sender, EventArgs e)
        {
            FrmPhongBan frmphongbang = new FrmPhongBan();
            LoadFormIntoPanel(frmphongbang);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            Frm_DuAn frmda = new Frm_DuAn();
            LoadFormIntoPanel(frmda);

        }
        private void btnThanNhan_Click(object sender, EventArgs e)
        {
            frmThanNhan frmthannhan = new frmThanNhan();
            LoadFormIntoPanel(frmthannhan);
        }
    }
}
