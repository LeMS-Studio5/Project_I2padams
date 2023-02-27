using libLeMS;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.panTaskBar = new System.Windows.Forms.Panel();
            this.btnAppLauncher = new libLeMS.Button();
            this.elvDesktop = new libLeMS.ExplorerListView();
            this.panAppLaunch = new System.Windows.Forms.Panel();
            this.menAppLaunch = new MenuStrip();
            this.picAppLaunch = new System.Windows.Forms.PictureBox();
            this.panTaskBar.SuspendLayout();
            this.panAppLaunch.SuspendLayout();
            this.menAppLaunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTaskBar
            // 
            this.panTaskBar.Controls.Add(this.btnAppLauncher);
            this.panTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTaskBar.Location = new System.Drawing.Point(0, 380);
            this.panTaskBar.Name = "panTaskBar";
            this.panTaskBar.Size = new System.Drawing.Size(640, 100);
            this.panTaskBar.TabIndex = 1;
            // 
            // btnAppLauncher
            // 
            this.btnAppLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAppLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppLauncher.Held = false;
            this.btnAppLauncher.HoldOnPush = false;
            this.btnAppLauncher.Location = new System.Drawing.Point(155, 55);
            this.btnAppLauncher.Name = "btnAppLauncher";
            this.btnAppLauncher.ShowFocusRectangle = true;
            this.btnAppLauncher.Size = new System.Drawing.Size(75, 23);
            this.btnAppLauncher.TabIndex = 2;
            this.btnAppLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppLauncher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppLauncher.UseVisualStyleBackColor = false;
            this.btnAppLauncher.Click += AppLauncherToggle;
            // 
            // elvDesktop
            // 
            this.elvDesktop.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.elvDesktop.AutoRefreshFolder = true;
            this.elvDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elvDesktop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elvDesktop.Directory = "";
            this.elvDesktop.DisplayMode = libLeMS.ExplorerListView.DisplayType.DirectoriesAndFiles;
            this.elvDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elvDesktop.FileSizeType = libLeMS.ExplorerListView.SizeType.Bytes;
            this.elvDesktop.Filter = "*.*";
            this.elvDesktop.FollowPallet = true;
            this.elvDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elvDesktop.GridLines = true;
            this.elvDesktop.Location = new System.Drawing.Point(0, 0);
            this.elvDesktop.Name = "elvDesktop";
            this.elvDesktop.OnErrorGoToParentDirectory = false;
            this.elvDesktop.OSIconLocationPath = "";
            this.elvDesktop.OwnerDraw = true;
            this.elvDesktop.Pattern = ((System.Drawing.Bitmap)(resources.GetObject("elvDesktop.Pattern")));
            this.elvDesktop.Root = "C:\\";
            this.elvDesktop.Size = new System.Drawing.Size(640, 480);
            this.elvDesktop.TabIndex = 0;
            this.elvDesktop.UpdateDesktop = false;
            this.elvDesktop.UseCompatibleStateImageBehavior = false;
            this.elvDesktop.View = System.Windows.Forms.View.SmallIcon;
            this.elvDesktop.ViewType = libLeMS.ExplorerListView.ExplorerType.Desktop;
            this.elvDesktop.Wallpaper = ((System.Drawing.Bitmap)(resources.GetObject("elvDesktop.Wallpaper")));
            this.elvDesktop.WallpaperLayout = System.Windows.Forms.ImageLayout.None;
            // 
            // panAppLaunch
            // 
            this.panAppLaunch.AutoSize = false;
            this.panAppLaunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panAppLaunch.Controls.Add(this.menAppLaunch);
            this.panAppLaunch.Controls.Add(this.picAppLaunch);
            this.panAppLaunch.Location = new System.Drawing.Point(0, 195);
            this.panAppLaunch.Name = "panAppLaunch";
            this.panAppLaunch.Size = new System.Drawing.Size(193, 179);
            this.panAppLaunch.TabIndex = 2;
            this.panAppLaunch.Visible = false;
            // 
            // menAppLaunch
            // 
            this.picAppLaunch.Dock = System.Windows.Forms.DockStyle.Right;
            this.menAppLaunch.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            //this.menAppLaunch.Items.Add(tsmiRoot);
            this.menAppLaunch.Location = new System.Drawing.Point(0, 0);
            this.menAppLaunch.Name = "menAppLaunch";
            this.menAppLaunch.Size = new System.Drawing.Size(193, 44);
            this.menAppLaunch.TabIndex = 0;
            this.menAppLaunch.Text = "menAppLaunch";
            // 
            // picAppLaunch
            // 
            this.picAppLaunch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAppLaunch.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAppLaunch.Location = new System.Drawing.Point(0, 0);
            this.picAppLaunch.Name = "menAppLaunch";
            //this.picAppLaunch.Size = new System.Drawing.Size(193, 44);
            this.picAppLaunch.TabIndex = 0;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.panAppLaunch);
            this.Controls.Add(this.panTaskBar);
            this.Controls.Add(this.elvDesktop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menAppLaunch;
            this.Name = "Desktop";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panTaskBar.ResumeLayout(false);
            this.panAppLaunch.ResumeLayout(false);
            this.panAppLaunch.PerformLayout();
            this.menAppLaunch.ResumeLayout(false);
            this.menAppLaunch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private libLeMS.ExplorerListView elvDesktop;
        private System.Windows.Forms.Panel panTaskBar;
        private libLeMS.Button btnAppLauncher;
        private System.Windows.Forms.Panel panAppLaunch;
        private MenuStrip menAppLaunch;
        private System.Windows.Forms.PictureBox picAppLaunch;
    }
}

