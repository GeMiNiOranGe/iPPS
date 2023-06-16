
namespace GUI
{
    partial class ControlProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPercentProject = new System.Windows.Forms.Label();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblIdProject = new System.Windows.Forms.Label();
            this.lblNameDepartment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPercentProject
            // 
            this.lblPercentProject.AutoSize = true;
            this.lblPercentProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentProject.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPercentProject.Location = new System.Drawing.Point(51, 55);
            this.lblPercentProject.Name = "lblPercentProject";
            this.lblPercentProject.Size = new System.Drawing.Size(96, 42);
            this.lblPercentProject.TabIndex = 0;
            this.lblPercentProject.Text = "50%";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.Location = new System.Drawing.Point(54, 135);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(106, 24);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "Tên dự án";
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProject.Location = new System.Drawing.Point(54, 171);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(75, 20);
            this.lblIdProject.TabIndex = 2;
            this.lblIdProject.Text = "Mã dự án";
            // 
            // lblNameDepartment
            // 
            this.lblNameDepartment.AutoSize = true;
            this.lblNameDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDepartment.Location = new System.Drawing.Point(31, 191);
            this.lblNameDepartment.Name = "lblNameDepartment";
            this.lblNameDepartment.Size = new System.Drawing.Size(98, 20);
            this.lblNameDepartment.TabIndex = 3;
            this.lblNameDepartment.Text = "Tên bộ phận";
            // 
            // ControlProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblNameDepartment);
            this.Controls.Add(this.lblIdProject);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.lblPercentProject);
            this.Name = "ControlProject";
            this.Size = new System.Drawing.Size(191, 226);
            this.Click += new System.EventHandler(this.ControlProject_Click);
            this.MouseEnter += new System.EventHandler(this.ControlProject_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ControlProject_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentProject;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblNameDepartment;
    }
}
