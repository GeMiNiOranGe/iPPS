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

namespace MainProject {
    public partial class FormLogin : Form {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public FormLogin() {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e) {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            sqlConnection.Open();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e) {
            string strUserId = txtBox_userId.Text;
            string strPassword = txtBox_password.Text;
            string strError = "Tên tài khoản hoặc mật khẩu không đúng";
            string strQuery = $"SELECT * FROM PHANQUYEN INNER JOIN DANGNHAP ON PHANQUYEN.ID = DANGNHAP.ID WHERE DANGNHAP.USERID = '{strUserId}'AND DANGNHAP.PASSWORD = '{strPassword}'";
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = strQuery;

            if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(strPassword))
                lb_error.Text = strError;
            else {
                SqlDataReader dt = sqlCommand.ExecuteReader();
                if (dt.Read()) {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                    lb_error.Text = strError;
            }
            txtBox_userId.Clear();
            txtBox_password.Clear();
        }

    }
}
