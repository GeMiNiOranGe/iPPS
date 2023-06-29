using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CProgressBLL
    {
        public static string getTotalDocument()
        {
            return DAL.CProgressDAL.Instance.getTotalDocument();
        }
        public static string getTotalDocumentbyJobID(string jobID)
        {
            return DAL.CProgressDAL.Instance.getTotalDocumentbyJobID(jobID);
        }
    }
}
