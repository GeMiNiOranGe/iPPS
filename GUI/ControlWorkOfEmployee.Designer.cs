
namespace GUI
{
    partial class ControlWorkOfEmployee
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
            this.lblIdProject = new System.Windows.Forms.Label();
            this.lblIdWork = new System.Windows.Forms.Label();
            this.lblNameWork = new System.Windows.Forms.Label();
            this.lblPercentWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdProject.Location = new System.Drawing.Point(143, 0);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(71, 16);
            this.lblIdProject.TabIndex = 0;
            this.lblIdProject.Text = "Mã dự án";
            // 
            // lblIdWork
            // 
            this.lblIdWork.AutoSize = true;
            this.lblIdWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdWork.ForeColor = System.Drawing.Color.Crimson;
            this.lblIdWork.Location = new System.Drawing.Point(24, 26);
            this.lblIdWork.Name = "lblIdWork";
            this.lblIdWork.Size = new System.Drawing.Size(100, 16);
            this.lblIdWork.TabIndex = 1;
            this.lblIdWork.Text = "Mã công việc";
            // 
            // lblNameWork
            // 
            this.lblNameWork.AutoSize = true;
            this.lblNameWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameWork.Location = new System.Drawing.Point(23, 52);
            this.lblNameWork.Name = "lblNameWork";
            this.lblNameWork.Size = new System.Drawing.Size(106, 20);
            this.lblNameWork.TabIndex = 2;
            this.lblNameWork.Text = "Tên công việc";
            // 
            // lblPercentWork
            // 
            this.lblPercentWork.AutoSize = true;
            this.lblPercentWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentWork.ForeColor = System.Drawing.Color.Crimson;
            this.lblPercentWork.Location = new System.Drawing.Point(261, 26);
            this.lblPercentWork.Name = "lblPercentWork";
            this.lblPercentWork.Size = new System.Drawing.Size(87, 31);
            this.lblPercentWork.TabIndex = 3;
            this.lblPercentWork.Text = "100%";
            // 
            // ControlWorkOfEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblPercentWork);
            this.Controls.Add(this.lblNameWork);
            this.Controls.Add(this.lblIdWork);
            this.Controls.Add(this.lblIdProject);
            this.Name = "ControlWorkOfEmployee";
            this.Size = new System.Drawing.Size(361, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblIdWork;
        private System.Windows.Forms.Label lblNameWork;
        private System.Windows.Forms.Label lblPercentWork;
    }
}
