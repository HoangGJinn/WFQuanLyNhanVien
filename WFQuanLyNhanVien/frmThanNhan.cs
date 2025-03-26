using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;
namespace WFQuanLyNhanVien
{
    public partial class frmThanNhan : Form
    {
        private bool IsAdding = false;
        private bool isEditing = false;

        public frmThanNhan()
        {
            InitializeComponent();
            LoadData();
            dgvThanNhan.SelectionChanged += dgvThanNhan_SelectionChanged;

        }
        private void LoadData() {
            try
            {
                dgvThanNhan.AutoGenerateColumns = false;
                var dtThanNhan = new DataTable();
                dtThanNhan.Clear();
                DataSet ds = DBThanNhan.LayDanhSachThanNhan();
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtThanNhan = ds.Tables[0];
                    dgvThanNhan.DataSource = dtThanNhan;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            IsAdding = true;
            isEditing = false;
            txtManhanvien.Text = "";
            txtTenThanNhan.Text = "";
            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtQuanHe.Text = "";
            txtManhanvien.Focus();
        }


        private void dgvThanNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThanNhan.CurrentRow != null)
            {
                txtManhanvien.Text = dgvThanNhan.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTenThanNhan.Text = dgvThanNhan.CurrentRow.Cells["TenTN"].Value.ToString();
                txtGioiTinh.Text = dgvThanNhan.CurrentRow.Cells["Phai"].Value.ToString();
                txtNgaySinh.Text = dgvThanNhan.CurrentRow.Cells["NgaySinh"].Value.ToString();
                txtQuanHe.Text = dgvThanNhan.CurrentRow.Cells["QuanHe"].Value.ToString();
            }
        }
        private void dgvThanNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtManhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThanNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuanHe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
