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
        //lấy số lượng tài liệu cần của mỗi công việc
        public string getNumberofDocumentbyJobID(string jobID)
        {
            string query = "Select NUMBER_OF_DOCUMENTS from JOB where ID = '" + jobID + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows[0][0].ToString();
        }
        //Đếm số lượng tài liệu đã thêm vào của mỗi công việc
        public string getTotalDocumentbyJobID(string jobID)
        {
            string query = "Select Count(ID) from DOCUMENT where JOB_ID = '" + jobID + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows[0][0].ToString();
        }
    }
}
