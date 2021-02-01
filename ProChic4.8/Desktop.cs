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
                CheckForIllegalCrossThreadCalls = false;
                this.com.Config.ConfigUpdated += DesktopLoad;
                this.Load += DesktopLoad;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            elvDesktop.OSIconLocationPath = com.toSystemPath(com.Config.GetConfig("windows", "ICO").Setting);
            elvDesktop.BackColor = com.convertColour(com.Config.GetConfig("Colors", "Background").Setting);
            elvDesktop.Directory = com.toSystemPath(@"C:\Windows\Desktop");
        }
        public void DesktopLoad(Object sender, EventArgs e)
        {
            try
            {
                elvDesktop.UpdateDesktop = false;
                if (com.Config.GetConfig("Desktop", "TileWallpaper").Setting == "1") elvDesktop.WallpaperLayout = ImageLayout.Tile; else elvDesktop.WallpaperLayout = ImageLayout.Center;
                elvDesktop.Wallpaper = (Bitmap)com.prepareImage(com.toSystemPath(com.Config.GetConfig("Desktop", "Wallpaper").Setting));
                elvDesktop.Pattern = new Bitmap(getPattern(com.Config.GetConfig("Desktop", "Pattern").Setting), 8, 8);
                int taskWidth=int.Parse(com.Config.GetConfig("Taskbar", "Width").Setting), taskHeight= int.Parse(com.Config.GetConfig("Taskbar", "Height").Setting);
                panTaskBar.Height= taskHeight;
                if (taskWidth == -1)
                {
                    panTaskBar.Dock = DockStyle.Bottom;
                }else
                {
                    panTaskBar.Dock = DockStyle.None;
                    panTaskBar.Width = taskWidth;
                }
                panTaskBar.Location = new Point((int)((Width/(Double)2)-(taskWidth/(Double)2)), Height - taskHeight);
                elvDesktop.UpdateDesktop = true;
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }
        public Image getPattern(string patternString)
        {
            int y = 0;
            System.Drawing.Bitmap canvasbitmap = new System.Drawing.Bitmap(152, 152);
            Graphics g = Graphics.FromImage(canvasbitmap);
            if (patternString == "(None)")
                return canvasbitmap;
            foreach (var dec in patternString.Split(' '))
            {
                int x = 0;
                for (int index = 0; index <= 7; index++)
                {
                    if (Convert.ToString(Convert.ToInt32(dec), 2).PadLeft(8, '0').Substring(index, 1) == "1")
                        g.FillRectangle(Brushes.Black, x * 19, y * 19, 19, 19);
                    x += 1;
                }
                y += 1;
            }
            return canvasbitmap;
        }
    }
}
