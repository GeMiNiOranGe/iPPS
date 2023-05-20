using Config;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.ARS         
{
    #region Đọc dữ liệu
    class AddReadSql
    {
        public DataTable ReadItemsTable()
        {
            SqlConnection connection = new SqlConnection(Database.CONNECTION_STRING);
            connection.Open();
            string query = "SELECT TENDA, TENBP FROM QLDA, DUAN, BOPHAN WHERE QLDA.MADA = DUAN.MADA AND QLDA.MABP = BOPHAN.MABP";
            //Câu lệnh trên là để in ra tất cả các dự án đang có trong dữ liệu
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
    #endregion
}
