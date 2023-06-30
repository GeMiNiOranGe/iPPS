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
    public partial class UCProjectItem : UserControl {
        bool isHover = false;

        #region Properties
        [Category("Custom Props")]
        public string Id {
            get => lbId.Text;
            set => lbId.Text = value;
        }

        [Category("Custom Props")]
        public new string Name {
            get => lbName.Text;
            set => lbName.Text = value;
        }

        [Category("Custom Props")]
        public string DepartmentName {
            get => lbDepartmentName.Text;
            set => lbDepartmentName.Text = value;
        }

        [Category("Custom Props")]
        public string Percent {
            get => lbPercent.Text;
            set => lbPercent.Text = value;
        }
        #endregion

        public UCProjectItem() {
            InitializeComponent();
        }

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
            var formJobDetail = new FormJobDetail {
                ProjectId = Id,
                ProjectName = Name
            };
            formJobDetail.ShowDialog();
        }
    }
}
