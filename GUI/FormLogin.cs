using System;
using System.Drawing;
using System.Windows.Forms;
using HandleControl;

namespace GUI {
    public partial class FormLogin : Form {
        private readonly DTO.CAccount account = new DTO.CAccount();

        public FormLogin() {
            InitializeComponent();
            ForTextbox.SetPlaceHolder(this.TxtUserId, BLL.CAccountBLL.USER_ID_PLACEHOLDER);
            ForTextbox.SetPlaceHolder(this.TxtPassword, BLL.CAccountBLL.PASSWORD_PLACEHOLDER);
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            // Get data from textboxes
            account.EmployeeId = TxtUserId.Text;
            account.Password = TxtPassword.Text;

            // Call the login handler method and get the result
            BLL.LoginStatus status = BLL.CAccountBLL.Instance.GetLoginStatus(account);
            string userID = TxtUserId.Text;
            // Check the result
            switch (status) {
            case BLL.LoginStatus.Success:
                LbError.Text = "Đăng nhập thành công!";
                var formMenu = new FormMenu {
                    UserId = TxtUserId.Text
                };
                formMenu.Show();
                Hide();
                break;
            case BLL.LoginStatus.InvalidInput:
                // Displays an error message due to invalid input data
                LbError.Text = "ID người dùng và mật khẩu không được để trống!";
                break;
            case BLL.LoginStatus.InvalidAccount:
                // Displays an error message because the account does not exist or has incorrect information
                LbError.Text = "ID người dùng hoặc mật khẩu sai!";
                break;
            case BLL.LoginStatus.LockedAccount:
                // Shows an error message because the account is locked
                LbError.Text = "Tài khoản của bạn đã bị khóa!";
                break;
            case BLL.LoginStatus.OtherError:
                // Display error messages due to other causes
                LbError.Text = "Đã xảy ra lỗi trong quá trình đăng nhập!";
                break;
            }
            TxtUserId.Text = BLL.CAccountBLL.USER_ID_PLACEHOLDER;
            TxtPassword.Text = BLL.CAccountBLL.PASSWORD_PLACEHOLDER;
            TxtUserId.ForeColor = Color.Gray;
            TxtPassword.ForeColor = Color.Gray;
            TxtPassword.UseSystemPasswordChar = false;
            TxtUserId.Focus();
        }

        private void TxtPassword_Enter(object sender, EventArgs e) {
            if (TxtPassword.Text == BLL.CAccountBLL.PASSWORD_PLACEHOLDER) {
                TextBox textBox = sender as TextBox;
                TxtPassword.UseSystemPasswordChar = true;
                textBox.ForeColor = Color.FromArgb(248, 245, 168);
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e) {
            if (TxtPassword.Text == BLL.CAccountBLL.PASSWORD_PLACEHOLDER)
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

        private void PcbClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
