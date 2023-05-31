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

namespace MainProject
{
    public partial class EmployeeTasks : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
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
            cmd = new SqlCommand("SELECT * FROM WORK", conn);
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

        private string GetDate(object dateObj)
        {
            if (dateObj is DateTime)
            {
                DateTime date = (DateTime)dateObj;
                return date.ToString("MM/dd/yyyy");
            }
            return string.Empty;
        }
    }
}
