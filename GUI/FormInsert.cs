using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInsert : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public FormInsert()
        {
            InitializeComponent();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            loadCombobox();
        }
        public void loadCombobox()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select * from PROJECT", sqlConnection);
            dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbNameProject.DisplayMember= "NAME";
            cbNameProject.ValueMember= "ID";
            cbNameProject.DataSource= dataTable;
            txtDocument_ID.DataBindings.Clear();
            txtDocument_ID.DataBindings.Add("Text", cbNameProject.DataSource, "ID");

            sqlDataAdapter = new SqlDataAdapter("select * from JOB where PROJECT_ID='" + txtDocument_ID.Text+"'", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbNameJob.DisplayMember = "NAME";
            cbNameJob.ValueMember = "ID";
            cbNameJob.DataSource = dataTable;
            txtJobID.DataBindings.Clear();
            txtJobID.DataBindings.Add("Text", cbNameJob.DataSource, "ID");

            sqlDataAdapter = new SqlDataAdapter("select * from PARTNER", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbPartner_Code.DisplayMember = "CODE";
            cbPartner_Code.ValueMember = "ID";
            cbPartner_Code.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("insert into DOCUMENT (ID, JOB_ID, PACKAGE, WORK_ITEM, TYPE, PARTNER_CODE, REVISION_NUMBER, LASTEST_REVISION, DATE, ISSUE_PURPOSE, PREPARED_BY, CHECKED_BY, APPROVED_BY, ACTION, SUPPORT, REFERRENCE, TO_COMPANY, ISSUSED_ON, ISSUSED_VIA, TITLE) values ('" + txtDocument_ID.Text + "', '" + txtJobID.Text + "', '" + cbPackage.Text + "', '" + txtWork_Item.Text + "', '" + cbType.Text + "', '" + cbPartner_Code.Text + "', '" + cbRevision_Number.Text + "', '" + cbLastest_Revision.Text + "', '" + dateDate.Text + "', '" + txtIssue_Purpose.Text + "', '" + txtPrepared_By.Text + "', '" + txtChecked_By.Text + "', '" + txtApproved_By.Text + "', '" + cbAction.Text + "', '" + cbSupport.Text + "', '" + cbReference.Text + "', '" + txtTo_Company.Text + "', '" + dateIssused_On.Text + "', '" + txtIssused_Via.Text + "', N'" + txtTitle.Text + "')", sqlConnection);
            MessageBox.Show("Thêm tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnInsertExit_Click(object sender, EventArgs e)
        {

        }
    }
}
