using BusinessAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace WFQuanLyNhanVien
{
    public partial class FrmPhongBang : Form
    {
        private readonly DBPhongBang dbpb;
        private DataTable dtPhongBan;
        private bool isAdding = false;
        private bool isEditing = false;
        private string previousMaPB = string.Empty;

        public FrmPhongBang()
        {
            InitializeComponent();
            dbpb = new DBPhongBang();
        }

        private void FrmPhongBang_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvPhongBan.SelectionChanged += dgvPhongBang_OnSelectionChanged;
        }

        private void LoadData()
        {
            try
            {
                dgvPhongBan.AutoGenerateColumns = false;
                dtPhongBan = new DataTable();
                dtPhongBan.Clear();

                DataSet ds = dbpb.LayDanhSachPhongBan();
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtPhongBan = ds.Tables[0];
                    dgvPhongBan.DataSource = dtPhongBan;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetInputFields();
                SetControlState(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetInputFields()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtTrPhong.Clear();
            txtNgNhanChuc.Clear();
        }

        private void SetControlState(bool isEditingState)
        {
            panel2.Enabled = isEditingState;
            btnSave.Enabled = isEditingState;
            btnDiscard.Enabled = isEditingState;
            btnAdd.Enabled = !isEditingState;
            btnEdit.Enabled = !isEditingState;
            btnDel.Enabled = !isEditingState;
        }

        private void dgvPhongBang_OnSelectionChanged(object sender, EventArgs e)
        {
            if ((isAdding || isEditing) && dgvPhongBan.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có thay đổi chưa lưu. Bạn có muốn chuyển dòng mà không lưu không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.No)
                {
                    return;
                }
                isAdding = false;
                isEditing = false;
                SetControlState(false);
            }

            if (dgvPhongBan.CurrentRow == null) return;

            int r = dgvPhongBan.CurrentRow.Index;
            if (dgvPhongBan.Rows[r].Cells["MaPB"].Value != null)
            {
                string currentMaPB = dgvPhongBan.Rows[r].Cells["MaPB"].Value.ToString();

                if (currentMaPB != previousMaPB)
                {
                    txtMaPB.Text = currentMaPB;
                    txtTenPB.Text = dgvPhongBan.Rows[r].Cells["TenPB"].Value?.ToString();
                    txtTrPhong.Text = dgvPhongBan.Rows[r].Cells["TrPhong"].Value?.ToString();

                    if (DateTime.TryParse(dgvPhongBan.Rows[r].Cells["NgNhanChuc"].Value?.ToString(), out DateTime ngayNhanChuc))
                    {
                        txtNgNhanChuc.Text = ngayNhanChuc.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtNgNhanChuc.Text = string.Empty;
                    }

                    SetControlState(false);
                    previousMaPB = currentMaPB;
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhongBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phòng ban để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing = true;
            isAdding = false;
            SetControlState(true);
            txtTenPB.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ResetInputFields();
            SetControlState(true);
            txtMaPB.Focus();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                string err = string.Empty;
                int maPB = int.Parse(txtMaPB.Text);
                bool result = dbpb.XoaPhongBan(maPB, ref err);
                MessageBox.Show(result ? "Xóa thành công!" : $"Xóa thất bại: {err}");

                if (result) LoadData();
            }
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text) || !int.TryParse(txtMaPB.Text, out _))
            {
                MessageBox.Show("Mã PB không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                MessageBox.Show("Tên phòng ban không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTrPhong.Text))
            {
                MessageBox.Show("Tên trưởng phòng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrPhong.Focus();
                return false;
            }
            if (!DateTime.TryParseExact(txtNgNhanChuc.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày nhận chức không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgNhanChuc.Focus();
                return false;
            }
            return true;
        }


        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy các thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isAdding = false;
                isEditing = false;
                LoadData();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu()) return;

            string err = string.Empty;
            bool success;
            int maPB = int.Parse(txtMaPB.Text);
            string tenPB = txtTenPB.Text.Trim();
            string truongPhong = txtTrPhong.Text.Trim();
            DateTime ngayNhanChuc = DateTime.Parse(txtNgNhanChuc.Text);

            if (isAdding)
            {
                success = dbpb.ThemPhongBan(maPB, tenPB, truongPhong, ngayNhanChuc, ref err);
                MessageBox.Show(success ? "Thêm thành công!" : $"Thêm thất bại: {err}");
            }
            else if (isEditing)
            {
                success = dbpb.CapNhatPhongBan(maPB, tenPB, truongPhong, ngayNhanChuc, ref err);
                MessageBox.Show(success ? "Cập nhật thành công!" : $"Cập nhật thất bại: {err}");
            }
            else return;

            if (success)
            {
                isAdding = false;
                isEditing = false;
                LoadData();
            }
        }
    }
}
