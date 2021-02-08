using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libProChic
{
    public class ExplorerListView : ListView{
        public Image addImage(string strPath, string strCurrentDir)
        {
            string strFilPath = strPath;
            try
            {
                if (System.IO.Directory.Exists(strPath) == true && (new DirectoryInfo(strPath)).Name.EndsWith("‰ƒ"))
                    return DriveIcon(strPath);
                if (System.IO.Directory.Exists(strPath) == true && strPath == strCurrentDir)
                    return com.prepareImage(OSIco[4].ToBitmap(), FollowPallet);
                if (System.IO.Directory.Exists(strPath) == true && strPath != strCurrentDir)
                    return com.prepareImage(OSIco[3].ToBitmap(), FollowPallet);
                // MessageBox.Show(IO.Directory.Exists(strPath))
                // MessageBox.Show(OSIco.Count)
                if (!System.IO.File.Exists(strPath))
                    // MessageBox.Show("!exists:" & strPath)
                    return com.prepareImage(OSIco[52].ToBitmap(), FollowPallet);
                // MessageBox.Show("IN There")

                if (strPath.EndsWith("lnk", true, System.Globalization.CultureInfo.CurrentUICulture))
                {
                    Bitmap ink = new Bitmap(1, 1);
                    Graphics g = Graphics.FromImage(ink); // rooted &     '& "\"
                                                          // MessageBox.Show(m.getRoot & IO.File.ReadAllLines(strPath).First)
                                                          // MessageBox.Show(File.Exists(m.getRoot & IO.File.ReadAllLines(strPath).First) & ":" & IO.File.ReadAllLines(strPath).First)
                                                          // MessageBox.Show(strPath & vbCrLf & (m.getRoot(2359))) ' & "WINDOWS\Start Menu\Programs\")) 'IO.Directory.Exists
                                                          // MessageBox.Show(File.Exists(strPath))
                                                          // MessageBox.Show(File.ReadAllLines(strPath).First)
                    ShortCut lnk = new ShortCut(strPath);
                   // if (File.Exists(shortData[0])) strPath = shortData[0]; else Console.WriteLine(shortData[0]);
                    //        Console.WriteLine(com.toSystemPath(System.IO.File.ReadAllLines(strPath)[3].Split('☼')[0]));
                    //    if (File.ReadAllLines(strPath).Count() >= 4 && File.Exists(com.toSystemPath(System.IO.File.ReadAllLines(strPath)[3].Split('☼')[0])))
                    //        // Console.WriteLine(File.Exists("C:\Users\Luke\Documents\Visual Studio 2015\GitHub\LeMS-Studio5\ProjectChicago\win 95.ico")) 'm.toSystemPath(File.ReadAllLines(strPath)(3).Split("☼"c)(0)))) 'Console.WriteLine(m.toSystemPath("$" & File.ReadAllLines(strPath)(3)))
                    //        // Console.WriteLine(New IconExtractor("C:\Users\Luke\Documents\Visual Studio 2015\GitHub\LeMS-Studio5\ProjectChicago\win 95.ico").Count)
                    //        // strPath = File.ReadAllLines(strPath)(3).Split("☼"c)(0)
                    //        ink = TsudaKageyu.IconUtil.Split(new Icon(com.toSystemPath(File.ReadAllLines(strPath)[3].Split('☼')[0])))[int.Parse(File.ReadAllLines(strPath)[3].Split('☼')[1])].ToBitmap(); // ink = (New IconExtractor(m.toSystemPath(File.ReadAllLines(strPath)(3).Split("☼"c)(0)))).GetIcon(File.ReadAllLines(strPath)(3).Split("☼"c)(1)).ToBitmap
                    //    else if (File.Exists(File.ReadAllLines(strPath).First()))
                    //        strPath = File.ReadAllLines(strPath).First();
                    //    else
                    //        // MessageBox.Show("g")
                    //        strPath = com.toSystemPath(@"C:\") + File.ReadAllLines(strPath).First().ToCharArray();
                    //    // MessageBox.Show(strPath & ", " & File.Exists(strPath))
                    //    // If File.ReadAllLines(strFilPath).Count >= 5 Then Console.WriteLine(strFilPath & ((File.ReadAllLines(strFilPath)(4)))) ' = "Sys")))
                    if (ink.Width + ink.Height == 2)
                        ink = new Bitmap(addImage(com.toSystemPath(lnk.TargetFile), ""), 32, 32);
                    if (!(File.ReadAllLines(strFilPath).Count() >= 5 && File.ReadAllLines(strFilPath)[4] == "Sys"))
                        g.DrawImage(OSIco[29].ToBitmap(), 0, ink.Height - OSIco[29].Height);  // ink.Height - OSIco(29).Height)
                                                                                              // If Not strFilPath.StartsWith(m.getRoot(2359) & "WINDOWS\Start Menu\Programs\", StringComparison.CurrentCultureIgnoreCase) Then g.DrawImage(OSIco(29).ToBitmap, 0, ink.Height - OSIco(29).Height)  'ink.Height - OSIco(29).Height)
                                                                                              // MessageBox.Show(ink.Height)
                    return com.prepareImage(ink, FollowPallet);
                }
                if (strPath.EndsWith("U95exe", true, System.Globalization.CultureInfo.CurrentUICulture) || strPath.EndsWith("U95com", true, System.Globalization.CultureInfo.CurrentUICulture))
                    return null;// Properties.Resources.Attention;
                if ((ViewType == ExplorerType.ControlPanel && strPath.EndsWith("cpl", true, System.Globalization.CultureInfo.CurrentUICulture)) || strPath.EndsWith("exe", true, System.Globalization.CultureInfo.CurrentUICulture))
                {
                    TsudaKageyu.IconExtractor i = new TsudaKageyu.IconExtractor(strPath); // addImage(CDrivePath & File.ReadAllLines(strPath).First, "")
                                                                                          // MessageBox.Show(strPath)
                    if (i.Count > 0)
                        return com.prepareImage(i.GetIcon(i.Count - 1).ToBitmap(), FollowPallet);
                    else
                        return com.prepareImage(OSIco[2].ToBitmap(), FollowPallet);  // Return setSetting.OSIco(Int(ReadAllLines(strPath).Last)).ToBitmap
                }
                if (strPath.EndsWith(".U95ico", true, System.Globalization.CultureInfo.CurrentUICulture))
                    return com.prepareImage(strPath); // Image.FromFile(strPath)
                if (strPath.EndsWith(".txt", true, System.Globalization.CultureInfo.CurrentUICulture))
                    return com.prepareImage(OSIco[42].ToBitmap(), FollowPallet); // CHANGE IN AR 9 TO LOOK AT WIN.INI
                if (strPath.EndsWith(".msi", true, System.Globalization.CultureInfo.CurrentUICulture))
                    return com.prepareImage(OSIco[46].ToBitmap(), FollowPallet);
                return com.prepareImage(OSIco[0].ToBitmap(), FollowPallet);
            }
            catch (Exception ex)
            {
                if ((OSIco != null) && OSIco.Count() < 1)
                {
                    SHFILEINFO shInfo = new SHFILEINFO(); // Create and Instantiate File Info Object
                    shInfo.szDisplayName = new string('\0', 260); // Get Display Name
                    shInfo.szTypeName = new string('\0', 80); // Get File Type
                    IntPtr hIcon = SHGetFileInfo(strFilPath, 0, shInfo, Marshal.SizeOf(shInfo), 256 | 1); // Get File Type Icon Based On File Association
                    return com.prepareImage(Icon.FromHandle(shInfo.hIcon).ToBitmap(), FollowPallet); // 
                }
                Console.WriteLine(ex.ToString());
                // MessageBox.Show(ex.ToString)
                return null;//Properties.Resources.Error95;
            }
        }
        public Boolean AutoDispose = false;
        public bool AutoRefreshFolder { get; set; } = true;
        public new Color BackColor { get { return base.BackColor; } set { base.BackColor = value; if (upDesk) RefreshImage("col"); } }
        public new System.Drawing.Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
        }
        private MasterClass com = new MasterClass();
        private System.ComponentModel.IContainer components;
        private string dir = "";
        public string Directory
        {
            set
            {
                // MessageBox.Show(value)
                // If value = Nothing Then value = Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf("\"))
                // dir = value
                if (System.IO.Directory.Exists(value))
                {
                    if (!value.EndsWith(@"\"))
                        value += @"\";
                    if (value != dir)
                    {
                        dir = value;
                        //fswExplorer.Path = value; // ERROR
                        // MessageBox.Show("Dir")
                        if ( AutoRefreshFolder)
                            RefreshFolder();
                    }
                }
                else
                {
                    base.Items.Clear();
                    dir = "";
                }
            }
            get
            {
                return dir;
            }
        }
        public DirectoryInfo DirInfo()
        {
            if (dir != null)
                return new DirectoryInfo(dir);
            else
                return null;
        }
        private DisplayType display; // = DisplayType.DirectoriesAndFiles
        public DisplayType DisplayMode
        {
            set
            {
                display = value;
                // MessageBox.Show("Display")
                if (AutoRefreshFolder)
                    RefreshFolder();
            }
            get
            {
                return display;
            }
        }
        public enum DisplayType
        {
            Directories,
            DirectoriesAndFiles,
            Files
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
        private Image DriveIcon(string path)
        {
            if (File.ReadAllLines(path + @"\(_)drive.info")[0] == "HD")
                return OSIco[8].ToBitmap();
            if (File.ReadAllLines(path + @"\(_)drive.info")[0] == "flp")
                return OSIco[6].ToBitmap();
            if (File.ReadAllLines(path + @"\(_)drive.info")[0] == "cd" || File.ReadAllLines(path + @"\(_)drive.info")[0] == "dvd")
                return OSIco[11].ToBitmap();
            return null;// Properties.Resources.Error95;
        }
        public enum ExplorerType
        {
            Desktop,
            ControlPanel,
            General,
            Unlaunchable
        }
        public SizeType FileSizeType { set; get; } = SizeType.Bytes;
        private String filt = "*.*";
        public String Filter
        {
            set
            {
                filt = value;
                // MessageBox.Show(filt)
                // MessageBox.Show("Filter")
                if (AutoRefreshFolder)
                    RefreshFolder();
            }
            get
            {
                return filt;
            }
        }
        public Boolean FollowPallet { get; set; }
        private void fswExplorer_Changed(object sender, FileSystemEventArgs e)
        {
            if (!System.IO.Directory.Exists(dir) && AutoDispose)
                this.Dispose();
            if (!System.IO.Directory.Exists(dir) && !AutoDispose)
                UpDirectory();
            // MessageBox.Show(e.ChangeType.ToString)
            if (AutoRefreshFolder)
                RefreshFolder();
        }
        public ExplorerListView() : base()    // fswExplorer.CloseFile = m.specialRequest("Communcations", "closeEFSW" & Now.ToShortDateString) & "\close.U95"
        {
        }
        public bool OnErrorGoToParentDirectory { get; set; } = false;
        private Icon[] OSIco;
        private string OSPath;
        public string OSIconLocationPath
        {
            set
            {
                // Dim i As New TsudaKageyu.IconUtil(value)
                // MessageBox.Show(IO.File.Exists(value))
                if (System.IO.File.Exists(value))
                {
                    OSIco = TsudaKageyu.IconUtil.Split(new Icon(value)); // i.GetAllIcons
                    OSPath = value;
                }
                else
                {
                    OSIco = null;
                    OSPath = "";
                }
                // MessageBox.Show("OSICO")
                if (AutoRefreshFolder)
                    RefreshFolder();
            }
            get
            {
                return OSPath;
            }
        }
        [System.Runtime.InteropServices.DllImport("shlwapi")]
        public static extern long PathIsDirectory(string pszPath); // return 16 for local folders and 1 for server folders
        private Bitmap pat=new Bitmap(1,1);
        public Bitmap Pattern { get { return pat; } set {pat = value; if (upDesk) RefreshImage("pat"); } }
        public void RefreshFolder()
        {
            try
            {
                if ((Items != null)) Items.Clear();
                if (SmallImageList != null) SmallImageList.Images.Clear();
                if (System.IO.Directory.Exists(dir))
                {
                    //  System.Security.Permissions.FileIOPermission readPermission = new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Read, dir);
                    //  if (!System.Security.SecurityManager.IsGranted(readPermission))   return;
                    if (display == DisplayType.Directories || display == DisplayType.DirectoriesAndFiles)
                    {
                        foreach (string fil in System.IO.Directory.GetDirectories(dir)) // Get Files In Folder
                        {
                           
                            try
                            {
                                //   System.Security.Permissions.FileIOPermission writePermission = new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Read, fil);
                                //if ((System.Security.SecurityManager.IsGranted(writePermission)) && (!modCommunication.GetDirectoryName(fil).StartsWith("$")) && !(new System.IO.DirectoryInfo(fil).Attributes == System.IO.FileAttributes.Hidden || new System.IO.DirectoryInfo(fil).Attributes == System.IO.FileAttributes.Hidden) && !fil.Substring(fil.LastIndexOf('\\') + 1).StartsWith("(_)"))
                                // MessageBox.Show("fil: " & fil)
                                SmallImageList.Images.Add(fil, addImage(fil, dir));
                                // AddImages(file, iltDesktopIcons) 'Add Icons
                                Int64 intTotal = 0; // CHECK PERMISSIONS OF DIR BEFORE ENTERING
                                                    //System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(fil);
                                                    // MessageBox.Show(d.GetAccessControl.ToString)
                                                    // If d.GetAccessControl Then
                                foreach (var SizeFile in System.IO.Directory.GetFiles(fil, "*.*", System.IO.SearchOption.AllDirectories))
                                {
                                    // if (System.Security.SecurityManager.IsGranted(new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Read, SizeFile)))
                                    intTotal += (new FileInfo(SizeFile)).Length;
                                }
                                Items.Add(fil.Substring(fil.LastIndexOf('\\') + 1).Replace("‰", ":").Replace("ƒ", @"\"), fil); // Add Files & File Properties To ListView
                                Items[Items.Count - 1].ImageKey = fil;
                                Items[Items.Count - 1].ImageIndex = Items.Count - 1;
                                Items[Items.Count - 1].SubItems.Add((intTotal / FileSizeType.GetHashCode()) + " " + FileSizeType.ToString());
                                Items[Items.Count - 1].SubItems.Add("File Folder");
                                Items[Items.Count - 1].Tag = fil;
                                Items[Items.Count - 1].SubItems.Add(System.IO.Directory.GetLastWriteTime(fil).ToString());
                                intTotal = 0;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    // MessageBox.Show(dir)
                    // SubItemIndex = 0
                    // MessageBox.Show(filt)
                    //   if (!System.Security.SecurityManager.IsGranted(readPermission))               return;
                    if ((display == DisplayType.DirectoriesAndFiles || display == DisplayType.Files) && System.IO.Directory.Exists(dir))
                    {
                        foreach (string fil in System.IO.Directory.GetFiles(dir, filt)) // Get Files In Folder
                        {
                           
                            if (fil != null && !System.IO.Path.GetFileName(fil).StartsWith("(_)"))
                            {
                                // If  Then GoTo n    ' MessageBox.Show(file)
                                // If Not File.Exists(fil) Then Exit For
                                SmallImageList.Images.Add(fil, addImage(fil, dir));
                                // iltDesktopIcons.Images.Add(addImage(file, activeDir))
                                // AddImages(file, iltDesktopIcons) 'Add Icons
                                // If Not File.Exists(fil) Then Exit For                            
                                if (ViewType == ExplorerType.ControlPanel)
                                    Items.Add(System.Diagnostics.FileVersionInfo.GetVersionInfo(fil).ProductName, fil);
                                else
                                    Items.Add(System.IO.Path.GetFileName(fil), fil); // 'MyItems.Add(fil.Substring(fil.LastIndexOf("\"c) + 1), fil.ToString()) 'Add Files & File Properties To ListView     Add Files & File Properties To ListView 
                                Items[Items.Count - 1].SubItems.Add(((new FileInfo(fil)).Length / FileSizeType.GetHashCode()) + " " + FileSizeType.ToString());
                                Items[Items.Count - 1].Tag = fil;
                                Items[Items.Count - 1].ImageKey = fil;
                                Items[Items.Count - 1].ImageIndex = Items.Count - 1;
                                Items[Items.Count - 1].SubItems.Add(System.IO.File.GetLastWriteTime(fil).ToString());
                                //Items[SubItemIndex].SubItems.Add(getExtension(fil));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                if (OnErrorGoToParentDirectory)
                    UpDirectory();
            }
        }
        public void RefreshFolder(ref string Dir)
        {
            Directory = Dir;
        }
        private void RefreshImage(String source)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
            if (wallMode == ImageLayout.Tile)
            {
                base.BackgroundImage = com.prepareImage((Bitmap)Wallpaper, true);//base.BackColor
                base.BackgroundImageTiled = true;
            }
            else
            {
            Console.WriteLine(wallMode + source);
                base.BackgroundImageTiled = false;
                base.BackgroundImage = updateBackground(ref pat,ref wall,wallMode,base.Size, BackColor);
            }
        }
        public String Root
        {
            set {
               if (value == "" || value ==null)
                    value = System.IO.Path.GetPathRoot(Application.ExecutablePath);
                if (!value.EndsWith(@"\"))
                    value += @"\";
                rooted = value;
                if (AutoRefreshFolder) RefreshFolder();
            }
            get
            {
                return rooted;
            }
        }
        private String rooted;
        public struct SHFILEINFO // Contains information about a file object
        {
            public IntPtr hIcon;            // Icon
            public int iIcon;           // Icondex
            public int dwAttributes;    // SFGAO_ flags
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, SHFILEINFO psfi, int cbFileInfo, int uFlags); // Retrieves information about an object in the file system, such as a file, folder, directory, or drive root
        public enum SizeType
        {
            Bytes = 1,
            KiloBytes = 1024,
            MegaBytes = 1048576,
            GigaBytes = 1073741824
        }
        public static Bitmap updateBackground(ref Bitmap imgPattern, ref Bitmap imgWallpaper, ImageLayout wallpaperMode, Size imgSize, Color backgroundCol)
        {
            Bitmap bmp = new Bitmap(imgSize.Width, imgSize.Height);
            int imgH = imgWallpaper.Height, imgW = imgWallpaper.Width;
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(backgroundCol), 0, 0, imgSize.Width, imgSize.Height);
            //    if (((imgWallpaper != null)) && wallpaperMode == ImageLayout.Tile)
            //    {
            //        // If Not imgpattern.Height = 8 OrElse Not imgpattern.Width = 8 Then imgpattern = New Bitmap(imgpattern, 8, 8)
            //        for (int x = 0; x <= imgSize.Width; x += imgWallpaper.Width)
            //        {
            //            for (int y = 0; y <= imgSize.Height; y += imgWallpaper.Height)
            //                g.DrawImage(imgWallpaper, x, y, imgWallpaper.Width, imgWallpaper.Height);
            //        }
            //    }
            if (wallpaperMode == ImageLayout.Center) g.FillRectangle(new TextureBrush(imgPattern), new Rectangle(0, 0, imgSize.Width, imgSize.Height));
        //   {
        //       for (int x = 0; x <= imgSize.Width; x += imgW)
        //       {
        //           for (int y = 0; y <= imgSize.Height; y += imgH)
        //               g.DrawImage(imgPattern, x, y);
        //       }
        //   }
                if (wallpaperMode == ImageLayout.Center)
                {
                    //Console.WriteLine(imgH + ',' + imgW);
                    g.DrawImage(imgWallpaper, new Rectangle(Convert.ToInt32((imgSize.Width / (double)2) - (imgW / (double)2)), Convert.ToInt32((imgSize.Height / (double)2) - (imgH / (double)2)),imgW,imgH));
                }
            return bmp;
        }
        public Boolean UpdateDesktop { get { return upDesk; } set { upDesk = value; if (value) RefreshImage("Update"); } }
        private Boolean upDesk = false;
        public void UpDirectory()
        {
            if (dir != rooted)
                Directory = new DirectoryInfo(dir).Parent.FullName;
            else
                AutoRefreshFolder = false;
        }
        public ExplorerType ViewType { get; set; } = ExplorerType.General;
        private Bitmap wall = new Bitmap(1, 1);
        public Bitmap Wallpaper { get { return wall; } set {wall = value; if (upDesk) RefreshImage("Wall"); } }
        public ImageLayout WallpaperLayout { get { return wallMode; } set { wallMode = value; if (upDesk) RefreshImage("WallLayout"); } }
        private ImageLayout wallMode = ImageLayout.None;
    }
    public class ShortCut {  //http://csharphelper.com/blog/2018/06/get-information-about-windows-shortcuts-in-c/
        Shell32.ShellLinkObject lnk;
        ConfigHelper conLNK;
        public ShortCut(String lnkLocation)
        {
            Shell32.FolderItem fil = (new Shell32.Shell()).NameSpace(Path.GetDirectoryName(lnkLocation)).Items().Item(Path.GetFileName(lnkLocation));
         // if (fil.IsLink)
         // {
         //     Console.WriteLine(lnkLocation);
         //     lnk = (Shell32.ShellLinkObject)fil.GetLink;
         //     lType = lnkType.Windows;
         //
         // }else
            {
                conLNK = new ConfigHelper(lnkLocation);
                lType = lnkType.ProjectI2padams;
            }
        }
        public String TargetFile {
            set {
                if (lType == lnkType.Windows) { lnk.Path = value; Save(); } else conLNK.SetConfig("Shortcut","Target",value);

            } get {
                if (lType == lnkType.Windows) return lnk.Path; else return conLNK.GetConfig("Shortcut", "Target").Setting;
            } }
        public void Save()
        {
          if (lType==lnkType.Windows)  lnk.Save();
        }
        private lnkType lType;
        public enum lnkType
        {
            Windows,ProjectI2padams
        }
        public lnkType ShortcutType { get { return lType; } }
        private void GetShortcutInfo(String full_name)
        {
        //    name = "";
        //    path = "";
        //    descr = "";
        //    working_dir = "";
        //    args = "";
            try
            {
                // Make a Shell object.
                Shell32.Shell shell = new Shell32.Shell();

                // Get the shortcut's folder and name.
                //     string shortcut_path = full_name.Substring(0, full_name.LastIndexOf("\\"));
                String shortcut_name = Path.GetFileName(full_name);
          //     if (!shortcut_name.EndsWith(".lnk"))  shortcut_name += ".lnk";

                // Get the shortcut's folder.
                //Shell32.Folder shortcut_folder =     shell.NameSpace(shortcut_path);
                // Get the shortcut's file.
             //   Shell32.FolderItem folder_item = shortcut_folder.Items().Item(shortcut_name);

          //     if (folder_item == null)  return "Cannot find shortcut file '" + full_name + "'";
          //     if (!folder_item.IsLink)  return "File '" + full_name + "' isn't a shortcut.";

                // Display the shortcut's information.
                Console.WriteLine(lnk.Path);
           //    name = folder_item.Name;
           //    descr = lnk.Description;
           //    path = lnk.Path;
           //    working_dir = lnk.WorkingDirectory;
           //    args = lnk.Arguments;
           //     return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
        }
    }
}
