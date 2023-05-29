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
    public partial class AdminProjectsModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PROJECT_MANAGEMENT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public AdminProjectsModule()
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
            if(txtID.Text=="" || txtName.Text == "" 
                || txtCustomer.Text == "" || cbbState.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if(MessageBox.Show("Bạn có muốn lưu thông tin này ?", "Đang lưu",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO PROJECT VALUES(@id,@name,@cus,@start,@end,@state)", conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cus", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text);
                    cmd.Parameters.AddWithValue("@state", cbbState.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    resetTextBox();
                    MessageBox.Show("Lưu thông tin thành công!");
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
            if (txtID.Text == "" || txtName.Text == ""
                || txtCustomer.Text == "" || cbbState.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật thông tin này ?", "Đang lưu",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE PROJECT SET PROJECT_ID=@id, PROJECT_NAME=@name, CUSTOMER=@cus, FIRST_DAY=@start, LAST_DAY=@end, STATE=@state WHERE PROJECT_ID={txtID.Text}", conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cus", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text);
                    cmd.Parameters.AddWithValue("@state", cbbState.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    resetTextBox();
                    MessageBox.Show("Cập nhật thông tin thành công!");
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
            resetTextBox();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void resetTextBox()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtCustomer.ResetText();
            dtpStart.ResetText();
            dtpEnd.ResetText();
            cbbState.ResetText();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
