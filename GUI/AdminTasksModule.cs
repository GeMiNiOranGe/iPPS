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

namespace GUI
{
    public partial class AdminTasksModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();

        public AdminTasksModule()
        {
            InitializeComponent();
        }

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrjID.Text == "" || txtJobID.Text == "" 
                || txtMngID.Text == "" || txtAccessR.Text == "" 
                || txtDepPub.Text == "" || txtPrjPub.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO JOB VALUES (@idJob,@idMng,@name,@access,@status,@prjPub,@depPub,@idPrj)", conn);
                    cmd.Parameters.AddWithValue("@idJob", txtJobID.Text);
                    cmd.Parameters.AddWithValue("@idMng", txtMngID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@access", txtAccessR.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@prjPub", txtPrjPub.Text);
                    cmd.Parameters.AddWithValue("@depPub", txtDepPub.Text);
                    cmd.Parameters.AddWithValue("@idPrj", txtPrjID.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Lưu công việc thành công!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPrjID.Text == "" || txtJobID.Text == ""
                || txtMngID.Text == "" || txtAccessR.Text == ""
                || txtDepPub.Text == "" || txtPrjPub.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE JOB SET ID=@idJob, JOB_MANAGER_ID=@idMng, NAME=@name, ACCESS_RIGHT=@access, STATUS=@status, PROJECT_PUBLIC=@prjPub, DEPARTMENT_PUBLIC=@depPub, PROJECT_ID=@idPrj WHERE ID='{txtJobID.Text}'", conn);
                    cmd.Parameters.AddWithValue("@idJob", txtJobID.Text);
                    cmd.Parameters.AddWithValue("@idMng", txtMngID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@access", txtAccessR.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@prjPub", txtPrjPub.Text);
                    cmd.Parameters.AddWithValue("@depPub", txtDepPub.Text);
                    cmd.Parameters.AddWithValue("@idPrj", txtPrjID.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Sửa công việc thành công!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void ResetTextBox()
        {
            txtName.ResetText();
            txtJobID.ResetText();
            txtMngID.ResetText();
            txtAccessR.ResetText();
            txtStatus.ResetText();
            txtPrjPub.ResetText();
            txtDepPub.ResetText();
            txtPrjID.ResetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
