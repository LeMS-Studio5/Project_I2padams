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
using System.IO;
using System.IO.Pipes;

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
            elvDesktop.Directory = com.toSystemPath(@"C:\Windows\Desktop");
        }
        public void DesktopLoad(Object sender, EventArgs e)
        {
            try
            {
                elvDesktop.UpdateDesktop = false;
                if (com.Config.GetConfig("Desktop", "TileWallpaper").Setting == "1") elvDesktop.WallpaperLayout = ImageLayout.Tile; else elvDesktop.WallpaperLayout = ImageLayout.Center;
                elvDesktop.BackColor = com.convertColour(com.Config.GetConfig("Colors", "Background").Setting);
                //elvDesktop.Wallpaper = (Bitmap)com.prepareImage(com.toSystemPath(com.Config.GetConfig("Desktop", "Wallpaper").Setting));
                elvDesktop.Pattern = new Bitmap(getPattern(com.Config.GetConfig("Desktop", "Pattern").Setting), 8, 8);
                elvDesktop.UpdateDesktop = true;
                int taskWidth = int.Parse(com.Config.GetConfig("Taskbar", "Width").Setting), taskHeight = int.Parse(com.Config.GetConfig("Taskbar", "Height").Setting);
                panTaskBar.Height = taskHeight;
                if (taskWidth == -1)
                {
                    panTaskBar.Dock = DockStyle.Bottom;
                }
                else
                {
                    panTaskBar.Dock = DockStyle.None;
                    panTaskBar.Width = taskWidth;
                }
                panTaskBar.Location = new Point((int)((Width / (Double)2) - (taskWidth / (Double)2)), Height - taskHeight);
                btnAppLauncher.Location = new Point(int.Parse(com.Config.GetConfig("AppLauncher", "X").Setting), int.Parse(com.Config.GetConfig("AppLauncher", "Y").Setting));
                btnAppLauncher.Size = new Size(int.Parse(com.Config.GetConfig("AppLauncher", "Width").Setting), int.Parse(com.Config.GetConfig("AppLauncher", "Height").Setting));
                btnAppLauncher.Image = com.prepareImage(com.toSystemPath(com.Config.GetConfig("AppLauncher", "ButtonImage").Setting));
                btnAppLauncher.Text = com.Config.GetConfig("AppLauncher", "ButtonText").Setting;
                menAppLaunch.Items.Clear();
                menAppLaunch.Items.Add(BuildMenuFromPathData(com.toSystemPath(@"C:\Windows\Start Menu\Programs")));
                panAppLaunch.Size = new Size(panAppLaunch.Width, menAppLaunch.Height);
                Console.WriteLine(panAppLaunch.Size);
                panAppLaunch.Location = new Point(int.Parse(com.Config.GetConfig("AppLauncher", "X").Setting), panTaskBar.Location.Y - panAppLaunch.Height);
                (new System.Threading.Thread(new System.Threading.ThreadStart(FileLaunch))).Start();
            }
            catch (Exception ex)
            {
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
        public ToolStripMenuItem BuildMenuFromPathData(String RootPath)
        {
            try
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(new DirectoryInfo(RootPath).Name, elvDesktop.addImage(RootPath, RootPath));
                foreach (DirectoryInfo dirInfo in ListDirs(RootPath))
                {
                    //Console.WriteLine(dirInfo.FullName);
                    tsmi.DropDownItems.Add(BuildMenuFromPathData(dirInfo.FullName));
                }
                foreach (FileInfo filInfo in ListFiles(RootPath))
                {
                    tsmi.DropDownItems.Add(CreateToolStripFileItem(filInfo));
                }
                return tsmi;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        private ToolStripMenuItem CreateToolStripFileItem(FileInfo ItemText)
        {
            ToolStripMenuItem tsi = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(ItemText.FullName), elvDesktop.addImage(ItemText.FullName, ItemText.FullName), launch);
            tsi.Tag = ItemText.FullName;
            return tsi;
        }
        private DirectoryInfo[] ListDirs(String Path)
        {
            try
            {
                if (Directory.Exists(Path))
                    return new System.IO.DirectoryInfo(Path).GetDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly);
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        private FileInfo[] ListFiles(String Path)
        {
            try // MessageBox.Show(Path)
            {
                if (Path != null && Directory.Exists(Path))
                    return new DirectoryInfo(Path).GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
        private void launch(Object sender, EventArgs e)
        {
            elvDesktop.OpenFile(((ToolStripMenuItem)sender).Tag.ToString());
        }
        private void FileLaunch()
        {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream("ProjectI2padamsNet"))
                {
                    if (!pipeClient.IsConnected) pipeClient.Connect();
                    string temp = "";
                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                    while (temp != "Exit")
                    {
                        while ((temp = sr.ReadLine()) == "")
                        {

                            Console.WriteLine(temp);

                        }
                        Console.WriteLine("Here");
                        AppHolder app = new AppHolder(temp, "");
                        this.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            elvDesktop.Controls.Add(app);
                        });
                    }
                }
            }
        }
    }
}