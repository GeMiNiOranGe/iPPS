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
    public partial class AdminProjects : Form
    {
        SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader rd = null;

        public AdminProjects()
        {
            InitializeComponent();
        }

        private void AdminProjects_Load(object sender, EventArgs e)
        {
            LoadAdminProjects();
        }

        public void LoadAdminProjects()
        {
            dgvProjects.Rows.Clear();
            conn.Open();
            cmd=new SqlCommand("SELECT P.ID, P.NAME, P.ACCESS_RIGHT, P.STATUS, P.CUSTOMER_NAME, P.PROJECT_MANAGER_ID, IP.DEPARTMENT_ID, IP.PROJECT_START_DATE, IP.PROJECT_END_DATE FROM PROJECT AS P INNER JOIN IMPLEMENT_PROJECT AS IP ON P.ID = IP.PROJECT_ID", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                string strFirstDay = GetDate(rd["PROJECT_START_DATE"]);
                string strLastDay = GetDate(rd["PROJECT_END_DATE"]);

                dgvProjects.Rows.Add(rd["ID"].ToString(), rd["NAME"].ToString(),
                    rd["ACCESS_RIGHT"].ToString(), rd["STATUS"].ToString(),
                    rd["CUSTOMER_NAME"].ToString(), rd["PROJECT_MANAGER_ID"].ToString(),
                    rd["DEPARTMENT_ID"].ToString(), strFirstDay, strLastDay);
            }
            rd.Close();
            conn.Close();
        }

        private string GetDate(object dateObj)
        {
            if (dateObj is DateTime)
            {
                DateTime date = (DateTime)dateObj;
                return date.ToString("MM/dd/yyyy");
            }
            return string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminProjectsModule adminProjectsModule = new AdminProjectsModule();
            adminProjectsModule.btnUpdate.Enabled = false;
            adminProjectsModule.btnSave.Enabled = true;
            adminProjectsModule.ShowDialog();
            LoadAdminProjects();
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strColName = dgvProjects.Columns[e.ColumnIndex].Name;
            if(strColName == "Edit")
            {
                AdminProjectsModule adminProjectsModule = new AdminProjectsModule();
                adminProjectsModule.txtIDPrj.Text = dgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminProjectsModule.txtName.Text = dgvProjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminProjectsModule.txtAccess.Text = dgvProjects.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminProjectsModule.txtStatus.Text = dgvProjects.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminProjectsModule.txtCustomer.Text = dgvProjects.Rows[e.RowIndex].Cells[4].Value.ToString();
                adminProjectsModule.txtIDManager.Text = dgvProjects.Rows[e.RowIndex].Cells[5].Value.ToString();
                adminProjectsModule.txtIDDep.Text = dgvProjects.Rows[e.RowIndex].Cells[6].Value.ToString();
                adminProjectsModule.dtpStart.Text = dgvProjects.Rows[e.RowIndex].Cells[7].Value.ToString();
                adminProjectsModule.dtpEnd.Text = dgvProjects.Rows[e.RowIndex].Cells[8].Value.ToString();

                adminProjectsModule.btnSave.Enabled = false;
                adminProjectsModule.btnUpdate.Enabled = true;
                adminProjectsModule.btnClear.Enabled = false;
                adminProjectsModule.txtIDPrj.Enabled = false;
                adminProjectsModule.txtIDManager.Enabled = false;
                adminProjectsModule.txtIDDep.Enabled = false;
                adminProjectsModule.ShowDialog();
            }
            else if(strColName == "Delete")
            {
                if(MessageBox.Show("Bạn có muốn xóa dự án này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string strIDProject = dgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmd2 = new SqlCommand($"DELETE FROM IMPLEMENT_PROJECT WHERE PROJECT_ID='{strIDProject}'", conn);
                    cmd2.ExecuteNonQuery();

                    cmd = new SqlCommand($"DELETE FROM EMPLOYEE_BELONG_TO_PROJECT WHERE PROJECT_ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE JOIN_JOB FROM JOIN_JOB JOIN JOB ON JOIN_JOB.JOB_ID = JOB.ID WHERE JOB.PROJECT_ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE DOCUMENT_NATIVE_FILE_FORMAT FROM DOCUMENT JOIN DOCUMENT_NATIVE_FILE_FORMAT ON DOCUMENT.ID = DOCUMENT_NATIVE_FILE_FORMAT.ID", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE DOCUMENT FROM DOCUMENT JOIN JOB ON DOCUMENT.JOB_ID = JOB.ID WHERE JOB.PROJECT_ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE FROM JOB WHERE PROJECT_ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    //$"DELETE FROM IMPLEMENT_PROJECT WHERE PROJECT_ID = '{strIDProject}'--6" +
                    cmd = new SqlCommand($"DELETE FROM JOIN_PROJECT WHERE PROJECT_ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE FROM PROJECT WHERE ID = '{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            LoadAdminProjects();
        }
    }
}
