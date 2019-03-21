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
    public partial class frmNotes : Form
    {
        public frmNotes()
        {
            InitializeComponent();
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            displayNotes();
        }
        private void displayNotes()
        {
            string selectQuery = "SELECT * from Notes";

            SqlConnection con = ConnectionManager.DatabaseConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(selectQuery, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    Notes note = new Notes();
                    note.NotesID = int.Parse(sdr["NotesID"].ToString());
                    note.FileName = sdr["FileName"].ToString();
                    note.FileLocation = sdr["FileLocation"].ToString();
                    if (!DBNull.Value.Equals(sdr["NoteType"]))
                    {
                        note.NoteType = sdr["NoteType"].ToString();
                    }

                    ListViewItem lvi = new ListViewItem(note.NotesID.ToString());
                    lvi.SubItems.Add(note.FileName);
                    lvi.SubItems.Add(note.FileLocation);
                    lvi.SubItems.Add(note.NoteType);

                    lvNotes.Items.Add(lvi);


                }







                if (sdr != null)
                {
                    sdr.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful " + ex);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
