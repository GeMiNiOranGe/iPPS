using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FormMenu : Form {
        string employeeID;
        public FormMenu(string userID) {
            InitializeComponent();
            employeeID = userID;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResulth = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResulth == DialogResult.Yes)
                Application.Exit();
        }

        public void OpenUploadFile() {
            var formUpload = new FormUpload();
            formUpload.ShowDialog();
        }
        private void LbReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void PcbReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void PnlReport_Click(object sender, EventArgs e) {
            OpenUploadFile();
        }

        private void PnlAccountInfo_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo(employeeID);
            f.ShowDialog();
        }
    }
}
