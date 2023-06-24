using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        private static readonly string DATABASE = "PROJECT_MANAGEMENT.mdf";
        private static readonly string DATABASE_PATH = System.IO.Path.GetFullPath(DATABASE);
        private static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DATABASE_PATH + ";Integrated Security=True";

        protected SqlConnection _conn = new SqlConnection(CONNECTION_STRING);
    }
}
