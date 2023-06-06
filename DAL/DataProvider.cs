using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public static class DataProvider {
        private const string CONNECTION_STRING = @"Data Source=.;Initial Catalog=PROJECT_MANAGEMENT_TEMP;Integrated Security=True";

        private static SqlConnection GetConnection() {
            return new SqlConnection(CONNECTION_STRING);
        }

        public static void OpenConnection(SqlConnection sqlConnection) {
            if (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken) {
                sqlConnection.Open();
            }
        }

        public static void CloseConnection(SqlConnection sqlConnection) {
            if (sqlConnection != null) {
                sqlConnection.Close();
            }
        }

        public static DataTable ExecuteQuery(string query) {
            var data = new DataTable();
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                // Fill data with returned query
                sqlDataAdapter.Fill(data);
                CloseConnection(sqlConnection);
            }
            return data;
        }

        public static int ExecuteNonQuery(string query) {
            int data = 0;
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                data = sqlCommand.ExecuteNonQuery();
                CloseConnection(sqlConnection);
            }
            return data;
        }

        public static object ExecuteScalar(string query) {
            object data = 0;
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                data = sqlCommand.ExecuteScalar();
                CloseConnection(sqlConnection);
            }
            return data;
        }
    }
}
