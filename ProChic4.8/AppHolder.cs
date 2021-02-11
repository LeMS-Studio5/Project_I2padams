using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libProChic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ProChic4._8
{
    class AppHolder: ProI2padamsShell
    {
        private Rectangle siz = new Rectangle();
        private MasterClass com = new MasterClass();
        private Process pro;
        public AppHolder(String exePath, String arguments):base()
        {
            ProcessStartInfo info = new ProcessStartInfo(exePath, arguments);
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardInput = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = false;
            //info.WindowStyle = ProcessWindowStyle.Hidden
            try
            {
                pro = Process.Start(info);
            if (!IsDotNetProcess(exePath))
                {// If Not IsDotNetProcess(pro) Then
                    Console.WriteLine(pro.MainWindowTitle + " is not a compatable program");
                    pro.Close();
                    Dispose();
                    return;
                }
                //   Console.WriteLine(info.FileName)
                //ProjectChicagoObjects.modCommunication.Nap(500, false)
                do
                {

                } while (pro.MainWindowHandle == null || pro.MainWindowHandle == IntPtr.Zero);
            //   Console.WriteLine("d")
            // MessageBox.Show("d")
                do {
                    //ProjectChicagoObjects.modCommunication.Nap(400, false)
                    SetParent(pro.MainWindowHandle, GuestArea.Handle);
                    GetClientRect(pro.MainWindowHandle, ref siz);
                // MessageBox.Show(siz.ToString)
                //    Console.WriteLine(siz)
                }while ( siz.Width == 0 && siz.Height == 0);
                //  Console.WriteLine("c")
                pro.BeginOutputReadLine();
            //MessageBox.Show(Graphics.FromHwnd(pro.MainWindowHandle).DpiX & "," & Graphics.FromHwnd(pro.MainWindowHandle).DpiY)
            Size = new Size(siz.Width + lefts.Width + rights.Width, siz.Height + programtopbar.Height + bottoms.Height + 0); //Graphics.FromHwnd(pro.MainWindowHandle).DpiX, Graphics.FromHwnd(pro.MainWindowHandle).DpiY)             REMOVE EXTRAS AND SEE IF IT WORKS
            // SetWindowPos(pro.MainWindowHandle, 0, panGuestMod.PointToScreen(panGuestMod.Location).X, panGuestMod.PointToScreen(panGuestMod.Location).Y, panGuestMod.Width, panGuestMod.Height, 64) //MoveWindow(pro.MainWindowHandle, panGuestMod.PointToScreen(panGuestMod.Location).X, panGuestMod.PointToScreen(panGuestMod.Location).Y, panGuestMod.Width, panGuestMod.Height, true)
            //   Console.WriteLine("Title")
                Text = pro.MainWindowTitle;
                TsudaKageyu.IconExtractor i = new TsudaKageyu.IconExtractor(pro.StartInfo.FileName);
            // in
            if (i.Count > 0) programIcon.Image = new Bitmap(i.GetIcon(i.Count - 1).ToBitmap(), 16, 16); else programIcon.Image = new Bitmap(com.prepareImage(com.toSystemPath(com.Config.GetConfig("Desktop", "GenericAppIco").Setting)), 16, 16); // New TsudaKageyu.IconUtil //pro.StartInfo.FileName).ToBitmap
            this.Tag = pro.Id;
            this.AccessibleName = exePath;
            SetParent(pro.MainWindowHandle, GuestArea.Handle);
            // pro.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            //  Console.WriteLine("Finished")
            //timCmdBuild.Start();//    //look       Console.WriteLine(closebutton.Height)
        }catch(Exception ex){
                Console.WriteLine(ex.ToString());
        }
        }
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
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr HWND, ref Rectangle LPRECT);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

    }
}
