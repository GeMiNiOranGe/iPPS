using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CProgressBLL
    {
        public static string getNumberofDocumentbyJobID(string jobID)
        {
            return DAL.CProgressDAL.Instance.getNumberofDocumentbyJobID(jobID);
        }
        public static string getTotalDocumentbyJobID(string jobID)
        {
            return DAL.CProgressDAL.Instance.getTotalDocumentbyJobID(jobID);
        }
    }
}
