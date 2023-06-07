using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public static class CProjectBLL {
        public static DataTable GetProjectList() {
            return DAL.CProjectDAL.Instance.GetProjectList();
        }
    }
}
