using System.Data;

namespace BLL {
    public class CJobBLL {
        #region Singleton Design Pattern
        private static CJobBLL instance;

        public static CJobBLL Instance {
            // The null-coalescing operators
            get => instance ?? (instance = new CJobBLL());
            private set => instance = value;
        }

        private CJobBLL() { }
        #endregion

        public DataTable GetAllFromProject(string strProjectId) {
            return DAL.CJobDAL.Instance.GetAllFromProject(strProjectId);
        }
        
        public DataTable GetAllByEmployee(string strEmployeeId) {
            return DAL.CJobDAL.Instance.GetAllByEmployee(strEmployeeId);
        }
        
        public DataTable GetManager(string strJobId) {
            return DAL.CJobDAL.Instance.GetManager(strJobId);
        }
    }
}
