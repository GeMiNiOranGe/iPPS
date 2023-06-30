using System.Data;

namespace BLL {
    public class CEmployeeBLL {
        #region Singleton Design Pattern
        private static CEmployeeBLL instance;

        public static CEmployeeBLL Instance {
            // The null-coalescing operators
            get => instance ?? (instance = new CEmployeeBLL());
            private set => instance = value;
        }

        private CEmployeeBLL() { }
        #endregion


    }
}
