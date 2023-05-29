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
    public partial class AdminProjects : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
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
            cmd=new SqlCommand("select * from PROJECT", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                dgvProjects.Rows.Add(rd["PROJECT_ID"].ToString(), rd["PROJECT_NAME"].ToString(), 
                    rd["CUSTOMER"].ToString(), rd["FIRST_DAY"].ToString(), 
                    rd["LAST_DAY"].ToString(), rd["STATE"].ToString());
            }
            rd.Close();
            conn.Close();
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
                adminProjectsModule.txtID.Text = dgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString();
                adminProjectsModule.txtName.Text = dgvProjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                adminProjectsModule.txtCustomer.Text = dgvProjects.Rows[e.RowIndex].Cells[2].Value.ToString();
                adminProjectsModule.dtpStart.Text = dgvProjects.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminProjectsModule.dtpEnd.Text = dgvProjects.Rows[e.RowIndex].Cells[4].Value.ToString();
                adminProjectsModule.cbbState.Text = dgvProjects.Rows[e.RowIndex].Cells[5].Value.ToString();

                adminProjectsModule.btnSave.Enabled = false;
                adminProjectsModule.btnUpdate.Enabled = true;
                adminProjectsModule.ShowDialog();
            }
            else if(strColName == "Delete")
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string strIDProject = dgvProjects.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmd = new SqlCommand($"DELETE FROM PROJECT WHERE PROJECT_ID='{strIDProject}'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            LoadAdminProjects();
        }
    }
}
