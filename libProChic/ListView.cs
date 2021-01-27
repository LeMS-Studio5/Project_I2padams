using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libProChic
{
    public class ListView : System.Windows.Forms.ListView
    {
        private System.ComponentModel.IContainer components;
        private ImageList sil = new ImageList();
        private MasterClass com = new MasterClass();

        public ListView() : base()
        {
            try
            {
                //   Console.WriteLine(Items == null);
                InitializeComponent();
                Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }
        public Color SelectedColor { get; set; }
        public Color SelectedTextColor { get; set; }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            OwnerDraw = true;
            DoubleBuffered = true;
           SelectedColor = com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting);
           SelectedTextColor = com.convertColour(com.Config.GetConfig("Colors", "HilightText").Setting);
           BackColor = com.convertColour(com.Config.GetConfig("Colors", "Window").Setting);
           ForeColor = com.convertColour(com.Config.GetConfig("Colors", "WindowText").Setting);
            SmallImageList = sil;
            this.DrawItem += mybase_DrawItem;
        }
        private void mybase_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            
        }
    }
}
