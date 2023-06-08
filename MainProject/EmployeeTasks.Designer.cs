namespace MainProject
{
    partial class EmployeeTasks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProject = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.idJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrjPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.txtSearchTask);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchProject);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 80);
            this.panel1.TabIndex = 3;
            // 
            // txtSearchTask
            // 
            this.txtSearchTask.Location = new System.Drawing.Point(639, 28);
            this.txtSearchTask.Name = "txtSearchTask";
            this.txtSearchTask.Size = new System.Drawing.Size(150, 22);
            this.txtSearchTask.TabIndex = 4;
            this.txtSearchTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTask_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập ID công việc";
            // 
            // txtSearchProject
            // 
            this.txtSearchProject.Location = new System.Drawing.Point(218, 30);
            this.txtSearchProject.Name = "txtSearchProject";
            this.txtSearchProject.Size = new System.Drawing.Size(150, 22);
            this.txtSearchProject.TabIndex = 1;
            this.txtSearchProject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchProject_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(69, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(125, 22);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Nhập ID dự án";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJob,
            this.idMng,
            this.WorkName,
            this.AccessRight,
            this.Status,
            this.PrjPublic,
            this.DepPublic,
            this.ProjectID});
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTasks.Location = new System.Drawing.Point(0, 0);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(1082, 474);
            this.dgvTasks.TabIndex = 2;
            // 
            // idJob
            // 
            this.idJob.HeaderText = "ID công việc";
            this.idJob.MinimumWidth = 6;
            this.idJob.Name = "idJob";
            this.idJob.ReadOnly = true;
            // 
            // idMng
            // 
            this.idMng.HeaderText = "ID quản lý";
            this.idMng.MinimumWidth = 6;
            this.idMng.Name = "idMng";
            this.idMng.ReadOnly = true;
            // 
            // WorkName
            // 
            this.WorkName.HeaderText = "Tên công việc";
            this.WorkName.MinimumWidth = 6;
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            this.WorkName.Width = 120;
            // 
            // AccessRight
            // 
            this.AccessRight.HeaderText = "Quyền truy cập";
            this.AccessRight.MinimumWidth = 6;
            this.AccessRight.Name = "AccessRight";
            this.AccessRight.ReadOnly = true;
            this.AccessRight.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // PrjPublic
            // 
            this.PrjPublic.HeaderText = "Công khai dự án";
            this.PrjPublic.MinimumWidth = 6;
            this.PrjPublic.Name = "PrjPublic";
            this.PrjPublic.ReadOnly = true;
            this.PrjPublic.Width = 80;
            // 
            // DepPublic
            // 
            this.DepPublic.HeaderText = "Công khai phòng ban";
            this.DepPublic.MinimumWidth = 6;
            this.DepPublic.Name = "DepPublic";
            this.DepPublic.ReadOnly = true;
            this.DepPublic.Width = 80;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "ID dự án";
            this.ProjectID.MinimumWidth = 6;
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // EmployeeTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeTasks";
            this.Load += new System.EventHandler(this.EmployeeTasks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchProject;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMng;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrjPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
    }
}