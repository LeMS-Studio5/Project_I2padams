using System;
using libLeMS;
using System.Drawing;
namespace WinMine
{
    public partial class MineSweeper95
    {
        private MasterClass com = new MasterClass();
        private ConfigHelper configMine;
        private int w, h;
        private Box[,] board;
        private int[,] sizes = new int[,] { { 8, 8 }, { 16, 16 }, { 30, 16 } };
        private int[] mineCount = new int[] { 10, 40, 99, 15 };
        private Image[] faces = new[] { Properties.Resources.minsweeper_smile, Properties.Resources.minsweeper_gasp, Properties.Resources.minsweeper_win, Properties.Resources.minsweeper_sad };
        private System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        private CustomMineSweeperDialog cust;

        private void picFace_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                createGame();
        }
        private void MineSweeper95_Load(object sender, EventArgs e)
        {
            configMine = new ConfigHelper(com.toSystemPath(@"C:\WINDOWS\winmine.ini"));
            w = configMine.GetConfigAsInt32("Minesweeper", "Width");
            h = configMine.GetConfigAsInt32("Minesweeper", "Height");
            pfc.AddFontFile(com.toSystemPath(@"C:\WINDOWS\FONTS\LeMS LCD.ttf"));
            lblBomb.Font = new Font(pfc.Families[0], 20);
            lblTimer.Font = new Font(pfc.Families[ 0], 20);
            int dif = configMine.GetConfigAsInt32("Minesweeper", "Difficulty");
            BeginnerToolStripMenuItem.Checked = (dif == 0);
            IntermediateToolStripMenuItem.Checked = (dif == 1);
            ExpertToolStripMenuItem.Checked = (dif == 2);
            CustomToolStripMenuItem.Checked = (dif == 3);
            createGame();
        }
        private void BeginnerToolStripMenuItem_Click(System.Windows.Forms.ToolStripMenuItem sender, EventArgs e)
        {
            try
            {
                int dif = Convert.ToInt32(sender.Tag); // Console.WriteLine(dif) ' = 
                cust = new CustomMineSweeperDialog();
                if (dif != 3)
                    w = sizes[dif, 0];
                if (dif != 3)
                    h = sizes[dif, 1]; // Console.WriteLine(w & "," & h)
                if (BeginnerToolStripMenuItem.Text != sender.Text)
                    BeginnerToolStripMenuItem.Checked = false;
                if (IntermediateToolStripMenuItem.Text != sender.Text)
                    IntermediateToolStripMenuItem.Checked = false;
                if (ExpertToolStripMenuItem.Text != sender.Text)
                    ExpertToolStripMenuItem.Checked = false;
                CustomToolStripMenuItem.Checked = sender.Text == "&Custom";
                // Console.WriteLine((sender.Text = "Custom") & "," & (cust.ShowDialog() = DialogResult.OK))
                if (sender.Text == "&Custom" && cust.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    h = Int32.Parse(cust.txtHeight.Text);
                    w = Int32.Parse(cust.txtWidth.Text);
                    mineCount[3] = Int32.Parse(cust.txtMines.Text);
                } // Console.WriteLine(cust.DialogResult)
                  // Console.WriteLine(cust.txtHeight.Text & vbTab & cust.txtWidth.Text & vbTab & cust.txtMines.Text)
                configMine.SetConfig("Minesweeper","Difficulty", dif.ToString());
                configMine.SetConfig("Minesweeper","Mines", mineCount[dif].ToString());
                configMine.SetConfig("Minesweeper","Height", h.ToString());
                configMine.SetConfig("Minesweeper","Width", w.ToString());
                createGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void createGame()
        {
            timGame.Stop();
            spcBoard.Panel2.SuspendLayout();
            spcBoard.Panel2.Controls.Clear();
            System.GC.Collect();
            board = new Box[w - 1 + 1, h - 1 + 1];
            Box.TotalWidth = w;
            Box.TotalHeight = h;
            for (int x = 0; x <= w - 1; x++)
            {
                for (int y = 0; y <= h - 1; y++)
                {
                    Box pic = new Box() { Location = new Point((16 * x) + 2, (16 * y) + 2), Size = new System.Drawing.Size(16, 16), X = x, Y = y , MineBoard = this,ShowFocusRectangle = false };//BackgroundImage = Properties.Resources.button,  SizeMode = PictureBoxSizeMode.CenterImage
                    spcBoard.Panel2.Controls.Add(pic);
                    board[x, y] = pic;
                    pic.FaceChange += box_FaceChange;
                    pic.FlagChange += box_FlagChange;
                    pic.Click += box_Click;
                }
            }
            Box.Board = board;
            Box.Done = false;
            int count = 0;
            var r = new Random();
            while ((count < configMine.GetConfigAsInt32("Minesweeper","Mines")))
            {
                int x = r.Next(w);
                int y = r.Next(h);
                if (!board[x, y].IsBomb)
                {
                    board[x, y].IsBomb = true;
                    count += 1;
                }
            }
            Width = 20 + (16 * (w + 0));
            Height = 80 + (16 * (h + 0));
            picFace.Location = new Point((Int32)((spcBoard.Width / (double)2) - (picFace.Width / (double)2)), picFace.Location.Y);
            picFace.Image = Properties.Resources.minsweeper_smile;
            lblBomb.Text = configMine.GetConfig("Minesweeper", "Mines").Setting.PadLeft(3, '0');
            lblTimer.Text = "000";
            spcBoard.Panel2.ResumeLayout(true);
        }
        private void box_FaceChange(Object sender, EventArgs e)
        {
            Box.FaceType ft = (Box.FaceType)sender;
            picFace.Image = faces[(Int32)ft];
            if (ft == Box.FaceType.Dead)
            {
                timGame.Stop();    // Console.WriteLine("Dead")
                for (int x = 0; x <= w - 1; x++)
                {
                    for (int y = 0; y <= h - 1; y++)
                    {
                        // Console.WriteLine(x & "," & y)
                        if (board[x, y].IsBomb && !board[x, y].Flagged)
                            board[x, y].BackgroundImage = Properties.Resources.NumberSquareBack;
                        if (board[x, y].Flagged && !board[x, y].IsBomb)
                            board[x, y].Image = Properties.Resources.Wrong;
                        if (board[x, y].IsBomb && !board[x, y].Flagged)
                            board[x, y].Image = Properties.Resources.Mine;
                        board[x, y].UnClick = true;
                    }
                }
                Box.Done = true;
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void box_Click(object sender, EventArgs e)
        {
            if (!timGame.Enabled & !Box.Done)
                timGame.Start();
            // Console.WriteLine(clickCount)
            if (clickCount() == (w * h) - 1)
            {
                picFace.Image = Properties.Resources.minsweeper_win;
                Box.Done = true;
                timGame.Stop();
                if (configMine.GetConfigAsInt32("Minesweeper","Difficulty") + 1 != 3)
                {
                    spcBoard.Refresh(); // Console.WriteLine(configMine.load("Time" & (configMine.load("Difficulty") + 1)))
                    Int32 dif = configMine.GetConfigAsInt32("Minesweeper", "Difficulty")+1;
                    if (Int32.Parse(lblTimer.Text) < configMine.GetConfigAsInt32("Minesweeper","Time" + dif))
                    {
                        var box = new InputBox("You Have the fastest time for the " + Environment.NewLine + " level. Please type your name:", "Congratulations", configMine.GetConfig("Minesweeper","Name" + dif));
                        if (box.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            configMine.SetConfig("Minesweeper","Time" + dif, lblTimer.Text);
                            configMine.SetConfig("Minesweeper","Name" + dif, box.Response);
                        }
                        BestTime();
                    }
                }
            }
        }
        private void BestTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestTime();
        }
        public int clickCount()
        {
            int c = 0;
            foreach (var b in board)
            {
                if (b.UnClick || b.Flagged)
                    c += 1;
            }
            return c;
        }
        private void BestTime()
        {
            //BestTimes best = new BestTimes();
            //best.ShowDialog();
        }
        private void box_FlagChange(Object sender, EventArgs e)
        {
            if ((Boolean)sender)
                lblBomb.Text = (int.Parse(lblBomb.Text) - 1).ToString("000");
            else
                lblBomb.Text = (int.Parse(lblBomb.Text) + 1).ToString("000");
        }
        public int CountMines(int x, int y)
        {
            int count = 0;
            try
            {
                // Console.WriteLine(b.GetLength(1))
                for (int xA = x - 1; xA <= x + 1; xA++) // From https://github.com/brickmack/VB-Minesweeper/tree/master/minesweeper
                {
                    if ((xA > -1 & xA < w - 0))
                    {
                        for (int yA = y - 1; yA <= y + 1; yA++)
                        {
                            if ((yA > -1 & yA < h - 0))
                            {
                                if (x != xA || y != yA)
                                {
                                    if (board[xA, yA].IsBomb)
                                        count += 1;
                                } // Console.Write(xA & "," & yA & " ")
                            }
                        } // Console.WriteLine()
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return count;
        }
        private void EndGame(ref int x, ref int y)
        {
            board[x, y].Image = Properties.Resources.Flag;
            board[x, y].BackColor = Color.Red;
            spcBoard.Panel2.Enabled = false;
        }
        private void picFace_MouseDown(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //((Button)(sender)).Tag = ((Button)sender).Image;
            //((Button)(sender)).BackgroundImage = Properties.Resources.NumberSquareBack;
            ((Button)(sender)).Image = Properties.Resources.minsweeper_smile;
        }
        private void picFace_MouseUp(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //sender.BackgroundImage = Properties.Resources.button;
           // if (timGame.Enabled)
           //     ((Button)(sender)).Image = ((Image)((Button)(sender)).Tag);
        }
        private void timGame_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = (int.Parse(lblTimer.Text) + 1).ToString("000");
        }
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createGame();
        }
    }

public class Box:Button
    {
        private static Color[] numColours = new[] { Color.Blue, Color.Green, Color.Red, Color.Navy, Color.Maroon, Color.Teal, Color.Black, Color.Gray };
        private bool quest = false;
        private Label lbl;

        public Box():base()
        {
            // This call is required by the designer.

            this.Size = new System.Drawing.Size(16, 16);
            this.MouseClick += Box_Click;
            this.MouseDown += PropertiesBase_MouseDown;
            this.MouseUp += PropertiesBase_Mouseup;
        }
        private void PropertiesBase_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left || UnClick || Done)
                return;
            BackgroundImage = Properties.Resources.NumberSquareBack;
            FaceChange?.Invoke(FaceType.Scared, new EventArgs());
        }
        private void PropertiesBase_Mouseup(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left || Done)
                return; // UnClick  'If Not IsBomb AndAlso Not Done Then Console.WriteLine("Raise")
            if (!IsBomb && !Done)
                FaceChange?.Invoke(FaceType.Happy,new EventArgs()   );
           //if(!UnClick)
           //     BackgroundImage = Properties.Resources.button;
        }
        private void Box_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                // Console.WriteLine(UnClick)
                // Console.WriteLine()
                if (!UnClick)
                {
                    if (e.Button ==System.Windows.Forms. MouseButtons.Right && !UnClick && (!Done || MineBoard.clickCount() >= (TotalHeight * TotalWidth) - 1))
                        Flagged = !Flagged;
                    if (e.Button ==System.Windows.Forms. MouseButtons.Left && (!Done || MineBoard.clickCount() >= (TotalHeight * TotalWidth) - 1))
                    {
                        UnClick = true;
                        if (IsBomb & !Flagged)
                        {
                            FaceChange?.Invoke(FaceType.Dead,new EventArgs());
                            BackColor = Color.Red;
                        }
                        else
                        {
                            int c = MineBoard.CountMines(X - 0, Y - 0);
                            // Console.WriteLine(X & "," & Y)
                            if (c == 0 && !Flagged)
                                CheckSurround(X, Y);
                            else if ((!Done) || Flagged || MineBoard.clickCount() >= (TotalHeight * TotalWidth) - 1)
                            {
                                //lbl = new Label() { ForeColor = numColours[c - 1], Text = c.ToString(), TextAlign = ContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Arial", 12), Location = new Point(2, -1), BackColor = Color.Transparent, Size = new Size(12, 15), Padding = new System.Windows.Forms.Padding(0), Margin = new System.Windows.Forms.Padding(0) };
                                NumLabel(c);//this.Controls.Add(lbl);
                            }
                        }
                    }
                    if (!Done)
                        MouseClick?.Invoke(this, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void ZeroCheck()
        {
            if (!Board[X, Y].IsBomb)
            {
                int c = MineBoard.CountMines(X, Y);
                UnClick = true;
                Board[X, Y].BackgroundImage = Properties.Resources.NumberSquareBack;
                if (c == 0)
                    CheckSurround(X, Y);
                else
                {
                    NumLabel(c);
                }
            }
        }
        private void NumLabel(int count)
        {
            lbl = new Label() { ForeColor = numColours[count - 1], Text = count.ToString(), TextAlign = ContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Arial", 12), Location = new Point(2, -1), BackColor = Color.Transparent, Size = new Size(12, 15), Padding = new System.Windows.Forms.Padding(0), Margin = new System.Windows.Forms.Padding(0) };
            this.Controls.Add(lbl);
        }
        private void CheckSurround(int BoxX, int BoxY)
        {
            for (int xA = BoxX - 1; xA <= BoxX + 1; xA++) // From https://github.com/brickmack/VB-Minesweeper/tree/master/minesweeper
            {
                if ((xA > -1 & xA < TotalWidth - +0))
                {
                    for (int yA = BoxY - 1; yA <= BoxY + 1; yA++)
                    {
                        if ((yA > -1 & yA < TotalHeight + 0))
                        {
                            if (X != xA || Y != yA)
                            {
                                if (!Board[xA, yA].UnClick)
                                    Board[xA, yA].ZeroCheck();
                            } // Console.Write(xA & "," & yA & " ")
                        }
                    } // Console.WriteLine()
                }
            }
        }
        public event EventHandler FaceChange = new EventHandler((e, a) => { });
        public event EventHandler FlagChange = new EventHandler((e, a) => { });
        public new event System.Windows.Forms.MouseEventHandler MouseClick;     
        public enum FaceType
        {
            Happy = 0,
            Scared = 1,
            Cool = 2,
            Dead = 3
        }
        public static Box[,] Board { get; set; }
        public static int TotalWidth { get; set; } = 0;
        public static int TotalHeight { get; set; } = 0;
        public static bool Done { get; set; } = false;
        public bool IsBomb { get; set; } = false;
        public bool UnClick { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }
        public MineSweeper95 MineBoard { get; set; }
        public bool Questioned
        {
            set
            {
                quest = value;
                if (quest)
                    Image = Properties.Resources.Question;
                //else
                //   Image = Properties.Resources.button;
            }
            get
            {
                return quest;
            }
        }
        public bool Flagged
        {
            set
            {
                quest = value;
                FlagChange?.Invoke(value,new EventArgs());
                if (quest)
                    Image = Properties.Resources.Flag;
                //else
                    //Image = Properties.Resources.button;
            }
            get
            {
                return quest;
            }
        }
    }

}