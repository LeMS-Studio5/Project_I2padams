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
    public class ExplorerListView : ListView
    {
        private System.ComponentModel.IContainer components;
        private MasterClass com = new MasterClass();
        private string dir="";
        public Image addImage(string strPath, string strCurrentDir){
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
                    if (File.ReadAllLines(strPath).Count() >= 4 && File.Exists(com.toSystemPath(System.IO.File.ReadAllLines(strPath)[3].Split('☼')[0])))
                        // Console.WriteLine(File.Exists("C:\Users\Luke\Documents\Visual Studio 2015\GitHub\LeMS-Studio5\ProjectChicago\win 95.ico")) 'm.toSystemPath(File.ReadAllLines(strPath)(3).Split("☼"c)(0)))) 'Console.WriteLine(m.toSystemPath("$" & File.ReadAllLines(strPath)(3)))
                        // Console.WriteLine(New IconExtractor("C:\Users\Luke\Documents\Visual Studio 2015\GitHub\LeMS-Studio5\ProjectChicago\win 95.ico").Count)
                        // strPath = File.ReadAllLines(strPath)(3).Split("☼"c)(0)
                        ink = TsudaKageyu.IconUtil.Split(new Icon(com.toSystemPath(File.ReadAllLines(strPath)[3].Split('☼')[0])))[int.Parse(File.ReadAllLines(strPath)[3].Split('☼')[1])].ToBitmap(); // ink = (New IconExtractor(m.toSystemPath(File.ReadAllLines(strPath)(3).Split("☼"c)(0)))).GetIcon(File.ReadAllLines(strPath)(3).Split("☼"c)(1)).ToBitmap
                    else if (File.Exists(File.ReadAllLines(strPath).First()))
                        strPath = File.ReadAllLines(strPath).First();
                    else
                        // MessageBox.Show("g")
                        strPath = com.toSystemPath(@"C:\") + File.ReadAllLines(strPath).First().ToCharArray();
                    // MessageBox.Show(strPath & ", " & File.Exists(strPath))
                    // If File.ReadAllLines(strFilPath).Count >= 5 Then Console.WriteLine(strFilPath & ((File.ReadAllLines(strFilPath)(4)))) ' = "Sys")))
                    if (ink.Width + ink.Height == 2)
                        ink = new Bitmap(addImage(strPath, ""), 32, 32);
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
                if ((OSIco != null) || OSIco.Count() < 1)
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
        public Boolean AutoRefreshFolder { get; set; } = false;
        public String Directory
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
                        if ( AutoRefreshFolder)//ViewType != ExplorerType.Simple &&
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
        private DisplayType display; // = DisplayType.DirectoriesAndFiles
        public DisplayType DisplayMode
        {
            set
            {
                display = value;
                // MessageBox.Show("Display")
                if (AutoRefreshFolder)//ViewType != ExplorerType.Simple && 
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
        private Image DriveIcon(string path){
            String dir = File.ReadAllLines(path + @"\(_)drive.info")[0];
            if (dir == "HD")
                return OSIco[8].ToBitmap();
            if (dir == "flp")
                return OSIco[6].ToBitmap();
            if (dir == "cd" || dir == "dvd")
                return OSIco[11].ToBitmap();
            return null;
        }
        public ExplorerListView() : base()
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
        public enum ExplorerType
        {
            Desktop,
            ControlPanel,
            General,
            Unlaunchable
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DoubleBuffered = true;
        }
        private ImageList iltLarge = new ImageList();
        public Boolean OnErrorGoToParentDirectory { get; set; } = false;
        private Icon[] OSIco;
        private string OSPath;
        public Icon[] OSIcons{
            get
            {
                return OSIco;
            }
        }
        public void RefreshFolder()
        {
            try
            {
                if ((base.Items != null)) base.Items.Clear();
                if (iltLarge != null) iltLarge.Images.Clear();
                if (System.IO.Directory.Exists(dir))
                {
                    int SubItemIndex = 0;
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
                                    iltLarge.Images.Add(fil, addImage(fil, dir));
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
                                    base.Items.Add(fil.Substring(fil.LastIndexOf('\\') + 1).Replace("‰", ":").Replace("ƒ", @"\"), fil); // Add Files & File Properties To ListView
                                    base.Items[SubItemIndex].ImageKey = fil;
                                    base.Items[SubItemIndex].SubItems.Add((intTotal / FileSizeType.GetHashCode()) + " " + FileSizeType.ToString());
                                    base.Items[SubItemIndex].SubItems.Add("File Folder");
                                    base.Items[SubItemIndex].Tag = fil;
                                    base.Items[SubItemIndex].SubItems.Add(System.IO.Directory.GetLastWriteTime(fil).ToString());
                                    SubItemIndex += 1;
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
                                iltLarge.Images.Add(fil, addImage(fil, dir));
                                // iltDesktopIcons.Images.Add(addImage(file, activeDir))
                                // AddImages(file, iltDesktopIcons) 'Add Icons
                                // If Not File.Exists(fil) Then Exit For                            
                                    if (ViewType == ExplorerType.ControlPanel)
                                        base.Items.Add(System.Diagnostics.FileVersionInfo.GetVersionInfo(fil).ProductName, fil);
                                    else
                                        base.Items.Add(System.IO.Path.GetFileName(fil), fil); // 'MyBase.Items.Add(fil.Substring(fil.LastIndexOf("\"c) + 1), fil.ToString()) 'Add Files & File Properties To ListView     Add Files & File Properties To ListView 
                                    base.Items[SubItemIndex].SubItems.Add(((new FileInfo(fil)).Length / FileSizeType.GetHashCode()) + " " + FileSizeType.ToString());
                                    //base.Items[SubItemIndex].SubItems.Add(getExtension(fil));
                                }
                                base.Items[SubItemIndex].Tag = fil;
                                base.Items[SubItemIndex].ImageKey = fil;
                                base.Items[SubItemIndex].SubItems.Add(System.IO.File.GetLastWriteTime(fil).ToString());
                                SubItemIndex += 1;
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
        public String Root{
            set{
                if (value == "" || value == null)  value = System.IO.Path.GetPathRoot(Application.ExecutablePath);
                if (!value.EndsWith(@"\"))  value += @"\";
                rooted = value;
                if (AutoRefreshFolder)   RefreshFolder();
            }
            get{
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
        public void UpDirectory()
        {
            if (dir != rooted)
                Directory = new DirectoryInfo(dir).Parent.FullName;
            else
                AutoRefreshFolder = false;
        }
        public ExplorerType ViewType { get; set; }
    }
}
