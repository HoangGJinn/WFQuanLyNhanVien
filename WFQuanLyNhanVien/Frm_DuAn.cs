using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;
namespace WFQuanLyNhanVien
{
    public partial class Frm_DuAn : Form
    {
        private bool IsAdding = false;
        private bool isEditing = false;
        public Frm_DuAn()
        {
            InitializeComponent();
            LoadData();
            //disable all textbot in panel 2
            ReverstControlState(false);



        }
        private void SetButtonControlState(bool state, List<Button> buttons)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = buttons.Contains(button) ? state : !state;
                }
            }
        }

        private void ReverstControlState(bool state)
        {
            txtMaDuAn.Enabled = state;
            txtTenDuAn.Enabled = state;
            txtDiaDiem.Enabled = state;
            txtPhong.Enabled = state;
        }
        private void LoadData(bool theophong = false)
        {
            try
            {
                dgvDuAn.AutoGenerateColumns = false;
                var dtDuAn = new DataTable();
                dtDuAn.Clear();
                DataSet ds = DBDuAn.LayDanhSachDuAn();
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtDuAn = ds.Tables[0];
                    dgvDuAn.DataSource = dtDuAn;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /*
                ResetInputFields();
                SetControlState(false);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDuAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDuAn.CurrentRow != null)
            {
                txtMaDuAn.Text = dgvDuAn.CurrentRow.Cells["MaDA"].Value.ToString();
                txtTenDuAn.Text = dgvDuAn.CurrentRow.Cells["TenDA"].Value.ToString();
                txtDiaDiem.Text = dgvDuAn.CurrentRow.Cells["DiaDiem"].Value.ToString();
                txtPhong.Text = dgvDuAn.CurrentRow.Cells["Phong"].Value.ToString();
            }
        }

        private void Frm_DuAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV1DataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.qLNV1DataSet.DUAN);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAdding = true;
            isEditing = false;
            ResetInputFields();
            ReverstControlState(true);
            SetButtonControlState(true, new List<Button> { btnSave, btnDiscard });
        }

        private void ResetInputFields()
        {
            txtMaDuAn.Text = "";
            txtTenDuAn.Text = "";
            txtDiaDiem.Text = "";
            txtPhong.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                String err = "";
                var ma = txtMaDuAn.Text;
                var ten = txtTenDuAn.Text;
                var diadiem = txtDiaDiem.Text;
                var phong = int.Parse(txtPhong.Text);
                if (DBDuAn.ThemDuAn(ref err, ma, ten, diadiem, phong))
                {
                    MessageBox.Show("Thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ReverstControlState(false);
                }
                else
                {
                    MessageBox.Show($"Lỗi thêm dự án: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isEditing)
            {
                string err = "";
                var ma = txtMaDuAn.Text;
                var ten = txtTenDuAn.Text;
                var diadiem = txtDiaDiem.Text;
                var phong = int.Parse(txtPhong.Text);
                if (DBDuAn.CapNhatDuAn(ref err, ma, ten, diadiem, phong))
                {
                    MessageBox.Show("Cập nhật dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ReverstControlState(false);
                }
                else
                {
                    MessageBox.Show($"Lỗi cập nhật dự án: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SetButtonControlState(false, new List<Button> { btnSave, btnDiscard });
        }
        public void ChangeDataSource(DataTable dt)
        {
            dgvDuAn.DataSource = dt;
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            String err = "";
            var ma = txtMaDuAn.Text;
            if (DBDuAn.XoaDuAn(ref err, ma))
            {
                MessageBox.Show("Xóa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show($"Lỗi xóa dự án: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            IsAdding = false;
            isEditing = false;
            ResetInputFields();
            ReverstControlState(false);
            SetButtonControlState(false, new List<Button> { btnSave, btnDiscard });

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            IsAdding = false;
            ReverstControlState(true);
            SetButtonControlState(true, new List<Button> { btnSave, btnDiscard });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPhongg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDchi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDuAn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
