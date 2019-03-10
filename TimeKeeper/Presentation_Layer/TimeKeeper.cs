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

                cmd.Parameters.AddWithValue("@NewSessionID", SqlDbType.Int).Direction = ParameterDirection.Output;
                //MessageBox.Show("ID equals " + cmd.Parameters["@NewSessionID"].Value.ToString());
                // record stsored proc output to local variable.
                GlobalVariables.currentSessionID = int.Parse(cmd.Parameters["@NewSessionID"].Value.ToString());

                // Not sure why this doesn't work but mafs is on haha.
                // It seems the same as the assignment I did but no.
                // The output above in the message box is "INT'. ??

                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("unsuccessful " + ex);
            }
            


        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            // Create a global variable to hold the sessionID until the session is closed.
            // Below is copy paste start, edit accordingly.

            DateTime end = DateTime.Now;


            // Save it into the class. 


            Session session = new Session();
            session.SessionID = int.Parse(GlobalVariables.currentSessionID);
            session.StopTime = end;


            MessageBox.Show("session id, session stop: " + session.SessionID + ", " + session.StopTime);

            //string addQuery = "sp_Sessions_NewSession";
            string updateQuery = "sp_Sessions_EndSession";


            try
            {
                MessageBox.Show("entered try");
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
    }
}
