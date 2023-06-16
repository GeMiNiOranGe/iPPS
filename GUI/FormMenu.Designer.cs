
namespace GUI {
    partial class FormMenu {
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
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlAccount = new System.Windows.Forms.Panel();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbRole = new System.Windows.Forms.Label();
            this.PcbImageUser = new System.Windows.Forms.PictureBox();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnDocument = new System.Windows.Forms.Button();
            this.BtnProject = new System.Windows.Forms.Button();
            this.BtnJob = new System.Windows.Forms.Button();
            this.LbiPPS = new System.Windows.Forms.Label();
            this.PnlAbove = new System.Windows.Forms.Panel();
            this.PnlWorkplace = new System.Windows.Forms.Panel();
            this.LbAppName = new System.Windows.Forms.Label();
            this.PnlHead = new System.Windows.Forms.Panel();
            this.PcbMinimize = new System.Windows.Forms.PictureBox();
            this.PcbMaximize = new System.Windows.Forms.PictureBox();
            this.PcbClose = new System.Windows.Forms.PictureBox();
            this.PnlLeft.SuspendLayout();
            this.PnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImageUser)).BeginInit();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PnlLeft.Controls.Add(this.PnlAccount);
            this.PnlLeft.Controls.Add(this.BtnProgress);
            this.PnlLeft.Controls.Add(this.BtnDocument);
            this.PnlLeft.Controls.Add(this.BtnProject);
            this.PnlLeft.Controls.Add(this.BtnJob);
            this.PnlLeft.Controls.Add(this.LbiPPS);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 40);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(250, 680);
            this.PnlLeft.TabIndex = 0;
            // 
            // PnlAccount
            // 
            this.PnlAccount.Controls.Add(this.LbUsername);
            this.PnlAccount.Controls.Add(this.LbRole);
            this.PnlAccount.Controls.Add(this.PcbImageUser);
            this.PnlAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAccount.Location = new System.Drawing.Point(0, 608);
            this.PnlAccount.Name = "PnlAccount";
            this.PnlAccount.Size = new System.Drawing.Size(250, 72);
            this.PnlAccount.TabIndex = 12;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.BackColor = System.Drawing.Color.Transparent;
            this.LbUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbUsername.Location = new System.Drawing.Point(66, 12);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(64, 25);
            this.LbUsername.TabIndex = 8;
            this.LbUsername.Text = "Name";
            // 
            // LbRole
            // 
            this.LbRole.AutoSize = true;
            this.LbRole.BackColor = System.Drawing.Color.Transparent;
            this.LbRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(183)))), ((int)(((byte)(180)))));
            this.LbRole.Location = new System.Drawing.Point(67, 40);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(39, 20);
            this.LbRole.TabIndex = 8;
            this.LbRole.Text = "Role";
            // 
            // PcbImageUser
            // 
            this.PcbImageUser.Image = global::GUI.Properties.Resources.AccImage;
            this.PcbImageUser.Location = new System.Drawing.Point(12, 12);
            this.PcbImageUser.Name = "PcbImageUser";
            this.PcbImageUser.Size = new System.Drawing.Size(48, 48);
            this.PcbImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbImageUser.TabIndex = 10;
            this.PcbImageUser.TabStop = false;
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProgress.FlatAppearance.BorderSize = 0;
            this.BtnProgress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.BtnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgress.ForeColor = System.Drawing.Color.White;
            this.BtnProgress.Image = global::GUI.Properties.Resources.DoughnutChart;
            this.BtnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgress.Location = new System.Drawing.Point(0, 288);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnProgress.Size = new System.Drawing.Size(250, 60);
            this.BtnProgress.TabIndex = 20;
            this.BtnProgress.Text = "   Tiến độ";
            this.BtnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProgress.UseVisualStyleBackColor = false;
            this.BtnProgress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnProgress_MouseClick);
            this.BtnProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnProgress_MouseDown);
            this.BtnProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnProgress_MouseUp);
            // 
            // BtnDocument
            // 
            this.BtnDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocument.FlatAppearance.BorderSize = 0;
            this.BtnDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.BtnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocument.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocument.ForeColor = System.Drawing.Color.White;
            this.BtnDocument.Image = global::GUI.Properties.Resources.MultiplePages;
            this.BtnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocument.Location = new System.Drawing.Point(0, 228);
            this.BtnDocument.Name = "BtnDocument";
            this.BtnDocument.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnDocument.Size = new System.Drawing.Size(250, 60);
            this.BtnDocument.TabIndex = 19;
            this.BtnDocument.Text = "   Tài liệu";
            this.BtnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDocument.UseVisualStyleBackColor = false;
            this.BtnDocument.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnDocument_MouseClick);
            this.BtnDocument.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDocument_MouseDown);
            this.BtnDocument.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDocument_MouseUp);
            // 
            // BtnProject
            // 
            this.BtnProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProject.FlatAppearance.BorderSize = 0;
            this.BtnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.BtnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProject.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProject.ForeColor = System.Drawing.Color.White;
            this.BtnProject.Image = global::GUI.Properties.Resources.Folder;
            this.BtnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProject.Location = new System.Drawing.Point(0, 168);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnProject.Size = new System.Drawing.Size(250, 60);
            this.BtnProject.TabIndex = 21;
            this.BtnProject.Text = "   Dự án";
            this.BtnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProject.UseVisualStyleBackColor = false;
            this.BtnProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnProject_MouseClick);
            this.BtnProject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnProject_MouseDown);
            this.BtnProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnProject_MouseUp);
            // 
            // BtnJob
            // 
            this.BtnJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJob.FlatAppearance.BorderSize = 0;
            this.BtnJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.BtnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJob.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJob.ForeColor = System.Drawing.Color.White;
            this.BtnJob.Image = global::GUI.Properties.Resources.PasteClipboard;
            this.BtnJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJob.Location = new System.Drawing.Point(0, 108);
            this.BtnJob.Name = "BtnJob";
            this.BtnJob.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnJob.Size = new System.Drawing.Size(250, 60);
            this.BtnJob.TabIndex = 18;
            this.BtnJob.Text = "   Công việc";
            this.BtnJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJob.UseVisualStyleBackColor = false;
            this.BtnJob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseClick);
            this.BtnJob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseDown);
            this.BtnJob.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseUp);
            // 
            // LbiPPS
            // 
            this.LbiPPS.BackColor = System.Drawing.Color.Transparent;
            this.LbiPPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbiPPS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbiPPS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbiPPS.Location = new System.Drawing.Point(0, 0);
            this.LbiPPS.Name = "LbiPPS";
            this.LbiPPS.Size = new System.Drawing.Size(250, 108);
            this.LbiPPS.TabIndex = 8;
            this.LbiPPS.Text = "iPPS Ver.0";
            this.LbiPPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlAbove
            // 
            this.PnlAbove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.PnlAbove.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAbove.Location = new System.Drawing.Point(250, 40);
            this.PnlAbove.Name = "PnlAbove";
            this.PnlAbove.Size = new System.Drawing.Size(1030, 64);
            this.PnlAbove.TabIndex = 1;
            // 
            // PnlWorkplace
            // 
            this.PnlWorkplace.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PnlWorkplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.PnlWorkplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWorkplace.Location = new System.Drawing.Point(250, 104);
            this.PnlWorkplace.Name = "PnlWorkplace";
            this.PnlWorkplace.Size = new System.Drawing.Size(1030, 616);
            this.PnlWorkplace.TabIndex = 2;
            // 
            // LbAppName
            // 
            this.LbAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbAppName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbAppName.Location = new System.Drawing.Point(0, 0);
            this.LbAppName.Name = "LbAppName";
            this.LbAppName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.LbAppName.Size = new System.Drawing.Size(172, 40);
            this.LbAppName.TabIndex = 7;
            this.LbAppName.Text = "Quản lý tiến độ dự án";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(48)))));
            this.PnlHead.Controls.Add(this.LbAppName);
            this.PnlHead.Controls.Add(this.PcbMinimize);
            this.PnlHead.Controls.Add(this.PcbMaximize);
            this.PnlHead.Controls.Add(this.PcbClose);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(1280, 40);
            this.PnlHead.TabIndex = 3;
            this.PnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseDown);
            // 
            // PcbMinimize
            // 
            this.PcbMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.PcbMinimize.Image = global::GUI.Properties.Resources.MinimizeCircleFill;
            this.PcbMinimize.Location = new System.Drawing.Point(1160, 0);
            this.PcbMinimize.Name = "PcbMinimize";
            this.PcbMinimize.Size = new System.Drawing.Size(40, 40);
            this.PcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbMinimize.TabIndex = 0;
            this.PcbMinimize.TabStop = false;
            this.PcbMinimize.Click += new System.EventHandler(this.PcbMinimize_Click);
            // 
            // PcbMaximize
            // 
            this.PcbMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.PcbMaximize.Image = global::GUI.Properties.Resources.FullScreenCircleFill;
            this.PcbMaximize.Location = new System.Drawing.Point(1200, 0);
            this.PcbMaximize.Name = "PcbMaximize";
            this.PcbMaximize.Size = new System.Drawing.Size(40, 40);
            this.PcbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbMaximize.TabIndex = 0;
            this.PcbMaximize.TabStop = false;
            this.PcbMaximize.Click += new System.EventHandler(this.PcbMaximize_Click);
            // 
            // PcbClose
            // 
            this.PcbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.PcbClose.Image = global::GUI.Properties.Resources.CloseCircleFill;
            this.PcbClose.Location = new System.Drawing.Point(1240, 0);
            this.PcbClose.Name = "PcbClose";
            this.PcbClose.Size = new System.Drawing.Size(40, 40);
            this.PcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbClose.TabIndex = 0;
            this.PcbClose.TabStop = false;
            this.PcbClose.Click += new System.EventHandler(this.PcbClose_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PnlWorkplace);
            this.Controls.Add(this.PnlAbove);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.PnlHead);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.PnlLeft.ResumeLayout(false);
            this.PnlAccount.ResumeLayout(false);
            this.PnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImageUser)).EndInit();
            this.PnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlAbove;
        private System.Windows.Forms.Panel PnlWorkplace;
        private System.Windows.Forms.Label LbiPPS;
        private System.Windows.Forms.PictureBox PcbImageUser;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.Label LbRole;
        private System.Windows.Forms.Panel PnlAccount;
        private System.Windows.Forms.Panel PnlHead;
        private System.Windows.Forms.PictureBox PcbMinimize;
        private System.Windows.Forms.PictureBox PcbMaximize;
        private System.Windows.Forms.PictureBox PcbClose;
        private System.Windows.Forms.Button BtnJob;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnDocument;
        private System.Windows.Forms.Button BtnProject;
    }
}

