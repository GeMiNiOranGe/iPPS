namespace GUI
{
    partial class AdminTasksModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTasksModule));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrjID = new System.Windows.Forms.TextBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtMngID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccessR = new System.Windows.Forms.TextBox();
            this.txtDepPub = new System.Windows.Forms.TextBox();
            this.txtPrjPub = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.pnlHead.Controls.Add(this.pictureBox1);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(488, 65);
            this.pnlHead.TabIndex = 0;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID công việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID quản lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên công việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quyền truy cập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Công khai dự án";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Công khai phòng ban";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 370);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(374, 370);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrjID
            // 
            this.txtPrjID.Location = new System.Drawing.Point(185, 89);
            this.txtPrjID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrjID.Name = "txtPrjID";
            this.txtPrjID.Size = new System.Drawing.Size(265, 20);
            this.txtPrjID.TabIndex = 1;
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(185, 124);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(265, 20);
            this.txtJobID.TabIndex = 2;
            // 
            // txtMngID
            // 
            this.txtMngID.Location = new System.Drawing.Point(185, 158);
            this.txtMngID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMngID.Name = "txtMngID";
            this.txtMngID.Size = new System.Drawing.Size(265, 20);
            this.txtMngID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAccessR
            // 
            this.txtAccessR.Location = new System.Drawing.Point(185, 228);
            this.txtAccessR.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessR.Name = "txtAccessR";
            this.txtAccessR.Size = new System.Drawing.Size(265, 20);
            this.txtAccessR.TabIndex = 5;
            // 
            // txtDepPub
            // 
            this.txtDepPub.Location = new System.Drawing.Point(185, 333);
            this.txtDepPub.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepPub.Name = "txtDepPub";
            this.txtDepPub.Size = new System.Drawing.Size(265, 20);
            this.txtDepPub.TabIndex = 8;
            // 
            // txtPrjPub
            // 
            this.txtPrjPub.Location = new System.Drawing.Point(185, 298);
            this.txtPrjPub.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrjPub.Name = "txtPrjPub";
            this.txtPrjPub.Size = new System.Drawing.Size(265, 20);
            this.txtPrjPub.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(185, 263);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(265, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // AdminTasksModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(488, 447);
            this.Controls.Add(this.txtDepPub);
            this.Controls.Add(this.txtPrjPub);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAccessR);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMngID);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.txtPrjID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminTasksModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTasksModule";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtPrjID;
        public System.Windows.Forms.TextBox txtJobID;
        public System.Windows.Forms.TextBox txtMngID;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAccessR;
        public System.Windows.Forms.TextBox txtDepPub;
        public System.Windows.Forms.TextBox txtPrjPub;
        public System.Windows.Forms.TextBox txtStatus;
    }
}