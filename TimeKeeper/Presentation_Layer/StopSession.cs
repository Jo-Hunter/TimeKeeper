using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TimeKeeper;

namespace TimeKeeper.Presentation_Layer
{
    public partial class frmStop : Form
    {
        public frmStop()
        {
            InitializeComponent();
        }

        private void frmStop_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
