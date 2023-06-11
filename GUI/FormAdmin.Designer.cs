
namespace GUI {
    partial class FormAdmin {
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
            this.BtnTask = new System.Windows.Forms.Button();
            this.BtnProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTask
            // 
            this.BtnTask.Location = new System.Drawing.Point(130, 173);
            this.BtnTask.Name = "BtnTask";
            this.BtnTask.Size = new System.Drawing.Size(183, 71);
            this.BtnTask.TabIndex = 0;
            this.BtnTask.Text = "Công Việc";
            this.BtnTask.UseVisualStyleBackColor = true;
            this.BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // BtnProject
            // 
            this.BtnProject.Location = new System.Drawing.Point(466, 173);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Size = new System.Drawing.Size(183, 71);
            this.BtnProject.TabIndex = 0;
            this.BtnProject.Text = "Dự án";
            this.BtnProject.UseVisualStyleBackColor = true;
            this.BtnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProject);
            this.Controls.Add(this.BtnTask);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTask;
        private System.Windows.Forms.Button BtnProject;
    }
}