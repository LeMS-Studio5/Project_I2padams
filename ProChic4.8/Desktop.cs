using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libLeMS;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

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
                elvDesktop.Click += appLaunchHide;
                elvDesktop.OSIconLocationPath = com.toSystemPath(com.Config.GetConfig("windows", "ICO").Setting);
                elvDesktop.Directory = com.toSystemPath(@"C:\Windows\Desktop");               
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Desktop: Init: " + ex.ToString());
            }
        }
        private System.Threading.Thread thrdFileListener;
        private System.Threading.Thread thrdActiveApp;
        public new DialogResult ShowDialog()
        {
            Show();
            thrdFileListener = new System.Threading.Thread(new System.Threading.ThreadStart(FileLaunch));
            thrdActiveApp = new System.Threading.Thread(new System.Threading.ThreadStart(ActiveApp));
            thrdFileListener.Start();
            thrdActiveApp.Start();
            Hide();
            return base.ShowDialog();
        }
        public void DesktopLoad(Object sender, EventArgs e)
        {
            try
            {
                int taskWidth = com.Config.GetConfigAsInt32("Taskbar", "Width"), taskHeight = com.Config.GetConfigAsInt32("Taskbar", "Height");
                panTaskBar.BackgroundImage = com.prepareImage(com.toSystemPath(com.Config.GetConfig("Taskbar", "BackgroundImg").Setting));
                panTaskBar.BackColor = com.convertColour(com.Config.GetConfig("Colors", "ButtonFace").Setting);
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
                elvDesktop.UpdateDesktop = false;
                MenuSeup();
                if (com.Config.GetConfig("Desktop", "TileWallpaper").Setting == "1") elvDesktop.WallpaperLayout = ImageLayout.Tile; else elvDesktop.WallpaperLayout = ImageLayout.Center;
                elvDesktop.BackColor = com.convertColour(com.Config.GetConfig("Colors", "Background").Setting);
                elvDesktop.Wallpaper = (Bitmap)com.prepareImage(com.toSystemPath(com.Config.GetConfig("Desktop", "Wallpaper").Setting));
                elvDesktop.PatternString= com.Config.GetConfig("Desktop", "Pattern").Setting;
                elvDesktop.UpdateDesktop = true;
              }
            catch (Exception ex)
            {
                Debug.WriteLine("Desktop: Load: " + ex.ToString());
            }
        }
        #region AppLauncher
        private void MenuSeup()
        {
            btnAppLauncher.Location = new Point(com.Config.GetConfigAsInt32("AppLauncher", "X"), com.Config.GetConfigAsInt32("AppLauncher", "Y"));
            btnAppLauncher.Size = new Size(com.Config.GetConfigAsInt32("AppLauncher", "Width"), com.Config.GetConfigAsInt32("AppLauncher", "Height"));
            btnAppLauncher.Image = com.prepareImage(com.toSystemPath(com.Config.GetConfig("AppLauncher", "ButtonImage").Setting));
            btnAppLauncher.Text = com.Config.GetConfig("AppLauncher", "ButtonText").Setting;
            ConfigHelper conMenu = new ConfigHelper(com.toSystemPath(com.Config.GetConfig("AppLauncher", "Contents").Setting));
            menAppLaunch.Items.Clear();
            foreach(ConfigGroup cGrp in conMenu.GetAllConfigsGroup()) {
                if (cGrp.Name==("Image")) {                  
                }else if (cGrp.Name == "Split"){
                    menAppLaunch.Items.Add(new ToolStripSeparator());
                }else{
                    menAppLaunch.Items.Add(BuildMenu(cGrp));
                }
            }
            menAppLaunch.Padding = new Padding(0);
            //menAppLaunch.BackColor = com.convertColour(com.Config.GetConfig("Colors", "ButtonFace").Setting);
            panAppLaunch.Size = new Size(panAppLaunch.Width, menAppLaunch.Height + 0);
            panAppLaunch.Location = new Point(com.Config.GetConfigAsInt32("AppLauncher", "MenuXOffset") + btnAppLauncher.Location.X, panTaskBar.Location.Y - menAppLaunch.Height + com.Config.GetConfigAsInt32("AppLauncher", "MenuYOffset"));
            panAppLaunch.Size = new Size(panAppLaunch.Width, menAppLaunch.Height+0);
            if (conMenu.Exists("Image"))
            {
                Bitmap i = com.prepareImage(com.toSystemPath(conMenu.GetConfig("Image", "src").Setting)), b = new Bitmap(i.Width, picAppLaunch.Height);// ;
                Graphics g = Graphics.FromImage(b);
                g.DrawImage(i, new Point(0, picAppLaunch.Height - i.Height));
                picAppLaunch.Image = b;
                picAppLaunch.BackColor = com.convertColour((conMenu.GetConfig("Image", "BackgroundCol").Setting));
            }
        }
        private ToolStripMenuItem BuildMenu(ConfigGroup conGroup)
        {
            ToolStripMenuItem tsm = new ToolStripMenuItem(conGroup.Name);
            if (conGroup.Contains("Path") > -1) tsm= BuildMenuFromPathData(com.toSystemPath(conGroup.Item("Path").Setting));
            if (conGroup.Contains("cmd") > -1)
            {
                tsm.Tag = conGroup.Item("cmd").Setting;
                tsm.Click += launch;
            }
            if (conGroup.Contains("IconResource") > -1)
            {
                if (conGroup.Item("IconResource").Setting.Contains(",")) tsm.Image = com.prepareImage(elvDesktop.addImage(com.toSystemPath(conGroup.Item("IconResource").Setting),""),true); else tsm.Image =com.prepareImage(com.toSystemPath(conGroup.Item("IconResource").Setting));
            }
            tsm.ImageScaling = ToolStripItemImageScaling.None;
            tsm.TextAlign = ContentAlignment.MiddleLeft;
            tsm.ImageAlign = ContentAlignment.MiddleLeft;
            tsm.Alignment = ToolStripItemAlignment.Left;
            tsm.Padding = new Padding(0);
           //Debug.WriteLine(tsm.    );
            return tsm;
        }
        private ToolStripMenuItem BuildMenuFromPathData(String RootPath)
        {
            try
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(new DirectoryInfo(RootPath).Name, elvDesktop.addImage(RootPath, RootPath));
                foreach (DirectoryInfo dirInfo in ListDirs(RootPath))
                {
                    //Debug.WriteLine(dirInfo.FullName);
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
                Debug.WriteLine("Build Menu from Path: " + ex.ToString());
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
                Debug.WriteLine("List Dirs: " + ex.ToString());
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
                Debug.WriteLine("List Files: " + ex.ToString());
            }
            return null;
        }
        private void launch(Object sender, EventArgs e)
        {
            panAppLaunch.Hide();
            elvDesktop.OpenFile(((ToolStripMenuItem)sender).Tag.ToString());
        }
        private void appLaunchHide(Object sender, EventArgs e)
        {
            panAppLaunch.Hide();
        }
        private void AppLauncherToggle(object sender, EventArgs e)
        {
            panAppLaunch.Visible = !panAppLaunch.Visible;
            panAppLaunch.BringToFront();
        }
        private String ProperAppLaunch(String filePath)
        {
            String Ext = Path.GetExtension(filePath);
            if (Ext.Equals(".exe", StringComparison.CurrentCultureIgnoreCase)) return filePath;
            if (Ext.Equals(".lnk", StringComparison.CurrentCultureIgnoreCase)) return ProperAppLaunch(com.toSystemPath(new ShortCut(filePath).TargetFile));
            if (com.Config.GetConfigGroup("Extensions").Contains(Ext) > -1) return com.Config.GetConfig("Extensions", Ext).Setting.Split('^')[0];
            throw new Exception("File Extention not regristered");
        }
        #endregion AppLauncher
        private void addPanelItem(ref AppHolder app)
        {
            apps.Add(app.ProcessHandle, app);
            Panel_Item pan = new Panel_Item(ref app);
            panTaskBar.Controls.Add(pan);
            panItems.Add(app.ProcessHandle, pan);
            pan.AppVisChange += AppVis;
            panelPlace();
        }
        private void AppVis(IntPtr Apphandler)
        {
            apps[Apphandler].Visible = !apps[Apphandler].Visible;
        }
        private void panelPlace() {
            Int32 itmHorPad = com.Config.GetConfigAsInt32("Taskbar", "ItemHorPadding"), itmX = com.Config.GetConfigAsInt32("AppLauncher", "Width") + itmHorPad, itmY = com.Config.GetConfigAsInt32("Taskbar", "ItemY");
            for (int i = 0; i < panTaskBar.Controls.Count; i++)
            {
                if (panTaskBar.Controls[i].GetType()==( typeof(Panel_Item)))
                {
                    panTaskBar.Controls[i].Location = new Point(itmX, itmY);// ' pan(i).Visible = True
                    itmX += panTaskBar.Controls[i].Width + itmHorPad;
                }
            }
        }
        private Dictionary<IntPtr, AppHolder> apps = new Dictionary<IntPtr, AppHolder>();
        private Dictionary<IntPtr, Panel_Item> panItems = new Dictionary<IntPtr, Panel_Item>();
        private void FileLaunch()
        {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream("ProjectI2padamsNet"))
                {
                    if (!pipeClient.IsConnected) pipeClient.Connect();
                    string temp = "";
                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                    while (true)//temp != "ProChicSuspend" || temp!= "ProChicExit")
                    {
                            while ((temp = sr.ReadLine()) == "") ;
                            Debug.WriteLineIf(temp!="","Came thru pipe: " + temp);
                        if (temp == "ProChicExit")
                        {
                            DialogResult = DialogResult.Cancel;
                            Debug.WriteLine("Desktop: Shutting Down");
                            DesktopClosing();
                        }
                        else if (temp == "ProChicSuspend")
                        {
                            DialogResult = DialogResult.OK;
                            Debug.WriteLine("Desktop: Suspend");
                            DesktopClosing();
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                AppHolder app = new AppHolder(ProperAppLaunch(temp), "");
                                if (app != null) elvDesktop.Controls.Add(app);
                                app.AppClose += clospro;
                                app.FocusChanged += FocChange;
                                addPanelItem(ref app);
                            });
                        }
                    }
                }
            }
        }
        private void DesktopClosing()
        {
            for (int i = 0; i < apps.Count;){
                IntPtr id = apps.Values.ElementAt(i).ProcessHandle;
                apps.Values.ElementAt(i).Close(CloseReason.FormOwnerClosing);
                while (apps.ContainsKey(id)) { }
            }
            this.Close();
            thrdFileListener.Abort();
        }
        private void FocChange(object sender, EventArgs e){
            currentFocus=FocusCheck(currentFocus, (IntPtr)sender);
        }
        private void clospro(IntPtr Apphandler)
        {
            Debug.WriteLine(apps[Apphandler].Text + " is closing");
            apps[Apphandler].Dispose();
            apps.Remove(Apphandler);
            panItems[Apphandler].Dispose();
            panItems.Remove(Apphandler);
        }
        IntPtr currentFocus = IntPtr.Zero;
        private IntPtr FocusCheck(IntPtr _currentFocus, IntPtr newFocus){
            if (_currentFocus != newFocus && newFocus != IntPtr.Zero)
            {
                if (this.Handle == newFocus) Debug.WriteLine("Active Desktop: Desktop has focus");
                for (int i = 0; i < panItems.Count;i++)
                {
                    panItems.Values.ElementAt(i).Held = false;
                }
                for (int i = 0; i < apps.Count;i++)
                {
                    apps.Values.ElementAt(i).Focused = false;
                }
                _currentFocus = newFocus;
                if (apps.ContainsKey(newFocus)) apps[newFocus].Focused = true;
                if (panItems.ContainsKey(newFocus)) panItems[newFocus].Held = true;
            }
            return _currentFocus;
        }
        private void ActiveApp(){
            while (!IsDisposed){
                currentFocus = FocusCheck(currentFocus, GetForegroundWindow());                
            }
            thrdActiveApp.Abort();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();        
    }
    
}