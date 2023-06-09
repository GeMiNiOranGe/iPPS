using System;

namespace DAL {
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
            // Create query check account
            string query = $"Select EMPLOYEE_ID, PASSWORD From ACCOUNT Where EMPLOYEE_ID = '{account.EmployeeId}' And PASSWORD = '{account.Password}'";
            
            // Execute query
            var sqlCommand = DataProvider.Instance.GetCommand(query);
            
            // Check data
            DataProvider.Instance.OpenConnection(sqlCommand);
            var sqlDataReader = sqlCommand.ExecuteReader();
            bool bExist = sqlDataReader.HasRows;
            DataProvider.Instance.CloseConnection(sqlCommand);
            
            // Return to existence 
            return bExist;
        }

        public bool IsActive(DTO.CAccount account) {
            // Create query check account
            string query = $"Select IS_ACTIVE From ACCOUNT Where EMPLOYEE_ID = '{account.EmployeeId}'";
            
            // Execute query
            bool bActive = Convert.ToBoolean(DataProvider.Instance.ExecuteScalar(query));
            return bActive;
        }
    }
}
