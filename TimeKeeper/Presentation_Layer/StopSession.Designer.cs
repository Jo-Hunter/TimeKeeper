namespace TimeKeeper.Presentation_Layer
{
    partial class frmStop
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
            this.lblStop = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(29, 25);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(0, 13);
            this.lblStop.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(49, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(164, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Current Session";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(49, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(49, 22);
            this.txtStop.Multiline = true;
            this.txtStop.Name = "txtStop";
            this.txtStop.ReadOnly = true;
            this.txtStop.Size = new System.Drawing.Size(164, 58);
            this.txtStop.TabIndex = 3;
            this.txtStop.Text = "You have selected a different topic. Do you want to stop the current session?";
            // 
            // frmStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 193);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStop);
            this.Name = "frmStop";
            this.Text = "Stop Session";
            this.Load += new System.EventHandler(this.frmStop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStop;
    }
}