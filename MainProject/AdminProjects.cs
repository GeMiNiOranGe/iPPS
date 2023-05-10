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

namespace MainProject
{
    public partial class AdminProjects : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True");
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
            cmd=new SqlCommand("select * from DUAN", conn);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                i++;
                dgvProjects.Rows.Add(rd["MADA"].ToString(), rd["TENDA"].ToString(), 
                    rd["KHACHHANG"].ToString(), rd["NGAYBATDAU"].ToString(), 
                    rd["NGAYKETTHUC"].ToString(), rd["TRANGTHAI"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }
}
