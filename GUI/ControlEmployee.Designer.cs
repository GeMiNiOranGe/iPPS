
namespace GUI
{
    partial class ControlEmployee
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
            this.lblIdEmployee = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdEmployee
            // 
            this.lblIdEmployee.AutoSize = true;
            this.lblIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmployee.Location = new System.Drawing.Point(32, 19);
            this.lblIdEmployee.Name = "lblIdEmployee";
            this.lblIdEmployee.Size = new System.Drawing.Size(136, 24);
            this.lblIdEmployee.TabIndex = 0;
            this.lblIdEmployee.Text = "Mã nhân viên";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(32, 43);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(132, 24);
            this.lblNameEmployee.TabIndex = 1;
            this.lblNameEmployee.Text = "Tên nhân viên";
            // 
            // ControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lblNameEmployee);
            this.Controls.Add(this.lblIdEmployee);
            this.Name = "ControlEmployee";
            this.Size = new System.Drawing.Size(353, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEmployee;
        private System.Windows.Forms.Label lblNameEmployee;
    }
}
