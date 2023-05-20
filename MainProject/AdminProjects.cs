﻿using System;
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

namespace MainProject
{
    public partial class AdminProjects : Form
    {
        SqlConnection conn = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd = null;

        public AdminProjects()
        {
            InitializeComponent();
        }

        private void AdminProjects_Load(object sender, EventArgs e)
        {
            LoadAdminProjects();
        }

        public void LoadAdminProjects()
        {
            dgvProjects.Rows.Clear();
            int i = 0;
            conn.Open();
            cmd=new SqlCommand("select * from PROJECT", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                i++;
                dgvProjects.Rows.Add(rd["PROJECT_ID"].ToString(), rd["PROJECT_NAME"].ToString(), 
                    rd["CUSTOMER"].ToString(), rd["FIRST_DAY"].ToString(), 
                    rd["LAST_DAY"].ToString(), rd["STATE"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }
}
