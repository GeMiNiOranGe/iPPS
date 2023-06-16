
namespace GUI
{
    partial class FormWorkOfProject
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
            this.lblIdProject = new System.Windows.Forms.Label();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblListWorkOfProject = new System.Windows.Forms.Label();
            this.lblEmployeeOfWork = new System.Windows.Forms.Label();
            this.flPanelListWork = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEmployeeOfWork = new System.Windows.Forms.Panel();
            this.flPanelWorkOfEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.Location = new System.Drawing.Point(12, 8);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(52, 13);
            this.lblIdProject.TabIndex = 0;
            this.lblIdProject.Text = "Mã dự án";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Location = new System.Drawing.Point(12, 31);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(56, 13);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "Tên dự án";
            // 
            // lblListWorkOfProject
            // 
            this.lblListWorkOfProject.AutoSize = true;
            this.lblListWorkOfProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListWorkOfProject.Location = new System.Drawing.Point(12, 57);
            this.lblListWorkOfProject.Name = "lblListWorkOfProject";
            this.lblListWorkOfProject.Size = new System.Drawing.Size(359, 25);
            this.lblListWorkOfProject.TabIndex = 2;
            this.lblListWorkOfProject.Text = "Danh sách công việc trong dự án";
            // 
            // lblEmployeeOfWork
            // 
            this.lblEmployeeOfWork.AutoSize = true;
            this.lblEmployeeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeOfWork.Location = new System.Drawing.Point(552, 57);
            this.lblEmployeeOfWork.Name = "lblEmployeeOfWork";
            this.lblEmployeeOfWork.Size = new System.Drawing.Size(224, 25);
            this.lblEmployeeOfWork.TabIndex = 3;
            this.lblEmployeeOfWork.Text = "Nhân viên phụ trách";
            // 
            // flPanelListWork
            // 
            this.flPanelListWork.AutoScroll = true;
            this.flPanelListWork.Location = new System.Drawing.Point(12, 93);
            this.flPanelListWork.Name = "flPanelListWork";
            this.flPanelListWork.Size = new System.Drawing.Size(427, 371);
            this.flPanelListWork.TabIndex = 4;
            // 
            // panelEmployeeOfWork
            // 
            this.panelEmployeeOfWork.Location = new System.Drawing.Point(466, 93);
            this.panelEmployeeOfWork.Name = "panelEmployeeOfWork";
            this.panelEmployeeOfWork.Size = new System.Drawing.Size(384, 83);
            this.panelEmployeeOfWork.TabIndex = 5;
            // 
            // flPanelWorkOfEmployee
            // 
            this.flPanelWorkOfEmployee.AutoScroll = true;
            this.flPanelWorkOfEmployee.Location = new System.Drawing.Point(466, 197);
            this.flPanelWorkOfEmployee.Name = "flPanelWorkOfEmployee";
            this.flPanelWorkOfEmployee.Size = new System.Drawing.Size(384, 267);
            this.flPanelWorkOfEmployee.TabIndex = 5;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(387, 57);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(52, 24);
            this.btnWatch.TabIndex = 6;
            this.btnWatch.Text = "Xem";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // FormWorkOfProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 476);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.flPanelWorkOfEmployee);
            this.Controls.Add(this.panelEmployeeOfWork);
            this.Controls.Add(this.flPanelListWork);
            this.Controls.Add(this.lblEmployeeOfWork);
            this.Controls.Add(this.lblListWorkOfProject);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.lblIdProject);
            this.Name = "FormWorkOfProject";
            this.Text = "FormWorkOfProject";
            this.Load += new System.EventHandler(this.FormWorkOfProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblListWorkOfProject;
        private System.Windows.Forms.Label lblEmployeeOfWork;
        private System.Windows.Forms.FlowLayoutPanel flPanelListWork;
        private System.Windows.Forms.Panel panelEmployeeOfWork;
        private System.Windows.Forms.FlowLayoutPanel flPanelWorkOfEmployee;
        private System.Windows.Forms.Button btnWatch;
    }
}