using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    internal class DBPhanCong
    {
        private DAL db;
        public DBPhanCong()
        {
            db = new DAL();
        }
        public DataSet LayDanhSachPhanCong()
        {
            return db.ExecuteQueryDataSet("sp_LayDSDuAn", CommandType.StoredProcedure, null);
        }


    }
}
