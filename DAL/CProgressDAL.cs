using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CProgressDAL
    {
        #region Singleton Design Pattern
        private static CProgressDAL instance;
        public static CProgressDAL Instance
        {
            get { if (instance == null) instance = new CProgressDAL(); return instance; }
            private set { instance = value; }
        }
        private CProgressDAL() { }
        #endregion
        //Đếm tổng tài liệu 
        public string getTotalDocument()
        {
            string query = "Select Count(ID) from DOCUMENT";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows[0][0].ToString();
        }
        //Đếm tổng tài liệu dựa vào JOB_ID
        public string getTotalDocumentbyJobID(string jobID)
        {
            string query = "Select Count(ID) from DOCUMENT where JOB_ID = '" + jobID + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows[0][0].ToString();
        }
    }
}
