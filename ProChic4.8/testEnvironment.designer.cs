namespace ProChic4._8
{
    partial class TestEnvironment
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.lvwIcons = new ProChic4._8.IconListView();
            this.btnSaveAsIco = new System.Windows.Forms.Button();
            this.saveIcoDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAsPng = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.iconPickerDialog = new ProChic4._8.IconPickerDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saufleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(110, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(911, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Location = new System.Drawing.Point(12, 13);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(92, 21);
            this.btnSelectIcon.TabIndex = 0;
            this.btnSelectIcon.Text = "Select Icon...";
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // lvwIcons
            // 
            this.lvwIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwIcons.BackgroundImageTiled = true;
            this.lvwIcons.Location = new System.Drawing.Point(12, 40);
            this.lvwIcons.MultiSelect = false;
            this.lvwIcons.Name = "lvwIcons";
            this.lvwIcons.OwnerDraw = true;
            this.lvwIcons.Size = new System.Drawing.Size(599, 315);
            this.lvwIcons.TabIndex = 2;
            this.lvwIcons.TileSize = new System.Drawing.Size(132, 130);
            this.lvwIcons.UseCompatibleStateImageBehavior = false;
            this.lvwIcons.View = System.Windows.Forms.View.Tile;
            // 
            // btnSaveAsIco
            // 
            this.btnSaveAsIco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAsIco.Location = new System.Drawing.Point(705, 362);
            this.btnSaveAsIco.Name = "btnSaveAsIco";
            this.btnSaveAsIco.Size = new System.Drawing.Size(155, 25);
            this.btnSaveAsIco.TabIndex = 4;
            this.btnSaveAsIco.Text = "Save as Single .ico...";
            this.btnSaveAsIco.UseVisualStyleBackColor = true;
            this.btnSaveAsIco.Click += new System.EventHandler(this.btnSaveAsIco_Click);
            // 
            // saveIcoDialog
            // 
            this.saveIcoDialog.Filter = "Icon files|*.ico";
            // 
            // btnSaveAsPng
            // 
            this.btnSaveAsPng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAsPng.Location = new System.Drawing.Point(866, 362);
            this.btnSaveAsPng.Name = "btnSaveAsPng";
            this.btnSaveAsPng.Size = new System.Drawing.Size(155, 25);
            this.btnSaveAsPng.TabIndex = 5;
            this.btnSaveAsPng.Text = "Save as Multiple .png...";
            this.btnSaveAsPng.UseVisualStyleBackColor = true;
            this.btnSaveAsPng.Click += new System.EventHandler(this.btnSaveAsPng_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(618, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 315);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lukeToolStripMenuItem,
            this.saufleyToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(98, 315);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lukeToolStripMenuItem
            // 
            this.lukeToolStripMenuItem.Image = global::ProChic4._8.Properties.Resources.app;
            this.lukeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lukeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lukeToolStripMenuItem.Name = "lukeToolStripMenuItem";
            this.lukeToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.lukeToolStripMenuItem.Text = "Luke";
            this.lukeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saufleyToolStripMenuItem
            // 
            this.saufleyToolStripMenuItem.Name = "saufleyToolStripMenuItem";
            this.saufleyToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.saufleyToolStripMenuItem.Text = "Saufley";
            // 
            // TestEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveAsPng);
            this.Controls.Add(this.btnSaveAsIco);
            this.Controls.Add(this.lvwIcons);
            this.Controls.Add(this.btnSelectIcon);
            this.Controls.Add(this.txtFileName);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 430);
            this.Name = "TestEnvironment";
            this.Text = "Test Environment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IconPickerDialog iconPickerDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectIcon;
        private IconListView lvwIcons;
        private System.Windows.Forms.Button btnSaveAsIco;
        private System.Windows.Forms.SaveFileDialog saveIcoDialog;
        private System.Windows.Forms.Button btnSaveAsPng;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lukeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saufleyToolStripMenuItem;
    }
}

