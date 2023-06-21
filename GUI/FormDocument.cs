using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDocument : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public FormDocument()
        {
            InitializeComponent();
        }

        private void FormDocument_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            this.dgvDocument.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvDocument.DefaultCellStyle.ForeColor = Color.Black;
            dataDocument();
        }
        public void dataDocument()
        {
            sqlCommand = new SqlCommand("select DOCUMENT.ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE from DOCUMENT", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formInsert = new FormInsert();
            formInsert.ShowDialog();
;        }
    }
}

