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

namespace WFQuanLyNhanVien
{
    public partial class FrmPhongBang : Form
    {
        DBPhongBang dbpb;

        DataTable dtPhongBan = null;
        bool Them = false;
        public FrmPhongBang()
        {
            InitializeComponent();
            dbpb = new DBPhongBang();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadData()
        {
            try
            {
                dgvPhongBan.AutoGenerateColumns = false;
                dtPhongBan = new DataTable();
                dtPhongBan.Clear();

                // Lấy dữ liệu từ BAL
                DataSet ds = dbpb.LayDanhSachPhongBan();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtPhongBan = ds.Tables[0];

                    // Đưa dữ liệu lên DataGridView
                    dgvPhongBan.DataSource = dtPhongBan;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong bảng Phòng Ban.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPhongBang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
