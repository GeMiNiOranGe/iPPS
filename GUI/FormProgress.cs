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
            flPnlAllProject.Controls.Clear();
            var dataTable = BLL.CProjectBLL.Instance.GetProjectList();
            double totalDocument = Convert.ToDouble(BLL.CProgressBLL.getTotalDocument());
            string projectID;
            double total = 0;
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
                    {
                        foreach (DataRow row1 in dataTable1.Rows)
                        {
                            total += Convert.ToDouble(BLL.CProgressBLL.getTotalDocumentbyJobID(row1["JOB_ID"].ToString()));
                        }
                    }
                    projectItem.Percent = Math.Round((total / totalDocument) * 100, 2).ToString();
                    flPnlAllProject.Controls.Add(projectItem);
                    total = 0;
                }
            }
        }
    }
}
