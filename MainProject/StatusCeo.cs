using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Config;
using MainProject.HS;

namespace MainProject {
    public partial class StatusCeo : Form {

        public StatusCeo() {
            InitializeComponent();
        }

        private void GeneratedDynamicUserControl()
        {
            flowLayoutPanelmanhinhduan.Controls.Clear();
            HandleSql objHS = new HandleSql();
            DataTable dt = objHS.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ProjectControlChoose[] listItems = new ProjectControlChoose[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new ProjectControlChoose();

                            listItems[i].Tenduan = row["TENDA"].ToString();
                            listItems[i].Tenbophan = row["TENBP"].ToString();

                            flowLayoutPanelmanhinhduan.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }

        private void StatusCeo_Load(object sender, EventArgs e)
        {
            GeneratedDynamicUserControl();
        }

        private void flowLayoutPanelmanhinhduan_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
