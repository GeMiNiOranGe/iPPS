﻿namespace DAL {
    public class CAccountDAL {
        #region Singleton Design Pattern
        private static CAccountDAL instance;

        public static CAccountDAL Instance {
            get => instance ?? (instance = new CAccountDAL());
            private set => instance = value;
        }

        private CAccountDAL() { }
        #endregion

        public bool IsAccountExist(DTO.CAccount account) {
            // Create a query to check if the account exists or not
            string strQuery = $"Select EMPLOYEE_ID, PASSWORD From ACCOUNT Where EMPLOYEE_ID = '{account.EmployeeId}' And PASSWORD = '{account.Password}'";
            
            // Execute query
            var sqlCommand = DataProvider.Instance.GetCommand(strQuery);
            
            // Check data
            DataProvider.Instance.OpenConnection(sqlCommand);
            var sqlDataReader = sqlCommand.ExecuteReader();
            bool bExist = sqlDataReader.HasRows;
            DataProvider.Instance.CloseConnection(sqlCommand);
            
            // Return to existence 
            return bExist;
        }

        public bool IsActive(DTO.CAccount account) {
            // Create a query to check if the account is active or not
            string strQuery = $"Select IS_ACTIVE From ACCOUNT Where EMPLOYEE_ID = '{account.EmployeeId}'";
            
            // Execute query
            bool bActive = System.Convert.ToBoolean(DataProvider.Instance.ExecuteScalar(strQuery));
            return bActive;
        }

        public DTO.CAccount GetAccount(DTO.CAccount account) {
            string query = $"Select EMPLOYEE_ID, PASSWORD, IS_ACTIVE From ACCOUNT Where EMPLOYEE_ID = '{account.EmployeeId}' And PASSWORD = '{account.Password}'";
            
            var sqlCommand = DataProvider.Instance.GetCommand(query);
            
            DataProvider.Instance.OpenConnection(sqlCommand);
            var sqlDataReader = sqlCommand.ExecuteReader();
            DTO.CAccount newAccount = null;
            if (sqlDataReader.Read()) {
                    newAccount = new DTO.CAccount() {
                    EmployeeId = sqlDataReader["EMPLOYEE_ID"].ToString(),
                    Password = sqlDataReader["PASSWORD"].ToString(),
                    IsActive = System.Convert.ToBoolean(sqlDataReader["IS_ACTIVE"])
                };
            }
            DataProvider.Instance.CloseConnection(sqlCommand);
            return newAccount;
        }
    }
}
