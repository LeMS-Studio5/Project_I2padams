using System;
using libLeMS;
namespace WinMine
{
    public partial class CustomMineSweeperDialog
    {
        private MasterClass com = new MasterClass();
        private ConfigHelper configMine;

        public CustomMineSweeperDialog()
        {
            // This call is required by the designer.
            InitializeComponent();
            configMine = new ConfigHelper(com.toSystemPath(@"C:\WINDOWS\winmine.ini"));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Hide();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Hide();
        }
        private void CustomMineSweeperDialog_Load(object sender, EventArgs e)
        {
            try
            {
                txtHeight.Text = configMine.GetConfig("Minesweeper", "Height").Setting;
                txtWidth.Text = configMine.GetConfig("Minesweeper", "Width").Setting;
                txtMines.Text = configMine.GetConfig("Minesweeper","Mines").Setting;
                txtHeight.Focus();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public System.Windows.Forms.DialogResult ShowDialog()
        {
            Show();
            return DialogResult;
        }
    }
}