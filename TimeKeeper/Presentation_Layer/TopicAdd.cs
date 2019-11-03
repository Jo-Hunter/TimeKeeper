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
using System.Data.SqlClient;
using TimeKeeper.Data_Layer;

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
            if (GlobalVariables.selectedCategoryID > 0)
            {
                txtTopicID.Visible = true;
                lblTopicIdentification.Text = "Topic ID:";
                txtTopicID.Text = GlobalVariables.selectedCategoryID.ToString();
                this.Text = "Update Topic";
                btnAdd.Text = "Update";
            }
            else
            {
                txtTopicID.Visible = false;
                lblTopicIdentification.Text = "Topic will automatically give itself an ID";
                this.Text = "Add New Topic";
                btnAdd.Text = "Add";
            }
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

                Topics topic = new Topics(GlobalVariables.selectedCategoryID, tbTopic.Text);

                string addQuery;

                // determine if add or update
                if(GlobalVariables.selectedCategoryID == 0)
                {
                    addQuery = "sp_Topics_CreateTopic";
                }
                else
                {
                    addQuery = "sp_Topics_UpdateTopic";
                }

                // ake connection etc
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(addQuery, conn);

                // Tell program to I am using a stored proc.
                cmd.CommandType = CommandType.StoredProcedure;

                if (GlobalVariables.selectedCategoryID != 0)
                {
                    cmd.Parameters.AddWithValue("@TopicID", topic.TopicID);
                }

                cmd.Parameters.AddWithValue("@TopicName", topic.TopicName);

                if (GlobalVariables.selectedCategoryID == 0)
                {
                    cmd.Parameters.AddWithValue("@NewTopicID", SqlDbType.Int).Direction = ParameterDirection.Output;

                }   

                // Use transaction to send data to db
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                // Close connection, close form.
                conn.Close();

            }
            this.Close();
        }
    }
}
