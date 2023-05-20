using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Config;
using HandleControl;

namespace MainProject {
    public partial class FormLogin : Form {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        string userId_ph = "User ID";
        string password_ph = "Password";

        public FormLogin() {
            InitializeComponent();

            ForTextbox.SetPlaceHolder(this.txtBox_userId, userId_ph);
            ForTextbox.SetPlaceHolder(this.txtBox_password, password_ph);
            txtBox_password.UseSystemPasswordChar = false;
        }

        private void FormLogin_Load(object sender, EventArgs e) {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            sqlConnection.Open();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e) {
            string strUserId = txtBox_userId.Text;
            string strPassword = txtBox_password.Text;
            string strQuery = $"SELECT * FROM PHANQUYEN INNER JOIN DANGNHAP ON PHANQUYEN.ID = DANGNHAP.ID WHERE DANGNHAP.USERID = '{strUserId}'AND DANGNHAP.PASSWORD = '{strPassword}'";

            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = strQuery;

            if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(strPassword))
                lb_error.Text = "Không được để trống thông tin đăng nhập";
            else {
                SqlDataReader dt = sqlCommand.ExecuteReader();
                if (dt.Read()) {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                    lb_error.Text = "Tên tài khoản hoặc mật khẩu không đúng";
                dt.Close();
            }
            txtBox_userId.Clear();
            txtBox_password.Clear();
        }

        private void txtBox_password_Enter(object sender, EventArgs e) {
            if (txtBox_password.Text == password_ph)
                txtBox_password.UseSystemPasswordChar = true;
        }

        private void txtBox_password_Leave(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(txtBox_password.Text))
                txtBox_password.UseSystemPasswordChar = false;
        }
    }
}
