using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Job : DBConnect
    {

        //lấy tất cả các công việc có trong dự án nào đó (truyền vào idProject)
        public DataTable GetAllJobProject(string idProject)
        {
            string SQL = string.Format("SELECT ID JOB_ID, NAME JOB_NAME, STATUS JOB_STATUS FROM JOB WHERE PROJECT_ID = '{0}'", idProject);
            SqlDataAdapter sda = new SqlDataAdapter(SQL, _conn);
            DataTable dtAllJobProject = new DataTable();
            sda.Fill(dtAllJobProject);
            return dtAllJobProject;
        }

        //lấy ra tất cả các công việc của một nhân viên nào đó (truyền vào idEmployee)
        public DataTable GetJobOfEmployee(string idEmployee)
        {
            string SQL = string.Format("SELECT PROJECT_ID, ID JOB_ID, NAME JOB_NAME, STATUS JOB_STATUS FROM JOB WHERE JOB_MANAGER_ID = '{0}'", idEmployee);
            SqlDataAdapter sda = new SqlDataAdapter(SQL, _conn);
            DataTable dtJobOfEmployee = new DataTable();
            sda.Fill(dtJobOfEmployee);
            return dtJobOfEmployee;
        }
    }
}
