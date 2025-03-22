using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DBThanNhan
    {
        private static DAL db = new DAL();
        public static DataSet LayDanhSachThanNhan()
        {
            return db.ExecuteQueryDataSet("sp_LayDSThanNhan", CommandType.StoredProcedure, null);
        }
        public static bool ThemThanNhan(ref string err, string MaNV, string TenTN, string Phai, string NgSinh, string QuanHe)
        {
            return db.MyExecuteNonQuery("sp_ThemThanNhan", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@Manv", MaNV),
                new System.Data.SqlClient.SqlParameter("@TenTN", TenTN),
                new System.Data.SqlClient.SqlParameter("@Phai", Phai),
                new System.Data.SqlClient.SqlParameter("@NgSinh", NgSinh),
                new System.Data.SqlClient.SqlParameter("@QuanHe", QuanHe));
        }

        public static bool XoaThanNhan(ref string err, string MaNV, string TenTN)
        {
            return db.MyExecuteNonQuery("sp_XoaThanNhan", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@Manv", MaNV),
                new System.Data.SqlClient.SqlParameter("@TenTN", TenTN));
        }

        public static bool CapNhatThanNhan(ref string err, string MaNV, string TenTN, string Phai, string NgSinh, string QuanHe)
        {
            return db.MyExecuteNonQuery("sp_CapNhatThanNhan", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@Manv", MaNV),
                new System.Data.SqlClient.SqlParameter("@TenTN", TenTN),
                new System.Data.SqlClient.SqlParameter("@Phai", Phai),
                new System.Data.SqlClient.SqlParameter("@NgSinh", NgSinh),
                new System.Data.SqlClient.SqlParameter("@QuanHe", QuanHe));
        }

        public static DataSet LayThanNhanTheoNhanVien(string MaNV)
        {
            return db.ExecuteQueryDataSet("sp_LayThanNhanTheoNhanVien", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter("@Manv", MaNV));
        }
    }
}
