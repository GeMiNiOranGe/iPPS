
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
            this.txtBox_userId = new System.Windows.Forms.TextBox();
            this.lb_appName = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_userId
            // 
            this.txtBox_userId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_userId.Location = new System.Drawing.Point(49, 65);
            this.txtBox_userId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBox_userId.Name = "txtBox_userId";
            this.txtBox_userId.Size = new System.Drawing.Size(364, 37);
            this.txtBox_userId.TabIndex = 2;
            // 
            // lb_appName
            // 
            this.lb_appName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_appName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.lb_appName.Location = new System.Drawing.Point(0, 0);
            this.lb_appName.Name = "lb_appName";
            this.lb_appName.Size = new System.Drawing.Size(468, 59);
            this.lb_appName.TabIndex = 0;
            this.lb_appName.Text = "PHẦN MỀM iPPS";
            this.lb_appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_password.Location = new System.Drawing.Point(49, 114);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(364, 37);
            this.txtBox_password.TabIndex = 3;
            this.txtBox_password.UseSystemPasswordChar = true;
            this.txtBox_password.Enter += new System.EventHandler(this.txtBox_password_Enter);
            this.txtBox_password.Leave += new System.EventHandler(this.txtBox_password_Leave);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dangNhap.Location = new System.Drawing.Point(49, 190);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(364, 49);
            this.btn_dangNhap.TabIndex = 1;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
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
            this.AcceptButton = this.btn_dangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(468, 251);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_userId);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.lb_appName);
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

        private System.Windows.Forms.TextBox txtBox_userId;
        private System.Windows.Forms.Label lb_appName;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Label lb_error;
    }
}

