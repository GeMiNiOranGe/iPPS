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
        private readonly SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        private Form currentFormChild;
        private string strUserId;

        public string UserId {
            get => strUserId;
            set => strUserId = value;
        }

        public FormMenu() {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm) {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlWorkplace.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public string GetFullname() {
            string strFullname;
            string query = $"select FIRST_NAME, MIDDLE_NAME, LAST_NAME from EMPLOYEE where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            strFullname = sqlDataReader["FIRST_NAME"] + ", " + sqlDataReader["LAST_NAME"];
            conn.Close();
            return strFullname;
        }

        public string GetRole() {
            string strRole;
            string query = $"select NAME from ROLE where EMPLOYEE_ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            strRole = sqlDataReader["NAME"].ToString();
            conn.Close();
            return strRole;
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            LbUsername.Text = GetFullname();
            LbRole.Text = GetRole();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult dialogResulth = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResulth == DialogResult.Yes)
                Application.Exit();
        }

        #region button job
        private void BtnJob_MouseClick(object sender, MouseEventArgs e) {
            string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
                if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1)
                    OpenChildForm(new AdminTasks());
                else
                    OpenChildForm(new EmployeeTasks());
            conn.Close();
        }

        private void BtnJob_MouseDown(object sender, MouseEventArgs e) {
            BtnJob.Image = Properties.Resources.PasteClipboardFill;
            BtnJob.ForeColor = Color.FromArgb(29, 29, 29);
        }

        private void BtnJob_MouseUp(object sender, MouseEventArgs e) {
            BtnJob.Image = Properties.Resources.PasteClipboard;
            BtnJob.ForeColor = Color.White;
        }
        #endregion

        #region button project
        private void BtnProject_MouseClick(object sender, MouseEventArgs e) {
            string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                    OpenChildForm(new AdminProjects());
                }
                else {
                    OpenChildForm(new EmployeeProjects());
                }
            }
            conn.Close();
        }

        private void BtnProject_MouseDown(object sender, MouseEventArgs e) {
            BtnProject.Image = Properties.Resources.FolderFill;
            BtnProject.ForeColor = Color.FromArgb(29, 29, 29);
        }

        private void BtnProject_MouseUp(object sender, MouseEventArgs e) {
            BtnProject.Image = Properties.Resources.Folder;
            BtnProject.ForeColor = Color.White;
        }
        #endregion

        #region button document
        private void BtnDocument_MouseClick(object sender, MouseEventArgs e) {
            OpenChildForm(new FormDocument());
        }

        private void BtnDocument_MouseDown(object sender, MouseEventArgs e) {
            BtnDocument.Image = Properties.Resources.MultiplePagesFill;
            BtnDocument.ForeColor = Color.FromArgb(29, 29, 29);
        }

        private void BtnDocument_MouseUp(object sender, MouseEventArgs e) {
            BtnDocument.Image = Properties.Resources.MultiplePages;
            BtnDocument.ForeColor = Color.White;
        }
        #endregion

        #region button progress
        private void BtnProgress_MouseClick(object sender, MouseEventArgs e) {
            OpenChildForm(new FormProgress());
        }

        private void BtnProgress_MouseDown(object sender, MouseEventArgs e) {
            BtnProgress.Image = Properties.Resources.DoughnutChartFill;
            BtnProgress.ForeColor = Color.FromArgb(29, 29, 29);
        }

        private void BtnProgress_MouseUp(object sender, MouseEventArgs e) {
            BtnProgress.Image = Properties.Resources.DoughnutChart;
            BtnProgress.ForeColor = Color.White;
        }
        #endregion

        #region account info
        private void Account_MouseClick(object sender, MouseEventArgs e) {
            OpenChildForm(new frmInfo(strUserId));
        }

        private void Account_MouseDown(object sender, MouseEventArgs e) {
            PnlAccount.BackColor = Color.FromArgb(34, 130, 253);
            LbUsername.ForeColor = Color.Black;
        }

        private void Account_MouseUp(object sender, MouseEventArgs e) {
            PnlAccount.BackColor = Color.Transparent;
            LbUsername.ForeColor = Color.White;
        }

        private void Account_MouseEnter(object sender, EventArgs e) {
            PnlAccount.BackColor = Color.FromArgb(34, 130, 253);
        }

        private void Account_MouseLeave(object sender, EventArgs e) {
            PnlAccount.BackColor = Color.Transparent;
        }
        #endregion

        private void LbAppName_Click(object sender, EventArgs e) {
            if (currentFormChild != null)
                currentFormChild.Close();
        }
    }
}
