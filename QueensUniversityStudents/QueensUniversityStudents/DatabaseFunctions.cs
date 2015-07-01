using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QueensUniversityStudents
{
    class DatabaseFunctions
    {
        ConnectionString connObject = new ConnectionString();

        public SqlCommand LoadStudent(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SelectRegistration", conn);

            return cmd;
        }

        public Int32 GetRowsCount()
        {
            Int32 rowsCount;

            SqlConnection conn = new SqlConnection(connObject.MyConnString());
            SqlCommand cmd = new SqlCommand("GetRowsCount", conn);

            conn.Open();
            rowsCount = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return rowsCount;
        }


        public SqlCommand InsertNewRegistrationCommand(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("InsertRegistration", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            return cmd;
        }
    }
}
