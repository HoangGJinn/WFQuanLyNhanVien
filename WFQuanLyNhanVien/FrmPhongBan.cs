using BusinessAccessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFQuanLyNhanVien
{
    public partial class FrmPhongBan : Form
    {
        private readonly DBPhongBang dbpb;
        private readonly DBDiaDiemPB dbddpb;
        private DataTable dtPhongBan;
        private bool isAdding = false;
        private bool isEditing = false;
        private bool isAdding2 = false;
        private bool isEditing2 = false;
        private TabPage previousTab = null;


        public FrmPhongBan()
        {
            InitializeComponent();
            dbpb = new DBPhongBang();
            dbddpb = new DBDiaDiemPB();
        }

        private void FrmPhongBang_Load(object sender, EventArgs e)
        {
            LoadDataPB();
            dgvPhongBan.SelectionChanged += dgvPhongBang_OnSelectionChanged;
            LoadDataDiaDiem();
            dgvDDPB.SelectionChanged += dgvDiaDiemPB_OnSelectionChanged;
        }

        private void LoadDataPB()
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
                SetControlState(panel2, btnSave, btnDiscard, btnAdd, btnEdit, btnDel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataDiaDiem()
        {
            try
            {
                dgvDDPB.AutoGenerateColumns = false;
                DataTable dtDiaDiem = new DataTable();
                dtDiaDiem.Clear();

                DataSet ds = dbddpb.LayDanhSachDiaDiem(); // Gọi BAL để lấy dữ liệu
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtDiaDiem = ds.Tables[0];
                    dgvDDPB.DataSource = dtDiaDiem;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu địa điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetInputFields();
                SetControlState(panel2, btnSave2, btnDiscard2, btnAdd2, btnEdit2, btnDel2, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu địa điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResetInputFields()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtTrPhong.Clear();
            txtNgNhanChuc.Clear();
            txtDiaDiemPB.Clear();
        }

        private void SetControlState(Panel panel, Button btnSave, Button btnDiscard, Button btnAdd, Button btnEdit, Button btnDel, bool isEditingState)
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
                SetControlState(panel2, btnSave, btnDiscard, btnAdd, btnEdit, btnDel, false);
            }

            if (dgvPhongBan.CurrentRow != null)
            {
                int r = dgvPhongBan.CurrentRow.Index;
                if (dgvPhongBan.Rows[r].Cells["MaPB"].Value != null)

                {
                    string currentMaPB = dgvPhongBan.Rows[r].Cells["MaPB"].Value.ToString();

                    txtMaPB.Text = currentMaPB;
                    txtTenPB.Text = dgvPhongBan.Rows[r].Cells["TenPB"].Value?.ToString();
                    txtTrPhong.Text = dgvPhongBan.Rows[r].Cells["TrPhong"].Value?.ToString();

                    if (DateTime.TryParse(dgvPhongBan.Rows[r].Cells["NgNhanChuc"].Value?.ToString(), out DateTime ngayNhanChuc))
                    {
                        txtNgNhanChuc.Text = ngayNhanChuc.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtNgNhanChuc.Text = string.Empty;
                    }

                    // GỌI HÀM LẤY ĐỊA ĐIỂM PHÒNG BAN
                    LayVaHienThiDiaDiem(currentMaPB);

                    SetControlState(panel2, btnSave, btnDiscard, btnAdd, btnEdit, btnDel, false);
                }
            }
        }
        private void LayVaHienThiDiaDiem(string maPB)
        {
            // Gọi database lấy danh sách địa điểm
            DataSet ds = dbddpb.LayDanhSachDiaDiem();

            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                // Tìm địa điểm theo MaPB
                DataRow[] rows = dt.Select($"MaPB = {maPB}");
                if (rows.Length > 0)
                {
                    txtDiaDiemPB.Text = rows[0]["DiaDiem"].ToString();
                }
                else
                {
                    txtDiaDiemPB.Text = "Không có dữ liệu";
                }
            }
        }


        private void dgvDiaDiemPB_OnSelectionChanged(object sender, EventArgs e)
        {
            if ((isAdding2 || isEditing2) && dgvDDPB.CurrentRow != null)
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
                isAdding2 = false;
                isEditing2 = false;
                SetControlState(panel2, btnSave2, btnDiscard2, btnAdd2, btnEdit2, btnDel2, false);
            }
            int r = dgvDDPB.CurrentRow.Index;
            if (dgvDDPB.Rows[r].Cells["MaPB1"].Value != null)
            {
                txtMaPB.Text = dgvDDPB.Rows[r].Cells["MaPB1"].Value.ToString();
                txtDiaDiemPB.Text = dgvDDPB.Rows[r].Cells["DiaDiem"].Value.ToString();
                CapNhatTuPhongBan(txtMaPB.Text);
                SetControlState(panel2, btnSave2, btnDiscard2, btnAdd2, btnEdit2, btnDel2, false);
            }
        }

        private void CapNhatTuPhongBan(string maPB)
        {
            foreach (DataGridViewRow row in dgvPhongBan.Rows) // Corrected dgvPhongBang to dgvPhongBan
            {
                if (row.Cells["MaPB"].Value?.ToString() == maPB)
                {
                    txtTenPB.Text = row.Cells["TenPB"].Value?.ToString();
                    txtTrPhong.Text = row.Cells["TrPhong"].Value?.ToString();
                    if (DateTime.TryParse(row.Cells["NgNhanChuc"].Value?.ToString(), out DateTime ngayNhanChuc))
                    {
                        txtNgNhanChuc.Text = ngayNhanChuc.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtNgNhanChuc.Text = string.Empty;
                    }
                    return;
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
            SetControlState(panel2, btnSave, btnDiscard, btnAdd, btnEdit, btnDel, true);
            txtDiaDiemPB.Clear();
            txtDiaDiemPB.Enabled = false;
            txtTenPB.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ResetInputFields();
            SetControlState(panel2, btnSave, btnDiscard, btnAdd, btnEdit, btnDel, true);
            txtDiaDiemPB.Enabled = false;
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

                if (result) LoadDataPB();
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
            if (!DateTime.TryParseExact(txtNgNhanChuc.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày nhận chức không hợp lệ! Vui lòng nhập theo định dạng MM/dd/yyyy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadDataPB();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataPB();
            dgvPhongBan.ClearSelection();
            dgvPhongBan.Rows[0].Selected = true;
            dgvPhongBan.CurrentCell = dgvPhongBan.Rows[0].Cells[0];
            dgvPhongBang_OnSelectionChanged(null, EventArgs.Empty);
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
                LoadDataPB();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            if (previousTab != tabPage1) return;
            dgvDDPB.ClearSelection();
            dgvDDPB.Rows[0].Selected = true;
            dgvDDPB.CurrentCell = dgvDDPB.Rows[0].Cells[0];
            dgvDiaDiemPB_OnSelectionChanged(null, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (previousTab != tabPage2) return; // Chỉ chạy khi từ tabPage2 chuyển sang

            dgvPhongBan.ClearSelection();
            dgvPhongBan.Rows[0].Selected = true;
            dgvPhongBan.CurrentCell = dgvPhongBan.Rows[0].Cells[0];
            dgvPhongBang_OnSelectionChanged(null, EventArgs.Empty);
        }


        private void btnAdd2_Click(object sender, EventArgs e)
        {
            isAdding2 = true;
            isEditing2 = false;
            ResetInputFields();
            SetControlState(panel2, btnSave2, btnDiscard2, btnAdd2, btnEdit2, btnDel2, true);
            txtTenPB.Enabled = false;
            txtTrPhong.Enabled = false;
            txtNgNhanChuc.Enabled = false;
            txtMaPB.Focus();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (dgvDDPB.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phòng ban để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing2 = true;
            isAdding2 = false;
            SetControlState(panel2, btnSave2, btnDiscard2, btnAdd2, btnEdit2, btnDel2, true);
            txtTenPB.Clear();
            txtTrPhong.Clear();
            txtNgNhanChuc.Clear();
            txtTenPB.Enabled = false;
            txtTrPhong.Enabled = false;
            txtNgNhanChuc.Enabled = false;
            txtMaPB.Focus();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text) || string.IsNullOrWhiteSpace(txtDiaDiemPB.Text))
            {
                MessageBox.Show("Mã phòng ban và địa điểm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string err = string.Empty;
            bool success;
            int maPB = int.Parse(txtMaPB.Text);
            string diaDiem = txtDiaDiemPB.Text.Trim();

            if (isAdding2)
            {
                success = dbddpb.ThemDiaDiem(ref err, maPB, diaDiem);
                MessageBox.Show(success ? "Thêm địa điểm thành công!" : $"Thêm địa điểm thất bại: {err}");
            }
            else if (isEditing2)
            {
                success = dbddpb.XoaDiaDiem(ref err, maPB, diaDiem) && dbddpb.ThemDiaDiem(ref err, maPB, diaDiem);
                MessageBox.Show(success ? "Cập nhật địa điểm thành công!" : $"Cập nhật địa điểm thất bại: {err}");
            }
            else return;

            if (success)
            {
                isAdding2 = false;
                isEditing2 = false;
                LoadDataDiaDiem();
            }
        }

        private void btnDiscard2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy các thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isAdding2 = false;
                isEditing2 = false;
                LoadDataDiaDiem();
            }
        }

        private void btnReload2_Click(object sender, EventArgs e)
        {
            LoadDataDiaDiem();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            previousTab = tabControl1.SelectedTab;
            txtDiaDiemPB.Enabled = true;
            txtTenPB.Enabled = true;
            txtTrPhong.Enabled = true;
            txtNgNhanChuc.Enabled = true;
            txtMaPB.Enabled = true;
            
        }

        private void btnDel2_Click(object sender, EventArgs e)
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
                bool result = dbddpb.XoaDiaDiem(ref err, maPB, txtDiaDiemPB.Text);
                MessageBox.Show(result ? "Xóa thành công!" : $"Xóa thất bại: {err}");

                if (result) LoadDataDiaDiem();
            }
        }

        private void dgvPhongBan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // mở danh sách nhân viên thuộc phòng ban đó
            //message box display name phongban
            MessageBox.Show("Danh sách nhân viên thuộc phòng ban " + txtTenPB.Text);

        }
    }
}
