namespace TimeKeeper.Presentation_Layer
{
    partial class frmProjectAdd
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
            this.gbProjectID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.txtFileDialog = new System.Windows.Forms.TextBox();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbProjectID.SuspendLayout();
            this.gbProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProjectID
            // 
            this.gbProjectID.Controls.Add(this.txtID);
            this.gbProjectID.Controls.Add(this.lblID);
            this.gbProjectID.Location = new System.Drawing.Point(13, 13);
            this.gbProjectID.Name = "gbProjectID";
            this.gbProjectID.Size = new System.Drawing.Size(507, 69);
            this.gbProjectID.TabIndex = 0;
            this.gbProjectID.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(205, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(270, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(197, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID number will be automatically assigned";
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.txtFileDialog);
            this.gbProperties.Controls.Add(this.cbTopic);
            this.gbProperties.Controls.Add(this.txtName);
            this.gbProperties.Controls.Add(this.lblLocation);
            this.gbProperties.Controls.Add(this.lblTopic);
            this.gbProperties.Controls.Add(this.lblName);
            this.gbProperties.Location = new System.Drawing.Point(13, 89);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(507, 119);
            this.gbProperties.TabIndex = 1;
            this.gbProperties.TabStop = false;
            // 
            // txtFileDialog
            // 
            this.txtFileDialog.Location = new System.Drawing.Point(205, 78);
            this.txtFileDialog.Name = "txtFileDialog";
            this.txtFileDialog.Size = new System.Drawing.Size(270, 20);
            this.txtFileDialog.TabIndex = 9;
            this.txtFileDialog.Click += new System.EventHandler(this.txtFileDialog_Click);
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Location = new System.Drawing.Point(205, 49);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(270, 21);
            this.cbTopic.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(205, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(36, 78);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "File Location:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(36, 49);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(40, 13);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "Topic: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Project Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbProperties);
            this.Controls.Add(this.gbProjectID);
            this.Name = "frmProjectAdd";
            this.Text = "ProjectAdd";
            this.gbProjectID.ResumeLayout(false);
            this.gbProjectID.PerformLayout();
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProjectID;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}