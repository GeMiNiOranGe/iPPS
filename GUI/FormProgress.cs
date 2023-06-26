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
    public partial class FormProgress : Form {
        public FormProgress() {
            InitializeComponent();
        }

        private void ShowAllProject() {
            flPnlAllProject.Controls.Clear();
            DataTable dt = BLL.CProjectBLL.Instance.GetProjectList();

            if (dt != null && dt.Rows.Count > 0) {
                foreach (DataRow row in dt.Rows) {
                    var projectItem = new UCProjectItem {
                        Id = row["PROJECT_ID"].ToString(),
                        Name = row["PROJECT_NAME"].ToString(),
                        DepartmentName = row["DEPARTMENT_NAME"].ToString()
                    };

                    if (row["PROJECT_STATUS"].ToString() == "2")
                        projectItem.Percent = "0%";
                    else if (row["PROJECT_STATUS"].ToString() == "1")
                        projectItem.Percent = "50%";
                    else
                        projectItem.Percent = "100%";

                    flPnlAllProject.Controls.Add(projectItem);
                }
            }
        }

        private void FormProgress_Load(object sender, EventArgs e) {
            ShowAllProject();
        }
    }
}
