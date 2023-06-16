using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FormMenu : Form {
        private readonly SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
        private string strUserId;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string UserId {
            get => strUserId;
            set => strUserId = value;
        }

        public FormMenu() {
            InitializeComponent();
        }

        private Form currentFormChild;

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

        private void PnlHead_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region button minimize, maximize, close
        private void PcbMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void PcbMaximize_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                PcbMaximize.Image = Properties.Resources.NormalScreenCircleFill;
            }
            else {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                PcbMaximize.Image = Properties.Resources.FullScreenCircleFill;
            }
        }

        private void PcbClose_Click(object sender, EventArgs e) {
            DialogResult dialogResulth = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResulth == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #region button job
        private void BtnJob_MouseClick(object sender, MouseEventArgs e) {
            string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                    OpenChildForm(new AdminTasks());
                }
                else {
                    OpenChildForm(new EmployeeTasks());
                }
            }
            conn.Close();
        }

        private void BtnJob_MouseDown(object sender, MouseEventArgs e) {
            BtnJob.Image = Properties.Resources.PasteClipboardFill;
            BtnJob.ForeColor = Color.Black;
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
            BtnProject.ForeColor = Color.Black;
        }

        private void BtnProject_MouseUp(object sender, MouseEventArgs e) {
            BtnProject.Image = Properties.Resources.Folder;
            BtnProject.ForeColor = Color.White;
        }
        #endregion

        #region button document
        private void BtnDocument_MouseClick(object sender, MouseEventArgs e) {
            OpenChildForm(new FormUpload());
        }

        private void BtnDocument_MouseDown(object sender, MouseEventArgs e) {
            BtnDocument.Image = Properties.Resources.MultiplePagesFill;
            BtnDocument.ForeColor = Color.Black;
        }

        private void BtnDocument_MouseUp(object sender, MouseEventArgs e) {
            BtnDocument.Image = Properties.Resources.MultiplePages;
            BtnDocument.ForeColor = Color.White;
        }
        #endregion

        #region button progress
        private void BtnProgress_MouseClick(object sender, MouseEventArgs e) {

        }

        private void BtnProgress_MouseDown(object sender, MouseEventArgs e) {
            BtnProgress.Image = Properties.Resources.DoughnutChartFill;
            BtnProgress.ForeColor = Color.Black;
        }

        private void BtnProgress_MouseUp(object sender, MouseEventArgs e) {
            BtnProgress.Image = Properties.Resources.DoughnutChart;
            BtnProgress.ForeColor = Color.White;
        }
        #endregion
    }
}
