using System;
using System.Data;
using System.Net;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public static class DBDuAn
    {
        private static DAL db = new DAL();

        public static DataSet LayDanhSachDuAn()
        {
            return db.ExecuteQueryDataSet("sp_LayDSDuAn", CommandType.StoredProcedure, null);
        }

        public static bool ThemDuAn(ref string err, string Ma, string Ten, string DiaDiem, int Phong)
        {
            return db.MyExecuteNonQuery("sp_ThemDuAn", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@MaDA", Ma),
                new System.Data.SqlClient.SqlParameter("@TenDA", Ten),
                new System.Data.SqlClient.SqlParameter("@DiaDiem", DiaDiem),
                new System.Data.SqlClient.SqlParameter("@Phong", Phong));
        }

        public static bool XoaDuAn(ref string err, string Ma)
        {
            return db.MyExecuteNonQuery("sp_XoaDuAn", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@MaDA", Ma));
        }
        public static bool CapNhatDuAn(ref string err, string Ma, string Ten, string DiaDiem, int Phong)
        {
            return db.MyExecuteNonQuery("sp_CapNhatDuAn", CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@MaDA", Ma),
                new System.Data.SqlClient.SqlParameter("@TenDA", Ten),
                new System.Data.SqlClient.SqlParameter("@DiaDiem", DiaDiem),
                new System.Data.SqlClient.SqlParameter("@Phong", Phong));
        }
        public static DataSet LayNhanVienTheoPhong(int Ma)
        {
            return db.ExecuteQueryDataSet("sp_LayNhanVienTheoPhong", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter("@MaPB", Ma));
        }
        public static DataSet LayDuAnTheoPhong(int Ma)
        {
            return db.ExecuteQueryDataSet("sp_LayDuAnTheoPhong", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter("@MaPB", Ma));
        }
    }
}
