using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProChic4._8
{
    class Panel_Item: libLeMS.Button
    {
        IntPtr appPtr;
        libLeMS.MasterClass com = new libLeMS.MasterClass();
        public Panel_Item(ref AppHolder app)
        {
            PictureBox pic = new PictureBox();
            Text = app.Text;
                BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(com.Config.GetConfigAsInt32("Taskbar", "ItemWidth"), com.Config.GetConfigAsInt32("Taskbar", "ItemHeight"));
            appPtr = app.ProcessHandle;
                Visible = true;
                pic.Location = new Point(6, (Height/2)-8);
                pic.Size = new Size(16, 16);
                if (app.programIcon.Image != null) pic.Image = new Bitmap(app.programIcon.Image, 16, 16);
            pic.SizeMode = PictureBoxSizeMode.Normal;
                //pic.BringToFront();
                Controls.Add(pic);
            this.Click += SingleClick;
                }
        private void SingleClick(Object sender, EventArgs e)
        {
            AppVisChange(appPtr);
        }
        public event AppHolder.AppHandler AppVisChange;
    }
    }
    