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

namespace MainProject
{
    public partial class AdminTasksModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
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
            if (txtProjectID.Text == "" || txtTaskID.Text == "" 
                || txtName.Text == "" || cbbPriority.Text == "" 
                || cbbState.Text == "" || cbbPublic.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO WORK VALUES(@idTask,@name,@start,@end,@priority,@state,@public,@idProject)", conn);
                    cmd.Parameters.AddWithValue("@idTask", txtTaskID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text);
                    cmd.Parameters.AddWithValue("@priority", cbbPriority.Text);
                    cmd.Parameters.AddWithValue("@state", cbbState.Text);
                    cmd.Parameters.AddWithValue("@public", cbbPublic.Text);
                    cmd.Parameters.AddWithValue("@idProject", txtProjectID.Text);
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
            if (txtProjectID.Text == "" || txtTaskID.Text == ""
                || txtName.Text == "" || cbbPriority.Text == ""
                || cbbState.Text == "" || cbbPublic.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE WORK SET WORK_ID=@idTask, WORK_NAME=@name, FIRST_DAY=@start, LAST_DAY=@end, PRIORITY=@priority, STATE=@state, OPEN_PUBLIC=@public, PROJECT_ID=@idProject WHERE WORK_ID={txtTaskID.Text}", conn);
                    cmd.Parameters.AddWithValue("@idTask", txtTaskID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text);
                    cmd.Parameters.AddWithValue("@priority", cbbPriority.Text);
                    cmd.Parameters.AddWithValue("@state", cbbState.Text);
                    cmd.Parameters.AddWithValue("@public", cbbPublic.Text);
                    cmd.Parameters.AddWithValue("@idProject", txtProjectID.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Cập nhật công việc thành công!");
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
            txtProjectID.ResetText();
            txtTaskID.ResetText();
            txtName.ResetText();
            dtpStart.ResetText();
            dtpEnd.ResetText();
            cbbPriority.ResetText();
            cbbState.ResetText();
            cbbPublic.ResetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
