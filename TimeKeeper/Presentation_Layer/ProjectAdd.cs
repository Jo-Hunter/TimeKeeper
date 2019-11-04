using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper.Presentation_Layer
{
    public partial class frmProjectAdd : Form
    {
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        private void txtFileDialog_Click(object sender, EventArgs e)
        {


            // this works well. But do I actually need this here? Why am I recording a file location when
            // I have only yet chosen a file?
            // Could this be useful to find project stuff? Or would it be restrictive when you have complex projects?
            // I think... just let this sit for now. Don't hook it up. 


            // this makes the file dialog chooser pop up.
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            //txtFileDialog.Text = result.ToString();
            if (result.ToString() == "OK")
            {
                txtFileDialog.Text = folderDlg.SelectedPath.ToString();
            }
        }
    }
}
