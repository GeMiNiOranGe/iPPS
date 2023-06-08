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

namespace GUI {
    public partial class FormLogin : Form {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private DTO.CAccount account = new DTO.CAccount();

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
            //string strUserId = TxtUserId.Text;
            //string strPassword = TxtPassword.Text;
            //string strQuery = $"SELECT * FROM DECENTRALIZATION INNER JOIN LOGIN ON DECENTRALIZATION.DECENTRALIZATION_ID = LOGIN.USERID WHERE LOGIN.USERID = '{strUserId}' AND LOGIN.PASSWORD = '{strPassword}'";

            //sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = strQuery;

            //if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(strPassword) || TxtUserId.Text == USER_ID_PLACEHOLDER || TxtPassword.Text == PASSWORD_PLACEHOLDER)
            //    LbError.Text = "Không được để trống thông tin đăng nhập";
            //else {
            //    SqlDataReader dt = sqlCommand.ExecuteReader();
            //    if (dt.Read()) {
            //        FormMain formMain = new FormMain();
            //        formMain.Show();
            //    }
            //    else
            //        LbError.Text = "Tên tài khoản hoặc mật khẩu không đúng";
            //    dt.Close();
            //}
            //if (TxtUserId.Text != USER_ID_PLACEHOLDER || TxtPassword.Text != PASSWORD_PLACEHOLDER) {
            //    TxtUserId.Clear();
            //    TxtPassword.Clear();
            //}

            // Lấy dữ liệu từ các textbox
            account.EmployeeId = TxtUserId.Text;
            account.Password = TxtPassword.Text;
            // Gọi phương thức xử lý đăng nhập và lấy kết quả
            BLL.LoginStatus status = BLL.CAccountBLL.Instance.GetLoginStatus(account);
            // Kiểm tra kết quả
            switch (status) {
            case BLL.LoginStatus.Success:
                // Hiển thị thông báo thành công và chuyển sang form khác
                MessageBox.Show("Đăng nhập thành công!");
                var formMain = new FormMain();
                formMain.Show();
                //this.Hide();
                break;
            case BLL.LoginStatus.InvalidInput:
                // Hiển thị thông báo lỗi do dữ liệu đầu vào không hợp lệ
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!");
                TxtUserId.Clear();
                TxtPassword.Clear();
                TxtUserId.Focus();
                break;
            case BLL.LoginStatus.InvalidAccount:
                // Hiển thị thông báo lỗi do tài khoản không tồn tại hoặc sai thông tin
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
                TxtUserId.Clear();
                TxtPassword.Clear();
                TxtUserId.Focus();
                break;
            case BLL.LoginStatus.LockedAccount:
                // Hiển thị thông báo lỗi do tài khoản bị khóa
                MessageBox.Show("Tài khoản của bạn đã bị khóa!");
                TxtUserId.Clear();
                TxtPassword.Clear();
                TxtUserId.Focus();
                break;
            case BLL.LoginStatus.OtherError:
                // Hiển thị thông báo lỗi do các nguyên nhân khác
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập!");
                TxtUserId.Clear();
                TxtPassword.Clear();
                TxtUserId.Focus();
                break;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e) {
            if (TxtPassword.Text == PASSWORD_PLACEHOLDER) {
                TextBox textBox = sender as TextBox;
                TxtPassword.UseSystemPasswordChar = true;
                textBox.ForeColor = Color.FromArgb(248, 245, 168);
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e) {
            if (TxtPassword.Text == PASSWORD_PLACEHOLDER)
                TxtPassword.UseSystemPasswordChar = false;
        }

        private void TxtUserId_Click(object sender, EventArgs e) {
            PictureUserID.BackgroundImage = Properties.Resources.UserYellow;
            panel1.BackColor = Color.FromArgb(248, 245, 168);
            if (TxtPassword.UseSystemPasswordChar == true) {
                PicturePassWord.BackgroundImage = Properties.Resources.CloseLockWhite;
                panel2.BackColor = Color.White;
            }
            else {
                PicturePassWord.BackgroundImage = Properties.Resources.OpenLockWhite;
                panel2.BackColor = Color.White;
            }
        }

        private void TxtPassword_Click(object sender, EventArgs e) {
            PictureUserID.BackgroundImage = Properties.Resources.UserWhite;
            panel1.BackColor = Color.White;

            if (TxtPassword.UseSystemPasswordChar == true) {
                PicturePassWord.BackgroundImage = Properties.Resources.CloseLockYellow;
                panel2.BackColor = Color.FromArgb(248, 245, 168);
            }
            else {
                PicturePassWord.BackgroundImage = Properties.Resources.OpenLockYellow;
                panel2.BackColor = Color.FromArgb(248, 245, 168);
            }
        }

        private void PicturePassWord_Click(object sender, EventArgs e) {
            if (TxtPassword.UseSystemPasswordChar == true && panel2.BackColor == Color.FromArgb(248, 245, 168)) {
                TxtPassword.UseSystemPasswordChar = false;
                PicturePassWord.BackgroundImage = Properties.Resources.OpenLockYellow;
            }
            else if (TxtPassword.UseSystemPasswordChar == false && panel2.BackColor == Color.FromArgb(248, 245, 168)) {
                TxtPassword.UseSystemPasswordChar = true;
                PicturePassWord.BackgroundImage = Properties.Resources.CloseLockYellow;
            }
            else if (TxtPassword.UseSystemPasswordChar == true && panel2.BackColor == Color.White) {
                TxtPassword.UseSystemPasswordChar = false;
                PicturePassWord.BackgroundImage = Properties.Resources.OpenLockWhite;
            }
            else {
                TxtPassword.UseSystemPasswordChar = true;
                PicturePassWord.BackgroundImage = Properties.Resources.CloseLockWhite;
            }
        }

        private void Label1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
