using Config;
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

namespace MainProject
{
    public partial class ProjectControlChoose : UserControl
    {
        public ProjectControlChoose()
        {
            InitializeComponent();
        }

        //Chỗ này phục vụ cho việc đọc dữ liệu để add vào label của ProjectControlChoos
        private string _tenduan;
        private string _tenbophan;

        [Category("Custom Props")]
        public string Tenduan
        {
            get { return _tenduan; }
            set { _tenduan = value; lbltenduan.Text = value; }
        }

        [Category("Custom Props")]
        public string Tenbophan
        {
            get { return _tenbophan; }
            set { _tenbophan = value; lblbophanduan.Text = value; }
        }

        // MouseEnter và MouseLeave là sự kiện sẽ xảy ra hiệu ứng khi di chuột vào và ra
        bool isHover = false;
        private void ProjectControlChoose_MouseEnter(object sender, EventArgs e)
        {
            if (isHover == true)
            {
                return;
            }
            BackColor = SystemColors.ButtonFace;
            lbltenduan.ForeColor = SystemColors.Highlight;
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void ProjectControlChoose_MouseLeave(object sender, EventArgs e)
        {
            if (isHover == false)
            {
                return;
            }
            BackColor = SystemColors.ButtonHighlight;
            lbltenduan.ForeColor = SystemColors.ControlText;
            this.Cursor = Cursors.Default;
            isHover = false;
        }

        private void ProjectControlChoose_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjectControlChoose_Click(object sender, EventArgs e)
        {
            Work openWork = new Work();
            openWork.Show();
        }
    }
}
