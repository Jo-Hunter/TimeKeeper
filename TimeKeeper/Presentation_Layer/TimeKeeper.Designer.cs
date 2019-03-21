namespace TimeKeeper
{
    partial class frmTimeKeeperMain
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
            this.lblTopic = new System.Windows.Forms.Label();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.chkTopicArchive = new System.Windows.Forms.CheckBox();
            this.chkArchivedProject = new System.Windows.Forms.CheckBox();
            this.rbNewNote = new System.Windows.Forms.RadioButton();
            this.rbOpenExisting = new System.Windows.Forms.RadioButton();
            this.rbSelectNotes = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddTags = new System.Windows.Forms.Button();
            this.btnAddLinks = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStartControls = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbStartControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(6, 16);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(99, 13);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "Choose your Topic:";
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Location = new System.Drawing.Point(138, 16);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(99, 21);
            this.cbTopic.TabIndex = 2;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(6, 63);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(105, 13);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Choose your Project:";
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(138, 63);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(99, 21);
            this.cbProject.TabIndex = 4;
            // 
            // chkTopicArchive
            // 
            this.chkTopicArchive.AutoSize = true;
            this.chkTopicArchive.Location = new System.Drawing.Point(307, 16);
            this.chkTopicArchive.Name = "chkTopicArchive";
            this.chkTopicArchive.Size = new System.Drawing.Size(117, 17);
            this.chkTopicArchive.TabIndex = 5;
            this.chkTopicArchive.Text = "Check for Archived";
            this.chkTopicArchive.UseVisualStyleBackColor = true;
            // 
            // chkArchivedProject
            // 
            this.chkArchivedProject.AutoSize = true;
            this.chkArchivedProject.Location = new System.Drawing.Point(307, 63);
            this.chkArchivedProject.Name = "chkArchivedProject";
            this.chkArchivedProject.Size = new System.Drawing.Size(117, 17);
            this.chkArchivedProject.TabIndex = 6;
            this.chkArchivedProject.Text = "Check for Archived";
            this.chkArchivedProject.UseVisualStyleBackColor = true;
            // 
            // rbNewNote
            // 
            this.rbNewNote.AutoSize = true;
            this.rbNewNote.Location = new System.Drawing.Point(24, 31);
            this.rbNewNote.Name = "rbNewNote";
            this.rbNewNote.Size = new System.Drawing.Size(187, 17);
            this.rbNewNote.TabIndex = 7;
            this.rbNewNote.TabStop = true;
            this.rbNewNote.Text = "Open New Study Notes document";
            this.rbNewNote.UseVisualStyleBackColor = true;
            this.rbNewNote.Visible = false;
            // 
            // rbOpenExisting
            // 
            this.rbOpenExisting.AutoSize = true;
            this.rbOpenExisting.Location = new System.Drawing.Point(24, 70);
            this.rbOpenExisting.Name = "rbOpenExisting";
            this.rbOpenExisting.Size = new System.Drawing.Size(112, 17);
            this.rbOpenExisting.TabIndex = 8;
            this.rbOpenExisting.TabStop = true;
            this.rbOpenExisting.Text = "Open Study Notes";
            this.rbOpenExisting.UseVisualStyleBackColor = true;
            this.rbOpenExisting.CheckedChanged += new System.EventHandler(this.rbOpenExisting_CheckedChanged);
            // 
            // rbSelectNotes
            // 
            this.rbSelectNotes.AutoSize = true;
            this.rbSelectNotes.Location = new System.Drawing.Point(24, 110);
            this.rbSelectNotes.Name = "rbSelectNotes";
            this.rbSelectNotes.Size = new System.Drawing.Size(175, 17);
            this.rbSelectNotes.TabIndex = 9;
            this.rbSelectNotes.TabStop = true;
            this.rbSelectNotes.Text = "Select Study Notes (don\'t open)";
            this.rbSelectNotes.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddTags
            // 
            this.btnAddTags.Location = new System.Drawing.Point(37, 42);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(75, 23);
            this.btnAddTags.TabIndex = 10;
            this.btnAddTags.Text = "Add tags";
            this.btnAddTags.UseVisualStyleBackColor = true;
            // 
            // btnAddLinks
            // 
            this.btnAddLinks.Location = new System.Drawing.Point(204, 42);
            this.btnAddLinks.Name = "btnAddLinks";
            this.btnAddLinks.Size = new System.Drawing.Size(75, 23);
            this.btnAddLinks.TabIndex = 11;
            this.btnAddLinks.Text = "Add Links";
            this.btnAddLinks.UseVisualStyleBackColor = true;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(343, 42);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddInfo.TabIndex = 12;
            this.btnAddInfo.Text = "Add Info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTopic);
            this.groupBox1.Controls.Add(this.cbTopic);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.chkArchivedProject);
            this.groupBox1.Controls.Add(this.cbProject);
            this.groupBox1.Controls.Add(this.chkTopicArchive);
            this.groupBox1.Location = new System.Drawing.Point(35, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNewNote);
            this.groupBox2.Controls.Add(this.rbOpenExisting);
            this.groupBox2.Controls.Add(this.rbSelectNotes);
            this.groupBox2.Location = new System.Drawing.Point(35, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 140);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddInfo);
            this.groupBox3.Controls.Add(this.btnAddLinks);
            this.groupBox3.Controls.Add(this.btnAddTags);
            this.groupBox3.Location = new System.Drawing.Point(35, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicsToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topicsToolStripMenuItem.Text = "Topics";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // gbStartControls
            // 
            this.gbStartControls.Controls.Add(this.btnStop);
            this.gbStartControls.Controls.Add(this.btnStart);
            this.gbStartControls.Location = new System.Drawing.Point(361, 168);
            this.gbStartControls.Name = "gbStartControls";
            this.gbStartControls.Size = new System.Drawing.Size(225, 139);
            this.gbStartControls.TabIndex = 0;
            this.gbStartControls.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(38, 106);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(162, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmTimeKeeperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.gbStartControls);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTimeKeeperMain";
            this.Text = "TimeKeeper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStartControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.CheckBox chkTopicArchive;
        private System.Windows.Forms.CheckBox chkArchivedProject;
        private System.Windows.Forms.RadioButton rbNewNote;
        private System.Windows.Forms.RadioButton rbOpenExisting;
        private System.Windows.Forms.RadioButton rbSelectNotes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAddTags;
        private System.Windows.Forms.Button btnAddLinks;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbStartControls;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

