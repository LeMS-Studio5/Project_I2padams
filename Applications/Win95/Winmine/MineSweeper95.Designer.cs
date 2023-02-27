using libLeMS;

namespace WinMine
{
    partial class MineSweeper95 : System.Windows.Forms.Form
{

    // Form overrides dispose to clean up the component list.
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && (components != null))
                components.Dispose();
        }
        finally
        {
            base.Dispose(disposing);
        }
    }
public MineSweeper95()
        {
            InitializeComponent();
        }
    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip1 = new MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BeginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BestTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMinesweeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panGame = new System.Windows.Forms.Panel();
            this.spcBoard = new System.Windows.Forms.SplitContainer();
            this.picFace = new libLeMS.Button();
            this.lblTimer = new libLeMS.Label();
            this.lblBomb = new libLeMS.Label();
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1.SuspendLayout();
            this.panGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBoard)).BeginInit();
            this.spcBoard.Panel1.SuspendLayout();
            this.spcBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(167, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.ToolStripSeparator1,
            this.BeginnerToolStripMenuItem,
            this.IntermediateToolStripMenuItem,
            this.ExpertToolStripMenuItem,
            this.CustomToolStripMenuItem,
            this.ToolStripSeparator2,
            this.MarkToolStripMenuItem,
            this.ColorToolStripMenuItem,
            this.ToolStripSeparator4,
            this.BestTimesToolStripMenuItem,
            this.ToolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.GameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.GameToolStripMenuItem.Text = "&Game";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewToolStripMenuItem.Text = "&New";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // BeginnerToolStripMenuItem
            // 
            this.BeginnerToolStripMenuItem.CheckOnClick = true;
            this.BeginnerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem";
            this.BeginnerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BeginnerToolStripMenuItem.Tag = "0";
            this.BeginnerToolStripMenuItem.Text = "&Beginner";
            // 
            // IntermediateToolStripMenuItem
            // 
            this.IntermediateToolStripMenuItem.CheckOnClick = true;
            this.IntermediateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IntermediateToolStripMenuItem.Name = "IntermediateToolStripMenuItem";
            this.IntermediateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IntermediateToolStripMenuItem.Tag = "1";
            this.IntermediateToolStripMenuItem.Text = "&Intermediate";
            // 
            // ExpertToolStripMenuItem
            // 
            this.ExpertToolStripMenuItem.CheckOnClick = true;
            this.ExpertToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExpertToolStripMenuItem.Name = "ExpertToolStripMenuItem";
            this.ExpertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExpertToolStripMenuItem.Tag = "2";
            this.ExpertToolStripMenuItem.Text = "&Expert";
            // 
            // CustomToolStripMenuItem
            // 
            this.CustomToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem";
            this.CustomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomToolStripMenuItem.Tag = "3";
            this.CustomToolStripMenuItem.Text = "&Custom";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MarkToolStripMenuItem
            // 
            this.MarkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem";
            this.MarkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MarkToolStripMenuItem.Text = "&Mark (?)";
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ColorToolStripMenuItem.Text = "Co&lor";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // BestTimesToolStripMenuItem
            // 
            this.BestTimesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BestTimesToolStripMenuItem.Name = "BestTimesToolStripMenuItem";
            this.BestTimesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BestTimesToolStripMenuItem.Text = "Best &Times...";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpTopicsToolStripMenuItem,
            this.ToolStripSeparator5,
            this.AboutMinesweeperToolStripMenuItem});
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // HelpTopicsToolStripMenuItem
            // 
            this.HelpTopicsToolStripMenuItem.Name = "HelpTopicsToolStripMenuItem";
            this.HelpTopicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpTopicsToolStripMenuItem.Text = "&Help Topics";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // AboutMinesweeperToolStripMenuItem
            // 
            this.AboutMinesweeperToolStripMenuItem.Name = "AboutMinesweeperToolStripMenuItem";
            this.AboutMinesweeperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutMinesweeperToolStripMenuItem.Text = "&About Minesweeper";
            // 
            // panGame
            // 
            this.panGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGame.Controls.Add(this.spcBoard);
            this.panGame.Location = new System.Drawing.Point(6, 29);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(155, 208);
            this.panGame.TabIndex = 1;
            // 
            // spcBoard
            // 
            this.spcBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBoard.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcBoard.IsSplitterFixed = true;
            this.spcBoard.Location = new System.Drawing.Point(0, 0);
            this.spcBoard.Name = "spcBoard";
            this.spcBoard.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcBoard.Panel1
            // 
            this.spcBoard.Panel1.Controls.Add(this.picFace);
            this.spcBoard.Panel1.Controls.Add(this.lblTimer);
            this.spcBoard.Panel1.Controls.Add(this.lblBomb);
            this.spcBoard.Size = new System.Drawing.Size(155, 208);
            this.spcBoard.SplitterDistance = 34;
            this.spcBoard.TabIndex = 0;
            // 
            // picFace
            // 
            this.picFace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picFace.Held = false;
            this.picFace.HoldOnPush = false;
            this.picFace.Location = new System.Drawing.Point(62, 4);
            this.picFace.Name = "picFace";
            this.picFace.ShowFocusRectangle = false;
            this.picFace.Size = new System.Drawing.Size(26, 26);
            this.picFace.Stuck = false;
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            this.picFace.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picFace.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.DropShadow = false;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Image = global::WinMine.Properties.Resources.NumBoxBack;
            this.lblTimer.Location = new System.Drawing.Point(95, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(56, 26);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "000";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBomb
            // 
            this.lblBomb.BackColor = System.Drawing.Color.Transparent;
            this.lblBomb.DropShadow = false;
            this.lblBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomb.ForeColor = System.Drawing.Color.Red;
            this.lblBomb.Image = global::WinMine.Properties.Resources.NumBoxBack;
            this.lblBomb.Location = new System.Drawing.Point(3, 5);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(56, 26);
            this.lblBomb.TabIndex = 1;
            this.lblBomb.Text = "000";
            this.lblBomb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timGame
            // 
            this.timGame.Interval = 1000;
            // 
            // MineSweeper95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(167, 244);
            this.Controls.Add(this.panGame);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "MineSweeper95";
            this.Text = "Minesweeper";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.panGame.ResumeLayout(false);
            this.spcBoard.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcBoard)).EndInit();
            this.spcBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private MenuStrip MenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem BeginnerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem IntermediateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ExpertToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CustomToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem MarkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem BestTimesToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem HelpTopicsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem AboutMinesweeperToolStripMenuItem;
    private System.Windows.Forms.Panel panGame;
    private System.Windows.Forms.SplitContainer spcBoard;
    private Button picFace;
    private System.Windows.Forms.Timer timGame;
    private Label lblBomb;
    private Label lblTimer;
}
}