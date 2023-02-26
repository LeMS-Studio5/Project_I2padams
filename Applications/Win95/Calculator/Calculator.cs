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
namespace Calculator
{
    public partial class formCalculator
    {
        private double prevNum = 0;
        private string operation = "";
        private bool operation_pressed = false;
        private double dblMem;
        private MasterClass com = new MasterClass();
        public formCalculator()
        {
            InitializeComponent();
        }
        private void formcalculator_Load(System.Object sender, System.EventArgs e)
        {
            string val = com.Config.GetConfig("SciCalc", "layout").Setting;
            Int32 intVal = Int32.Parse(val);
            StandardToolStripMenuItem.Checked = (val == "ERROR" || (intVal == 0));
            ScientificToolStripMenuItem.Checked = (val != "ERROR" && intVal == 1);
        }
        private void btnNum_Click(Object sender, EventArgs e)
        {
            // If blnOne Then dblNum1 = sender.Text Else dblNum2 = sender.Text
            // txtCalc.Text = sender.Text
            // If (txtNumbers.Text = "0") OrElse (operation_pressed) Then txtNumbers.Text = ""
            // operation_pressed = False
            numEnter(((Button)sender).Text);
        }
        private void numEnter(String text)
        {
            if (txtCalc.Text == "0" || operation_pressed)
                txtCalc.ResetText();
            operation_pressed = false;
            if (text == "back")
                txtCalc.Text = "0";
            else if (text == ".")
            {
                if (!txtCalc.Text.Contains("."))
                    txtCalc.Text += text;
            }
            else
                txtCalc.Text += text;
            txtHidden.Focus();
        }
        private void arithmitic_click(Object sender, EventArgs e)
        {
            arithmitic(((Button)sender).Text);
        }
        private void arithmitic(String artOp)
        {
            // If txtCalc.Text.Contains("∞") Then txtCalc.Clear()
            // 
            if (prevNum != 0)
            {
                if (artOp == "sqrt")
                    prevNum = Math.Sqrt(double.Parse(txtCalc.Text));
                if (artOp == "1/x")
                    prevNum = Convert.ToDouble(1.0 / Convert.ToDouble(txtCalc.Text));
                if (artOp == "%")
                    prevNum = Convert.ToDouble(txtCalc.Text) / 100;
                btnEquals.PerformClick();
                operation = artOp;
                operation_pressed = true;
            }
            else if (artOp == "sqrt")
            {
                prevNum = Math.Sqrt(double.Parse(txtCalc.Text));
                txtCalc.Text = prevNum.ToString();
            }
            else if (artOp == "1/x")
            {
                prevNum = Convert.ToDouble(1.0 / Convert.ToDouble(txtCalc.Text));
                txtCalc.Text = prevNum.ToString();
            }
            else if (artOp == "%")
            {
                prevNum = Convert.ToDouble(txtCalc.Text) / 100;
                txtCalc.Text = prevNum.ToString();
            }
            else
            {
                operation = artOp;
                prevNum = double.Parse(txtCalc.Text);
                // txtCalc.Text = "0"
                operation_pressed = true;
            }
            txtHidden.Focus();
        }
        private void btnMemAdd_Click(object sender, EventArgs e)
        {
            dblMem += Double.Parse(txtCalc.Text);
        }
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "0";
        }
        private void CopyCtrlCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtCalc.Copy();
        }
        private void PasteCtrlVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var ch in System.Windows.Forms.Clipboard.GetText())
            {
                if (char.IsDigit(ch))
                    txtCalc.Text += ch;
            }
        }
        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            txtCalc.Text = dblMem + txtCalc.Text;
        }
        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 val = 0;
            bool stan = StandardToolStripMenuItem.Checked;
            if (StandardToolStripMenuItem.Checked)
                val = 1;
            com.Config.SetConfig("SciCalc", "layout", val.ToString());
            panStandard.Visible = StandardToolStripMenuItem.Checked;
            StandardToolStripMenuItem.Checked = ScientificToolStripMenuItem.Checked;
            ScientificToolStripMenuItem.Checked = stan;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dblMem = 0;
            prevNum = 0;
            operation = "";
            operation_pressed = false;
        }
        private void btnMemStore_Click(object sender, EventArgs e)
        {
            dblMem = Double.Parse(txtCalc.Text);
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // txtCalc.Text = solve()
            switch (operation)
            {
                case "+":
                    {
                        txtCalc.Text = (prevNum + double.Parse(txtCalc.Text)).ToString();
                        break;
                    }

                case "-":
                    {
                        txtCalc.Text = (prevNum - double.Parse(txtCalc.Text)).ToString();
                        break;
                    }

                case "X" // was *
         :
                    {
                        txtCalc.Text = (prevNum * double.Parse(txtCalc.Text)).ToString();
                        break;
                    }

                case "/":
                    {
                        txtCalc.Text = (prevNum / double.Parse(txtCalc.Text)).ToString();
                        break;
                    }
            }
            txtHidden.Focus();
            prevNum = Double.Parse(txtCalc.Text);
            operation = "";
        }
        private void Button25_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text.Length > 1)
                txtCalc.Text = txtCalc.Text.Remove(txtCalc.TextLength - 1, 1);
            else
                numEnter("back");
        }
        private void btnMemClear_Click(object sender, EventArgs e)
        {
            dblMem = 0;
        }
        private void txtCalc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) // Add for other keys, and add memory, move all current controls to a panel for standard and then create for sci, with a txtbox var to save code
        {
            String k = (e.KeyData.ToString());
            // MessageBox.Show(k)
            if (char.IsDigit(k[0]))
                numEnter(k.ToString());
        }
    }
}