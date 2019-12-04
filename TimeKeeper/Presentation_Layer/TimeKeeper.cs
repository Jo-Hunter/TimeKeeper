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
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

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


            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter =
            //   "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                //MessageBox.Show(fname.ToString());


                ProcessStartInfo startInfo = new ProcessStartInfo();
                Process.Start("WINWORD.EXE", "\"" + fname.ToString() + "\"");

                // how to record in database
                //GlobalVariables.sess.SessionLinksID = 

                // so my thinking is... table for file ID file name, file location
                // multi entry table to link session with files - file ID, session ID

                // will need to either move where to open file or when I hit start session keep the last 
                //file path I opened through the program? Shouldn't be hard wither something will exist 
                //in file path or it will be null if nothing open yet.

            }
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
            if (cbTopic.Text != null)
            {
                MessageBox.Show("topic is ! null");
            }
            else
            {
                MessageBox.Show("topic is null");
            }
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

            lblStartInfo.Text = "Session in progress. \nTopic: " + GlobalVariables.selectedTopicName + 
                "\nProject: " + GlobalVariables.selectedProjectName;
            lblStartInfo.Visible = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CloseSession();
            //DateTime end = DateTime.Now;
            
            //// Create a session using the current session ID with the new information.
            //Session session = new Session();
            //session.SessionID = int.Parse(GlobalVariables.currentSessionID.ToString());
            //session.StopTime = end;


            //string updateQuery = "sp_Sessions_EndSession";

            //try
            //{
                
            //    SqlConnection conn = ConnectionManager.DatabaseConnection();
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(updateQuery, conn);

            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@SessionID", session.SessionID);
            //    cmd.Parameters.AddWithValue("@StopTime", session.StopTime);

            //    cmd.Transaction = conn.BeginTransaction();
            //    cmd.ExecuteNonQuery();
            //    cmd.Transaction.Commit();

            //    conn.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("unsuccessful " + ex);
            //}
            //GlobalVariables.currentSessionID = 0;
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjects pro = new frmProjects();
            pro.ShowDialog();
            this.Hide();
            
        }

        //private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmNotes notes = new frmNotes();
        //    notes.ShowDialog();
        //    this.Hide();
            
        //}

        private void topicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmTopic topic = new frmTopic();
            topic.ShowDialog();
            //this.Close();

        }

        private void frmTimeKeeperMain_Load(object sender, EventArgs e)
        {

            if (GlobalVariables.currentSessionID == 0)
            {
                //MessageBox.Show("load with no current session");
                preFillComboBoxes();
            }
            
            

            

            // if project combobox is written in, it should save a new project, and popup to attach a topic
            // it should activate if the use leaves the box, and there is something in it
            // the popup form should also have an opportunity to cancel and correct the project in case they 
            // just left it.
            
        }

        private void preFillComboBoxes()
        {

            string selectTopic = "SELECT * FROM Topics";
           

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                MessageBox.Show("prefill topics");
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectTopic, conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    Topics top = new Topics();
                    top.TopicName = sdr["TopicName"].ToString();
                    top.TopicID = int.Parse(sdr["TopicID"].ToString());

                    cbTopic.Items.Add(top.TopicName);                    
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

        }

        private void rbSelectNotes_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter =
            //   "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                //MessageBox.Show(fname.ToString());

                // record in database this file, this session 

            }
        }

        private void rbNewNote_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Header text goes here";
                }

                //Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Footer text goes here";
                }

                //adding text to document  
                document.Content.SetRange(0, 0);
                document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Para 1 text";
                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();

                //Create a 5X5 table and insert some dummy record  
                Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here  
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row  
                        else
                        {
                            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                        }
                    }
                }

                //Save the document  
                object filename = @"c:\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddLinks_Click(object sender, EventArgs e)
        {
            frmAddLink addL = new frmAddLink();
            addL.Show();
            //this.Hide();
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinksMaint linksM = new frmLinksMaint();
            linksM.ShowDialog();
            this.Hide();
        }

        private void frmTimeKeeperMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalVariables.currentSessionID != 0)
            {

                MessageBox.Show("session was not stopped");
                CloseSession();
            }
            else
            {
                MessageBox.Show("no current session open");
            }
        }

        public void CloseSession()
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

            // close off globals and clear form.
            GlobalVariables.currentSessionID = 0;
            GlobalVariables.selectedTopicID = 0;
            GlobalVariables.selectedCategoryID = 0;
            cbTopic.Text = null;
            cbProject.Text = null;

        }

        //if topic changed, check if there is a session in progress, and if so, 
        // stop and display a popup box with a info and a button.
        private void cbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            // if there is a current session running and I haven't programmatically replaced the old topic
            if (GlobalVariables.currentSessionID!=0 && cbTopic.Text != GlobalVariables.selectedTopicName)
            {
                // open the stop session form
                frmStop st = new frmStop();
                st.ShowDialog();
                // once closed, clear ???
                //cbProject.Items.Clear();

                // if user has cancelled and wants to continue the current session
                if (GlobalVariables.currentSessionID != 0)
                {
                    // return the topic to what it was before they changed it
                    cbTopic.Text = GlobalVariables.selectedTopicName;
                    
                }
            }


            //MessageBox.Show("selected = " + cbTopic.Text + "saved topic = " + GlobalVariables.selectedTopicName);
            //MessageBox.Show("the saved topic name is " + GlobalVariables.selectedTopicName);
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            // if the topic has in fact changed (this will skip if user cancelled)
            if (cbTopic.Text != GlobalVariables.selectedTopicName)
            {
                MessageBox.Show("condition: the topic name has changed");

                // antoher way of doing this is to hava a hidden list on the form that records the number.
                // but for now I am going to grab it from the database.

                string getID = "SELECT * FROM Topics WHERE TopicName = " + "'" + cbTopic.Text + "'";

                try // try to get the Topic ID number using the name and save in globals
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(getID, conn);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {

                        Topics top = new Topics();
                        top.TopicName = sdr["TopicName"].ToString();
                        top.TopicID = int.Parse(sdr["TopicID"].ToString());

                        GlobalVariables.selectedTopicID = top.TopicID;
                        GlobalVariables.selectedTopicName = top.TopicName;
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




                string selectProject = "SELECT * FROM Projects WHERE TopicID = " + GlobalVariables.selectedTopicID;

                try // populate the project list (needed the topic ID to do so)
                {
                    //MessageBox.Show("try to populate the project list");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectProject, conn);

                    SqlDataReader sdr = cmd.ExecuteReader();


                    while (sdr.Read())
                    {

                        Project pro = new Project();
                        pro.ProjectName = sdr["ProjectName"].ToString();

                        cbProject.Items.Add(pro.ProjectName);
                        MessageBox.Show("add a project");
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

            }
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {

            // if the topic has changed, prefill should be dealth with in topic.

            GlobalVariables.selectedProjectName = cbProject.Text;

            // need to get ProjectID so that I can insert it into the database
            // into the UI, put a combobox that is paired with names, so here I can compare indexes
            // do it for topics too

            //-----------------------------------------------

            //// pop up box, you have selected XXX project, are you ready to start a new session? yes/cancel
            
            //----------------------
            
            //MessageBox.Show("project index changed");

            //string selectProject = "SELECT * FROM Projects WHERE TopicID = " + GlobalVariables.selectedTopicID;
            
            
            
            
            ////MessageBox.Show(selectProject);
            //SqlConnection conn = ConnectionManager.DatabaseConnection();

            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(selectProject, conn);

            //    SqlDataReader sdr = cmd.ExecuteReader();




            //    while (sdr.Read())
            //    {

            //        Project pro = new Project();
            //        pro.ProjectName = sdr["ProjectName"].ToString();

            //        cbProject.Items.Add(pro.ProjectName);
            //        MessageBox.Show("auto triggered ad a project");
            //    }





            //    if (sdr != null)
            //    {
            //        sdr.Close();
            //    }

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("unsuccessful " + ex);
            //}
        }
    }
}
