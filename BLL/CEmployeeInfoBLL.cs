using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CEmployeeInfoBLL
    {
        public static CEmployee getEmployeebyEmployeeID(string employeeID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getEmployeebyEmployeeID(employeeID);
        }
        public static CRole getRolebyEmployeeID(string employeeID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getRolebyEmployeeID(employeeID);
        }
        public static CDepartment getDepartmentbyDepartmentID(string departmentID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getDepartmentbyDepartmentID(departmentID);
        }
        public static List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getProjectIDbyEmployeeID(employeeID);
        }
        public static CProject getProjectbyProjectID(string projectID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getProjectbyProjectID(projectID);
        }
        public static List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID)
        {
            return DAL.CEmployeeInfoDAL.Instance.getPhoneNumberbyEmployeeID(employeeID);
        }
    }
}
