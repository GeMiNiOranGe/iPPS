
namespace GUI {
    partial class FormStatus {
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
            this.flPanelAllProject = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flPanelAllProject
            // 
            this.flPanelAllProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelAllProject.Location = new System.Drawing.Point(0, 0);
            this.flPanelAllProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flPanelAllProject.Name = "flPanelAllProject";
            this.flPanelAllProject.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.flPanelAllProject.Size = new System.Drawing.Size(800, 450);
            this.flPanelAllProject.TabIndex = 0;
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flPanelAllProject);
            this.Name = "FormStatus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanelAllProject;
    }
}

