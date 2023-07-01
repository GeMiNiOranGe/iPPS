using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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

        private string strNameTitle;
        public FormInsert()
        {
            InitializeComponent();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            LoadData();
            loadCombobox();
            

            label24.Text = strNameTitle;
            if (label24.Text == "Thêm tài liệu")
            {
                IDDocument();
            }
            else
            {

            }
        }
        public FormInsert(string name)
        {
            InitializeComponent();
            this.strNameTitle = name;
        }
        public string ID { set; get; }
        public string JOB_ID { set; get; }
        public string PACKAGE { set; get; }
        public string WORK_ITEM { set; get; }
        public string TYPE { set; get; }
        public string PARTNER_CODE { set; get; }
        public string REVISION_NUMBER { set; get; }
        public string LASTEST_REVISION { set; get; }
        public string DATE { set; get; }
        public string ISSUE_PURPOSE { set; get; }
        public string PREPARED_BY { set; get; }
        public string CHECKED_BY { set; get; }
        public string APPROVED_BY { set; get; }
        public string ACTION { set; get; }
        public string SUPPORT { set; get; }
        public string REFERRENCE { set; get; }
        public string TO_COMPANY { set; get; }
        public string ISSUSED_ON { set; get; }
        public string ISSUSED_VIA { set; get; }
        public string TITLE { set; get; }
        public void LoadData()
        {
            txtIDDoc.Text = ID;
            txtIDJob.Text = JOB_ID;
            cbPackage.Text = PACKAGE;
            txtWork_Item.Text = WORK_ITEM;
            cbType.Text = TYPE;
            cbPartner_Code.Text = PARTNER_CODE;
            cbRevision_Number.Text = REVISION_NUMBER;
            cbLastest_Revision.Text = LASTEST_REVISION;
            dateDate.Text = DATE;
            cbIssue_Purpose.Text = ISSUE_PURPOSE;
            txtPrepared_By.Text = PREPARED_BY;
            txtChecked_By.Text = CHECKED_BY;
            txtApproved_By.Text = APPROVED_BY;
            cbAction.Text = ACTION;
            cbSupport.Text = SUPPORT;
            cbReference.Text = REFERRENCE;
            txtTo_Company.Text = TO_COMPANY;
            dateIssused_On.Text = ISSUSED_ON;
            txtIssused_Via.Text = ISSUSED_VIA;
            txtTitle.Text = TITLE;
        }
        public void loadCombobox()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PROJECT", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbNameProject.Items.Add(sqlDataReader["NAME"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PARTNER", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbPartner_Code.Items.Add(sqlDataReader["CODE"]);
            }
            sqlConnection.Close();
        }
        private void cbNameProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PROJECT WHERE NAME=@NAME", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NAME", cbNameProject.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtIDPro.Text = sqlDataReader["ID"].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select * from JOB where PROJECT_ID='" + txtIDPro.Text + "'", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbNameJob.DisplayMember = "NAME";
            cbNameJob.ValueMember = "ID";
            cbNameJob.DataSource = dataTable;
            txtIDJob.DataBindings.Clear();
            txtIDJob.DataBindings.Add("Text", cbNameJob.DataSource, "ID");
            sqlConnection.Close();
        }
        public void IDDocument()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT TOP 1 * FROM DOCUMENT ORDER BY ID DESC ", sqlConnection);
            string strID =Convert.ToString(sqlCommand.ExecuteScalar());
            strID = strID.Substring(3, 5);
            strID = strID.TrimStart('0');
            int iIDDoc = Convert.ToInt32(strID);
            sqlConnection.Close();
            iIDDoc++;
            if (iIDDoc < 10)
            {
                txtIDDoc.Text = iID0000 + iIDDoc.ToString();
            }
            else if(iIDDoc < 100)
            {
                txtIDDoc.Text = iID000 + iIDDoc.ToString();
            }
            else if (iIDDoc < 1000)
            {
                txtIDDoc.Text = iID00 + iIDDoc.ToString();
            }
            else if (iIDDoc < 10000)
            {
                txtIDDoc.Text = iID0 + iIDDoc.ToString();
            }
            else
            {
                txtIDDoc.Text = iID + iIDDoc.ToString();
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (label24.Text == "1")
            {
                if ((string.IsNullOrEmpty(cbNameProject.Text)) || (string.IsNullOrEmpty(cbPackage.Text)) || (string.IsNullOrEmpty(txtWork_Item.Text)) || (string.IsNullOrEmpty(cbType.Text)) || (string.IsNullOrEmpty(cbPartner_Code.Text)) || (string.IsNullOrEmpty(cbRevision_Number.Text)) || (string.IsNullOrEmpty(cbIssue_Purpose.Text)))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO DOCUMENT (ID, JOB_ID, PACKAGE, WORK_ITEM, TYPE, PARTNER_CODE, REVISION_NUMBER, LASTEST_REVISION, DATE, ISSUE_PURPOSE, PREPARED_BY, CHECKED_BY, APPROVED_BY, ACTION, SUPPORT, REFERRENCE, TO_COMPANY, ISSUSED_ON, ISSUSED_VIA, TITLE) VALUES ('" + txtIDDoc.Text + "', '" + txtIDJob.Text + "', '" + cbPackage.Text + "', '" + txtWork_Item.Text + "', '" + cbType.Text + "', '" + cbPartner_Code.Text + "', '" + cbRevision_Number.Text + "', '" + cbLastest_Revision.Text + "', '" + dateDate.Text + "', '" + cbIssue_Purpose.Text + "', '" + txtPrepared_By.Text + "', '" + txtChecked_By.Text + "', '" + txtApproved_By.Text + "', '" + cbAction.Text + "', '" + cbSupport.Text + "', '" + cbReference.Text + "', '" + txtTo_Company.Text + "', '" + dateIssused_On.Text + "', '" + txtIssused_Via.Text + "', N'" + txtTitle.Text + "')", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    if (!(string.IsNullOrEmpty(txtLink.Text))) {
                        SaveFile(txtLink.Text);
                    }
                    else
                    {
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand("INSERT INTO DOCUMENT_NATIVE_FILE_FORMAT VALUES ('" + txtIDDoc.Text + "', null, null, null)", sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }

                    MessageBox.Show("Thêm tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE DOCUMENT SET JOB_ID='" + txtIDJob.Text + "', PACKAGE='" + cbPackage.Text + "', WORK_ITEM='" + txtWork_Item.Text + "', TYPE='" + cbType.Text + "', PARTNER_CODE='" + cbPartner_Code.Text + "', REVISION_NUMBER='" + cbRevision_Number.Text + "', LASTEST_REVISION='" + cbLastest_Revision.Text + "', DATE='" + dateDate.Text + "', ISSUE_PURPOSE='" + cbIssue_Purpose.Text + "', PREPARED_BY='" + txtPrepared_By.Text + "', CHECKED_BY='" + txtChecked_By.Text + "', APPROVED_BY='" + txtApproved_By.Text + "', ACTION='" + cbAction.Text + "', SUPPORT='" + cbSupport.Text + "', REFERRENCE='" + cbReference.Text + "', TO_COMPANY='" + txtTo_Company.Text + "', ISSUSED_ON='" + dateIssused_On.Text + "', ISSUSED_VIA='" + txtIssused_Via.Text + "', TITLE=N'" + txtTitle.Text + "' where ID='" + txtIDDoc.Text + "'", sqlConnection);
                MessageBox.Show("Cập nhật tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (!(string.IsNullOrEmpty(txtLink.Text)))
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE DOCUMENT_NATIVE_FILE_FORMAT WHERE ID='" + txtIDDoc.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    SaveFile(txtLink.Text);
                }
            }
        }

        private void btnBroser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            txtLink.Text = openFileDialog.FileName;
        }
        public void SaveFile(string fileName)
        {
            sqlConnection.Open();
            using(Stream stream = File.OpenRead(fileName))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                string name = new FileInfo(fileName).Name;
                string extension = new FileInfo(fileName).Extension;
                using (sqlCommand = new SqlCommand("INSERT INTO DOCUMENT_NATIVE_FILE_FORMAT(ID, NAME, NATIVE_FILE_FORMAT, LINK) VALUES(@ID, @NAME, @NATIVE_FILE_FORMAT, @LINK)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@ID", txtIDDoc.Text);
                    sqlCommand.Parameters.AddWithValue("@NAME", SqlDbType.VarChar).Value = name;
                    sqlCommand.Parameters.AddWithValue("@NATIVE_FILE_FORMAT", SqlDbType.Char).Value = extension;
                    sqlCommand.Parameters.AddWithValue("@LINK", SqlDbType.VarBinary).Value = buffer;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
        }
    }
}
