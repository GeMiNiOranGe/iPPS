
namespace GUI
{
    partial class FormJobDetail
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
            this.lbManagerOfJob = new System.Windows.Forms.Label();
            this.flPanelListWork = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEmployeeOfWork = new System.Windows.Forms.Panel();
            this.flPanelWorkOfEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWatch = new System.Windows.Forms.Button();
            this.lbOtherJobOfManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.Location = new System.Drawing.Point(16, 10);
            this.lblIdProject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(67, 17);
            this.lblIdProject.TabIndex = 0;
            this.lblIdProject.Text = "Mã dự án";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Location = new System.Drawing.Point(16, 38);
            this.lblNameProject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(73, 17);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "Tên dự án";
            // 
            // lblListWorkOfProject
            // 
            this.lblListWorkOfProject.AutoSize = true;
            this.lblListWorkOfProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListWorkOfProject.Location = new System.Drawing.Point(16, 70);
            this.lblListWorkOfProject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListWorkOfProject.Name = "lblListWorkOfProject";
            this.lblListWorkOfProject.Size = new System.Drawing.Size(440, 31);
            this.lblListWorkOfProject.TabIndex = 2;
            this.lblListWorkOfProject.Text = "Danh sách công việc trong dự án";
            // 
            // lbManagerOfJob
            // 
            this.lbManagerOfJob.AutoSize = true;
            this.lbManagerOfJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagerOfJob.Location = new System.Drawing.Point(691, 70);
            this.lbManagerOfJob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbManagerOfJob.Name = "lbManagerOfJob";
            this.lbManagerOfJob.Size = new System.Drawing.Size(377, 31);
            this.lbManagerOfJob.TabIndex = 3;
            this.lbManagerOfJob.Text = "Nhân viên phụ trách quản lý";
            // 
            // flPanelListWork
            // 
            this.flPanelListWork.AutoScroll = true;
            this.flPanelListWork.Location = new System.Drawing.Point(16, 114);
            this.flPanelListWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flPanelListWork.Name = "flPanelListWork";
            this.flPanelListWork.Size = new System.Drawing.Size(569, 457);
            this.flPanelListWork.TabIndex = 4;
            // 
            // panelEmployeeOfWork
            // 
            this.panelEmployeeOfWork.Location = new System.Drawing.Point(621, 114);
            this.panelEmployeeOfWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelEmployeeOfWork.Name = "panelEmployeeOfWork";
            this.panelEmployeeOfWork.Size = new System.Drawing.Size(512, 102);
            this.panelEmployeeOfWork.TabIndex = 5;
            // 
            // flPanelWorkOfEmployee
            // 
            this.flPanelWorkOfEmployee.AutoScroll = true;
            this.flPanelWorkOfEmployee.Location = new System.Drawing.Point(621, 307);
            this.flPanelWorkOfEmployee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flPanelWorkOfEmployee.Name = "flPanelWorkOfEmployee";
            this.flPanelWorkOfEmployee.Size = new System.Drawing.Size(512, 264);
            this.flPanelWorkOfEmployee.TabIndex = 5;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(517, 70);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(69, 30);
            this.btnWatch.TabIndex = 6;
            this.btnWatch.Text = "Xem";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // lbOtherJobOfManager
            // 
            this.lbOtherJobOfManager.AutoSize = true;
            this.lbOtherJobOfManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherJobOfManager.Location = new System.Drawing.Point(615, 258);
            this.lbOtherJobOfManager.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOtherJobOfManager.Name = "lbOtherJobOfManager";
            this.lbOtherJobOfManager.Size = new System.Drawing.Size(658, 31);
            this.lbOtherJobOfManager.TabIndex = 7;
            this.lbOtherJobOfManager.Text = "Những công việc đang tham gia của người quản lý";
            // 
            // FormWorkOfProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 586);
            this.Controls.Add(this.lbOtherJobOfManager);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.flPanelWorkOfEmployee);
            this.Controls.Add(this.panelEmployeeOfWork);
            this.Controls.Add(this.flPanelListWork);
            this.Controls.Add(this.lbManagerOfJob);
            this.Controls.Add(this.lblListWorkOfProject);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.lblIdProject);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormWorkOfProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWorkOfProject";
            this.Load += new System.EventHandler(this.FormWorkOfProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblListWorkOfProject;
        private System.Windows.Forms.Label lbManagerOfJob;
        private System.Windows.Forms.FlowLayoutPanel flPanelListWork;
        private System.Windows.Forms.Panel panelEmployeeOfWork;
        private System.Windows.Forms.FlowLayoutPanel flPanelWorkOfEmployee;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Label lbOtherJobOfManager;
    }
}