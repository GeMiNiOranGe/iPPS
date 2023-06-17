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
    public partial class EmployeeTasks : Form
    {
        SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd = null;

        public EmployeeTasks()
        {
            InitializeComponent();
        }

        private void EmployeeTasks_Load(object sender, EventArgs e)
        {
            LoadEmployeeTasks();
        }

        public void LoadEmployeeTasks()
        {
            dgvTasks.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM JOB", conn);
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

        private string GetDate(object dateObj)
        {
            if (dateObj is DateTime)
            {
                DateTime date = (DateTime)dateObj;
                return date.ToString("MM/dd/yyyy");
            }
            return string.Empty;
        }

        private void txtSearchProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchProject.Text == "")
                LoadEmployeeTasks();
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
                LoadEmployeeTasks();
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
