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
    public partial class UCProject : UserControl {
        public UCProject() {
            InitializeComponent();
        }

        //Chỗ này phục vụ cho việc đọc dữ liệu để add vào label của ProjectControlChoos
        private string strId;
        private string strName;
        private string strDepartmentName;
        private string strPercent;

        [Category("Custom Props")]
        public string Id {
            get => strId;
            set {
                strId = value;
                lbId.Text = value;
            }
        }
        [Category("Custom Props")]
        public string Tenduan {
            get => strName;
            set {
                strName = value;
                lbName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string DepartmentName {
            get => strDepartmentName;
            set {
                strDepartmentName = value;
                lbDepartmentName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Percent {
            get => strPercent;
            set {
                strPercent = value;
                lbPercent.Text = value;
            }
        }

        public static string idProject;
        public static string NameProject;

        bool isHover = false;
        private void UCProject_MouseEnter(object sender, EventArgs e) {
            if (isHover == true) return;

            BackColor = Color.FromArgb(224, 229, 222);
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void UCProject_MouseLeave(object sender, EventArgs e) {
            if (isHover == false) return;

            BackColor = Color.White;
            isHover = false;
        }

        private void UCProject_Click(object sender, EventArgs e) {
            idProject = lbId.Text;
            NameProject = lbName.Text;
            var form = new FormWorkOfProject();
            form.Show();
        }
    }
}
