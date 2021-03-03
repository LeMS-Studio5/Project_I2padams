using libProChic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProChic4._8
{
    public partial class BIOS : Form
    {
        private MasterClass com = new MasterClass();
        public BIOS()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateResources("*.dll");
                UpdateResources("*.exe");
                Desktop d = new Desktop();
                //if (this.InvokeRequired)
                //{
                //    this.Invoke((MethodInvoker)delegate
                //    {
                //        d.Show();
                //        this.Hide();
                //    });
                //}
                //else
                //{
                //    d.Show();
                //    this.Hide();
                //}
                d.Show();
                d.startThreads();
                this.Hide();
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
}
