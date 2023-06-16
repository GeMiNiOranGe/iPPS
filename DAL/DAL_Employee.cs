using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Employee : DBConnect
    {
        // lấy ra được nhân viên đang quản lý công việc đó (truyền vào mã công việc)
        public DataTable GetEmployeeOfJob(string idWork)
        {
            string SQL = string.Format("SELECT EMPLOYEE.ID EMPLOYEE_ID, FIRST_NAME + ' ' + MIDDLE_NAME + ' ' + LAST_NAME EMPLOYEE_FULLNAME FROM EMPLOYEE, JOB WHERE EMPLOYEE.ID = JOB.JOB_MANAGER_ID AND JOB.ID = '{0}'", idWork);
            SqlDataAdapter sda = new SqlDataAdapter(SQL, _conn);
            DataTable dtEmployeeOfJob = new DataTable();
            sda.Fill(dtEmployeeOfJob);
            return dtEmployeeOfJob;
        }
    }
}
