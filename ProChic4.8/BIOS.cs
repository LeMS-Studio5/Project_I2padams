using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProChic4._8
{
    public partial class BIOS : Form
    {
        public BIOS()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Desktop d = new Desktop();
            d.Show();
            this.Hide();
        }
    }
}
