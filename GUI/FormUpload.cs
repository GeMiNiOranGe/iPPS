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
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class FormUpload : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public FormUpload()
        {
            InitializeComponent();
        }

        private void FormUpload_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Config.Database.CONNECTION_STRING);
            //sqlConnection.Open();
            loadJob_ID();
            loadPartner_Code();
            this.dgvDocument.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvFile.DefaultCellStyle.ForeColor = Color.Black;
            dataDocument();
            dataFile();
            loadID();
        }

        // Document
        public void loadJob_ID()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(@"select ID from JOB", sqlConnection);
            sqlDataReader=sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbJob_ID.Items.Add(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();
        }
        public void loadPartner_Code()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select CODE from PARTNER", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbPartner_Code.Items.Add(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();
        }

        public void Delete()
        {
            txtDocument_ID.Clear();
            cbJob_ID.Text = "";
            cbPackage.Text = "";
            txtWork_Item.Clear();
            cbType.Text = "";
            cbPartner_Code.Text = "";
            cbRevision_Number.Text = "";
            cbLastest_Revision.Text = "";
            txtIssue_Purpose.Clear();
            txtPrepared_By.Clear();
            txtChecked_By.Clear();
            txtApproved_By.Clear();
            cbAction.Text = "";
            cbSupport.Text = "";
            cbReference.Text = "";
            txtTo_Company.Clear();
            txtIssused_Via.Clear();
            txtTitle.Clear();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("insert into DOCUMENT (ID, JOB_ID, PACKAGE, WORK_ITEM, TYPE, PARTNER_CODE, REVISION_NUMBER, LASTEST_REVISION, DATE, ISSUE_PURPOSE, PREPARED_BY, CHECKED_BY, APPROVED_BY, ACTION, SUPPORT, REFERRENCE, TO_COMPANY, ISSUSED_ON, ISSUSED_VIA, TITLE) values ('" + txtDocument_ID.Text + "', '" + cbJob_ID.Text + "', '" + cbPackage.Text + "', '" + txtWork_Item.Text + "', '" + cbType.Text + "', '" + cbPartner_Code.Text + "', '" + cbRevision_Number.Text + "', '" + cbLastest_Revision.Text + "', '" + dateDate.Text + "', '" + txtIssue_Purpose.Text + "', '" + txtPrepared_By.Text + "', '" + txtChecked_By.Text + "', '" + txtApproved_By.Text + "', '" + cbAction.Text + "', '" + cbSupport.Text + "', '" + cbReference.Text + "', '" + txtTo_Company.Text + "', '" + dateIssused_On.Text + "', '" + txtIssused_Via.Text + "', N'" + txtTitle.Text + "')", sqlConnection);
            MessageBox.Show("Thêm tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlCommand.ExecuteNonQuery();
            Delete();
            dataDocument();
            sqlConnection.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("update DOCUMENT set JOB_ID='" + cbJob_ID.Text + "', PACKAGE='" + cbPackage.Text + "', WORK_ITEM='" + txtWork_Item.Text + "', TYPE='" + cbType.Text + "', PARTNER_CODE='" + cbPartner_Code.Text + "', REVISION_NUMBER='" + cbRevision_Number.Text + "', LASTEST_REVISION='" + cbLastest_Revision.Text + "', DATE='" + dateDate.Text + "', ISSUE_PURPOSE='" + txtIssue_Purpose.Text + "', PREPARED_BY='" + txtPrepared_By.Text + "', CHECKED_BY='" + txtChecked_By.Text + "', APPROVED_BY='" + txtApproved_By.Text + "', ACTION='" + cbAction.Text + "', SUPPORT='" + cbSupport.Text + "', REFERRENCE='" + cbReference.Text + "', TO_COMPANY='" + txtTo_Company.Text + "', ISSUSED_ON='" + dateIssused_On.Text + "', ISSUSED_VIA='" + txtIssused_Via.Text + "', TITLE=N'" + txtTitle.Text + "' where ID='" + txtDocument_ID.Text + "", sqlConnection);
            MessageBox.Show("Cập nhật tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlCommand.ExecuteNonQuery();
            Delete();
            dataDocument();
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (txtDocument_ID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlCommand = new SqlCommand("delete DOCUMENT where ID='" + txtDocument_ID.Text + "'", sqlConnection);
                    MessageBox.Show("Xóa tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCommand.ExecuteNonQuery();
                    Delete();
                    dataDocument();
                }
            }
            else
            {
                MessageBox.Show("Vui chọn tài liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        // Table Document
        public void dataDocument()
        {
            sqlCommand = new SqlCommand("select * from DOCUMENT", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
        }

        private void dgvDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = dgvDocument.Rows[e.RowIndex];
            txtDocument_ID.Text = Convert.ToString(dataGridViewRow.Cells["ID"].Value);
            cbJob_ID.Text = Convert.ToString(dataGridViewRow.Cells["JOB_ID"].Value);
            cbPackage.Text = Convert.ToString(dataGridViewRow.Cells["PACKAGE"].Value);
            txtWork_Item.Text = Convert.ToString(dataGridViewRow.Cells["WORK_ITEM"].Value);
            cbType.Text = Convert.ToString(dataGridViewRow.Cells["TYPE"].Value);
            cbPartner_Code.Text = Convert.ToString(dataGridViewRow.Cells["PARTNER_CODE"].Value);
            cbRevision_Number.Text = Convert.ToString(dataGridViewRow.Cells["REVISION_NUMBER"].Value);
            cbLastest_Revision.Text = Convert.ToString(dataGridViewRow.Cells["LASTEST_REVISION"].Value);
            dateDate.Text = Convert.ToString(dataGridViewRow.Cells["DATE"].Value);
            txtIssue_Purpose.Text = Convert.ToString(dataGridViewRow.Cells["ISSUE_PURPOSE"].Value);
            txtPrepared_By.Text = Convert.ToString(dataGridViewRow.Cells["PREPARED_BY"].Value);
            txtChecked_By.Text = Convert.ToString(dataGridViewRow.Cells["CHECKED_BY"].Value);
            txtApproved_By.Text = Convert.ToString(dataGridViewRow.Cells["APPROVED_BY"].Value);
            cbAction.Text = Convert.ToString(dataGridViewRow.Cells["ACTION"].Value);
            cbSupport.Text = Convert.ToString(dataGridViewRow.Cells["SUPPORT"].Value);
            cbReference.Text = Convert.ToString(dataGridViewRow.Cells["REFERRENCE"].Value);
            txtTo_Company.Text = Convert.ToString(dataGridViewRow.Cells["TO_COMPANY"].Value);
            dateIssused_On.Text = Convert.ToString(dataGridViewRow.Cells["ISSUSED_ON"].Value);
            txtIssused_Via.Text = Convert.ToString(dataGridViewRow.Cells["ISSUSED_VIA"].Value);
            txtTitle.Text = Convert.ToString(dataGridViewRow.Cells["TITLE"].Value);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            dataDocument();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from DOCUMENT where ID like N'%" + txtSearch.Text + "%' or TITLE like '%" + txtSearch.Text + "%'", sqlConnection) ;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
            txtSearch.Clear();
            sqlConnection.Close();
        }

        // Upload/Download
        public void loadID()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select ID from DOCUMENT where DOCUMENT.ID not in (select ID from DOCUMENT_NATIVE_FILE_FORMAT)", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbID.Items.Add(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();
        }
        public void Upload(string strFile)
        {
            sqlConnection.Open();
            FileStream fileStream = File.OpenRead(strFile);
            byte[] link = new byte[fileStream.Length];
            fileStream.Read(link, 0, (int)link.Length);
            fileStream.Close();
            using (sqlCommand = new SqlCommand("insert into DOCUMENT_NATIVE_FILE_FORMAT(ID, NATIVE_FILE_FORMAT, LINK) values(@ID,@NATIVE_FILE_FORMAT, @LINK)", sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@ID", cbID.Text);
                sqlCommand.Parameters.AddWithValue("@NATIVE_FILE_FORMAT", cbNative.Text);
                sqlCommand.Parameters.AddWithValue("@LINK", link);
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        public void Download(string strFile)
        {
            sqlConnection.Open();
            bool bFlag = false;
            using (sqlCommand = new SqlCommand("select LINK from  DOCUMENT_NATIVE_FILE_FORMAT where ID='" + cbID.Text + "'", sqlConnection))
            {
                using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.Default))
                {
                    if (sqlDataReader.Read())
                    {
                        bFlag = true;
                        byte[] link = (byte[])sqlDataReader.GetValue(0);
                        using (FileStream fileStream = new FileStream(strFile, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                            {
                                binaryWriter.Write(link);
                                binaryWriter.Close();
                            }
                        }
                    }
                    if (bFlag == false)
                    {
                        MessageBox.Show("Không có Data", "Thông báo", MessageBoxButtons.OK);
                    }
                    sqlDataReader.Close();
                }
            }
            sqlConnection.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(cbID.Text)) || (string.IsNullOrEmpty(cbNative.Text)))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbNative.Text == "PDF")
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (*.pdf) | *.pdf", ValidateNames = true })
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Upload?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = openFileDialog.FileName;
                                Upload(strFile);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. Word")
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (*.docx) | *.docx", ValidateNames = true })
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Upload?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = openFileDialog.FileName;
                                Upload(strFile);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. PPT")
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (*.pptx) | *.pptx", ValidateNames = true })
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Upload?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = openFileDialog.FileName;
                                Upload(strFile);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. Excel")
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (*.xlsx) | *.xlsx", ValidateNames = true })
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Upload?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = openFileDialog.FileName;
                                Upload(strFile);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            dataFile();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(cbID.Text)) || (string.IsNullOrEmpty(cbNative.Text)))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbNative.Text == "PDF")
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (.pdf) | *.pdf", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = saveFileDialog.FileName;
                                Download(strFile);
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. Word")
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (.docx) | *.docx", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad???", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = saveFileDialog.FileName;
                                Download(strFile);
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. PPT")
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (.pptx) | *.pptx", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad???", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = saveFileDialog.FileName;
                                Download(strFile);
                            }
                        }
                    }
                }
                else if (cbNative.Text == "Ms. Excel")
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT (.xlsx) | *.xlsx", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad???", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string strFile = saveFileDialog.FileName;
                                Download(strFile);
                            }
                        }
                    }
                }
            }
            dataFile();
        }
        public void dataFile()
        {
            sqlCommand = new SqlCommand("select ID, NATIVE_FILE_FORMAT from DOCUMENT_NATIVE_FILE_FORMAT", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvFile.DataSource = dataTable;
        }

        private void dgvFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = dgvFile.Rows[e.RowIndex];
            cbID.Text = Convert.ToString(dataGridViewRow.Cells["ID"].Value);
            cbNative.Text = Convert.ToString(dataGridViewRow.Cells["NATIVE_FILE_FORMAT"].Value);
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (cbID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlCommand = new SqlCommand("delete DOCUMENT_NATIVE_FILE_FORMAT where ID='" + cbID.Text + "'", sqlConnection);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCommand.ExecuteNonQuery();
                    dataFile();
                }
            }
            else
            {
                MessageBox.Show("Vui chọn dữ liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbID.Text = "";
            cbNative.Text = "";
            sqlConnection.Close();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select ID, NATIVE_FILE_FORMAT from DOCUMENT_NATIVE_FILE_FORMAT where ID like N'%" + txtSearch2.Text + "%' or NATIVE_FILE_FORMAT like '%" + txtSearch2.Text + "%'", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvFile.DataSource = dataTable;
            txtSearch2.Clear();
            sqlConnection.Close();
        }

        private void btnReload2_Click(object sender, EventArgs e)
        {
            dataFile();
        }
    }
}
