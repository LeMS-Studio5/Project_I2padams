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
using libLeMS;

namespace Calculator {
    partial class formCalculator : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components== null)
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
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.btnClearEntry = new Button();
            this.btnClear = new Button();
            this.btnBack = new Button();
            this.btnEquals = new Button();
            this.btnSquRt = new Button();
            this.btnInverse = new Button();
            this.btnPercent = new Button();
            this.btnPlus = new Button();
            this.btnDivide = new Button();
            this.btnMinus = new Button();
            this.btnTimes = new Button();
            this.btnPoint = new Button();
            this.btnSign = new Button();
            this.btn0 = new Button();
            this.btn9 = new Button();
            this.btn3 = new Button();
            this.btn6 = new Button();
            this.btn8 = new Button();
            this.btn2 = new Button();
            this.btn5 = new Button();
            this.btn7 = new Button();
            this.btn1 = new Button();
            this.btn4 = new Button();
            this.btnMemClear = new Button();
            this.btnMemStore = new Button();
            this.btnMemAdd = new Button();
            this.btnMemRecall = new Button();
            this.program = new System.Windows.Forms.Panel();
            this.panStandard = new System.Windows.Forms.Panel();
            this.txtHidden = new System.Windows.Forms.TextBox();
            this.MenuStrip2 = new MenuStrip();
            this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCtrlCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteCtrlVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTopicsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panSci = new System.Windows.Forms.Panel();
            this.program.SuspendLayout();
            this.panStandard.SuspendLayout();
            this.MenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCalc
            // 
            this.txtCalc.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);
            this.txtCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtCalc.Location = new System.Drawing.Point(9, 10);
            this.txtCalc.Multiline = true;
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(284, 28);
            this.txtCalc.TabIndex = 27;
            this.txtCalc.Text = "0";
            this.txtCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnClearEntry.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClearEntry.Location = new System.Drawing.Point(183, 56);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(53, 30);
            this.btnClearEntry.TabIndex = 26;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnClear.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClear.Location = new System.Drawing.Point(241, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 30);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnBack.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBack.Location = new System.Drawing.Point(124, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 30);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnEquals.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEquals.Location = new System.Drawing.Point(255, 200);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(38, 30);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += btnEqual_Click;
            // 
            // btnSquRt
            // 
            this.btnSquRt.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnSquRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnSquRt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSquRt.Location = new System.Drawing.Point(255, 92);
            this.btnSquRt.Name = "btnSquRt";
            this.btnSquRt.Size = new System.Drawing.Size(38, 30);
            this.btnSquRt.TabIndex = 22;
            this.btnSquRt.Text = "sqrt";
            this.btnSquRt.UseVisualStyleBackColor = true;
            this.btnSquRt.Click += arithmitic_click;
            // 
            // btnInverse
            // 
            this.btnInverse.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnInverse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnInverse.Location = new System.Drawing.Point(255, 164);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(38, 30);
            this.btnInverse.TabIndex = 21;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            // 
            // btnPercent
            // 
            this.btnPercent.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnPercent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPercent.Location = new System.Drawing.Point(255, 128);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(38, 30);
            this.btnPercent.TabIndex = 20;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += arithmitic_click;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Location = new System.Drawing.Point(211, 200);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(38, 30);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += arithmitic_click;
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(211, 92);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(38, 30);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += arithmitic_click;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(211, 164);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(38, 30);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += arithmitic_click;
            // 
            // btnTimes
            // 
            this.btnTimes.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnTimes.ForeColor = System.Drawing.Color.Red;
            this.btnTimes.Location = new System.Drawing.Point(211, 128);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(38, 30);
            this.btnTimes.TabIndex = 16;
            this.btnTimes.Text = "X";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += arithmitic_click;
            // 
            // btnPoint
            // 
            this.btnPoint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnPoint.ForeColor = System.Drawing.Color.Blue;
            this.btnPoint.Location = new System.Drawing.Point(169, 200);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(38, 30);
            this.btnPoint.TabIndex = 15;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnSign
            // 
            this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnSign.ForeColor = System.Drawing.Color.Blue;
            this.btnSign.Location = new System.Drawing.Point(125, 200);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(38, 30);
            this.btnSign.TabIndex = 14;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Location = new System.Drawing.Point(81, 200);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(38, 30);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += btnNum_Click;
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(169, 92);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(38, 30);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += btnNum_Click;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(169, 164);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(38, 30);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += btnNum_Click;
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(169, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(38, 30);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += btnNum_Click;
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(125, 92);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(38, 30);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += btnNum_Click;
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(125, 164);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(38, 30);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += btnNum_Click;
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(125, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 30);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += btnNum_Click;
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(81, 92);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 30);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += btnNum_Click;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(81, 164);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 30);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += btnNum_Click;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(81, 128);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 30);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += btnNum_Click;
            // 
            // btnMemClear
            // 
            this.btnMemClear.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnMemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnMemClear.ForeColor = System.Drawing.Color.Red;
            this.btnMemClear.Location = new System.Drawing.Point(17, 92);
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.Size = new System.Drawing.Size(38, 30);
            this.btnMemClear.TabIndex = 3;
            this.btnMemClear.Text = "MC";
            this.btnMemClear.UseVisualStyleBackColor = true;
            // 
            // btnMemStore
            // 
            this.btnMemStore.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnMemStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnMemStore.ForeColor = System.Drawing.Color.Red;
            this.btnMemStore.Location = new System.Drawing.Point(17, 164);
            this.btnMemStore.Name = "btnMemStore";
            this.btnMemStore.Size = new System.Drawing.Size(38, 30);
            this.btnMemStore.TabIndex = 2;
            this.btnMemStore.Text = "MS";
            this.btnMemStore.UseVisualStyleBackColor = true;
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnMemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnMemAdd.ForeColor = System.Drawing.Color.Red;
            this.btnMemAdd.Location = new System.Drawing.Point(17, 200);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(38, 30);
            this.btnMemAdd.TabIndex = 1;
            this.btnMemAdd.Text = "M+";
            this.btnMemAdd.UseVisualStyleBackColor = true;
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnMemRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.btnMemRecall.ForeColor = System.Drawing.Color.Red;
            this.btnMemRecall.Location = new System.Drawing.Point(17, 128);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(38, 30);
            this.btnMemRecall.TabIndex = 1000;
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = true;
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.panSci);
            this.program.Controls.Add(this.panStandard);
            this.program.Controls.Add(this.txtHidden);
            this.program.Controls.Add(this.MenuStrip2);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(308, 276);
            this.program.TabIndex = 29;
            // 
            // panStandard
            // 
            this.panStandard.Controls.Add(this.btn8);
            this.panStandard.Controls.Add(this.btn2);
            this.panStandard.Controls.Add(this.btnMinus);
            this.panStandard.Controls.Add(this.txtCalc);
            this.panStandard.Controls.Add(this.btnTimes);
            this.panStandard.Controls.Add(this.btnClearEntry);
            this.panStandard.Controls.Add(this.btn5);
            this.panStandard.Controls.Add(this.btnDivide);
            this.panStandard.Controls.Add(this.btnClear);
            this.panStandard.Controls.Add(this.btnPoint);
            this.panStandard.Controls.Add(this.btnMemRecall);
            this.panStandard.Controls.Add(this.btn7);
            this.panStandard.Controls.Add(this.btnBack);
            this.panStandard.Controls.Add(this.btn6);
            this.panStandard.Controls.Add(this.btnMemAdd);
            this.panStandard.Controls.Add(this.btnPlus);
            this.panStandard.Controls.Add(this.btnSign);
            this.panStandard.Controls.Add(this.btnEquals);
            this.panStandard.Controls.Add(this.btn1);
            this.panStandard.Controls.Add(this.btnMemStore);
            this.panStandard.Controls.Add(this.btn3);
            this.panStandard.Controls.Add(this.btnSquRt);
            this.panStandard.Controls.Add(this.btnPercent);
            this.panStandard.Controls.Add(this.btnMemClear);
            this.panStandard.Controls.Add(this.btn0);
            this.panStandard.Controls.Add(this.btnInverse);
            this.panStandard.Controls.Add(this.btn4);
            this.panStandard.Controls.Add(this.btn9);
            this.panStandard.Location = new System.Drawing.Point(3, 27);
            this.panStandard.Name = "panStandard";
            this.panStandard.Size = new System.Drawing.Size(305, 249);
            this.panStandard.TabIndex = 1001;
            // 
            // txtHidden
            // 
            this.txtHidden.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHidden.Location = new System.Drawing.Point(-100, 12);
            this.txtHidden.Name = "txtHidden";
            this.txtHidden.Size = new System.Drawing.Size(100, 20);
            this.txtHidden.TabIndex = 0;
            // 
            // MenuStrip2
            // 
            this.MenuStrip2.BackColor = System.Drawing.Color.Silver;
            this.MenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.EditToolStripMenuItem1, this.HelpToolStripMenuItem2, this.HelpToolStripMenuItem3 });
            this.MenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip2.Name = "MenuStrip2";
            this.MenuStrip2.Size = new System.Drawing.Size(308, 24);
            this.MenuStrip2.TabIndex = 28;
            this.MenuStrip2.Text = "MenuStrip2";
            // 
            // EditToolStripMenuItem1
            // 
            this.EditToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.EditToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.CopyCtrlCToolStripMenuItem1, this.PasteCtrlVToolStripMenuItem1 });
            this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            this.EditToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem1.Text = "Edit";
            // 
            // CopyCtrlCToolStripMenuItem1
            // 
            this.CopyCtrlCToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.CopyCtrlCToolStripMenuItem1.Name = "CopyCtrlCToolStripMenuItem1";
            this.CopyCtrlCToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.CopyCtrlCToolStripMenuItem1.Text = "Copy       Ctrl+C";
            // 
            // PasteCtrlVToolStripMenuItem1
            // 
            this.PasteCtrlVToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.PasteCtrlVToolStripMenuItem1.Name = "PasteCtrlVToolStripMenuItem1";
            this.PasteCtrlVToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.PasteCtrlVToolStripMenuItem1.Text = "Paste       Ctrl+V";
            // 
            // HelpToolStripMenuItem2
            // 
            this.HelpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ScientificToolStripMenuItem, this.StandardToolStripMenuItem });
            this.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2";
            this.HelpToolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.HelpToolStripMenuItem2.Text = "Veiw";
            // 
            // ScientificToolStripMenuItem
            // 
            this.ScientificToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem";
            this.ScientificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ScientificToolStripMenuItem.Text = "Scientific";
            // 
            // StandardToolStripMenuItem
            // 
            this.StandardToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.StandardToolStripMenuItem.Checked = true;
            this.StandardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem";
            this.StandardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StandardToolStripMenuItem.Text = "Standard";
            // 
            // HelpToolStripMenuItem3
            // 
            this.HelpToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.HelpTopicsToolStripMenuItem1, this.AboutCalculatorToolStripMenuItem });
            this.HelpToolStripMenuItem3.Name = "HelpToolStripMenuItem3";
            this.HelpToolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem3.Text = "Help";
            // 
            // HelpTopicsToolStripMenuItem1
            // 
            this.HelpTopicsToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.HelpTopicsToolStripMenuItem1.Name = "HelpTopicsToolStripMenuItem1";
            this.HelpTopicsToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.HelpTopicsToolStripMenuItem1.Text = "Help Topics";
            // 
            // AboutCalculatorToolStripMenuItem
            // 
            this.AboutCalculatorToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.AboutCalculatorToolStripMenuItem.Name = "AboutCalculatorToolStripMenuItem";
            this.AboutCalculatorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.AboutCalculatorToolStripMenuItem.Text = "About Calculator";
            // 
            // panSci
            // 
            this.panSci.Location = new System.Drawing.Point(3, 27);
            this.panSci.Name = "panSci";
            this.panSci.Size = new System.Drawing.Size(200, 100);
            this.panSci.TabIndex = 1002;
            this.panSci.Visible = false;
            // 
            // formcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 276);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formcalculator";
            this.Text = "Calculator";
            this.TopMost = true;
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.panStandard.ResumeLayout(false);
            this.panStandard.PerformLayout();
            this.MenuStrip2.ResumeLayout(false);
            this.MenuStrip2.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.TextBox txtCalc;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnBack;
        private Button btnEquals;
        private Button btnSquRt;
        private Button btnInverse;
        private Button btnPercent;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnTimes;
        private Button btnPoint;
        private Button btnSign;
        private Button btn0;
        private Button btn9;
        private Button btn3;
        private Button btn6;
        private Button btn8;
        private Button btn2;
        private Button btn5;
        private Button btn7;
        private Button btn1;
        private Button btn4;
        private Button btnMemClear;
        private Button btnMemStore;
        private Button btnMemAdd;
        private Button btnMemRecall;
        private System.Windows.Forms.Panel program;
        private MenuStrip MenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyCtrlCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PasteCtrlVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ScientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StandardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem HelpTopicsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutCalculatorToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHidden;
        private System.Windows.Forms.Panel panStandard;
        private System.Windows.Forms.Panel panSci;
    }
}