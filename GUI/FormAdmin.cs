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
    public partial class FormAdmin : Form {
        public FormAdmin() {
            InitializeComponent();
        }

        private void BtnProject_Click(object sender, EventArgs e) {
            var adminProject = new AdminProjects();
            adminProject.ShowDialog();
        }

        private void BtnTask_Click(object sender, EventArgs e) {
            var adminTasks = new AdminTasks();
            adminTasks.ShowDialog();
        }
    }
}
