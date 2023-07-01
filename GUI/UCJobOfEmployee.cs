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
    public partial class UCJobOfEmployee : UserControl {
        public UCJobOfEmployee() {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public string ProjectId {
            get => lbProjectId.Text;
            set => lbProjectId.Text = value;
        }

        [Category("Custom Props")]
        public string JobName {
            get => lbJobName.Text;
            set => lbJobName.Text = value;
        }
        [Category("Custom Props")]
        public string JobId {
            get => lbJobId.Text;
            set => lbJobId.Text = value;
        }
        [Category("Custom Props")]
        public string JobPercent {
            get => lbJobPercent.Text;
            set => lbJobPercent.Text = value;
        }
    }
}
