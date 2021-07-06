    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualBasic;
    using libProChic;
namespace WinMine{
    public partial class CustomMineSweeperDialog : ProI2padamsShell
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
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.lblHeight = new Label();
            this.lblWidth = new Label();
            this.lblMines = new Label();
            this.txtHeight = new TextBox();
            this.txtWidth = new TextBox();
            this.txtMines = new TextBox();
            this.programtopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.maximizebutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.minimizebutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.closebutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.programIcon).BeginInit();
            this.SuspendLayout();
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(167, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 19);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(13, 49);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width:";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.Location = new System.Drawing.Point(12, 78);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(38, 13);
            this.lblMines.TabIndex = 4;
            this.lblMines.Text = "&Mines:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(61, 16);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(61, 47);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // txtMines
            // 
            this.txtMines.Location = new System.Drawing.Point(61, 73);
            this.txtMines.Name = "txtMines";
            this.txtMines.Size = new System.Drawing.Size(100, 20);
            this.txtMines.TabIndex = 7;
            // 
            // CustomMineSweeperDialog
            // 
            this.ClientSize = new System.Drawing.Size(255, 123);
            this.GuestArea.Controls.Add(this.txtMines);
            this.GuestArea.Controls.Add(this.txtWidth);
            this.GuestArea.Controls.Add(this.txtHeight);
            this.GuestArea.Controls.Add(this.lblMines);
            this.GuestArea.Controls.Add(this.lblWidth);
            this.GuestArea.Controls.Add(this.lblHeight);
            this.GuestArea.Controls.Add(this.btnCancel);
            this.GuestArea.Controls.Add(this.btnOk);
            this.Name = "Custom Field";
            this.programname.Text = this.Name;
            this.GuestArea.Controls.SetChildIndex(this.btnOk, 0);
            this.GuestArea.Controls.SetChildIndex(this.btnCancel, 0);
            this.GuestArea.Controls.SetChildIndex(this.lblHeight, 0);
            this.GuestArea.Controls.SetChildIndex(this.lblWidth, 0);
            this.GuestArea.Controls.SetChildIndex(this.lblMines, 0);
            this.GuestArea.Controls.SetChildIndex(this.txtHeight, 0);
            this.GuestArea.Controls.SetChildIndex(this.txtWidth, 0);
            this.GuestArea.Controls.SetChildIndex(this.txtMines, 0);
            this.programtopbar.ResumeLayout(false);
            this.programtopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.maximizebutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.minimizebutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.closebutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.programIcon).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Button btnOk;
        private Button btnCancel;
        private Label lblHeight;
        private Label lblWidth;
        private Label lblMines;
        public TextBox txtHeight;
        public TextBox txtWidth;
        public TextBox txtMines;
    }

}