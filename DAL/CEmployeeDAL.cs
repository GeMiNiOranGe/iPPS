using System.Data;

namespace DAL {
    public class CEmployeeDAL {
        #region Singleton Design Pattern
        private static CEmployeeDAL instance;

        public static CEmployeeDAL Instance {
            // The null-coalescing operators
            get => instance ?? (instance = new CEmployeeDAL());
            private set => instance = value;
        }

        private CEmployeeDAL() { }
        #endregion


    }
}
