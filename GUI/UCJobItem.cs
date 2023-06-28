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
    public partial class UCJobItem : UserControl {
        public UCJobItem() {
            InitializeComponent();
        }

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

        public void RetrieveInfomation(string strId, ref Panel pnlManager, ref Panel pnlJobOfEmployee) {
            pnlManager.Controls.Clear();
            var dataTable = BLL.CJobBLL.Instance.GetManager(strId);

            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var managerItem = new UCManagerItem {
                        Id = row["EMPLOYEE_ID"].ToString(),
                        Name = row["EMPLOYEE_FULLNAME"].ToString()
                    };

                    strId = managerItem.Id;

                    managerItem.Size = new Size() {
                        Width = pnlManager.Size.Width,
                        Height = managerItem.Size.Height
                    };
                    pnlManager.Controls.Add(managerItem);
                }
            }

            pnlJobOfEmployee.Controls.Clear();
            DataTable dt2 = BLL.CJobBLL.Instance.GetAllByEmployee(strId);
            if (dt2 != null && dt2.Rows.Count > 0) {
                foreach (DataRow row in dt2.Rows) {
                    var listItems = new ControlWorkOfEmployee {
                        Maduan = row["PROJECT_ID"].ToString(),
                        Macongviec = row["JOB_ID"].ToString(),
                        Tencongviec = row["JOB_NAME"].ToString()
                    };

                    if (row["JOB_STATUS"].ToString() == "0")
                        listItems.Tilecongviec = "80%";
                    else if (row["JOB_STATUS"].ToString() == "1")
                        listItems.Tilecongviec = "50%";
                    else
                        listItems.Tilecongviec = "0%";

                    pnlJobOfEmployee.Controls.Add(listItems);
                }
            }
        }

        private void ControlWorkOfProject_Click(object sender, EventArgs e) {
            RetrieveInfomation(Id, ref pnlManager, ref pnlJobOfEmployee);
        }

        private void ControlWorkOfProject_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }
    }
}
