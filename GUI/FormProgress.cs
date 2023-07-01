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

        private void FormProgress_Load(object sender, EventArgs e) {
            ShowAllProject();
        }

        private void ShowAllProject() {
            if (flPnlProjectList.Controls.Count > 0) flPnlProjectList.Controls.Clear();

            var dataTable = BLL.CProjectBLL.Instance.GetProjectList();
            string projectID;
            double total;
            double total1;
            double totalJob = 0;
            double count = 0;
            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var projectItem = new UCProjectItem {
                        Id = row["PROJECT_ID"].ToString(),
                        Name = row["PROJECT_NAME"].ToString(),
                        DepartmentName = row["DEPARTMENT_NAME"].ToString()
                    };
                    projectID = projectItem.Id;
                    var dataTable1 = BLL.CJobBLL.Instance.GetAllFromProject(projectID);
                    if (dataTable1 != null && dataTable1.Rows.Count > 0)
                        foreach (DataRow row1 in dataTable1.Rows)
                            totalJob += 1;

                    if (dataTable1 != null && dataTable1.Rows.Count > 0)
                        foreach (DataRow row1 in dataTable1.Rows) {
                            total = Convert.ToDouble(BLL.CProgressBLL.getTotalDocumentbyJobID(row1["JOB_ID"].ToString()));
                            total1 = Convert.ToDouble(BLL.CProgressBLL.getNumberofDocumentbyJobID(row1["JOB_ID"].ToString()));
                            if (total == total1) count += 1;
                        }

                    projectItem.Percent = Math.Round((count / totalJob) * 100, 2).ToString() + "%";
                    flPnlProjectList.Controls.Add(projectItem);
                    totalJob = 0;
                    count = 0;
                }
            }
        }
    }
}
