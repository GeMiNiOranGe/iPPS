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

        private const string USER_ID_PLACEHOLDER = "ID người dùng";
        private const string PASSWORD_PLACEHOLDER = "Mật khẩu";

        public FormLogin() {
            InitializeComponent();

            ForTextbox.SetPlaceHolder(this.TxtUserId, USER_ID_PLACEHOLDER);
            ForTextbox.SetPlaceHolder(this.TxtPassword, PASSWORD_PLACEHOLDER);
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void FormLogin_Load(object sender, EventArgs e) {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            sqlConnection.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            string strUserId = TxtUserId.Text;
            string strPassword = TxtPassword.Text;
            string strQuery = $"SELECT * FROM PHANQUYEN INNER JOIN DANGNHAP ON PHANQUYEN.ID = DANGNHAP.ID WHERE DANGNHAP.USERID = '{strUserId}'AND DANGNHAP.PASSWORD = '{strPassword}'";

            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = strQuery;

            if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(strPassword) ||
                TxtUserId.Text == USER_ID_PLACEHOLDER || TxtPassword.Text == PASSWORD_PLACEHOLDER)
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
            if (TxtUserId.Text != USER_ID_PLACEHOLDER || TxtPassword.Text != PASSWORD_PLACEHOLDER) {
                TxtUserId.Clear();
                TxtPassword.Clear();
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e) {
            if (TxtPassword.Text == PASSWORD_PLACEHOLDER)
                TxtPassword.UseSystemPasswordChar = true;
        }

        private void TxtPassword_Leave(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(TxtPassword.Text) || TxtPassword.Text == PASSWORD_PLACEHOLDER)
                TxtPassword.UseSystemPasswordChar = false;
        }
    }
}
