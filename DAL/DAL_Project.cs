using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Project : DBConnect
    {
        //lấy toàn bộ dự án đang có (idProject, nameProject, nameDepartment, statusProject) 
        public DataTable GetProject()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT PROJECT_ID, PROJECT.NAME PROJECT_NAME, DEPARTMENT.NAME DEPARTMENT_NAME, STATUS PROJECT_STATUS FROM IMPLEMENT_PROJECT, PROJECT, DEPARTMENT WHERE IMPLEMENT_PROJECT.PROJECT_ID = PROJECT.ID AND IMPLEMENT_PROJECT.DEPARTMENT_ID = DEPARTMENT.ID", _conn);
            DataTable dtProject = new DataTable();
            sda.Fill(dtProject);
            return dtProject;
        }
    }
}
