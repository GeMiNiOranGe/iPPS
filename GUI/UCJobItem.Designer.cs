
namespace GUI
{
    partial class UCJobItem
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
            this.lbJobId = new System.Windows.Forms.Label();
            this.lbJobName = new System.Windows.Forms.Label();
            this.lbJobPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbJobId
            // 
            this.lbJobId.AutoSize = true;
            this.lbJobId.ForeColor = System.Drawing.Color.White;
            this.lbJobId.Location = new System.Drawing.Point(8, 8);
            this.lbJobId.Margin = new System.Windows.Forms.Padding(8, 8, 8, 5);
            this.lbJobId.Name = "lbJobId";
            this.lbJobId.Size = new System.Drawing.Size(97, 20);
            this.lbJobId.TabIndex = 0;
            this.lbJobId.Text = "Mã công việc";
            this.lbJobId.Click += new System.EventHandler(this.UCJobItem_Click);
            this.lbJobId.MouseEnter += new System.EventHandler(this.UCJobItem_MouseEnter);
            this.lbJobId.MouseLeave += new System.EventHandler(this.UCJobItem_MouseLeave);
            // 
            // lbJobName
            // 
            this.lbJobName.AutoSize = true;
            this.lbJobName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobName.ForeColor = System.Drawing.Color.White;
            this.lbJobName.Location = new System.Drawing.Point(7, 33);
            this.lbJobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJobName.Name = "lbJobName";
            this.lbJobName.Size = new System.Drawing.Size(146, 30);
            this.lbJobName.TabIndex = 1;
            this.lbJobName.Text = "Tên công việc";
            this.lbJobName.Click += new System.EventHandler(this.UCJobItem_Click);
            this.lbJobName.MouseEnter += new System.EventHandler(this.UCJobItem_MouseEnter);
            this.lbJobName.MouseLeave += new System.EventHandler(this.UCJobItem_MouseLeave);
            // 
            // lbJobPercent
            // 
            this.lbJobPercent.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbJobPercent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.lbJobPercent.Location = new System.Drawing.Point(415, 0);
            this.lbJobPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJobPercent.Name = "lbJobPercent";
            this.lbJobPercent.Size = new System.Drawing.Size(85, 85);
            this.lbJobPercent.TabIndex = 2;
            this.lbJobPercent.Text = "100%";
            this.lbJobPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbJobPercent.Click += new System.EventHandler(this.UCJobItem_Click);
            this.lbJobPercent.MouseEnter += new System.EventHandler(this.UCJobItem_MouseEnter);
            this.lbJobPercent.MouseLeave += new System.EventHandler(this.UCJobItem_MouseLeave);
            // 
            // UCJobItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.lbJobPercent);
            this.Controls.Add(this.lbJobName);
            this.Controls.Add(this.lbJobId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Name = "UCJobItem";
            this.Size = new System.Drawing.Size(500, 85);
            this.Click += new System.EventHandler(this.UCJobItem_Click);
            this.MouseEnter += new System.EventHandler(this.UCJobItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCJobItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJobId;
        private System.Windows.Forms.Label lbJobName;
        private System.Windows.Forms.Label lbJobPercent;
    }
}
