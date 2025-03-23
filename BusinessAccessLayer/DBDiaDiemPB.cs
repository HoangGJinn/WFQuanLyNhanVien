using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DBDiaDiemPB
    {
        private readonly DAL db; // Đối tượng DAL

        public DBDiaDiemPB()
        {
            db = new DAL(); // Khởi tạo DAL
        }

        // Hàm lấy danh sách địa điểm phòng
        public DataSet LayDanhSachDiaDiem()
        {
            return db.ExecuteQueryDataSet("sp_LayDiaDiemPhong", CommandType.StoredProcedure);
        }

        // Hàm thêm địa điểm phòng
        public bool ThemDiaDiem(ref string err, int MaPB, string DiaDiem)
        {
            return db.MyExecuteNonQuery("sp_ThemDiaDiemPhong", CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPB", MaPB),
                new SqlParameter("@DiaDiem", DiaDiem));
        }

        // Hàm xóa địa điểm phòng
        public bool XoaDiaDiem(ref string err, int MaPB, string DiaDiem)
        {
            return db.MyExecuteNonQuery("sp_XoaDiaDiemPhong", CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPB", MaPB),
                new SqlParameter("@DiaDiem", DiaDiem));
        }
    }
}
