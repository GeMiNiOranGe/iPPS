using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProject.ARS;


namespace MainProject.HS
{
    class HandleSql
    {
        #region Lấy dữ liệu

        public DataTable GetItems()
        {
            try
            {
                AddReadSql objdal = new AddReadSql();
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
