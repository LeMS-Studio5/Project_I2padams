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
            this.components = new System.ComponentModel.Container();
            this.elvDesktop = new libProChic.ExplorerListView();
            this.SuspendLayout();
            // 
            // elvDesktop
            // 
            this.elvDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elvDesktop.AutoRefreshFolder = false;
            this.elvDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elvDesktop.Directory = "C:\\Users\\Luke\\Desktop\\";
            this.elvDesktop.DisplayMode = libProChic.ExplorerListView.DisplayType.DirectoriesAndFiles;
            this.elvDesktop.FileSizeType = libProChic.ExplorerListView.SizeType.Bytes;
            this.elvDesktop.Filter = "*.*";
            this.elvDesktop.FollowPallet = false;
            this.elvDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elvDesktop.Location = new System.Drawing.Point(0, 0);
            this.elvDesktop.Name = "elvDesktop";
            this.elvDesktop.OnErrorGoToParentDirectory = false;
            this.elvDesktop.OwnerDraw = true;
            this.elvDesktop.Root = "C:\\";
            this.elvDesktop.SelectedColor = System.Drawing.Color.Empty;
            this.elvDesktop.SelectedTextColor = System.Drawing.Color.Empty;
            this.elvDesktop.Size = new System.Drawing.Size(640, 435);
            this.elvDesktop.TabIndex = 0;
            this.elvDesktop.UseCompatibleStateImageBehavior = false;
            this.elvDesktop.ViewType = libProChic.ExplorerListView.ExplorerType.Desktop;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.elvDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private libProChic.ExplorerListView elvDesktop;
    }
}

