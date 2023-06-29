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
            double total = 0;
            var dataTable = BLL.CJobBLL.Instance.GetAllFromProject(strProjectId);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable.Rows)
                {
                    total += Convert.ToDouble(BLL.CProgressBLL.getTotalDocumentbyJobID(row1["JOB_ID"].ToString()));
                }
            }
            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var jobItem = new UCJobItem {
                        Id = row["JOB_ID"].ToString(),
                        Name = row["JOB_NAME"].ToString(),
                        PanelManager = pnlManager,
                        PanelJobOfEmployee = flPnlJobOfEmployee
                    };

                    jobItem.Percent = Math.Round(Convert.ToDouble(BLL.CProgressBLL.getTotalDocumentbyJobID(jobItem.Id)) / total, 2).ToString();

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
