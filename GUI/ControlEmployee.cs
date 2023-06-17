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
    public partial class ControlEmployee : UserControl
    {
        public ControlEmployee()
        {
            InitializeComponent();
        }
        private string _idEmployee;
        private string _nameEmployee;

        [Category("Custom Props")]
        public string idEmployee
        {
            get { return _idEmployee; }
            set { _idEmployee = value; lblIdEmployee.Text = value; }
        }

        [Category("Custom Props")]
        public string nameEmployee
        {
            get { return _nameEmployee; }
            set { _nameEmployee = value; lblNameEmployee.Text = value; }
        }
    }
}
