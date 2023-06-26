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
        public string idEmployee;

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
            ShowJobOfProject(ProjectId);
        }

        private void ShowJobOfProject(string strProjectId) {
            flPanelListWork.Controls.Clear();
            var dataTable = BLL.CJobBLL.Instance.GetAllFromProject(strProjectId);

            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var projectItem = new ControlWorkOfProject {
                        Macongviec = row["JOB_ID"].ToString(),
                        Tencongviec = row["JOB_NAME"].ToString()
                    };

                    if (row["JOB_STATUS"].ToString() == "0")
                        projectItem.Tilecongviec = "80%";
                    else if (row["JOB_STATUS"].ToString() == "1")
                        projectItem.Tilecongviec = "50%";
                    else
                        projectItem.Tilecongviec = "0%";

                    flPanelListWork.Controls.Add(projectItem);
                }
            }
        }


        private void BtnWatch_Click(object sender, EventArgs e) {
            panelEmployeeOfWork.Controls.Clear();
            DataTable dt1 = BLL.CJobBLL.Instance.GetManager(ControlWorkOfProject.idWork);

            if (dt1 != null) {
                if (dt1.Rows.Count > 0) {
                    ControlEmployee[] listItems = new ControlEmployee[dt1.Rows.Count];
                    for (int i = 0; i < 1; i++) {
                        foreach (DataRow row in dt1.Rows) {
                            listItems[i] = new ControlEmployee {
                                idEmployee = row["EMPLOYEE_ID"].ToString(),
                                nameEmployee = row["EMPLOYEE_FULLNAME"].ToString()
                            };

                            idEmployee = listItems[i].idEmployee;

                            panelEmployeeOfWork.Controls.Add(listItems[i]);
                        }
                    }
                }
            }

            flPanelWorkOfEmployee.Controls.Clear();
            DataTable dt2 = BLL.CJobBLL.Instance.GetAllByEmployee(idEmployee);
            if (dt2 != null) {
                if (dt2.Rows.Count > 0) {
                    ControlWorkOfEmployee[] listItems = new ControlWorkOfEmployee[dt2.Rows.Count];
                    for (int i = 0; i < 1; i++) {
                        foreach (DataRow row in dt2.Rows) {
                            listItems[i] = new ControlWorkOfEmployee {
                                Maduan = row["PROJECT_ID"].ToString(),
                                Macongviec = row["JOB_ID"].ToString(),
                                Tencongviec = row["JOB_NAME"].ToString()
                            };

                            if (row["JOB_STATUS"].ToString() == "0")
                                listItems[i].Tilecongviec = "80%";
                            else if (row["JOB_STATUS"].ToString() == "1")
                                listItems[i].Tilecongviec = "50%";
                            else
                                listItems[i].Tilecongviec = "0%";

                            flPanelWorkOfEmployee.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }
    }
}
