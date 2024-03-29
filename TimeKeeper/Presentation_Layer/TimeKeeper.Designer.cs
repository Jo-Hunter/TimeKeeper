﻿namespace TimeKeeper
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
            this.rbNewNote = new System.Windows.Forms.RadioButton();
            this.rbOpenExisting = new System.Windows.Forms.RadioButton();
            this.rbSelectNotes = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddLinks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStartControls = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.cbTopic.SelectedIndexChanged += new System.EventHandler(this.cbTopic_SelectedIndexChanged);
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
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
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
            this.rbNewNote.CheckedChanged += new System.EventHandler(this.rbNewNote_CheckedChanged);
            // 
            // rbOpenExisting
            // 
            this.rbOpenExisting.AutoSize = true;
            this.rbOpenExisting.Location = new System.Drawing.Point(24, 97);
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
            this.rbSelectNotes.Location = new System.Drawing.Point(24, 163);
            this.rbSelectNotes.Name = "rbSelectNotes";
            this.rbSelectNotes.Size = new System.Drawing.Size(175, 17);
            this.rbSelectNotes.TabIndex = 9;
            this.rbSelectNotes.TabStop = true;
            this.rbSelectNotes.Text = "Select Study Notes (don\'t open)";
            this.rbSelectNotes.UseVisualStyleBackColor = true;
            this.rbSelectNotes.CheckedChanged += new System.EventHandler(this.rbSelectNotes_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddLinks
            // 
            this.btnAddLinks.Location = new System.Drawing.Point(364, 11);
            this.btnAddLinks.Name = "btnAddLinks";
            this.btnAddLinks.Size = new System.Drawing.Size(162, 23);
            this.btnAddLinks.TabIndex = 11;
            this.btnAddLinks.Text = "Add Links";
            this.btnAddLinks.UseVisualStyleBackColor = true;
            this.btnAddLinks.Click += new System.EventHandler(this.btnAddLinks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLinks);
            this.groupBox1.Controls.Add(this.lblTopic);
            this.groupBox1.Controls.Add(this.cbTopic);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.cbProject);
            this.groupBox1.Location = new System.Drawing.Point(35, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 100);
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
            this.groupBox2.Size = new System.Drawing.Size(296, 213);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicsTSMI,
            this.projectsToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // topicsTSMI
            // 
            this.topicsTSMI.Name = "topicsTSMI";
            this.topicsTSMI.Size = new System.Drawing.Size(116, 22);
            this.topicsTSMI.Text = "Topics";
            this.topicsTSMI.Click += new System.EventHandler(this.topicsToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.linksToolStripMenuItem.Text = "Links";
            this.linksToolStripMenuItem.Click += new System.EventHandler(this.linksToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // gbStartControls
            // 
            this.gbStartControls.Controls.Add(this.lblStartInfo);
            this.gbStartControls.Controls.Add(this.btnStop);
            this.gbStartControls.Controls.Add(this.btnStart);
            this.gbStartControls.Location = new System.Drawing.Point(361, 168);
            this.gbStartControls.Name = "gbStartControls";
            this.gbStartControls.Size = new System.Drawing.Size(225, 212);
            this.gbStartControls.TabIndex = 0;
            this.gbStartControls.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(38, 162);
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
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Location = new System.Drawing.Point(38, 96);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(0, 13);
            this.lblStartInfo.TabIndex = 2;
            this.lblStartInfo.Visible = false;
            // 
            // frmTimeKeeperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 392);
            this.Controls.Add(this.gbStartControls);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTimeKeeperMain";
            this.Text = "TimeKeeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimeKeeperMain_FormClosed);
            this.Load += new System.EventHandler(this.frmTimeKeeperMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStartControls.ResumeLayout(false);
            this.gbStartControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.RadioButton rbNewNote;
        private System.Windows.Forms.RadioButton rbOpenExisting;
        private System.Windows.Forms.RadioButton rbSelectNotes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAddLinks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicsTSMI;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbStartControls;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label lblStartInfo;
    }
}

