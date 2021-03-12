using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TsudaKageyu;

namespace ProChic4._8
{
    public partial class TestEnvironment : Form
    {
        IconExtractor m_iconExtractor = null;
        int m_iconIndex = 0;

        public TestEnvironment()
        {
            InitializeComponent();
        }

        private void ClearAllIcons()
        {
            foreach (var item in lvwIcons.Items)
                ((IconListViewItem)item).Bitmap.Dispose();

            lvwIcons.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearAllIcons();
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            var result = iconPickerDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileName = iconPickerDialog.FileName;
                m_iconIndex = iconPickerDialog.IconIndex;

                Icon icon = null;
                Icon[] splitIcons = null;
                try
                {
                    if (Path.GetExtension(iconPickerDialog.FileName).ToLower() == ".ico")
                    {
                        m_iconExtractor = null;
                        icon = new Icon(iconPickerDialog.FileName);
                    }
                    else
                    {
                        m_iconExtractor = new IconExtractor(fileName);
                        icon = m_iconExtractor.GetIcon(m_iconIndex);
                    }

                    splitIcons = IconUtil.Split(icon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtFileName.Text = String.Format(
                    "{0}, #{1}, {2} variations", fileName, m_iconIndex, splitIcons.Length);

                // Update icons.

                Icon = icon;
                icon.Dispose();

                lvwIcons.BeginUpdate();
                ClearAllIcons();
                int it = 0;
                foreach (var i in splitIcons)
                {
                    var item = new IconListViewItem();
                    var size = i.Size;
                    item.BitCount = IconUtil.GetBitCount(i);
                    item.Bitmap = IconUtil.ToBitmap(i);
                    item.ToolTipText = String.Format("{0}x{1}, {2} bits" + "," + it, size.Width, size.Height, item.BitCount);

                    i.Dispose();

                    lvwIcons.Items.Add(item);
                    it++;
                }

                lvwIcons.EndUpdate();

                btnSaveAsIco.Enabled = (m_iconExtractor != null);
            }
        }

        private void btnSaveAsIco_Click(object sender, EventArgs e)
        {
            var result = saveIcoDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                using (var fs = File.OpenWrite(saveIcoDialog.FileName))
                {
                    m_iconExtractor.Save(m_iconIndex, fs);
                }
            }
        }

        private void btnSaveAsPng_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                int count = lvwIcons.Items.Count;
                for (int i = 0; i < count; ++i)
                {
                    var item = (IconListViewItem)lvwIcons.Items[i];
                    var fileName = String.Format(
                        "{0}x{1}, {2} bits.png", item.Bitmap.Width, item.Bitmap.Height, item.BitCount);

                    fileName = Path.Combine(folderBrowserDialog.SelectedPath, fileName);

                    item.Bitmap.Save(fileName);
                }
            }
        }
        private Byte[] readFirstBytes(String fileName, int numOfBytes)
        {//https://stackoverflow.com/questions/3441338/how-do-i-hash-first-n-bytes-of-a-file
            var sha1 = SHA1Managed.Create();
            FileStream fs = new FileStream(fileName, FileMode.Open);
            using (var cs = new CryptoStream(fs, sha1, CryptoStreamMode.Read))
            {
                byte[] buf = new byte[16];
                int bytesRead = cs.Read(buf, 0, buf.Length);
                long totalBytesRead = bytesRead;
                while (bytesRead > 0 && totalBytesRead <= numOfBytes)//maxBytesToHash
                {
                    bytesRead = cs.Read(buf, 0, buf.Length);
                    totalBytesRead += bytesRead;
                }
            }
            return sha1.Hash;
        }
    }
    internal class IconListView : ListView
    {
        public IconListView() : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw, true);

            OwnerDraw = true;
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            base.OnDrawItem(e);

            var item = e.Item as IconListViewItem;

            // Draw item

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.Clip = new Region(e.Bounds);

            if (e.Item.Selected)
                e.Graphics.FillRectangle(SystemBrushes.MenuHighlight, e.Bounds);

            int w = Math.Min(128, item.Bitmap.Width);
            int h = Math.Min(128, item.Bitmap.Height);

            int x = e.Bounds.X + (e.Bounds.Width - w) / 2;
            int y = e.Bounds.Y + (e.Bounds.Height - h) / 2;
            var dstRect = new Rectangle(x, y, w, h);
            var srcRect = new Rectangle(Point.Empty, item.Bitmap.Size);

            e.Graphics.DrawImage(item.Bitmap, dstRect, srcRect, GraphicsUnit.Pixel);

            var textRect = new Rectangle(
                e.Bounds.Left, e.Bounds.Bottom - Font.Height - 4,
                e.Bounds.Width, Font.Height + 2);
            TextRenderer.DrawText(e.Graphics, item.ToolTipText, Font, textRect, ForeColor);

            e.Graphics.Clip = new Region();
            e.Graphics.DrawRectangle(SystemPens.ControlLight, e.Bounds);
        }
    }

    internal class IconListViewItem : ListViewItem
    {
        public Bitmap Bitmap { get; set; }
        public int BitCount { get; set; }
    }
    public class IconPickerDialog : CommonDialog
    {
        private static class NativeMethods
        {
            [DllImport("shell32.dll", EntryPoint = "#62", CharSet = CharSet.Unicode, SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            public static extern bool SHPickIconDialog(
                IntPtr hWnd, StringBuilder pszFilename, int cchFilenameMax, out int pnIconIndex);
        }

        private const int MAX_PATH = 260;

        [DefaultValue(default(string))]
        public string FileName
        {
            get;
            set;
        }

        [DefaultValue(0)]
        public int IconIndex
        {
            get;
            set;
        }

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            var buf = new StringBuilder(FileName, MAX_PATH);
            int index;

            bool ok = NativeMethods.SHPickIconDialog(hwndOwner, buf, MAX_PATH, out index);
            if (ok)
            {
                FileName = Environment.ExpandEnvironmentVariables(buf.ToString());
                IconIndex = index;
            }

            return ok;
        }

        public override void Reset()
        {
            FileName = null;
            IconIndex = 0;
        }
    }
}
