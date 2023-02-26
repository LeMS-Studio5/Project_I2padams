using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libLeMS;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ProChic4._8
{
    class AppHolder : Shell
    {
        private Rectangle siz = new Rectangle();
        private MasterClass com = new MasterClass();
        private Process pro;
        public AppHolder(String exePath, String arguments) : base()
        {
            if (!IsDotNetProcess(exePath))
            {
                Console.WriteLine(exePath + " is not a compatable program");
                Dispose();
                return;
            }
            ProcessStartInfo info = new ProcessStartInfo(exePath, arguments);
            try
            {
                info.UseShellExecute = false;
                info.CreateNoWindow = true;
                info.RedirectStandardInput = false;
                info.RedirectStandardOutput = true;
                info.RedirectStandardError = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                pro = Process.Start(info);
                pro.WaitForInputIdle();
                pro.Exited += Exited;
                while (pro.MainWindowHandle == null || pro.MainWindowHandle == IntPtr.Zero) ;
                SetParent(pro.MainWindowHandle, GuestArea.Handle);
                do {
                    GetClientRect(pro.MainWindowHandle, ref siz);
                } while (siz.Width == 0 && siz.Height == 0);
                // WS_POPUP style and add WS_CHILD style
                const UInt32 WS_POPUP = 0x80000000, WS_CHILD = 0x40000000;
                uint style = (UInt32)GetWindowLong(pro.MainWindowHandle, -16);
                //style = (style & ~(WS_POPUP)) | WS_CHILD;
                SetWindowLong(pro.MainWindowHandle, -16, style);
        //int GWL_STYLE = (-16);
        //uint WS_VISIBLE = 0x10000000;
                //SetWindowLong(pro.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                MoveWindow(pro.MainWindowHandle, 0, 0, siz.Width, siz.Height, true);
                Size = new Size(siz.Width + lefts.Width + rights.Width, siz.Height + programtopbar.Height + bottoms.Height + 0);
                this.Maximise += Max;
                this.DoubleBuffered = true;
                base.Resize += resizing;
                this.Closing += Exited;
                //info.WindowStyle = ProcessWindowStyle.Hidden

                //    do {
                //        //ProjectChicagoObjects.modCommunication.Nap(400, false)
                //        SetParent(pro.MainWindowHandle, GuestArea.Handle);
                //        GetClientRect(pro.MainWindowHandle, ref siz);
                //    // MessageBox.Show(siz.ToString)
                //    //    Console.WriteLine(siz)
                //    }while ( siz.Width == 0 && siz.Height == 0);
                //    //  Console.WriteLine("c")
                //    pro.BeginOutputReadLine();
                //MessageBox.Show(Graphics.FromHwnd(pro.MainWindowHandle).DpiX & "," & Graphics.FromHwnd(pro.MainWindowHandle).DpiY)
                //Size = new Size(siz.Width + lefts.Width + rights.Width, siz.Height + programtopbar.Height + bottoms.Height + 0); //Graphics.FromHwnd(pro.MainWindowHandle).DpiX, Graphics.FromHwnd(pro.MainWindowHandle).DpiY)             REMOVE EXTRAS AND SEE IF IT WORKS
                // SetWindowPos(pro.MainWindowHandle, 0, panGuestMod.PointToScreen(panGuestMod.Location).X, panGuestMod.PointToScreen(panGuestMod.Location).Y, panGuestMod.Width, panGuestMod.Height, 64) //MoveWindow(pro.MainWindowHandle, panGuestMod.PointToScreen(panGuestMod.Location).X, panGuestMod.PointToScreen(panGuestMod.Location).Y, panGuestMod.Width, panGuestMod.Height, true)
                //   Console.WriteLine("Title")
                Text = pro.MainWindowTitle;
                TsudaKageyu.IconExtractor i = new TsudaKageyu.IconExtractor(pro.StartInfo.FileName);
                // in
                if (i.Count > 0) programIcon.Image = new Bitmap(i.GetIcon(i.Count - 1).ToBitmap(), 16, 16); else programIcon.Image = new Bitmap(com.prepareImage(com.toSystemPath(com.Config.GetConfig("windows", "GenericAppIco").Setting)), 16, 16); // New TsudaKageyu.IconUtil //pro.StartInfo.FileName).ToBitmap
                 }
            catch (Exception ex) {
                Debug.WriteLine(ex.ToString());
            }
        }
        private void Exited (Object sender, EventArgs e)
        {
            AppClose(pro.MainWindowHandle);
            pro.Close();
        }
        public event AppHandler AppClose;
        public delegate void AppHandler(IntPtr Apphandler);
        public IntPtr ProcessHandle { get { return pro.MainWindowHandle; } }
        private void resizing (Object sender, EventArgs e)
        {
            MoveWindow(pro.MainWindowHandle, 0, 0, Size.Width-lefts.Width-rights.Width, Size.Height-programtopbar.Height-bottoms.Height, true);
        }
        public void Max(Object Sender, EventArgs e) {
            if (!maximize) {
                this.mexlocation = this.Location.X;
                this.meylocation = this.Location.Y;
                this.mewidth = this.Width;
                this.meheight = this.Height;
                //  this.toprightcorner.Hide()
                //  this.topleftcorner.Hide()
                //  this.bottomrightcorner.Hide()
                //  this.bottomleftcorner.Hide()
                //  this.lefts.Hide()
                //  this.tops.Hide()
                //  this.bottoms.Hide()
                //this.rights.Hide()
                Int32 w = Parent.Width, h = Parent.Height-(int.Parse(com.Config.GetConfig("Taskbar", "Height").Setting));
                this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
                this.moveable = false;
                //this.maximizebutton.tag = "4"
                this.maximize = true;
        }else{
                this.toprightcorner.Show();
                this.topleftcorner.Show();
                this.bottomrightcorner.Show();
                this.bottomleftcorner.Show();
                this.lefts.Show();
                this.tops.Show();
                this.bottoms.Show();
                this.rights.Show();
            this.Location = new Point(this.mexlocation, this.meylocation);
            this.Size = new Size(this.mewidth, this.meheight);
                this.moveable = true;
                //this.maximizebutton.tag = "6"
                this.maximize = false; } }
        public static bool IsDotNetProcess(string absolutePath)
        {
            try
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.LoadFile(absolutePath);
                // a.
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr HWND, ref Rectangle LPRECT);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern Int32 apiAttachThreadInput(Int32 idThreadAttach, Int32 idThreadAttachTo, Int32 fAttach);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
    }
}