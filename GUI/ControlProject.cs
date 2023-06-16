using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ControlProject : UserControl
    {
        public ControlProject()
        {
            InitializeComponent();
        }
        //Chỗ này phục vụ cho việc đọc dữ liệu để add vào label của ProjectControlChoos
        private string _maduan;
        private string _tenduan;
        private string _tenbophan;
        private string _tileduan;

        [Category("Custom Props")]
        public string Maduan
        {
            get { return _maduan; }
            set { _maduan = value; lblIdProject.Text = value; }
        }
        [Category("Custom Props")]
        public string Tenduan
        {
            get { return _tenduan; }
            set { _tenduan = value; lblNameProject.Text = value; }
        }

        [Category("Custom Props")]
        public string Tenbophan
        {
            get { return _tenbophan; }
            set { _tenbophan = value; lblNameDepartment.Text = value; }
        }

        [Category("Custom Props")]
        public string Tileduan
        {
            get { return _tileduan; }
            set { _tileduan = value; lblPercentProject.Text = value; }
        }

        public static string idProject;
        public static string NameProject;

        bool isHover = false;
        private void ControlProject_MouseEnter(object sender, EventArgs e)
        {
            if (isHover == true)
            {
                return;
            }
            BackColor = SystemColors.ButtonHighlight;
            lblNameProject.ForeColor = SystemColors.Highlight;
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void ControlProject_MouseLeave(object sender, EventArgs e)
        {
            if (isHover == false)
            {
                return;
            }
            BackColor = SystemColors.ButtonHighlight;
            lblNameProject.ForeColor = SystemColors.ControlText;
            isHover = false;

        }

        private void ControlProject_Click(object sender, EventArgs e)
        {
            idProject = lblIdProject.Text;
            NameProject = lblNameProject.Text;
            FormWorkOfProject form = new FormWorkOfProject();
            form.Show();
        }
    }
}
