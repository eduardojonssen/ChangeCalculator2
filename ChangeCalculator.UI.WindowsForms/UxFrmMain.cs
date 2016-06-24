using ChangeCalculator.Core;
using ChangeCalculator.Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator.UI.WindowsForms
{
    public partial class UxFrmMain : Form
    {
        

        public UxFrmMain()
        {
           
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UxFrmAbout uxFrmAbout = new UxFrmAbout();
            uxFrmAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UxFrmChangeCalculator uxFrmChangeCalculator = new UxFrmChangeCalculator();
         //   uxFrmChangeCalculator.MdiParent = this;
            uxFrmChangeCalculator.Show();

        }
    }
}
