using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TimeKeeper.Business_Layer;
using TimeKeeper.Data_Layer;

namespace TimeKeeper.Presentation_Layer
{
    public partial class frmTopic : Form
    {
        public frmTopic()
        {
            InitializeComponent();
        }

        private void frmTopic_Load(object sender, EventArgs e)
        {
            displayTopics();
        }

        private void displayTopics()
        {
            string selectTopic = "SELECT * FROM Topics";

            SqlConnection conn = ConnectionManager.DatabaseConnection();


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(selectTopic, conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    Topics topic = new Topics();
                    topic.TopicID = int.Parse(sdr["TopicID"].ToString());
                    topic.TopicName = sdr["TopicName"].ToString();

                    ListViewItem lvi = new ListViewItem(topic.TopicID.ToString());
                    lvi.SubItems.Add(topic.TopicName.ToString());

                    lvTopic.Items.Add(lvi);


                }




                if (sdr!=null)
                {
                    sdr.Close();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccesful " + ex);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // closes whole program why?
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTopicAdd topicAdd = new frmTopicAdd();
            topicAdd.ShowDialog();

            lvTopic.Clear();
            displayTopics();
        }
    }
}
