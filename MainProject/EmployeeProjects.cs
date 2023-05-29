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
    public partial class EmployeeProjects : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd = null;
        public EmployeeProjects()
        {
            InitializeComponent();
        }

        private void EmployeeProjects_Load(object sender, EventArgs e)
        {
            LoadEmployeeProjects();
        }

        public void LoadEmployeeProjects()
        {
            dgvProjects.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("select * from PROJECT", conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dgvProjects.Rows.Add(rd["PROJECT_ID"].ToString(), rd["PROJECT_NAME"].ToString(),
                    rd["CUSTOMER"].ToString(), rd["FIRST_DAY"].ToString(),
                    rd["LAST_DAY"].ToString(), rd["STATE"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }
}
