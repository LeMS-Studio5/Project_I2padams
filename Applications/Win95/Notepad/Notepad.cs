using System;
using System.IO;
using libLeMS;

namespace Notepad
{
    public partial class formnotepad
    {
        private string strFile;
        private MasterClass m = new MasterClass();
        public formnotepad(String strFile)
        {
            InitializeComponent();
            if (System.IO.File.Exists(strFile))
                txtNotepad.Text = File.ReadAllText(strFile);
            else
                strFile = "";
        }
        private void formnotepad_Load(System.Object sender, System.EventArgs e)
        {
            // editTaskbar("95", Me, True)
            look.Start();
        }
        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((txtNotepad.Text != null/* TODO Change to default(_) if this is not a reference type */ && strFile == null) || (strFile != null && System.IO.File.ReadAllText(strFile) == txtNotepad.Text))
            {
                //ProjectChicagoObjects.MessageBox c = new ProjectChicagoObjects.MessageBox("The text in this file has changed." + Constants.vbCrLf + "Do you want to save the changes?", "Notepad", false, ProjectChicagoObjects.MessageBox.MsgBoxType.Message_Warning);
                //var diaResult = c.ShowDialog;
                //if (diaResult == DialogResult.Yes)
                //{
                //    ProjectChicagoObjects.FileDialog fdb = new ProjectChicagoObjects.FileDialog("*.txt", "") { Filter = "Text Documents|*.txt|All Files (*.*)|*.*", Text = "Save As", Directory = "" };
                //    if (fdb.ShowDialog == DialogResult.OK)
                //        System.IO.File.WriteAllText(fdb.FileName, txtNotepad.Text);
                //}
                //else if (diaResult == DialogResult.No)
                //{
                //    txtNotepad.ResetText();
                //    txtNotepad.Focus();
                //}
            }
        }

        // CLICK EVENT I ACCIDENTALLY MADE:  Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click

        // End Sub
        // Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        // If txtNotepad.Text <> ReadAllText(strFile) Then
        // Dim msg = messageBoxGenerate("95", "warning", "The text in this file has changed." & vbCrLf & "Do you want to save the changes?", 1, 0, 1, 1, 0)
        // If msg.ShowDialog = DialogResult.Yes Then
        // If sfdNotepad.ShowDialog = DialogResult.OK Then
        // WriteAllText(sfdNotepad.FileName, txtNotepad.Text)
        // End If
        // ElseIf msg.DialogResult = DialogResult.No Then
        // Close()
        // End If
        // End If
        // End Sub
        private void look_Tick(System.Object sender, System.EventArgs e)
        {
        }
    }
}