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
    public partial class frmProjects : Form
    {
        public frmProjects()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            // TODO read from the database and add all the data into the listview columns.
        }
    }
}
