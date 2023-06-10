
namespace GUI {
    partial class Employee {
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
            this.BtnProject = new System.Windows.Forms.Button();
            this.BtnTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProject
            // 
            this.BtnProject.Location = new System.Drawing.Point(466, 182);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Size = new System.Drawing.Size(183, 71);
            this.BtnProject.TabIndex = 1;
            this.BtnProject.Text = "Dự án";
            this.BtnProject.UseVisualStyleBackColor = true;
            this.BtnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // BtnTask
            // 
            this.BtnTask.Location = new System.Drawing.Point(130, 182);
            this.BtnTask.Name = "BtnTask";
            this.BtnTask.Size = new System.Drawing.Size(183, 71);
            this.BtnTask.TabIndex = 2;
            this.BtnTask.Text = "Công Việc";
            this.BtnTask.UseVisualStyleBackColor = true;
            this.BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProject);
            this.Controls.Add(this.BtnTask);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProject;
        private System.Windows.Forms.Button BtnTask;
    }
}