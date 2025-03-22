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
    public partial class Frm_DuAn : Form
    {
        private bool IsAdding = false;
        private bool isEditing = false;
        public Frm_DuAn()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
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
    }
}
