﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TimeKeeper.Data_Layer;
using TimeKeeper.Business_Layer;



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
            DisplayProjects();

        }

        private void DisplayProjects()
        {
            // Query string
            string getProjects = "SELECT * FROM Projects";

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                // Open the connection.
                conn.Open();
                // Init the SqlCommand with the query and the connection. 
                SqlCommand cmd = new SqlCommand(getProjects, conn);

                // Init the reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop each row.
                while (sdr.Read())
                {
                   
                    // Probelm with bool
                    Project project = new Project();
                    project.ProjectID = int.Parse(sdr["ProjectID"].ToString());
                    project.ProjectName = sdr["ProjectName"].ToString();
                    //project.TopicID = int.Parse(sdr["TopicID"].ToString());
                    project.CodeLocation = sdr["CodeLocation"].ToString();
                    project.Archive = bool.Parse(sdr["Archive"].ToString());
                    project.TypeID = int.Parse(sdr["TypeID"].ToString());

                    
                    // Init the ListView by giving the PK.
                    ListViewItem lvi = new ListViewItem(project.ProjectID.ToString());
                    // Submit the information going in the other column/s.
                    lvi.SubItems.Add(project.ProjectName);
                    //lvi.SubItems.Add(project.TopicID.ToString());
                    lvi.SubItems.Add(project.CodeLocation);
                    lvi.SubItems.Add(project.Archive.ToString());
                    lvi.SubItems.Add(project.TypeID.ToString());
                    
                    //// Add the items to the listview.
                   
                    lvProjects.Items.Add(lvi);

                }

                // If the reader has been opened.
                if (sdr != null)
                {
                    // Close it.
                    sdr.Close();
                }
                // Close the connection.
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
            



        }
    }
}
