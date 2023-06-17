
namespace GUI
{
    partial class ControlWorkOfProject
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
            this.lblIdWork = new System.Windows.Forms.Label();
            this.lblNameWork = new System.Windows.Forms.Label();
            this.lblPercentWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdWork
            // 
            this.lblIdWork.AutoSize = true;
            this.lblIdWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdWork.Location = new System.Drawing.Point(34, 22);
            this.lblIdWork.Name = "lblIdWork";
            this.lblIdWork.Size = new System.Drawing.Size(88, 16);
            this.lblIdWork.TabIndex = 0;
            this.lblIdWork.Text = "Mã công việc";
            // 
            // lblNameWork
            // 
            this.lblNameWork.AutoSize = true;
            this.lblNameWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameWork.Location = new System.Drawing.Point(33, 47);
            this.lblNameWork.Name = "lblNameWork";
            this.lblNameWork.Size = new System.Drawing.Size(144, 24);
            this.lblNameWork.TabIndex = 1;
            this.lblNameWork.Text = "Tên công việc";
            // 
            // lblPercentWork
            // 
            this.lblPercentWork.AutoSize = true;
            this.lblPercentWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentWork.ForeColor = System.Drawing.Color.Crimson;
            this.lblPercentWork.Location = new System.Drawing.Point(296, 32);
            this.lblPercentWork.Name = "lblPercentWork";
            this.lblPercentWork.Size = new System.Drawing.Size(71, 25);
            this.lblPercentWork.TabIndex = 2;
            this.lblPercentWork.Text = "100%";
            // 
            // ControlWorkOfProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lblPercentWork);
            this.Controls.Add(this.lblNameWork);
            this.Controls.Add(this.lblIdWork);
            this.Name = "ControlWorkOfProject";
            this.Size = new System.Drawing.Size(389, 84);
            this.Click += new System.EventHandler(this.ControlWorkOfProject_Click);
            this.MouseEnter += new System.EventHandler(this.ControlWorkOfProject_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdWork;
        private System.Windows.Forms.Label lblNameWork;
        private System.Windows.Forms.Label lblPercentWork;
    }
}
