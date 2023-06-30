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
    public partial class FormJobDetail : Form {
        public string strEmployeeId;

        #region Properties
        public string ProjectId {
            get => lblIdProject.Text;
            set => lblIdProject.Text = value;
        }

        public string ProjectName {
            get => lblNameProject.Text;
            set => lblNameProject.Text = value;
        }
        #endregion

        public FormJobDetail() {
            InitializeComponent();
        }

        private void FormWorkOfProject_Load(object sender, EventArgs e) {
            ShowJobsFromProject(ProjectId);
        }

        private void ShowJobsFromProject(string strProjectId) {
            flPnlListJob.Controls.Clear();
            var dataTable = BLL.CJobBLL.Instance.GetAllFromProject(strProjectId);

            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var jobItem = new UCJobItem {
                        Id = row["JOB_ID"].ToString(),
                        Name = row["JOB_NAME"].ToString(),
                        PanelManager = pnlManager,
                        PanelJobOfEmployee = flPnlJobOfEmployee
                    };

                    if (row["JOB_STATUS"].ToString() == "0")
                        jobItem.Percent = "80%";
                    else if (row["JOB_STATUS"].ToString() == "1")
                        jobItem.Percent = "50%";
                    else
                        jobItem.Percent = "0%";

                    jobItem.Size = new Size() {
                        Width = flPnlListJob.Size.Width,
                        Height = jobItem.Size.Height
                    };
                    flPnlListJob.Controls.Add(jobItem);
                }
            }
        }
    }
}
