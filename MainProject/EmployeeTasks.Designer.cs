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
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.WorkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Public = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkID,
            this.WorkName,
            this.Start,
            this.End,
            this.Priority,
            this.State,
            this.Public,
            this.ProjectID});
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.Location = new System.Drawing.Point(0, 0);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(1082, 553);
            this.dgvTasks.TabIndex = 1;
            // 
            // WorkID
            // 
            this.WorkID.HeaderText = "Mã CV";
            this.WorkID.MinimumWidth = 6;
            this.WorkID.Name = "WorkID";
            this.WorkID.ReadOnly = true;
            this.WorkID.Width = 65;
            // 
            // WorkName
            // 
            this.WorkName.HeaderText = "Tên công việc";
            this.WorkName.MinimumWidth = 6;
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            this.WorkName.Width = 110;
            // 
            // Start
            // 
            this.Start.HeaderText = "Ngày bắt đầu";
            this.Start.MinimumWidth = 6;
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 125;
            // 
            // End
            // 
            this.End.HeaderText = "Ngày kết thúc";
            this.End.MinimumWidth = 6;
            this.End.Name = "End";
            this.End.ReadOnly = true;
            this.End.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Ưu tiên";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 80;
            // 
            // State
            // 
            this.State.HeaderText = "Tình trạng";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 90;
            // 
            // Public
            // 
            this.Public.HeaderText = "Công khai";
            this.Public.MinimumWidth = 6;
            this.Public.Name = "Public";
            this.Public.ReadOnly = true;
            this.Public.Width = 80;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Mã DA";
            this.ProjectID.MinimumWidth = 6;
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Width = 65;
            // 
            // EmployeeTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.dgvTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeTasks";
            this.Text = "EmployeeTasks";
            this.Load += new System.EventHandler(this.EmployeeTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Public;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
    }
}