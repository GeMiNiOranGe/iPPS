
namespace MainProject {
    partial class FormLogin {
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
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.LbAppName = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUserId
            // 
            this.TxtUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUserId.Location = new System.Drawing.Point(49, 65);
            this.TxtUserId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(364, 37);
            this.TxtUserId.TabIndex = 2;
            // 
            // LbAppName
            // 
            this.LbAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbAppName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.LbAppName.Location = new System.Drawing.Point(0, 0);
            this.LbAppName.Name = "LbAppName";
            this.LbAppName.Size = new System.Drawing.Size(468, 59);
            this.LbAppName.TabIndex = 0;
            this.LbAppName.Text = "PHẦN MỀM iPPS";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.Location = new System.Drawing.Point(49, 114);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(364, 37);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.Location = new System.Drawing.Point(49, 190);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(364, 49);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lb_error
            // 
            this.lb_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_error.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(49, 157);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(364, 30);
            this.lb_error.TabIndex = 3;
            this.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(468, 251);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LbAppName);
            this.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lb_error;
    }
}

