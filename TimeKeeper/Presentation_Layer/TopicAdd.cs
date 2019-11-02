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
    public partial class frmTopicAdd : Form
    {
        public frmTopicAdd()
        {
            InitializeComponent();
        }

        private void gbTopic_Enter(object sender, EventArgs e)
        {

        }

        private void lblTopicName_Click(object sender, EventArgs e)
        {

        }

        private void TopicAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTopic.Text))
            {
                MessageBox.Show("Please enter a topic.");

            }
            else
            {

                MessageBox.Show("Not empty");
            }
        }
    }
}
