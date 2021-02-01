namespace ProChic4._8
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            libProChic.ImageList imageList1 = new libProChic.ImageList();
            libProChic.ImageAlbum imageAlbum1 = new libProChic.ImageAlbum();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            libProChic.ImageList imageList2 = new libProChic.ImageList();
            libProChic.ImageAlbum imageAlbum2 = new libProChic.ImageAlbum();
            this.elvDesktop = new libProChic.ExplorerListView();
            this.panTaskBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // elvDesktop
            // 
            this.elvDesktop.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.elvDesktop.AutoRefreshFolder = true;
            this.elvDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elvDesktop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elvDesktop.Directory = "";
            this.elvDesktop.DisplayMode = libProChic.ExplorerListView.DisplayType.DirectoriesAndFiles;
            this.elvDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elvDesktop.FileSizeType = libProChic.ExplorerListView.SizeType.Bytes;
            this.elvDesktop.Filter = "*.*";
            this.elvDesktop.FollowPallet = true;
            this.elvDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elvDesktop.GridLines = true;
            imageList1.Images = imageAlbum1;
            this.elvDesktop.LargeImageList = imageList1;
            this.elvDesktop.Location = new System.Drawing.Point(0, 0);
            this.elvDesktop.Name = "elvDesktop";
            this.elvDesktop.OnErrorGoToParentDirectory = false;
            this.elvDesktop.OSIconLocationPath = "";
            this.elvDesktop.OwnerDraw = true;
            this.elvDesktop.Pattern = ((System.Drawing.Bitmap)(resources.GetObject("elvDesktop.Pattern")));
            this.elvDesktop.Root = "C:\\";
            this.elvDesktop.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.elvDesktop.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elvDesktop.Size = new System.Drawing.Size(640, 480);
            imageList2.Images = imageAlbum2;
            this.elvDesktop.SmallImageList = imageList2;
            this.elvDesktop.TabIndex = 0;
            this.elvDesktop.UpdateDesktop = false;
            this.elvDesktop.UseCompatibleStateImageBehavior = false;
            this.elvDesktop.View = System.Windows.Forms.View.SmallIcon;
            this.elvDesktop.ViewType = libProChic.ExplorerListView.ExplorerType.Desktop;
            this.elvDesktop.Wallpaper = ((System.Drawing.Bitmap)(resources.GetObject("elvDesktop.Wallpaper")));
            this.elvDesktop.WallpaperLayout = System.Windows.Forms.ImageLayout.None;
            // 
            // panTaskBar
            // 
            this.panTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTaskBar.Location = new System.Drawing.Point(0, 380);
            this.panTaskBar.Name = "panTaskBar";
            this.panTaskBar.Size = new System.Drawing.Size(640, 100);
            this.panTaskBar.TabIndex = 1;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.panTaskBar);
            this.Controls.Add(this.elvDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private libProChic.ExplorerListView elvDesktop;
        private System.Windows.Forms.Panel panTaskBar;
    }
}

