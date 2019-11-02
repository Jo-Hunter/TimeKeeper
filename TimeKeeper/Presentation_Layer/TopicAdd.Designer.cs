namespace TimeKeeper.Presentation_Layer
{
    partial class frmTopicAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbIdentification = new System.Windows.Forms.GroupBox();
            this.gbTopic = new System.Windows.Forms.GroupBox();
            this.gbTopicButtons = new System.Windows.Forms.GroupBox();
            this.lblTopicIdentification = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbIdentification.SuspendLayout();
            this.gbTopic.SuspendLayout();
            this.gbTopicButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIdentification
            // 
            this.gbIdentification.Controls.Add(this.lblTopicIdentification);
            this.gbIdentification.Location = new System.Drawing.Point(44, 29);
            this.gbIdentification.Name = "gbIdentification";
            this.gbIdentification.Size = new System.Drawing.Size(345, 74);
            this.gbIdentification.TabIndex = 0;
            this.gbIdentification.TabStop = false;
            // 
            // gbTopic
            // 
            this.gbTopic.Controls.Add(this.tbTopic);
            this.gbTopic.Controls.Add(this.lblTopicName);
            this.gbTopic.Location = new System.Drawing.Point(44, 109);
            this.gbTopic.Name = "gbTopic";
            this.gbTopic.Size = new System.Drawing.Size(345, 76);
            this.gbTopic.TabIndex = 1;
            this.gbTopic.TabStop = false;
            this.gbTopic.Enter += new System.EventHandler(this.gbTopic_Enter);
            // 
            // gbTopicButtons
            // 
            this.gbTopicButtons.Controls.Add(this.btnCancel);
            this.gbTopicButtons.Controls.Add(this.btnAdd);
            this.gbTopicButtons.Location = new System.Drawing.Point(44, 191);
            this.gbTopicButtons.Name = "gbTopicButtons";
            this.gbTopicButtons.Size = new System.Drawing.Size(345, 73);
            this.gbTopicButtons.TabIndex = 2;
            this.gbTopicButtons.TabStop = false;
            // 
            // lblTopicIdentification
            // 
            this.lblTopicIdentification.AutoSize = true;
            this.lblTopicIdentification.Location = new System.Drawing.Point(27, 20);
            this.lblTopicIdentification.Name = "lblTopicIdentification";
            this.lblTopicIdentification.Size = new System.Drawing.Size(191, 13);
            this.lblTopicIdentification.TabIndex = 0;
            this.lblTopicIdentification.Text = "Topic will automatically give itself an ID";
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Location = new System.Drawing.Point(27, 30);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(37, 13);
            this.lblTopicName.TabIndex = 0;
            this.lblTopicName.Text = "Topic:";
            this.lblTopicName.Click += new System.EventHandler(this.lblTopicName_Click);
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(125, 30);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(194, 20);
            this.tbTopic.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTopicAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 293);
            this.Controls.Add(this.gbTopicButtons);
            this.Controls.Add(this.gbTopic);
            this.Controls.Add(this.gbIdentification);
            this.Name = "frmTopicAdd";
            this.Text = "Add New Topic";
            this.Load += new System.EventHandler(this.TopicAdd_Load);
            this.gbIdentification.ResumeLayout(false);
            this.gbIdentification.PerformLayout();
            this.gbTopic.ResumeLayout(false);
            this.gbTopic.PerformLayout();
            this.gbTopicButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIdentification;
        private System.Windows.Forms.GroupBox gbTopic;
        private System.Windows.Forms.Label lblTopicIdentification;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.GroupBox gbTopicButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}