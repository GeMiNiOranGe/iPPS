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

namespace MainProject
{
    public partial class AdminTasks : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
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
            cmd=new SqlCommand("SELECT * FROM WORK", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                string strFirstDay = GetDate(rd["FIRST_DAY"]);
                string strLastDay = GetDate(rd["LAST_DAY"]);

                dgvTasks.Rows.Add(rd["WORK_ID"].ToString(), rd["WORK_NAME"].ToString(),
                    strFirstDay, strLastDay, rd["PRIORITY"].ToString(), rd["STATE"].ToString(),
                    rd["OPEN_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
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
                adminTasksModule.txtTaskID.Text = dgvTasks.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminTasksModule.txtName.Text = dgvTasks.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminTasksModule.dtpStart.Text = dgvTasks.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminTasksModule.dtpEnd.Text = dgvTasks.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminTasksModule.cbbPriority.Text = dgvTasks.Rows[e.RowIndex].Cells[4].Value.ToString();
                adminTasksModule.cbbState.Text = dgvTasks.Rows[e.RowIndex].Cells[5].Value.ToString();
                adminTasksModule.cbbPublic.Text = dgvTasks.Rows[e.RowIndex].Cells[6].Value.ToString();
                adminTasksModule.txtProjectID.Text = dgvTasks.Rows[e.RowIndex].Cells[7].Value.ToString();

                adminTasksModule.btnSave.Enabled = false;
                adminTasksModule.btnUpdate.Enabled = true;
                adminTasksModule.btnClear.Enabled = false;
                adminTasksModule.ShowDialog();
            }
            else if (strColName == "Delete")
            {
                if (MessageBox.Show("Bạn có muốn xóa công việc này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string strIDTask = dgvTasks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmd = new SqlCommand($"DELETE FROM WORK WHERE WORK_ID='{strIDTask}'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            LoadAdminTasks();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "")
                LoadAdminTasks();
            else
            {
                dgvTasks.Rows.Clear();
                conn.Open();
                cmd = new SqlCommand($"SELECT * FROM WORK WHERE PROJECT_ID LIKE '{txtSearch.Text}'", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string strFirstDay = GetDate(rd["FIRST_DAY"]);
                    string strLastDay = GetDate(rd["LAST_DAY"]);

                    dgvTasks.Rows.Add(rd["WORK_ID"].ToString(), rd["WORK_NAME"].ToString(),
                        strFirstDay, strLastDay, rd["PRIORITY"].ToString(), rd["STATE"].ToString(),
                        rd["OPEN_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
                }
                rd.Close();
                conn.Close();
            }
        }
    }
}
