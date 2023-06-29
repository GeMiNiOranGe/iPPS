using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HandleControl {
    static class ForTextbox {
        public static void SetPlaceHolder(TextBox textBox, string PlaceHolderText) {
            textBox.Text = PlaceHolderText;
            textBox.GotFocus += delegate (object sender, EventArgs args) {
                if (textBox.Text == PlaceHolderText) {
                    textBox.Text = "";
                    textBox.ForeColor = Color.FromArgb(248, 245, 168);
                }
            };
            textBox.LostFocus += delegate (object sender, EventArgs args) {
                if (textBox.Text.Length == 0) {
                    textBox.Text = PlaceHolderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        #region button minimize, maximize, close
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();

        //private void PnlHead_MouseDown(object sender, MouseEventArgs e) {
        //    if (e.Button == MouseButtons.Left) {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        //private void PcbMinimize_Click(object sender, EventArgs e) {
        //    WindowState = FormWindowState.Minimized;
        //}

        //private void PcbMaximize_Click(object sender, EventArgs e) {
        //    if (WindowState == FormWindowState.Normal) {
        //        FormBorderStyle = FormBorderStyle.Sizable;
        //        WindowState = FormWindowState.Maximized;
        //        FormBorderStyle = FormBorderStyle.None;
        //        PcbMaximize.Image = Properties.Resources.NormalScreenCircleFill;
        //    }
        //    else {
        //        FormBorderStyle = FormBorderStyle.Sizable;
        //        WindowState = FormWindowState.Normal;
        //        FormBorderStyle = FormBorderStyle.None;
        //        PcbMaximize.Image = Properties.Resources.FullScreenCircleFill;
        //    }
        //}

        //private void PcbClose_Click(object sender, EventArgs e) {
        //    DialogResult dialogResulth = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dialogResulth == DialogResult.Yes)
        //        Application.Exit();
        //}
        #endregion
    }
}