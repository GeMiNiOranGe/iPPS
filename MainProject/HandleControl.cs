using System;
using System.Drawing;
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
    }
}