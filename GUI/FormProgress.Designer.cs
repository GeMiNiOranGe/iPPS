
namespace GUI {
    partial class FormProgress {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flPnlProjectList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flPnlProjectList
            // 
            this.flPnlProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.flPnlProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnlProjectList.Location = new System.Drawing.Point(0, 0);
            this.flPnlProjectList.Name = "flPnlProjectList";
            this.flPnlProjectList.Padding = new System.Windows.Forms.Padding(12);
            this.flPnlProjectList.Size = new System.Drawing.Size(284, 261);
            this.flPnlProjectList.TabIndex = 0;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flPnlProjectList);
            this.Name = "FormProgress";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnlProjectList;
    }
}

