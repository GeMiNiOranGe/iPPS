using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Job
    {
        DAL_Job dalJob = new DAL_Job();

        public DataTable GetAllJobProject(string idProject)
        {
            return dalJob.GetAllJobProject(idProject);
        }
        public DataTable GetJobOfEmployee(string idEmployee)
        {
            return dalJob.GetJobOfEmployee(idEmployee);
        }
    }
}
