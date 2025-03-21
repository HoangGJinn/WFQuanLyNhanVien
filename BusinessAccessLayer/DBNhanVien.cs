using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DBNhanVien
    {
        private DAL db;

        public DBNhanVien()
        {
            db = new DAL();
        }

        // Lấy danh sách nhân viên
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("sp_LayNhanVien", CommandType.StoredProcedure, null);
        }


        // Thêm nhân viên
        public bool ThemNhanVien(ref string err, string manv, string hoNV, string tenLot, string tenNV, DateTime ngSinh, string dchi, string phai, int luong, string maNQL, int phong)
        {
            return db.MyExecuteNonQuery("sp_ThemNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Manv", manv),
                new SqlParameter("@HoNV", hoNV),
                new SqlParameter("@Tenlot", tenLot),
                new SqlParameter("@TenNV", tenNV),
                new SqlParameter("@NgSinh", ngSinh.Date),
                new SqlParameter("@Dchi", dchi),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@MaNQL", maNQL),
                new SqlParameter("@Phong", phong));
        }

        // Xóa nhân viên
        public bool XoaNhanVien(ref string err, string manv)
        {
            return db.MyExecuteNonQuery("sp_XoaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Manv", manv));
        }

        // Cập nhật nhân viên
        public bool CapNhatNhanVien(ref string err, string manv, string hoNV, string tenLot, string tenNV, DateTime ngSinh, string dchi, string phai, int luong, string maNQL, int phong)
        {
            return db.MyExecuteNonQuery("sp_CapNhatNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Manv", manv),
                new SqlParameter("@HoNV", hoNV),
                new SqlParameter("@Tenlot", tenLot),
                new SqlParameter("@TenNV", tenNV),
                new SqlParameter("@NgSinh", ngSinh.Date),
                new SqlParameter("@Dchi", dchi),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@MaNQL", maNQL),
                new SqlParameter("@Phong", phong));
        }

        // 🔹 Tìm kiếm nhân viên theo tên
        public DataSet TimKiemNhanVien(string tenNV)
        {
            if (string.IsNullOrEmpty(tenNV))
            {
                throw new ArgumentException("Tham số @TenNV không được để trống");
            }

            Console.WriteLine($"Gửi tham số @TenNV = {tenNV}");

            return db.ExecuteQueryDataSet("sp_TimNhanVienTheoTen",
                CommandType.StoredProcedure,
                new SqlParameter("@TenNV", tenNV));
        }

        // 🔹 Kiểm tra nhân viên có tồn tại không
        public bool KiemTraNhanVien(string manv)
        {
            DataSet ds = db.ExecuteQueryDataSet("sp_KiemTraNhanVien",
                CommandType.StoredProcedure,
                new SqlParameter("@Manv", manv));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["Exists"]) == 1;
            }
            return false;
        }

        // 🔹 Lấy thông tin nhân viên theo mã
        public DataSet LayNhanVienTheoMa(string manv)
        {
            return db.ExecuteQueryDataSet("sp_LayNhanVienTheoMa",
                CommandType.StoredProcedure,
                new SqlParameter("@Manv", manv));
        }
    }
}
