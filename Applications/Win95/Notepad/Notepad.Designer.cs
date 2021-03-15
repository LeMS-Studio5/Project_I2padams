using libProChic;

namespace Notepad
{
    partial class formnotepad : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
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
            this.menMain = new MenuStrip();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.WordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopicsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutNotepadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDateF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.look = new System.Windows.Forms.Timer(this.components);
            this.program = new System.Windows.Forms.Panel();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menMain.SuspendLayout();
            this.program.SuspendLayout();
            this.SuspendLayout();
            // 
            // menMain
            // 
            this.menMain.BackColor = System.Drawing.Color.Silver;
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileToolStripMenuItem1, this.EditToolStripMenuItem1, this.SearchToolStripMenuItem1, this.FormatToolStripMenuItem });
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Size = new System.Drawing.Size(540, 24);
            this.menMain.TabIndex = 2;
            this.menMain.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.NewToolStripMenuItem1, this.OpenToolStripMenuItem1, this.SaveToolStripMenuItem1, this.SaveAsToolStripMenuItem1, this.ToolStripSeparator2, this.PageToolStripMenuItem, this.PrintToolStripMenuItem1, this.ToolStripSeparator1, this.ExitToolStripMenuItem1 });
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem1.Text = "File";
            // 
            // NewToolStripMenuItem1
            // 
            this.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1";
            this.NewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.NewToolStripMenuItem1.Text = "&New";
            // 
            // OpenToolStripMenuItem1
            // 
            this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
            this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem1.Text = "&Open...";
            // 
            // SaveToolStripMenuItem1
            // 
            this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
            this.SaveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem1.Text = "&Save";
            // 
            // SaveAsToolStripMenuItem1
            // 
            this.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1";
            this.SaveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem1.Text = "Save &As...";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // PageToolStripMenuItem
            // 
            this.PageToolStripMenuItem.Name = "PageToolStripMenuItem";
            this.PageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PageToolStripMenuItem.Text = "Page Se&tup...";
            // 
            // PrintToolStripMenuItem1
            // 
            this.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1";
            this.PrintToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.PrintToolStripMenuItem1.Text = "&Print";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem1.Text = "E&xit";
            // 
            // EditToolStripMenuItem1
            // 
            this.EditToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.UndoToolStripMenuItem, this.ToolStripSeparator3, this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PasteToolStripMenuItem, this.DeleteToolStripMenuItem, this.ToolStripSeparator4, this.SelectAllToolStripMenuItem1, this.TimeDateToolStripMenuItem, this.ToolStripSeparator5, this.WordToolStripMenuItem });
            this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            this.EditToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem1.Text = "Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z);
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X);
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutToolStripMenuItem.Tag = "";
            this.CutToolStripMenuItem.Text = "Cu&t";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C);
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P);
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "De&lete";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // SelectAllToolStripMenuItem1
            // 
            this.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1";
            this.SelectAllToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.SelectAllToolStripMenuItem1.Text = "Select &All";
            // 
            // TimeDateToolStripMenuItem
            // 
            this.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem";
            this.TimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TimeDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TimeDateToolStripMenuItem.Text = "Time/&Date";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // WordToolStripMenuItem
            // 
            this.WordToolStripMenuItem.Checked = true;
            this.WordToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordToolStripMenuItem.Name = "WordToolStripMenuItem";
            this.WordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WordToolStripMenuItem.Text = "&Word Wrap";
            // 
            // SearchToolStripMenuItem1
            // 
            this.SearchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FindToolStripMenuItem, this.FindNextToolStripMenuItem });
            this.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1";
            this.SearchToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.SearchToolStripMenuItem1.Text = "Search";
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FindToolStripMenuItem.Text = "&Find...";
            // 
            // FindNextToolStripMenuItem
            // 
            this.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem";
            this.FindNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FindNextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FindNextToolStripMenuItem.Text = "Find &Next";
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.HelpTopicsToolStripMenuItem1, this.ToolStripSeparator6, this.AboutNotepadToolStripMenuItem1 });
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.FormatToolStripMenuItem.Text = "Help";
            // 
            // HelpTopicsToolStripMenuItem1
            // 
            this.HelpTopicsToolStripMenuItem1.Name = "HelpTopicsToolStripMenuItem1";
            this.HelpTopicsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.HelpTopicsToolStripMenuItem1.Text = "&Help Topics";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // AboutNotepadToolStripMenuItem1
            // 
            this.AboutNotepadToolStripMenuItem1.Name = "AboutNotepadToolStripMenuItem1";
            this.AboutNotepadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AboutNotepadToolStripMenuItem1.Text = "&About Notepad";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.NewToolStripMenuItem, this.OpenToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem, this.PageSetupToolStripMenuItem, this.PrintToolStripMenuItem, this.ExitToolStripMenuItem });
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.NewToolStripMenuItem.Text = "New";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.OpenToolStripMenuItem.Text = "Open...";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As...";
            // 
            // PageSetupToolStripMenuItem
            // 
            this.PageSetupToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem";
            this.PageSetupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PageSetupToolStripMenuItem.Text = "Page Setup...";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PrintToolStripMenuItem.Text = "Print";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.UndoCtrlZToolStripMenuItem, this.CutCtrlXToolStripMenuItem, this.CopyCtrlCToolStripMenuItem, this.PasteCtrlVToolStripMenuItem, this.DeleteDelToolStripMenuItem, this.SelectAllToolStripMenuItem, this.TimeDateF5ToolStripMenuItem, this.WordWrapToolStripMenuItem });
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoCtrlZToolStripMenuItem
            // 
            this.UndoCtrlZToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem";
            this.UndoCtrlZToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.UndoCtrlZToolStripMenuItem.Text = "Undo          Ctrl+Z";
            // 
            // CutCtrlXToolStripMenuItem
            // 
            this.CutCtrlXToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem";
            this.CutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.CutCtrlXToolStripMenuItem.Text = "Cut             Ctrl+X";
            // 
            // CopyCtrlCToolStripMenuItem
            // 
            this.CopyCtrlCToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem";
            this.CopyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.CopyCtrlCToolStripMenuItem.Text = "Copy          Ctrl+C";
            // 
            // PasteCtrlVToolStripMenuItem
            // 
            this.PasteCtrlVToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.PasteCtrlVToolStripMenuItem.Name = "PasteCtrlVToolStripMenuItem";
            this.PasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.PasteCtrlVToolStripMenuItem.Text = "Paste          Ctrl+V";
            // 
            // DeleteDelToolStripMenuItem
            // 
            this.DeleteDelToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.DeleteDelToolStripMenuItem.Name = "DeleteDelToolStripMenuItem";
            this.DeleteDelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.DeleteDelToolStripMenuItem.Text = "Delete         Del";
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.SelectAllToolStripMenuItem.Text = "Select All";
            // 
            // TimeDateF5ToolStripMenuItem
            // 
            this.TimeDateF5ToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.TimeDateF5ToolStripMenuItem.Name = "TimeDateF5ToolStripMenuItem";
            this.TimeDateF5ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.TimeDateF5ToolStripMenuItem.Text = "Time/Date F5";
            // 
            // WordWrapToolStripMenuItem
            // 
            this.WordWrapToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem";
            this.WordWrapToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.WordWrapToolStripMenuItem.Text = "Word Wrap";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FindToolStripMenuItem1, this.FindNextF3ToolStripMenuItem });
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SearchToolStripMenuItem.Text = "Search";
            // 
            // FindToolStripMenuItem1
            // 
            this.FindToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1";
            this.FindToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.FindToolStripMenuItem1.Text = "Find...";
            // 
            // FindNextF3ToolStripMenuItem
            // 
            this.FindNextF3ToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.FindNextF3ToolStripMenuItem.Name = "FindNextF3ToolStripMenuItem";
            this.FindNextF3ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.FindNextF3ToolStripMenuItem.Text = "Find Next     F3";
            // 
            // HelpToolStripMenuItem1
            // 
            this.HelpToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.HelpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.HelpTopicsToolStripMenuItem, this.AboutNotepadToolStripMenuItem });
            this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
            this.HelpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem1.Text = "Help";
            // 
            // HelpTopicsToolStripMenuItem
            // 
            this.HelpTopicsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.HelpTopicsToolStripMenuItem.Name = "HelpTopicsToolStripMenuItem";
            this.HelpTopicsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.HelpTopicsToolStripMenuItem.Text = "Help Topics";
            // 
            // AboutNotepadToolStripMenuItem
            // 
            this.AboutNotepadToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.AboutNotepadToolStripMenuItem.Name = "AboutNotepadToolStripMenuItem";
            this.AboutNotepadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AboutNotepadToolStripMenuItem.Text = "About Notepad";
            // 
            // look
            // 
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.txtNotepad);
            this.program.Controls.Add(this.menMain);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(540, 424);
            this.program.TabIndex = 4;
            // 
            // txtNotepad
            // 
            this.txtNotepad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotepad.Location = new System.Drawing.Point(0, 24);
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotepad.Size = new System.Drawing.Size(540, 400);
            this.txtNotepad.TabIndex = 1;
            // 
            // formnotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 424);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formnotepad";
            this.Text = "Notepad";
            this.TopMost = true;
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.ResumeLayout(false);
        }
        private MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeDateF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FindNextF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HelpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutNotepadToolStripMenuItem;
        private System.Windows.Forms.Timer look;
        private System.Windows.Forms.Panel program;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtNotepad;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TimeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem WordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpTopicsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem AboutNotepadToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}