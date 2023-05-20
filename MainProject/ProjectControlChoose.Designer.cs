
namespace MainProject
{
    partial class ProjectControlChoose
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
            this.cirpbartileduan = new CircularProgressBar.CircularProgressBar();
            this.lbltileduan = new System.Windows.Forms.Label();
            this.lbltenduan = new System.Windows.Forms.Label();
            this.lblbophanduan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cirpbartileduan
            // 
            this.cirpbartileduan.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirpbartileduan.AnimationSpeed = 500;
            this.cirpbartileduan.BackColor = System.Drawing.Color.Transparent;
            this.cirpbartileduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cirpbartileduan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirpbartileduan.InnerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cirpbartileduan.InnerMargin = 2;
            this.cirpbartileduan.InnerWidth = -1;
            this.cirpbartileduan.Location = new System.Drawing.Point(30, 17);
            this.cirpbartileduan.MarqueeAnimationSpeed = 2000;
            this.cirpbartileduan.Name = "cirpbartileduan";
            this.cirpbartileduan.OuterColor = System.Drawing.Color.LightGray;
            this.cirpbartileduan.OuterMargin = -25;
            this.cirpbartileduan.OuterWidth = 26;
            this.cirpbartileduan.ProgressColor = System.Drawing.Color.Turquoise;
            this.cirpbartileduan.ProgressWidth = 18;
            this.cirpbartileduan.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cirpbartileduan.Size = new System.Drawing.Size(147, 132);
            this.cirpbartileduan.StartAngle = 270;
            this.cirpbartileduan.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirpbartileduan.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cirpbartileduan.SubscriptText = ".23";
            this.cirpbartileduan.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirpbartileduan.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cirpbartileduan.SuperscriptText = "°C";
            this.cirpbartileduan.TabIndex = 0;
            this.cirpbartileduan.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cirpbartileduan.Value = 90;
            this.cirpbartileduan.Click += new System.EventHandler(this.ProjectControlChoose_Click);
            this.cirpbartileduan.MouseEnter += new System.EventHandler(this.ProjectControlChoose_MouseEnter);
            this.cirpbartileduan.MouseLeave += new System.EventHandler(this.ProjectControlChoose_MouseLeave);
            // 
            // lbltileduan
            // 
            this.lbltileduan.AutoSize = true;
            this.lbltileduan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltileduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltileduan.ForeColor = System.Drawing.Color.Turquoise;
            this.lbltileduan.Location = new System.Drawing.Point(75, 71);
            this.lbltileduan.Name = "lbltileduan";
            this.lbltileduan.Size = new System.Drawing.Size(64, 29);
            this.lbltileduan.TabIndex = 1;
            this.lbltileduan.Text = "90%";
            this.lbltileduan.Click += new System.EventHandler(this.ProjectControlChoose_Click);
            this.lbltileduan.MouseEnter += new System.EventHandler(this.ProjectControlChoose_MouseEnter);
            this.lbltileduan.MouseLeave += new System.EventHandler(this.ProjectControlChoose_MouseLeave);
            // 
            // lbltenduan
            // 
            this.lbltenduan.AutoSize = true;
            this.lbltenduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenduan.Location = new System.Drawing.Point(61, 162);
            this.lbltenduan.Name = "lbltenduan";
            this.lbltenduan.Size = new System.Drawing.Size(106, 24);
            this.lbltenduan.TabIndex = 2;
            this.lbltenduan.Text = "Tên dự án";
            this.lbltenduan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltenduan.Click += new System.EventHandler(this.ProjectControlChoose_Click);
            this.lbltenduan.MouseEnter += new System.EventHandler(this.ProjectControlChoose_MouseEnter);
            this.lbltenduan.MouseLeave += new System.EventHandler(this.ProjectControlChoose_MouseLeave);
            // 
            // lblbophanduan
            // 
            this.lblbophanduan.AutoSize = true;
            this.lblbophanduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbophanduan.Location = new System.Drawing.Point(40, 205);
            this.lblbophanduan.Name = "lblbophanduan";
            this.lblbophanduan.Size = new System.Drawing.Size(87, 18);
            this.lblbophanduan.TabIndex = 3;
            this.lblbophanduan.Text = "Bộ phận: ....";
            this.lblbophanduan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblbophanduan.Click += new System.EventHandler(this.ProjectControlChoose_Click);
            this.lblbophanduan.MouseEnter += new System.EventHandler(this.ProjectControlChoose_MouseEnter);
            this.lblbophanduan.MouseLeave += new System.EventHandler(this.ProjectControlChoose_MouseLeave);
            // 
            // ProjectControlChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblbophanduan);
            this.Controls.Add(this.lbltenduan);
            this.Controls.Add(this.lbltileduan);
            this.Controls.Add(this.cirpbartileduan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ProjectControlChoose";
            this.Size = new System.Drawing.Size(207, 234);
            this.Load += new System.EventHandler(this.ProjectControlChoose_Load);
            this.Click += new System.EventHandler(this.ProjectControlChoose_Click);
            this.MouseEnter += new System.EventHandler(this.ProjectControlChoose_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProjectControlChoose_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cirpbartileduan;
        private System.Windows.Forms.Label lbltileduan;
        private System.Windows.Forms.Label lbltenduan;
        private System.Windows.Forms.Label lblbophanduan;
    }
}
