using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminTasks : Form
    {
        SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd = null;

        public AdminTasks()
        {
            InitializeComponent();
        }

        private void AdminTasks_Load(object sender, EventArgs e)
        {
            LoadAdminTasks();
        }

        public void LoadAdminTasks()
        {
            dgvTasks.Rows.Clear();
            conn.Open();
            cmd=new SqlCommand("SELECT * FROM JOB", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                dgvTasks.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                    rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(), 
                    rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                    rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
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
            AdminTasksModule adminTasksModule = new AdminTasksModule();
            adminTasksModule.btnSave.Enabled = true;
            adminTasksModule.btnUpdate.Enabled = false;
            adminTasksModule.ShowDialog();
            LoadAdminTasks();
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strColName = dgvTasks.Columns[e.ColumnIndex].Name;
            if (strColName == "Edit")
            {
                AdminTasksModule adminTasksModule = new AdminTasksModule();
                adminTasksModule.txtJobID.Text = dgvTasks.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminTasksModule.txtMngID.Text = dgvTasks.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminTasksModule.txtName.Text = dgvTasks.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminTasksModule.txtAccessR.Text = dgvTasks.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminTasksModule.txtStatus.Text = dgvTasks.Rows[e.RowIndex].Cells[4].Value.ToString();
                adminTasksModule.txtPrjPub.Text = dgvTasks.Rows[e.RowIndex].Cells[5].Value.ToString();
                adminTasksModule.txtDepPub.Text = dgvTasks.Rows[e.RowIndex].Cells[6].Value.ToString();
                adminTasksModule.txtPrjID.Text = dgvTasks.Rows[e.RowIndex].Cells[7].Value.ToString();

                adminTasksModule.btnSave.Enabled = false;
                adminTasksModule.btnUpdate.Enabled = true;
                adminTasksModule.btnClear.Enabled = false;
                adminTasksModule.txtPrjID.Enabled = false;
                adminTasksModule.txtJobID.Enabled = false;
                adminTasksModule.txtMngID.Enabled = false;
                adminTasksModule.ShowDialog();
            }
            else if (strColName == "Delete")
            {
                if (MessageBox.Show("Bạn có muốn xóa công việc này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string strIDTask = dgvTasks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmd = new SqlCommand($"DELETE FROM JOIN_JOB WHERE JOB_ID = '{strIDTask}' --1", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE DOCUMENT_NATIVE_FILE_FORMAT " +
                        $"FROM DOCUMENT_NATIVE_FILE_FORMAT JOIN DOCUMENT ON DOCUMENT_NATIVE_FILE_FORMAT.ID = DOCUMENT.ID WHERE DOCUMENT.JOB_ID = '{strIDTask}'--2", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE FROM DOCUMENT WHERE JOB_ID = '{strIDTask}' --3", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand($"DELETE FROM JOB WHERE ID='{strIDTask}' --4", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            LoadAdminTasks();
        }

        private void txtSearchProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchProject.Text == "")
                LoadAdminTasks();
            else
            {
                dgvTasks.Rows.Clear();
                conn.Open();
                cmd = new SqlCommand($"SELECT * FROM JOB WHERE PROJECT_ID LIKE '%{txtSearchProject.Text}%'", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dgvTasks.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                        rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(),
                        rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                        rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
                }
                rd.Close();
                conn.Close();
            }
        }

        private void txtSearchTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchTask.Text == "")
                LoadAdminTasks();
            else
            {
                dgvTasks.Rows.Clear();
                conn.Open();
                cmd = new SqlCommand($"SELECT * FROM JOB WHERE ID LIKE '%{txtSearchTask.Text}%'", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dgvTasks.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                        rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(),
                        rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                        rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
                }
                rd.Close();
                conn.Close();
            }
        }
    }
}
