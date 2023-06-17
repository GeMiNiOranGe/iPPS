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
    public partial class AdminProjectsModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
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
            if(txtIDPrj.Text=="" || txtName.Text == "" 
                || txtAccess.Text == "" || txtStatus.Text == ""
                || txtCustomer.Text == "" || txtIDManager.Text == ""
                || txtIDDep.Text == "" || dtpStart.Text == "" || dtpEnd.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                if(MessageBox.Show("Bạn có muốn lưu dự án này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO PROJECT VALUES(@idPrj,@name,@access,@status,@cus,@idMng)", conn);
                    cmd.Parameters.AddWithValue("@idPrj", txtIDPrj.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@access", txtAccess.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@cus", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@idMng", txtIDManager.Text);

                    cmd2 = new SqlCommand("INSERT INTO IMPLEMENT_PROJECT VALUES(@idDep,@idPrj2,@start,@end)", conn);
                    cmd2.Parameters.AddWithValue("@idDep", txtIDDep.Text);
                    cmd2.Parameters.AddWithValue("@idPrj2", txtIDPrj.Text);
                    cmd2.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd2.Parameters.AddWithValue("@end", dtpEnd.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Lưu dự án thành công!");
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
            if (txtIDPrj.Text == "" || txtName.Text == ""
                || txtAccess.Text == "" || txtStatus.Text == ""
                || txtCustomer.Text == "" || txtIDManager.Text == ""
                || txtIDDep.Text == "" || dtpStart.Text == "" || dtpEnd.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật dự án này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    string updateProjectQuery = @"
                        UPDATE PROJECT
                        SET NAME = @name,
                            ACCESS_RIGHT = @access,
                            STATUS = @status,
                            CUSTOMER_NAME = @cus,
                            PROJECT_MANAGER_ID = @idMng
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                    cmd = new SqlCommand(updateProjectQuery, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@access", txtAccess.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@cus", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@idMng", txtIDManager.Text);
                    cmd.Parameters.AddWithValue("@idPrj", txtIDPrj.Text);
                    cmd.ExecuteNonQuery();

                    string updateImplementProjectQuery = @"
                        UPDATE IMPLEMENT_PROJECT
                        SET DEPARTMENT_ID = @idDep,
                            PROJECT_START_DATE = @start,
                            PROJECT_END_DATE = @end
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                    cmd = new SqlCommand(updateImplementProjectQuery, conn);
                    cmd.Parameters.AddWithValue("@idDep", txtIDDep.Text);
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text);
                    cmd.Parameters.AddWithValue("@idPrj", txtIDPrj.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Sửa dự án thành công!");
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

        public void ResetTextBox()
        {
            txtIDPrj.ResetText();
            txtName.ResetText();
            txtAccess.ResetText();
            txtStatus.ResetText();
            txtCustomer.ResetText();
            txtIDManager.ResetText();
            txtIDDep.ResetText();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
