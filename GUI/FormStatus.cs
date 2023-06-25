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
    public partial class FormStatus : Form {
        public FormStatus() {
            InitializeComponent();
        }

        private void ShowAllProject() {
            flPanelAllProject.Controls.Clear();
            DataTable dt = BLL.CProjectBLL.Instance.GetProjectList();

            if (dt != null) {
                if (dt.Rows.Count > 0) {
                    UCProject[] listItems = new UCProject[dt.Rows.Count];
                    for (int i = 0; i < 1; i++) {
                        foreach (DataRow row in dt.Rows) {
                            listItems[i] = new UCProject {
                                Id = row["PROJECT_ID"].ToString(),
                                Tenduan = row["PROJECT_NAME"].ToString(),
                                DepartmentName = row["DEPARTMENT_NAME"].ToString()
                            };
                            if (row["PROJECT_STATUS"].ToString() == "2") {
                                listItems[i].Percent = "0%";
                            }
                            else if (row["PROJECT_STATUS"].ToString() == "1") {
                                listItems[i].Percent = "50%";
                            }
                            else {
                                listItems[i].Percent = "100%";
                            }

                            flPanelAllProject.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }

        private void FormStatus_Load(object sender, EventArgs e) {
            ShowAllProject();
        }
    }
}
