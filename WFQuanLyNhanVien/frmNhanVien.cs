using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WFQuanLyNhanVien
{
    public partial class frmNhanVien : Form
    {
        DBNhanVien dbnv;

        DataTable dtNhanVien = null;
        bool Them = false;
        string previousMaNV = string.Empty; // Biến kiểm tra Mã NV trước đó
        public frmNhanVien()
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
        }



        private void dgvNhanVien_OnSelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int r = dgvNhanVien.CurrentRow.Index;

                // Kiểm tra nếu DataGridView có dữ liệu
                if (dgvNhanVien.Rows[r].Cells["MaNV"].Value != null)
                {
                    string currentMaNV = dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();

                    // So sánh Mã NV hiện tại với Mã NV trước đó
                    if (currentMaNV != previousMaNV)
                    {
                        txtMaNV.Text = currentMaNV;
                        txtHVT.Text = dgvNhanVien.Rows[r].Cells["HoTenDayDu"].Value.ToString(); // Đổi `HoTenDayDu` thành `HVTNV`
                        txtNgSinh.Text = Convert.ToDateTime(dgvNhanVien.Rows[r].Cells["NgSinh"].Value).ToString("dd-MM-yyyy");
                        txtDchi.Text = dgvNhanVien.Rows[r].Cells["Dchi"].Value.ToString();
                        txtPhai.Text = dgvNhanVien.Rows[r].Cells["Phai"].Value.ToString();
                        txtLuong.Text = dgvNhanVien.Rows[r].Cells["Luong"].Value.ToString();
                        txtMaNQL.Text = dgvNhanVien.Rows[r].Cells["MaNQL"].Value.ToString();
                        txtPhong.Text = dgvNhanVien.Rows[r].Cells["Phong"].Value.ToString();
                        panel2.Enabled = false;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDel.Enabled = true;

                        // Cập nhật Mã NV trước đó
                        previousMaNV = currentMaNV;
                    }
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvNhanVien.SelectionChanged += dgvNhanVien_OnSelectionChanged;
        }

        void LoadData()
        {
            try
            {
                // Bỏ AutoGenerateColumns nếu bạn chưa định nghĩa cột thủ công
                dgvNhanVien.AutoGenerateColumns = false;


                dtNhanVien = new DataTable();
                dtNhanVien.Clear();

                // Lấy dữ liệu từ BAL
                DataSet ds = dbnv.LayNhanVien();
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtNhanVien = ds.Tables[0];

                    // Gán DataTable vào DataGridView
                    dgvNhanVien.DataSource = dtNhanVien;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvNhanVien.DataSource = null;
                }

                // Xóa trống các TextBox
                txtMaNV.Clear();
                txtHVT.Clear();
                txtNgSinh.Clear();
                txtDchi.Clear();
                txtPhai.Clear();
                txtLuong.Clear();
                txtMaNQL.Clear();
                txtPhong.Clear();

                // Không cho thao tác trên các nút Lưu / Hủy
                btnSave.Enabled = false;
                btnDiscard.Enabled = false;
                panel2.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                //btnExit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtHVT.ResetText();
            this.txtDchi.ResetText();
            this.txtNgSinh.ResetText();
            this.txtPhai.ResetText();
            this.txtLuong.ResetText();
            this.txtMaNQL.ResetText();
            this.txtPhong.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnDiscard.Enabled = true;
            this.panel2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
            //this.btnExit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNV
            this.txtMaNV.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.CurrentRow != null)
                {
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                    string maNV = dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();

                    // Hỏi xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
                                                          "Xác nhận",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string err = string.Empty;
                        if (dbnv.XoaNhanVien(ref err, maNV))
                        {
                            LoadData();  // Load lại dữ liệu
                            MessageBox.Show("Xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại. Kiểm tra lại dữ liệu.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }


        private void btnDiscard_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtHVT.ResetText();
            this.txtDchi.ResetText();
            this.txtNgSinh.ResetText();
            this.txtPhai.ResetText();
            this.txtLuong.ResetText();
            this.txtMaNQL.ResetText();
            this.txtPhong.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDel.Enabled = true;
            //this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnDiscard.Enabled = false;
            this.panel2.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            string err = string.Empty;

            if (!DateTime.TryParse(txtNgSinh.Text, out DateTime ngSinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtLuong.Text, out int luong))
            {
                MessageBox.Show("Lương phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPhong.Text, out int phong))
            {
                MessageBox.Show("Phòng phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tách họ tên từ txtHVT
            string[] hoTenParts = txtHVT.Text.Trim().Split(' ');
            if (hoTenParts.Length < 2)
            {
                MessageBox.Show("Họ tên không hợp lệ. Vui lòng nhập đầy đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hoNV = hoTenParts[0];
            string tenNV = hoTenParts[hoTenParts.Length - 1];
            string tenLot = string.Join(" ", hoTenParts.Skip(1).Take(hoTenParts.Length - 2));

            if (Them) // Thêm mới
            {
                success = dbnv.ThemNhanVien(ref err, txtMaNV.Text, hoNV, tenLot, tenNV, ngSinh, txtDchi.Text, txtPhai.Text, luong, txtMaNQL.Text, phong);
                MessageBox.Show(success ? "Thêm nhân viên thành công!" : $"Thêm thất bại: {err}");
            }
            else // Cập nhật
            {
                success = dbnv.CapNhatNhanVien(ref err, txtMaNV.Text, hoNV, tenLot, tenNV, ngSinh, txtDchi.Text, txtPhai.Text, luong, txtMaNQL.Text, phong);
                MessageBox.Show(success ? "Cập nhật nhân viên thành công!" : $"Cập nhật thất bại: {err}");
            }

            if (success)
            {
                LoadData(); // Cập nhật lại DataGridView
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel nhập liệu
            this.panel2.Enabled = true;

            // Kiểm tra nếu có dòng được chọn trong DataGridView
            if (dgvNhanVien.CurrentRow != null)
            {
                int r = dgvNhanVien.CurrentCell.RowIndex; // Lấy chỉ mục dòng hiện tại

                // Đưa dữ liệu từ DataGridView lên các TextBox
                this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                this.txtHVT.Text = dgvNhanVien.Rows[r].Cells["HoTenDayDu"].Value.ToString();
                this.txtNgSinh.Text = dgvNhanVien.Rows[r].Cells["NgSinh"].Value.ToString();
                this.txtDchi.Text = dgvNhanVien.Rows[r].Cells["Dchi"].Value.ToString();
                this.txtPhai.Text = dgvNhanVien.Rows[r].Cells["Phai"].Value.ToString();
                this.txtLuong.Text = dgvNhanVien.Rows[r].Cells["Luong"].Value.ToString();
                this.txtMaNQL.Text = dgvNhanVien.Rows[r].Cells["MaNQL"].Value.ToString();
                this.txtPhong.Text = dgvNhanVien.Rows[r].Cells["Phong"].Value.ToString();

                // Cho phép thao tác trên nút Lưu / Hủy
                this.btnSave.Enabled = true;
                this.btnDiscard.Enabled = true;

                // Không cho phép thao tác trên các nút Thêm / Xóa / Thoát
                this.btnAdd.Enabled = false;
                this.btnEdit.Enabled = false;
                this.btnDel.Enabled = false;
                //this.btnExit.Enabled = false;

                // Đưa con trỏ về TextBox Họ và Tên để chỉnh sửa
                this.txtHVT.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
