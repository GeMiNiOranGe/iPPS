using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GUI {
    public partial class UCJobItem : UserControl {
        #region Properties
        bool isHover = false;
        private Panel pnlManager;
        private Panel pnlJobOfEmployee;

        public Panel PanelManager {
            get => pnlManager;
            set => pnlManager = value;
        }

        public Panel PanelJobOfEmployee {
            get => pnlJobOfEmployee;
            set => pnlJobOfEmployee = value;
        }

        [Category("Custom Props")]
        public string Id {
            get => lbJobId.Text;
            set => lbJobId.Text = value;
        }

        [Category("Custom Props")]
        public new string Name {
            get => lbJobName.Text;
            set => lbJobName.Text = value;
        }

        [Category("Custom Props")]
        public string Percent {
            get => lbJobPercent.Text;
            set => lbJobPercent.Text = value;
        }
        #endregion

        public UCJobItem() {
            InitializeComponent();
        }

        public void RetrieveInfomation(string strJobId, ref Panel pnlManager, ref Panel pnlJobOfEmployee) {
            if (pnlManager.Controls.Count > 0) pnlManager.Controls.Clear();
            if (pnlJobOfEmployee.Controls.Count > 0) pnlJobOfEmployee.Controls.Clear();

            string managerTempId = null;

            var dtManager = BLL.CJobBLL.Instance.GetManager(strJobId);

            if (dtManager != null && dtManager.Rows.Count > 0) {
                foreach (DataRow row in dtManager.Rows) {
                    var managerItem = new UCManagerItem {
                        Id = row["EMPLOYEE_ID"].ToString(),
                        Name = row["EMPLOYEE_FULLNAME"].ToString()
                    };

                    managerTempId = managerItem.Id;

                    managerItem.Size = new Size() {
                        Width = pnlManager.Size.Width,
                        Height = managerItem.Size.Height
                    };
                    pnlManager.Controls.Add(managerItem);
                }
            }

            var dtJobsByProject = BLL.CJobBLL.Instance.GetAllByEmployee(managerTempId);
            double total;
            double total1;
            if (dtJobsByProject != null && dtJobsByProject.Rows.Count > 0) {
                foreach (DataRow row in dtJobsByProject.Rows) {
                    var jobOfEmployeeItem = new UCJobOfEmployee {
                        ProjectId = row["PROJECT_ID"].ToString(),
                        JobId = row["JOB_ID"].ToString(),
                        JobName = row["JOB_NAME"].ToString()
                    };
                    total = Convert.ToDouble(BLL.CProgressBLL.getTotalDocumentbyJobID(jobOfEmployeeItem.JobId));
                    total1 = Convert.ToDouble(BLL.CProgressBLL.getNumberofDocumentbyJobID(jobOfEmployeeItem.JobId));
                    jobOfEmployeeItem.JobPercent = Math.Round((total / total1) * 100, 2).ToString() + "%";
                    pnlJobOfEmployee.Controls.Add(jobOfEmployeeItem);
                }
            }
        }

        private void UCJobItem_Click(object sender, EventArgs e) {
            RetrieveInfomation(Id, ref pnlManager, ref pnlJobOfEmployee);
        }

        private void UCJobItem_MouseEnter(object sender, EventArgs e) {
            if (isHover == true) return;

            BackColor = Color.FromArgb(22, 22, 22);
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void UCJobItem_MouseLeave(object sender, EventArgs e) {
            if (isHover == false) return;

            BackColor = Color.FromArgb(29, 29, 29);
            isHover = false;
        }
    }
}
