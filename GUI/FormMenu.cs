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
        private readonly SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=PROJECT_MANAGEMENT_TEMP;Integrated Security=True");
        private string strUserId;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public string UserId {
            get => strUserId;
            set => strUserId = value;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            string strFullname;
            string query = $"select FIRST_NAME, MIDDLE_NAME, LAST_NAME from EMPLOYEE where EMPLOYEE.ID = N'{strUserId ?? "emp00001"}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            strFullname = sqlDataReader["FIRST_NAME"] + ", " + sqlDataReader["LAST_NAME"];
            conn.Close();
            return strFullname;
        }
        void FindRole() {
            string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{strUserId}'";
            conn.Open();
            var sqlCommand = new SqlCommand(query, conn);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                if ((byte)sqlDataReader["PERMISSION_LEVER"] <= 1) {
                    var admin = new FormAdmin();
                    admin.ShowDialog();
                }
                else {
                    var employee = new FormEmployee();
                    employee.ShowDialog();
                }
            }
            conn.Close();
        }

        private void Document_Click(object sender, EventArgs e) {
            var formUpload = new FormUpload();
            formUpload.ShowDialog();
        }
        private void Document_MouseHover(object sender, EventArgs e) {
            PnlDocument.BackColor = Color.FromArgb(72, 73, 70);
        }

        private void Document_MouseLeave(object sender, EventArgs e) {
            PnlDocument.BackColor = Color.FromArgb(61, 63, 60);
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

        private void PnlHead_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
