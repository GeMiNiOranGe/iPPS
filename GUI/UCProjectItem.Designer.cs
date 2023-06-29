
namespace GUI
{
    partial class UCProjectItem
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
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPercent
            // 
            this.lbPercent.BackColor = System.Drawing.Color.Transparent;
            this.lbPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPercent.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.lbPercent.Location = new System.Drawing.Point(0, 40);
            this.lbPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(200, 130);
            this.lbPercent.TabIndex = 0;
            this.lbPercent.Text = "0%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPercent.Click += new System.EventHandler(this.UCProject_Click);
            this.lbPercent.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.lbPercent.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 170);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(200, 40);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên dự án";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.UCProject_Click);
            this.lbName.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.lbName.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(0, 0);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(200, 40);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Mã dự án";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbId.Click += new System.EventHandler(this.UCProject_Click);
            this.lbId.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.lbId.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lbDepartmentName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDepartmentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartmentName.ForeColor = System.Drawing.Color.White;
            this.lbDepartmentName.Location = new System.Drawing.Point(0, 210);
            this.lbDepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(200, 40);
            this.lbDepartmentName.TabIndex = 3;
            this.lbDepartmentName.Text = "Tên phòng ban";
            this.lbDepartmentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDepartmentName.Click += new System.EventHandler(this.UCProject_Click);
            this.lbDepartmentName.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.lbDepartmentName.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            // 
            // UCProjectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbDepartmentName);
            this.Controls.Add(this.lbId);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCProjectItem";
            this.Size = new System.Drawing.Size(200, 250);
            this.Click += new System.EventHandler(this.UCProject_Click);
            this.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDepartmentName;
    }
}
