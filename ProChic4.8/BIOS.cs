using libLeMS;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace ProChic4._8{
    public partial class BIOS : Form{
        private MasterClass com = new MasterClass();
        public BIOS() {
            InitializeComponent();
            Taskbar.Hide();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateResources("*.dll");
                UpdateResources("*.exe");
                Desktop d = new Desktop();
                this.Hide();
                DialogResult result = d.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Debug.WriteLine("Closed");
                    d = null;
                    Taskbar.Show();
                    Environment.Exit(Environment.ExitCode);
                }
                else if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void UpdateResources(String ext)
        {
            foreach (String exe in Directory.GetFiles(com.toSystemPath(@"C:\"), ext, SearchOption.AllDirectories))
            {
                foreach (String search in Directory.GetFiles(new FileInfo(Application.ExecutablePath).Directory.Parent.Parent.Parent.FullName, Path.GetFileName(exe), SearchOption.AllDirectories))
                {
                    if ((new FileInfo(exe)).LastWriteTime.ToFileTime() < (new FileInfo(search)).LastWriteTime.ToFileTime() && !search.Contains("dev") && !search.Contains(@"\obj\"))
                    {
                        Debug.WriteLine(Path.GetFileName(exe) + " has been updated");
                        File.Copy(search, exe, true);
                    }
                }
            }
        }
    }
    public class Taskbar
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetDesktopWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        protected static int Handle
        {
            get
            {
                return FindWindow("Shell_TrayWnd", "");
            }
        }

        protected static int HandleOfStartButton
        {
            get
            {
                int handleOfDesktop = GetDesktopWindow();
                int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                return handleOfStartButton;
            }
        }

        private Taskbar()
        {
            // hide ctor
        }

        public static void Show()
        {
            ShowWindow(Handle, SW_SHOW);
            ShowWindow(HandleOfStartButton, SW_SHOW);
        }

        public static void Hide()
        {
            ShowWindow(Handle, SW_HIDE);
            ShowWindow(HandleOfStartButton, SW_HIDE);
        }
    }   //Code from https://stackoverflow.com/questions/19022789/hide-taskbar-in-winforms-application/19024531#19024531
}
