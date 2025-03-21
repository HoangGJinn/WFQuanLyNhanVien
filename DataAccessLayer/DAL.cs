using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DAL
    {
        string ConnStr = "Data Source=(local);" + "Initial Catalog=QLNV1;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        //Constructor
        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand(); //create command

        }
        //Khai bao ham thuc thi tang ket noi
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.Parameters.Clear(); // Xóa các tham số cũ trước khi thêm mới
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            if (p != null && p.Length > 0)
            {
                comm.Parameters.AddRange(p);
                foreach (var param in p)
                {
                    Console.WriteLine($"Thêm tham số: {param.ParameterName} = {param.Value}");
                }
            }

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();
            return ds;
        }


        // Action Query = Insert | Delete | Update | Stored Procedure
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
