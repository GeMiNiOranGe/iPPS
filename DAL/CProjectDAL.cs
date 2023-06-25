using System.Data;

namespace DAL {
    public class CProjectDAL {
        #region Singleton Design Pattern
        private static CProjectDAL instance;

        public static CProjectDAL Instance {
            get => instance ?? (instance = new CProjectDAL());
            private set => instance = value;
        }

        private CProjectDAL() { }
        #endregion

        /// <summary>
        ///     Retrieve all projects
        /// </summary>
        /// <returns>
        ///     List of projects
        /// </returns>
        public DataTable GetProjectList() {
            string strQuery = string.Format(@"
                SELECT PROJECT_ID, PROJECT.NAME PROJECT_NAME, DEPARTMENT.NAME DEPARTMENT_NAME, STATUS PROJECT_STATUS 
                FROM IMPLEMENT_PROJECT, PROJECT, DEPARTMENT 
                WHERE IMPLEMENT_PROJECT.PROJECT_ID = PROJECT.ID AND IMPLEMENT_PROJECT.DEPARTMENT_ID = DEPARTMENT.ID
            ");
            return DataProvider.Instance.ExecuteQuery(strQuery);
        }
    }
}
