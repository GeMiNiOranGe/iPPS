
namespace GUI
{
    partial class UCManagerItem
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
            this.lbManagerId = new System.Windows.Forms.Label();
            this.lbManagerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbManagerId
            // 
            this.lbManagerId.AutoSize = true;
            this.lbManagerId.ForeColor = System.Drawing.Color.White;
            this.lbManagerId.Location = new System.Drawing.Point(8, 8);
            this.lbManagerId.Margin = new System.Windows.Forms.Padding(8, 8, 8, 5);
            this.lbManagerId.Name = "lbManagerId";
            this.lbManagerId.Size = new System.Drawing.Size(125, 20);
            this.lbManagerId.TabIndex = 0;
            this.lbManagerId.Text = "Mã người quản lý";
            // 
            // lbManagerName
            // 
            this.lbManagerName.AutoSize = true;
            this.lbManagerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagerName.ForeColor = System.Drawing.Color.White;
            this.lbManagerName.Location = new System.Drawing.Point(8, 33);
            this.lbManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbManagerName.Name = "lbManagerName";
            this.lbManagerName.Size = new System.Drawing.Size(191, 30);
            this.lbManagerName.TabIndex = 1;
            this.lbManagerName.Text = "Tên người quản lý";
            // 
            // UCManagerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.lbManagerName);
            this.Controls.Add(this.lbManagerId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCManagerItem";
            this.Size = new System.Drawing.Size(471, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManagerId;
        private System.Windows.Forms.Label lbManagerName;
    }
}
