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

        string iID0000 = "DOC0000";
        string iID000 = "DOC000";
        string iID00 = "DOC00";
        string iID0 = "DOC0";
        string iID = "DOC";
        public FormInsert()
        {
            InitializeComponent();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            loadCombobox();
            CountID();
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
            lbIDPro.DataBindings.Clear();
            lbIDPro.DataBindings.Add("Text", cbNameProject.DataSource, "ID");

            sqlDataAdapter = new SqlDataAdapter("select * from JOB where PROJECT_ID='" + lbIDPro.Text+"'", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbNameJob.DisplayMember = "NAME";
            cbNameJob.ValueMember = "ID";
            cbNameJob.DataSource = dataTable;
            lbIDJob.DataBindings.Clear();
            lbIDJob.DataBindings.Add("Text", cbNameJob.DataSource, "ID");

            sqlDataAdapter = new SqlDataAdapter("select * from PARTNER", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbPartner_Code.DisplayMember = "CODE";
            cbPartner_Code.ValueMember = "ID";
            cbPartner_Code.DataSource = dataTable;
            sqlConnection.Close();
        }

        public void CountID()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select count(ID) from DOCUMENT", sqlConnection);
            int iCount=Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            iCount++;
            if(iCount < 10)
            {
                lbIDDoc.Text = iID0000 + iCount.ToString();
            }
            else if(iCount < 100)
            {
                lbIDDoc.Text = iID000 + iCount.ToString();
            }
            else if (iCount < 1000)
            {
                lbIDDoc.Text = iID00 + iCount.ToString();
            }
            else if (iCount < 10000)
            {
                lbIDDoc.Text = iID0 + iCount.ToString();
            }
            else
            {
                lbIDDoc.Text = iID + iCount.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if((string.IsNullOrEmpty(cbNameProject.Text)) || (string.IsNullOrEmpty(cbPackage.Text)) || (string.IsNullOrEmpty(txtWork_Item.Text)) || (string.IsNullOrEmpty(cbType.Text)) || (string.IsNullOrEmpty(cbPartner_Code.Text)) || (string.IsNullOrEmpty(cbRevision_Number.Text)) || (string.IsNullOrEmpty(cbIssue_Purpose.Text)))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                sqlCommand = new SqlCommand("insert into DOCUMENT (ID, JOB_ID, PACKAGE, WORK_ITEM, TYPE, PARTNER_CODE, REVISION_NUMBER, LASTEST_REVISION, DATE, ISSUE_PURPOSE, PREPARED_BY, CHECKED_BY, APPROVED_BY, ACTION, SUPPORT, REFERRENCE, TO_COMPANY, ISSUSED_ON, ISSUSED_VIA, TITLE) values ('" + lbIDDoc.Text + "', '" + lbIDJob.Text + "', '" + cbPackage.Text + "', '" + txtWork_Item.Text + "', '" + cbType.Text + "', '" + cbPartner_Code.Text + "', '" + cbRevision_Number.Text + "', '" + cbLastest_Revision.Text + "', '" + dateDate.Text + "', '" + cbIssue_Purpose.Text + "', '" + txtPrepared_By.Text + "', '" + txtChecked_By.Text + "', '" + txtApproved_By.Text + "', '" + cbAction.Text + "', '" + cbSupport.Text + "', '" + cbReference.Text + "', '" + txtTo_Company.Text + "', '" + dateIssused_On.Text + "', '" + txtIssused_Via.Text + "', N'" + txtTitle.Text + "')", sqlConnection);
                MessageBox.Show("Thêm tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

    }
}
