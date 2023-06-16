﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    internal class DataProvider {
        private const string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT_TEMP;Integrated Security=True";

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
        public SqlCommand GetCommand(string query) {
            var sqlConnection = GetConnection();
            return new SqlCommand(query, sqlConnection);
        }

        public void OpenConnection(SqlConnection sqlConnection) {
            var state = sqlConnection.State;
            if (state == ConnectionState.Closed ||
                state == ConnectionState.Broken) {
                try { sqlConnection.Open(); }
                catch (SqlException ex) { throw ex; }
            }
        }
        public void OpenConnection(SqlCommand sqlCommand) {
            OpenConnection(sqlCommand.Connection);
        }

        public void CloseConnection(SqlConnection sqlConnection) {
            if (sqlConnection != null) {
                try { sqlConnection.Close(); }
                catch (SqlException ex) { throw ex; }
            }
        }
        public void CloseConnection(SqlCommand sqlCommand) {
            CloseConnection(sqlCommand.Connection);
        }


        public DataTable ExecuteQuery(string query) {
            var dataTable = new DataTable();
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Fill dataTable with returned query
                try { sqlDataAdapter.Fill(dataTable); }
                catch (SqlException ex) { throw ex; }

                CloseConnection(sqlConnection);
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query) {
            int iData = 0;
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);

                // Execute CRUD
                try { iData = sqlCommand.ExecuteNonQuery(); }
                catch (SqlException ex) { throw ex; }

                iData = sqlCommand.ExecuteNonQuery();
                CloseConnection(sqlConnection);
            }
            return iData;
        }

        /// <summary>
        ///     Executes the query, and returns the first column of the first row in the result
        ///     set returned by the query. Additional columns or rows are ignored.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>
        ///     The first column of the first row in the result set, or a null reference (Nothing
        ///     in Visual Basic) if the result set is empty. Returns a maximum of 2033 characters.
        /// </returns>
        public object ExecuteScalar(string query) {
            object objData = 0;
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);

                // Get data 
                try { objData = sqlCommand.ExecuteScalar(); }
                catch (SqlException ex) { throw ex; }

                CloseConnection(sqlConnection);
            }
            return objData;
        }

        //public void ExecuteReader(string query, out SqlDataReader dataReader) {
        //    using (var sqlConnection = GetConnection()) {
        //        OpenConnection(sqlConnection);
        //        var sqlCommand = new SqlCommand(query, sqlConnection);
        //        try {
        //            dataReader = sqlCommand.ExecuteReader();
        //        }
        //        catch (SqlException ex) { throw ex; }
        //        CloseConnection(sqlConnection);
        //    }
        //}
    }
}
