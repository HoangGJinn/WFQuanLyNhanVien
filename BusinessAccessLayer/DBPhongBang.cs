using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DBPhongBang
    {
        private DAL db;

        public DBPhongBang()
        {
            db = new DAL();
        }

        public bool ThemPhongBan(int maPB, string tenPB, string trPhong, DateTime ngNhanChuc, ref string err)
        {
            if (maPB < 0 || string.IsNullOrWhiteSpace(tenPB) || string.IsNullOrWhiteSpace(trPhong))
            {
                err = "Dữ liệu đầu vào không hợp lệ.";
                return false;
            }

            bool result = db.MyExecuteNonQuery("sp_ThemPhongBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@TenPB", tenPB),
                new SqlParameter("@TrPhong", trPhong),
                new SqlParameter("@NgNhanChuc", ngNhanChuc));

            if (!result)
                Console.WriteLine("Lỗi khi thêm phòng ban: " + err);

            return result;
        }

        public bool CapNhatPhongBan(int maPB, string tenPB, string trPhong, DateTime ngNhanChuc, ref string err)
        {
            if (maPB < 0 || string.IsNullOrWhiteSpace(tenPB) || string.IsNullOrWhiteSpace(trPhong))
            {
                err = "Dữ liệu đầu vào không hợp lệ.";
                return false;
            }

            bool result = db.MyExecuteNonQuery("sp_CapNhatPhongBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@TenPB", tenPB),
                new SqlParameter("@TrPhong", trPhong),
                new SqlParameter("@NgNhanChuc", ngNhanChuc));

            if (!result)
                Console.WriteLine("Lỗi khi cập nhật phòng ban: " + err);

            return result;
        }

        public bool XoaPhongBan(int maPB, ref string err)
        {
            if (maPB < 0)
            {
                err = "Mã phòng ban không hợp lệ.";
                return false;
            }

            bool result = db.MyExecuteNonQuery("sp_XoaPhongBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPB", maPB));

            if (!result)
                Console.WriteLine("Lỗi khi xóa phòng ban: " + err);

            return result;
        }

        //public DataTable LayDanhSachPhongBan()
        //{
        //    return db.ExecuteQueryDataTable("sp_LayDSPhongBan", CommandType.StoredProcedure);
        //}

        public DataSet LayDanhSachPhongBan()
        {
            return db.ExecuteQueryDataSet("sp_LayDSPhongBan", CommandType.StoredProcedure);
        }
    }
}
