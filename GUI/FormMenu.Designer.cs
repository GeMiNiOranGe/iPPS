
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
            this.lbAppName = new System.Windows.Forms.Label();
            this.PnlWorkplace = new System.Windows.Forms.Panel();
            this.PnlLeft.SuspendLayout();
            this.PnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.PnlLeft.Controls.Add(this.PnlAccount);
            this.PnlLeft.Controls.Add(this.BtnProgress);
            this.PnlLeft.Controls.Add(this.BtnDocument);
            this.PnlLeft.Controls.Add(this.BtnProject);
            this.PnlLeft.Controls.Add(this.BtnJob);
            this.PnlLeft.Controls.Add(this.lbAppName);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(231, 720);
            this.PnlLeft.TabIndex = 0;
            // 
            // PnlAccount
            // 
            this.PnlAccount.BackColor = System.Drawing.Color.Transparent;
            this.PnlAccount.Controls.Add(this.LbUsername);
            this.PnlAccount.Controls.Add(this.LbRole);
            this.PnlAccount.Controls.Add(this.PcbImageUser);
            this.PnlAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAccount.Location = new System.Drawing.Point(0, 648);
            this.PnlAccount.Name = "PnlAccount";
            this.PnlAccount.Size = new System.Drawing.Size(231, 72);
            this.PnlAccount.TabIndex = 12;
            this.PnlAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Account_MouseClick);
            this.PnlAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_MouseDown);
            this.PnlAccount.MouseEnter += new System.EventHandler(this.Account_MouseEnter);
            this.PnlAccount.MouseLeave += new System.EventHandler(this.Account_MouseLeave);
            this.PnlAccount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Account_MouseUp);
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.BackColor = System.Drawing.Color.Transparent;
            this.LbUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.ForeColor = System.Drawing.Color.White;
            this.LbUsername.Location = new System.Drawing.Point(66, 12);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(64, 25);
            this.LbUsername.TabIndex = 8;
            this.LbUsername.Text = "Name";
            this.LbUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Account_MouseClick);
            this.LbUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_MouseDown);
            this.LbUsername.MouseEnter += new System.EventHandler(this.Account_MouseEnter);
            this.LbUsername.MouseLeave += new System.EventHandler(this.Account_MouseLeave);
            this.LbUsername.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Account_MouseUp);
            // 
            // LbRole
            // 
            this.LbRole.AutoSize = true;
            this.LbRole.BackColor = System.Drawing.Color.Transparent;
            this.LbRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRole.ForeColor = System.Drawing.Color.Silver;
            this.LbRole.Location = new System.Drawing.Point(67, 40);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(39, 20);
            this.LbRole.TabIndex = 8;
            this.LbRole.Text = "Role";
            this.LbRole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Account_MouseClick);
            this.LbRole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_MouseDown);
            this.LbRole.MouseEnter += new System.EventHandler(this.Account_MouseEnter);
            this.LbRole.MouseLeave += new System.EventHandler(this.Account_MouseLeave);
            this.LbRole.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Account_MouseUp);
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
            this.PcbImageUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Account_MouseClick);
            this.PcbImageUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_MouseDown);
            this.PcbImageUser.MouseEnter += new System.EventHandler(this.Account_MouseEnter);
            this.PcbImageUser.MouseLeave += new System.EventHandler(this.Account_MouseLeave);
            this.PcbImageUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Account_MouseUp);
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.Transparent;
            this.BtnProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProgress.FlatAppearance.BorderSize = 0;
            this.BtnProgress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgress.ForeColor = System.Drawing.Color.White;
            this.BtnProgress.Image = global::GUI.Properties.Resources.DoughnutChart;
            this.BtnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgress.Location = new System.Drawing.Point(0, 280);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnProgress.Size = new System.Drawing.Size(231, 60);
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
            this.BtnDocument.BackColor = System.Drawing.Color.Transparent;
            this.BtnDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocument.FlatAppearance.BorderSize = 0;
            this.BtnDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocument.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocument.ForeColor = System.Drawing.Color.White;
            this.BtnDocument.Image = global::GUI.Properties.Resources.MultiplePages;
            this.BtnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocument.Location = new System.Drawing.Point(0, 220);
            this.BtnDocument.Name = "BtnDocument";
            this.BtnDocument.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnDocument.Size = new System.Drawing.Size(231, 60);
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
            this.BtnProject.BackColor = System.Drawing.Color.Transparent;
            this.BtnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProject.FlatAppearance.BorderSize = 0;
            this.BtnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProject.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProject.ForeColor = System.Drawing.Color.White;
            this.BtnProject.Image = global::GUI.Properties.Resources.Folder;
            this.BtnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProject.Location = new System.Drawing.Point(0, 160);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnProject.Size = new System.Drawing.Size(231, 60);
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
            this.BtnJob.BackColor = System.Drawing.Color.Transparent;
            this.BtnJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJob.FlatAppearance.BorderSize = 0;
            this.BtnJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJob.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJob.ForeColor = System.Drawing.Color.White;
            this.BtnJob.Image = global::GUI.Properties.Resources.PasteClipboard;
            this.BtnJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJob.Location = new System.Drawing.Point(0, 100);
            this.BtnJob.Name = "BtnJob";
            this.BtnJob.Padding = new System.Windows.Forms.Padding(24, 5, 0, 5);
            this.BtnJob.Size = new System.Drawing.Size(231, 60);
            this.BtnJob.TabIndex = 18;
            this.BtnJob.Text = "   Công việc";
            this.BtnJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJob.UseVisualStyleBackColor = false;
            this.BtnJob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseClick);
            this.BtnJob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseDown);
            this.BtnJob.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnJob_MouseUp);
            // 
            // lbAppName
            // 
            this.lbAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAppName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.White;
            this.lbAppName.Location = new System.Drawing.Point(0, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(231, 100);
            this.lbAppName.TabIndex = 23;
            this.lbAppName.Text = "iPPS Ver.0";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAppName.Click += new System.EventHandler(this.LbAppName_Click);
            // 
            // PnlWorkplace
            // 
            this.PnlWorkplace.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PnlWorkplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PnlWorkplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWorkplace.Location = new System.Drawing.Point(231, 0);
            this.PnlWorkplace.Name = "PnlWorkplace";
            this.PnlWorkplace.Size = new System.Drawing.Size(1049, 720);
            this.PnlWorkplace.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PnlWorkplace);
            this.Controls.Add(this.PnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.PnlLeft.ResumeLayout(false);
            this.PnlAccount.ResumeLayout(false);
            this.PnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlWorkplace;
        private System.Windows.Forms.PictureBox PcbImageUser;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbRole;
        private System.Windows.Forms.Panel PnlAccount;
        private System.Windows.Forms.Button BtnJob;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnDocument;
        private System.Windows.Forms.Button BtnProject;
        private System.Windows.Forms.Label lbAppName;
    }
}

