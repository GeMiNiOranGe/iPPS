using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable GetProjectList() {
            string query = "EXECUTE SP_SELECT_ALL_PROJECT";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
