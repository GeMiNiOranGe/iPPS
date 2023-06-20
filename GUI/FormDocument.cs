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
            ClickdgvDocument();
        }
        public void dataDocument()
        {
            sqlCommand = new SqlCommand("select DOCUMENT.ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE,NATIVE_FILE_FORMAT from DOCUMENT,DOCUMENT_NATIVE_FILE_FORMAT where DOCUMENT.ID=DOCUMENT_NATIVE_FILE_FORMAT.ID", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
        }

        public void ClickdgvDocument()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select * from DOCUMENT", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            txtIDDoc.DataBindings.Clear();
            txtIDDoc.DataBindings.Add("Text", dgvDocument.DataSource, "ID");
            sqlConnection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from DOCUMENT where ID like N'%" + txtSearch.Text + "%' or JOB_ID like N'%"+txtSearch.Text+"%' or TITLE like N'%" + txtSearch.Text + "%'", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
            txtSearch.Clear();
            sqlConnection.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataDocument();
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
                sqlCommand.Parameters.AddWithValue("@ID", txtIDDoc.Text);
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
            using (sqlCommand = new SqlCommand("select LINK from  DOCUMENT_NATIVE_FILE_FORMAT where ID='" + txtIDDoc.Text + "'", sqlConnection))
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
            if ((string.IsNullOrEmpty(txtIDDoc.Text)) || (string.IsNullOrEmpty(cbNative.Text)))
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
            dataDocument();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtIDDoc.Text)) || (string.IsNullOrEmpty(cbNative.Text)))
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
            dataDocument();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formInsert = new FormInsert();
            formInsert.ShowDialog();
        }
    }
}
