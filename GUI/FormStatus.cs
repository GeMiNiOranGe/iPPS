﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI {
    public partial class FormStatus : Form {
        BLL_Project bllPJ = new BLL_Project();
        public FormStatus()
        {
            InitializeComponent();
        }

        private void ShowAllProject()
        {
            flPanelAllProject.Controls.Clear();
            DataTable dt = bllPJ.GetProject();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ControlProject[] listItems = new ControlProject[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new ControlProject();

                            listItems[i].Maduan = row["PROJECT_ID"].ToString();
                            listItems[i].Tenduan = row["PROJECT_NAME"].ToString();
                            listItems[i].Tenbophan = row["DEPARTMENT_NAME"].ToString();
                            if (row["PROJECT_STATUS"].ToString() == "2")
                            {
                                listItems[i].Tileduan = "0%";
                            }
                            else if (row["PROJECT_STATUS"].ToString() == "1")
                            {
                                listItems[i].Tileduan = "50%";
                            }
                            else
                            {
                                listItems[i].Tileduan = "100%";
                            }

                            flPanelAllProject.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }

        private void FormStatus_Load(object sender, EventArgs e)
        {
            ShowAllProject();
        }
    }
}