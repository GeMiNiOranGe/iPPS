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
    public partial class UCManagerItem : UserControl {
        public UCManagerItem() {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public string Id {
            get => lbManagerId.Text;
            set => lbManagerId.Text = value;
        }

        [Category("Custom Props")]
        public new string Name {
            get => lbManagerName.Text;
            set => lbManagerName.Text = value;
        }
    }
}
