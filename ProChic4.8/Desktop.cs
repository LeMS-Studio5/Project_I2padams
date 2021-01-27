using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libProChic;

namespace ProChic4._8
{
    public partial class Desktop : Form
    {
        private MasterClass com = new MasterClass();
        public Desktop()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(elvDesktop.Items.Count + "");
            elvDesktop.BackColor = com.convertColour(com.Config.GetConfig("Colors", "Background").Setting);
        }
    }
}
