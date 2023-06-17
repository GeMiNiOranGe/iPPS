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
    public partial class ControlWorkOfEmployee : UserControl
    {
        public ControlWorkOfEmployee()
        {
            InitializeComponent();
        }
        private string _maduan;
        private string _macongviec;
        private string _tencongviec;
        private string _tilecongviec;

        [Category("Custom Props")]
        public string Maduan
        {
            get { return _maduan; }
            set { _maduan = value; lblIdProject.Text = value; }
        }

        [Category("Custom Props")]
        public string Tencongviec
        {
            get { return _tencongviec; }
            set { _tencongviec = value; lblNameWork.Text = value; }
        }
        [Category("Custom Props")]
        public string Macongviec
        {
            get { return _macongviec; }
            set { _macongviec = value; lblIdWork.Text = value; }
        }
        [Category("Custom Props")]
        public string Tilecongviec
        {
            get { return _tilecongviec; }
            set { _tilecongviec = value; lblPercentWork.Text = value; }
        }
    }
}
