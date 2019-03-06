using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper
{
    public partial class frmTimeKeeperMain : Form
    {
        public frmTimeKeeperMain()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOpenExisting_CheckedChanged(object sender, EventArgs e)
        {
            // this only opens the dialog and doesn't open a file... 
            // just need to check on github auth
            openFileDialog1.ShowDialog();
        }
    }
}
