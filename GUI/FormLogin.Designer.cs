
namespace GUI {
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
            this.LbError = new System.Windows.Forms.Label();
            this.PictureUserID = new System.Windows.Forms.PictureBox();
            this.PicturePassWord = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUserId
            // 
            this.TxtUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserId.ForeColor = System.Drawing.Color.Gray;
            this.TxtUserId.Location = new System.Drawing.Point(108, 89);
            this.TxtUserId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(305, 30);
            this.TxtUserId.TabIndex = 2;
            this.TxtUserId.Click += new System.EventHandler(this.TxtUserId_Click);
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
            this.LbAppName.Text = "iPPS Ver.0";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(108, 164);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(305, 30);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(49, 250);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(364, 49);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LbError
            // 
            this.LbError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbError.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(49, 217);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(364, 30);
            this.LbError.TabIndex = 3;
            this.LbError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureUserID
            // 
            this.PictureUserID.BackgroundImage = global::GUI.Properties.Resources.UserWhite;
            this.PictureUserID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureUserID.Location = new System.Drawing.Point(49, 76);
            this.PictureUserID.Name = "PictureUserID";
            this.PictureUserID.Size = new System.Drawing.Size(52, 50);
            this.PictureUserID.TabIndex = 4;
            this.PictureUserID.TabStop = false;
            // 
            // PicturePassWord
            // 
            this.PicturePassWord.BackgroundImage = global::GUI.Properties.Resources.CloseLockWhite;
            this.PicturePassWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicturePassWord.Location = new System.Drawing.Point(49, 151);
            this.PicturePassWord.Name = "PicturePassWord";
            this.PicturePassWord.Size = new System.Drawing.Size(52, 50);
            this.PicturePassWord.TabIndex = 5;
            this.PicturePassWord.TabStop = false;
            this.PicturePassWord.Click += new System.EventHandler(this.PicturePassWord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(49, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 1);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(468, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicturePassWord);
            this.Controls.Add(this.PictureUserID);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LbAppName);
            this.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.PictureBox PictureUserID;
        private System.Windows.Forms.PictureBox PicturePassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

