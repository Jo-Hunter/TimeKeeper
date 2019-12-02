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
    public partial class frmLinksMaint : Form
    {
        public frmLinksMaint()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddLink addL = new frmAddLink();
            addL.ShowDialog();
            this.Hide();

        }
    }
}
