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

namespace GUI {
    public partial class FormMenu : Form {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=PROJECT_MANAGEMENT_TEMP;Integrated Security=True");
        private SqlCommand sqlCommand;
        public FormMenu() {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e) {
            DialogResult dialogResulth = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResulth == DialogResult.Yes)
                Application.Exit();
        }

        public string GetFullname() {
            string strUserId = FormLogin.strTempUserId;
            string strFullname;
            string query = $"select FIRST_NAME, MIDDLE_NAME, LAST_NAME from EMPLOYEE where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                strFullname = sqlDataReader["FIRST_NAME"] + ", " + sqlDataReader["LAST_NAME"];
            }
            else {
                strFullname = sqlDataReader["FIRST_NAME"] + ", " + sqlDataReader["LAST_NAME"];
            }
            conn.Close();
            return strFullname;
        }
        void FindRole() {
            string strUserId = FormLogin.strTempUserId;
            string strPassword = FormLogin.strTempPassword;
            string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                if ((byte)sqlDataReader["PERMISSION_LEVER"] <= 1) {
                    var admin = new Admin();
                    admin.ShowDialog();
                }
                else {
                    var employee = new Employee();
                    employee.ShowDialog();
                }
            }
            conn.Close();
        }
        public void OpenUploadFile() {
            var formUpload = new FormUpload();
            formUpload.ShowDialog();
        }
        private void LbReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void PcbReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void PnlReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void LbManage_Click(object sender, EventArgs e) {
            FindRole();
        }

        private void PnlManage_Click(object sender, EventArgs e) {
            FindRole();
        }

        private void PcbManage_Click(object sender, EventArgs e) {
            FindRole();
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            LbUsername.Text = GetFullname();
        }
    }
}
