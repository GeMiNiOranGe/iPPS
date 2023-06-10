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
    public partial class Employee : Form {
        public Employee() {
            InitializeComponent();
        }

        private void BtnTask_Click(object sender, EventArgs e) {
                var employeeTasks = new EmployeeTasks();
                employeeTasks.ShowDialog();
        }

        private void BtnProject_Click(object sender, EventArgs e) {
                var employeeProject = new EmployeeProjects();
                employeeProject.ShowDialog();
        }
    }
}
