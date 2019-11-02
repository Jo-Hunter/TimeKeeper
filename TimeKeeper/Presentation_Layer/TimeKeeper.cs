using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeper.Business_Layer;
using TimeKeeper.Data_Layer;
using System.Data.SqlClient;
using TimeKeeper.Presentation_Layer;

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
            //openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// This button currently saves the starttime into the sessions table, alone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            
            // Save it into the class. 
            Session session = new Session();
            session.StartTime = start;
            
            string addQuery = "sp_Sessions_NewSession";

            try
            {
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(addQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                cmd.Parameters.Add("@NewSessionID", SqlDbType.Int).Direction = ParameterDirection.Output;
                
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                // Save ID in a global to keep track of current session.
                GlobalVariables.currentSessionID = int.Parse(cmd.Parameters["@NewSessionID"].Value.ToString());

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("unsuccessful " + ex);
            }
            


        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            DateTime end = DateTime.Now;
            
            // Create a session using the current session ID with the new information.
            Session session = new Session();
            session.SessionID = int.Parse(GlobalVariables.currentSessionID.ToString());
            session.StopTime = end;


            string updateQuery = "sp_Sessions_EndSession";

            try
            {
                
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID", session.SessionID);
                cmd.Parameters.AddWithValue("@StopTime", session.StopTime);

                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("unsuccessful " + ex);
            }
            GlobalVariables.currentSessionID = 0;
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjects pro = new frmProjects();
            pro.ShowDialog();
            this.Hide();
            
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotes notes = new frmNotes();
            notes.ShowDialog();
            this.Hide();
            
        }

        private void topicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmTopic topic = new frmTopic();
            topic.ShowDialog();
            //this.Close();

        }

        private void frmTimeKeeperMain_Load(object sender, EventArgs e)
        {
            preFillComboBoxes();

            // if project combobox is written in, it should save a new project, and popup to attach a topic
            // it should activate if the use leaves the box, and there is something in it
            // the popup form should also have an opportunity to cancel and correct the project in case they 
            // just left it.
            
        }

        private void preFillComboBoxes()
        {

            //string selectTopic = "SELECT * FROM Topics";
            string selectProject = "SELECT * FROM Projects";

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectProject, conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                


                while (sdr.Read())
                {

                    Project pro = new Project();
                    pro.ProjectName = sdr["ProjectName"].ToString();

                    cbProject.Items.Add(pro.ProjectName);
                }





                if (sdr != null)
                {
                    sdr.Close();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("unsuccessful " + ex);
            }
            
            
            
            
            // fill topics, 
            // fill projects
        }
    }
}
