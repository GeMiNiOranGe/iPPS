
namespace MainProject {
    partial class StatusCeo {
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
            this.flowLayoutPanelmanhinhduan = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelmanhinhduan
            // 
            this.flowLayoutPanelmanhinhduan.Location = new System.Drawing.Point(72, 47);
            this.flowLayoutPanelmanhinhduan.Name = "flowLayoutPanelmanhinhduan";
            this.flowLayoutPanelmanhinhduan.Size = new System.Drawing.Size(1140, 900);
            this.flowLayoutPanelmanhinhduan.TabIndex = 0;
            this.flowLayoutPanelmanhinhduan.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelmanhinhduan_Paint);
            // 
            // StatusCeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1149, 664);
            this.Controls.Add(this.flowLayoutPanelmanhinhduan);
            this.Name = "StatusCeo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StatusCeo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelmanhinhduan;
    }
}

