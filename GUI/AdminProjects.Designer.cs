namespace GUI
{
    partial class AdminProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProjects));
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.IDProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProject,
            this.ProjectName,
            this.AccessRight,
            this.TrangThai,
            this.KhachHang,
            this.IDTask,
            this.IDPhongBan,
            this.start,
            this.end,
            this.Edit,
            this.Delete});
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 51;
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(984, 482);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            // 
            // IDProject
            // 
            this.IDProject.HeaderText = "ID dự án";
            this.IDProject.MinimumWidth = 6;
            this.IDProject.Name = "IDProject";
            this.IDProject.Width = 110;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Tên dự án";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 125;
            // 
            // AccessRight
            // 
            this.AccessRight.HeaderText = "Quyền truy cập";
            this.AccessRight.MinimumWidth = 6;
            this.AccessRight.Name = "AccessRight";
            this.AccessRight.Width = 160;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 120;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Tên khách hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Width = 160;
            // 
            // IDTask
            // 
            this.IDTask.HeaderText = "ID quản lý";
            this.IDTask.MinimumWidth = 6;
            this.IDTask.Name = "IDTask";
            this.IDTask.Width = 130;
            // 
            // IDPhongBan
            // 
            this.IDPhongBan.HeaderText = "ID phòng ban";
            this.IDPhongBan.MinimumWidth = 6;
            this.IDPhongBan.Name = "IDPhongBan";
            this.IDPhongBan.Width = 150;
            // 
            // start
            // 
            this.start.HeaderText = "Ngày bắt đầu";
            this.start.MinimumWidth = 6;
            this.start.Name = "start";
            this.start.Width = 160;
            // 
            // end
            // 
            this.end.HeaderText = "Ngày kết thúc";
            this.end.MinimumWidth = 6;
            this.end.Name = "end";
            this.end.Width = 160;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(922, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 79);
            this.panel2.TabIndex = 2;
            // 
            // AdminProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.AdminProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}