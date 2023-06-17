using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Employee
    {
        DAL_Employee dalEmployee = new DAL_Employee();

        public DataTable GetEmployeeOfJob(string idWork)
        {
            return dalEmployee.GetEmployeeOfJob(idWork);
        }
    }
}
