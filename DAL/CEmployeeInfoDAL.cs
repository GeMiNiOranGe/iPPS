using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CEmployeeInfoDAL
    {
        #region Singleton Design Pattern
        private static CEmployeeInfoDAL instance;
        public static CEmployeeInfoDAL Instance
        {
            get { if (instance == null) instance = new CEmployeeInfoDAL(); return instance; }
            private set { instance = value; }
        }
        private CEmployeeInfoDAL() { }
        #endregion
        //Lấy dữ liệu từ table EMPLOYEE trong database dựa vào ID 
        public CEmployee getEmployeebyEmployeeID(string employeeID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE where ID = '" + employeeID + "'");
            foreach (DataRow item in data.Rows)
            {
                return new CEmployee(item);
            }
            return null;
        }
        //Lấy dữ liệu từ table ROLE trong database dựa vào EMPLOYEE_ID
        public CRole getRolebyEmployeeID(string employeeID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ROLE where EMPLOYEE_ID = '" + employeeID + "'");
            foreach (DataRow item in data.Rows)
            {
                return new CRole(item);
            }
            return null;
        }
        //Lấy dữ liệu từ table DEPARTMENT trong database dựa vào ID
        public CDepartment getDepartmentbyDepartmentID(string departmentID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from DEPARTMENT where ID = '" + departmentID + "'");
            foreach (DataRow item in data.Rows)
            {
                return new CDepartment(item);
            }
            return null;
        }
        //Lấy dữ liệu từ table EMPLOYEE_BELONG_TO_PROJECT trong database dựa vào EMPLOYEE_ID
        public List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID)
        {
            List<CEmployeeBelongToProject> listProjectID = new List<CEmployeeBelongToProject>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE_BELONG_TO_PROJECT where EMPLOYEE_ID = '" + employeeID + "'");
            foreach (DataRow item in data.Rows)
            {
                CEmployeeBelongToProject projectID = new CEmployeeBelongToProject(item);
                listProjectID.Add(projectID);
            }
            return listProjectID;
        }
        //Lấy dữ liệu từ table PROJECT trong database dựa vào ID
        public CProject getProjectbyProjectID(string projectID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from PROJECT where ID = '" + projectID + "'");
            foreach (DataRow item in data.Rows)
            {
                return new CProject(item);
            }
            return null;
        }
        //Lấy dữ liệu từ table EMPLOYEE_PHONE_NUMBER trong database dựa vào EMPLOYEE_ID
        public List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID)
        {
            List<CEmployeePhoneNumber> listPhoneNumber = new List<CEmployeePhoneNumber>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE_PHONE_NUMBER where EMPLOYEE_ID = '" + employeeID + "'");
            foreach (DataRow item in data.Rows)
            {
                CEmployeePhoneNumber phoneNumber = new CEmployeePhoneNumber(item);
                listPhoneNumber.Add(phoneNumber);
            }
            return listPhoneNumber;
        }
    }
}
