using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class DataProvider {
        private const string CONNECTION_STRING = @"Data Source=.;Initial Catalog=PROJECT_MANAGEMENT_TEMP;Integrated Security=True";

        #region Singleton Design Pattern
        private static DataProvider instance;
        
        public static DataProvider Instance {
            // The null-coalescing operators
            get => instance ?? (instance = new DataProvider());
            private set => instance = value;
        }

        private DataProvider() { }
        #endregion

        private SqlConnection GetConnection() {
            return new SqlConnection(CONNECTION_STRING);
        }

        public void OpenConnection(SqlConnection sqlConnection) {
            if (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken) {
                sqlConnection.Open();
            }
        }

        public void CloseConnection(SqlConnection sqlConnection) {
            if (sqlConnection != null) {
                sqlConnection.Close();
            }
        }

        public DataTable ExecuteQuery(string query) {
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

        public int ExecuteNonQuery(string query) {
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

        public object ExecuteScalar(string query) {
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

        public SqlDataReader ExecuteReader(string query) {
            SqlDataReader data;
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                data = sqlCommand.ExecuteReader();
                CloseConnection(sqlConnection);
            }
            return data;
        }
    }
}
