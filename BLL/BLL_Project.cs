using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Project
    {
        DAL_Project dalProject = new DAL_Project();

        public DataTable GetProject()
        {
            return dalProject.GetProject();
        }
    }
}
