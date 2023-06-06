using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public static class CProjectDAL {
        public static DataTable GetProjectList() {
            string query = "EXECUTE SP_SELECT_ALL_PROJECT";
            return DataProvider.ExecuteQuery(query);
        }
    }
}
