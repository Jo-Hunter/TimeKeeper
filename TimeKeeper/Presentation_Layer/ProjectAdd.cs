using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            // Open dialog works better
            //// this works well. But do I actually need this here? Why am I recording a file location when
            //// I have only yet chosen a file?
            //// Could this be useful to find project stuff? Or would it be restrictive when you have complex projects?
            //// I think... just let this sit for now. Don't hook it up. 

            //// https ://www.c-sharpcorner.com/uploadfile/mahesh/folderbrowserdialog-in-C-Sharp/ 
            //// only selects the folder.


            //// this makes the file dialog chooser pop up.
            //FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            //DialogResult result = folderDlg.ShowDialog();

            ////txtFileDialog.Text = result.ToString();
            //if (result.ToString() == "OK")
            //{
            //    //txtFileDialog.Text = folderDlg.SelectedPath.ToString();
            //    string[] files = Directory.GetFiles(folderDlg.SelectedPath);

            //    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            //}


            // https ://www.codeproject.com/Questions/319007/How-to-select-a-file-in-csharp

            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter =
               //"txt files(*.txt)| *.txt | DOC files(*.doc) | *.doc";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                //richTextBox1.Text = System.IO.File.ReadAllText(fname);
                //MessageBox.Show(fname.ToString());
                txtFileDialog.Text = fname.ToString();

            }


        }
    }
}
