
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
            this.flPnlListJob = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlManager = new System.Windows.Forms.Panel();
            this.flPnlJobOfEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.lbOtherJobOfManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.ForeColor = System.Drawing.Color.White;
            this.lblIdProject.Location = new System.Drawing.Point(12, 9);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(72, 20);
            this.lblIdProject.TabIndex = 0;
            this.lblIdProject.Text = "Mã dự án";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.ForeColor = System.Drawing.Color.White;
            this.lblNameProject.Location = new System.Drawing.Point(12, 39);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(74, 20);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "Tên dự án";
            // 
            // lblListWorkOfProject
            // 
            this.lblListWorkOfProject.AutoSize = true;
            this.lblListWorkOfProject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListWorkOfProject.ForeColor = System.Drawing.Color.White;
            this.lblListWorkOfProject.Location = new System.Drawing.Point(12, 89);
            this.lblListWorkOfProject.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListWorkOfProject.Name = "lblListWorkOfProject";
            this.lblListWorkOfProject.Size = new System.Drawing.Size(304, 25);
            this.lblListWorkOfProject.TabIndex = 2;
            this.lblListWorkOfProject.Text = "Danh sách công việc trong dự án";
            // 
            // lbManagerOfJob
            // 
            this.lbManagerOfJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManagerOfJob.AutoSize = true;
            this.lbManagerOfJob.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagerOfJob.ForeColor = System.Drawing.Color.White;
            this.lbManagerOfJob.Location = new System.Drawing.Point(693, 89);
            this.lbManagerOfJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbManagerOfJob.Name = "lbManagerOfJob";
            this.lbManagerOfJob.Size = new System.Drawing.Size(263, 25);
            this.lbManagerOfJob.TabIndex = 3;
            this.lbManagerOfJob.Text = "Nhân viên phụ trách quản lý";
            // 
            // flPnlListJob
            // 
            this.flPnlListJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flPnlListJob.AutoScroll = true;
            this.flPnlListJob.Location = new System.Drawing.Point(15, 126);
            this.flPnlListJob.Margin = new System.Windows.Forms.Padding(6);
            this.flPnlListJob.Name = "flPnlListJob";
            this.flPnlListJob.Size = new System.Drawing.Size(643, 540);
            this.flPnlListJob.TabIndex = 4;
            // 
            // pnlManager
            // 
            this.pnlManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlManager.Location = new System.Drawing.Point(698, 126);
            this.pnlManager.Margin = new System.Windows.Forms.Padding(6);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(551, 150);
            this.pnlManager.TabIndex = 5;
            // 
            // flPnlJobOfEmployee
            // 
            this.flPnlJobOfEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flPnlJobOfEmployee.AutoScroll = true;
            this.flPnlJobOfEmployee.Location = new System.Drawing.Point(698, 341);
            this.flPnlJobOfEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.flPnlJobOfEmployee.Name = "flPnlJobOfEmployee";
            this.flPnlJobOfEmployee.Size = new System.Drawing.Size(551, 325);
            this.flPnlJobOfEmployee.TabIndex = 5;
            // 
            // lbOtherJobOfManager
            // 
            this.lbOtherJobOfManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOtherJobOfManager.AutoSize = true;
            this.lbOtherJobOfManager.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherJobOfManager.ForeColor = System.Drawing.Color.White;
            this.lbOtherJobOfManager.Location = new System.Drawing.Point(693, 310);
            this.lbOtherJobOfManager.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOtherJobOfManager.Name = "lbOtherJobOfManager";
            this.lbOtherJobOfManager.Size = new System.Drawing.Size(463, 25);
            this.lbOtherJobOfManager.TabIndex = 7;
            this.lbOtherJobOfManager.Text = "Những công việc đang tham gia của người quản lý";
            // 
            // FormJobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbOtherJobOfManager);
            this.Controls.Add(this.flPnlJobOfEmployee);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.flPnlListJob);
            this.Controls.Add(this.lbManagerOfJob);
            this.Controls.Add(this.lblListWorkOfProject);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.lblIdProject);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJobDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết công việc";
            this.Load += new System.EventHandler(this.FormWorkOfProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblListWorkOfProject;
        private System.Windows.Forms.Label lbManagerOfJob;
        private System.Windows.Forms.FlowLayoutPanel flPnlListJob;
        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.FlowLayoutPanel flPnlJobOfEmployee;
        private System.Windows.Forms.Label lbOtherJobOfManager;
    }
}