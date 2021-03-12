using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libProChic
{
    public class MenuStrip : System.Windows.Forms.MenuStrip
    {
        public MenuStrip()
        {
            this.Renderer = new ProChicRender();
        }
    }
    public class ProChicCol : ProfessionalColorTable
    {
        MasterClass com = new MasterClass();
        public override Color MenuItemSelected
        {
            get { return com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting); }
        }
        public void test()
        {
            //base.Presse
        }
        //public override Color MenuItemSelectedGradientEnd { get { return com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting); } }
        //public override Color MenuStripGradientEnd{ get { return com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting); } }
        //public override Color MenuItemSelectedGradientBegin
        //{
        //    get { return Color.Orange; }
        //}
        //public override Color MenuItemSelectedGradientEnd
        //{
        //    get { return Color.Yellow; }
        //}
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.Navy;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.Navy;
            }
        }
    }
    public class ProChicRender : ToolStripProfessionalRenderer
    {
        Color bkgrdCol;
        Color bkgrdSelCol;
        MasterClass com = new MasterClass();
        public ProChicRender() : base(new ProChicCol())
        {
            bkgrdSelCol = com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting);
            bkgrdCol = com.convertColour(com.Config.GetConfig("Colors", "ButtonFace").Setting);
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderMenuItemBackground(e);
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.PaleGreen;
            if (e.Item.Selected) c = bkgrdSelCol; else c = bkgrdCol;
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
            //e.ToolStrip.BackColor = Color.Yellow;//e.Item.BackColor = Color.Yellow
            //if (e.Item.Selected) e.ToolStrip.Col= Color.Yellow;  else e.Item.BackColor = bkgrdCol;
            ////  e.Item.BackColor= com.convertColour(com.Config.GetConfig("Colors", "Hilight").Setting);
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            //Debug.WriteLineIf(e.Item.Selected, com.convertColour(com.Config.GetConfig("Colors", "HilightText").Setting).ToString());
            if (e.Item.Selected) e.Item.ForeColor = com.convertColour(com.Config.GetConfig("Colors", "HilightText").Setting); else e.Item.ForeColor = com.convertColour(com.Config.GetConfig("Colors", "MenuText").Setting);
        }
    }
}
