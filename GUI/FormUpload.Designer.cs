namespace GUI
{
    partial class FormUpload
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbReference = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.dateIssused_On = new System.Windows.Forms.DateTimePicker();
            this.cbSupport = new System.Windows.Forms.ComboBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.cbLastest_Revision = new System.Windows.Forms.ComboBox();
            this.cbRevision_Number = new System.Windows.Forms.ComboBox();
            this.cbPartner_Code = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.cbJob_ID = new System.Windows.Forms.ComboBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.txtDocument_ID = new System.Windows.Forms.TextBox();
            this.txtChecked_By = new System.Windows.Forms.TextBox();
            this.txtApproved_By = new System.Windows.Forms.TextBox();
            this.txtWork_Item = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIssue_Purpose = new System.Windows.Forms.TextBox();
            this.txtPrepared_By = new System.Windows.Forms.TextBox();
            this.txtIssused_Via = new System.Windows.Forms.TextBox();
            this.txtTo_Company = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReload2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.cbNative = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(26, 170);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(122, 61);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Tải lên";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(193, 170);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(122, 61);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Tải xuống";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 686);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài liệu";
            // 
            // cbReference
            // 
            this.cbReference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbReference.FormattingEnabled = true;
            this.cbReference.Items.AddRange(new object[] {
            "BCMP VIETNAM"});
            this.cbReference.Location = new System.Drawing.Point(817, 257);
            this.cbReference.Name = "cbReference";
            this.cbReference.Size = new System.Drawing.Size(301, 32);
            this.cbReference.TabIndex = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(739, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 62);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(519, 512);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 62);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(301, 512);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(139, 62);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.label22.Location = new System.Drawing.Point(3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1149, 57);
            this.label22.TabIndex = 41;
            this.label22.Text = "Tài liệu";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateIssused_On
            // 
            this.dateIssused_On.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateIssused_On.CustomFormat = "yyyy-mm-dd";
            this.dateIssused_On.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIssused_On.Location = new System.Drawing.Point(817, 360);
            this.dateIssused_On.Name = "dateIssused_On";
            this.dateIssused_On.Size = new System.Drawing.Size(301, 32);
            this.dateIssused_On.TabIndex = 40;
            // 
            // cbSupport
            // 
            this.cbSupport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSupport.FormattingEnabled = true;
            this.cbSupport.Items.AddRange(new object[] {
            "BCMP VIETNAM"});
            this.cbSupport.Location = new System.Drawing.Point(817, 207);
            this.cbSupport.Name = "cbSupport";
            this.cbSupport.Size = new System.Drawing.Size(301, 32);
            this.cbSupport.TabIndex = 39;
            // 
            // cbAction
            // 
            this.cbAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "BCMP KOREA",
            "BCMP - PASSET"});
            this.cbAction.Location = new System.Drawing.Point(817, 155);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(301, 32);
            this.cbAction.TabIndex = 38;
            // 
            // cbLastest_Revision
            // 
            this.cbLastest_Revision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLastest_Revision.FormattingEnabled = true;
            this.cbLastest_Revision.Items.AddRange(new object[] {
            "Latest"});
            this.cbLastest_Revision.Location = new System.Drawing.Point(233, 360);
            this.cbLastest_Revision.Name = "cbLastest_Revision";
            this.cbLastest_Revision.Size = new System.Drawing.Size(301, 32);
            this.cbLastest_Revision.TabIndex = 37;
            // 
            // cbRevision_Number
            // 
            this.cbRevision_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRevision_Number.FormattingEnabled = true;
            this.cbRevision_Number.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbRevision_Number.Location = new System.Drawing.Point(233, 309);
            this.cbRevision_Number.Name = "cbRevision_Number";
            this.cbRevision_Number.Size = new System.Drawing.Size(301, 32);
            this.cbRevision_Number.TabIndex = 36;
            // 
            // cbPartner_Code
            // 
            this.cbPartner_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPartner_Code.FormattingEnabled = true;
            this.cbPartner_Code.Location = new System.Drawing.Point(233, 257);
            this.cbPartner_Code.Name = "cbPartner_Code";
            this.cbPartner_Code.Size = new System.Drawing.Size(301, 32);
            this.cbPartner_Code.TabIndex = 35;
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "D",
            "E",
            "F",
            "H",
            "L",
            "M",
            "Q",
            "S"});
            this.cbType.Location = new System.Drawing.Point(233, 207);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(301, 32);
            this.cbType.TabIndex = 34;
            // 
            // cbPackage
            // 
            this.cbPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Items.AddRange(new object[] {
            "Common",
            "Licence"});
            this.cbPackage.Location = new System.Drawing.Point(233, 107);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(301, 32);
            this.cbPackage.TabIndex = 33;
            // 
            // cbJob_ID
            // 
            this.cbJob_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJob_ID.FormattingEnabled = true;
            this.cbJob_ID.Location = new System.Drawing.Point(233, 59);
            this.cbJob_ID.Name = "cbJob_ID";
            this.cbJob_ID.Size = new System.Drawing.Size(301, 32);
            this.cbJob_ID.TabIndex = 32;
            // 
            // dateDate
            // 
            this.dateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateDate.Checked = false;
            this.dateDate.CustomFormat = "yyyy-mm-dd";
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(233, 410);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(301, 32);
            this.dateDate.TabIndex = 31;
            // 
            // txtDocument_ID
            // 
            this.txtDocument_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocument_ID.Location = new System.Drawing.Point(233, 11);
            this.txtDocument_ID.Name = "txtDocument_ID";
            this.txtDocument_ID.Size = new System.Drawing.Size(301, 32);
            this.txtDocument_ID.TabIndex = 30;
            // 
            // txtChecked_By
            // 
            this.txtChecked_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChecked_By.Location = new System.Drawing.Point(817, 59);
            this.txtChecked_By.Name = "txtChecked_By";
            this.txtChecked_By.Size = new System.Drawing.Size(301, 32);
            this.txtChecked_By.TabIndex = 29;
            // 
            // txtApproved_By
            // 
            this.txtApproved_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApproved_By.Location = new System.Drawing.Point(817, 107);
            this.txtApproved_By.Name = "txtApproved_By";
            this.txtApproved_By.Size = new System.Drawing.Size(301, 32);
            this.txtApproved_By.TabIndex = 28;
            // 
            // txtWork_Item
            // 
            this.txtWork_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWork_Item.Location = new System.Drawing.Point(233, 155);
            this.txtWork_Item.Name = "txtWork_Item";
            this.txtWork_Item.Size = new System.Drawing.Size(301, 32);
            this.txtWork_Item.TabIndex = 27;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(817, 459);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(301, 32);
            this.txtTitle.TabIndex = 26;
            // 
            // txtIssue_Purpose
            // 
            this.txtIssue_Purpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIssue_Purpose.Location = new System.Drawing.Point(233, 459);
            this.txtIssue_Purpose.Name = "txtIssue_Purpose";
            this.txtIssue_Purpose.Size = new System.Drawing.Size(301, 32);
            this.txtIssue_Purpose.TabIndex = 24;
            // 
            // txtPrepared_By
            // 
            this.txtPrepared_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrepared_By.Location = new System.Drawing.Point(817, 11);
            this.txtPrepared_By.Name = "txtPrepared_By";
            this.txtPrepared_By.Size = new System.Drawing.Size(301, 32);
            this.txtPrepared_By.TabIndex = 23;
            // 
            // txtIssused_Via
            // 
            this.txtIssused_Via.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIssused_Via.Location = new System.Drawing.Point(817, 410);
            this.txtIssused_Via.Name = "txtIssused_Via";
            this.txtIssused_Via.Size = new System.Drawing.Size(301, 32);
            this.txtIssused_Via.TabIndex = 22;
            // 
            // txtTo_Company
            // 
            this.txtTo_Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTo_Company.Location = new System.Drawing.Point(817, 309);
            this.txtTo_Company.Name = "txtTo_Company";
            this.txtTo_Company.Size = new System.Drawing.Size(301, 32);
            this.txtTo_Company.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(102, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 24);
            this.label21.TabIndex = 20;
            this.label21.Text = "Mã đối tác";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(719, 462);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 24);
            this.label20.TabIndex = 19;
            this.label20.Text = "Tựa đề";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(748, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 24);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cấp";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(649, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 24);
            this.label18.TabIndex = 17;
            this.label18.Text = "Ban hành ngày";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(714, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 24);
            this.label17.TabIndex = 16;
            this.label17.Text = "Công ty";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(682, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 24);
            this.label16.TabIndex = 15;
            this.label16.Text = "Tham khảo";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(726, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hỗ trợ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(689, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hoạt động";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(605, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Được chấp nhận bởi";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "KIểm tra bằng";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số sửa đổi";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(655, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Được soạn bởi";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mục đích phát hành";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sửa đổi mới nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mục công việc";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bưu kiện";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã công việc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài liệu";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.btnReload);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.dgvDocument);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1155, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách các tài liệu";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(801, 14);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(240, 51);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Tải lại danh sách";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(638, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 51);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(253, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(365, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvDocument
            // 
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocument.Location = new System.Drawing.Point(3, 81);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowHeadersWidth = 51;
            this.dgvDocument.RowTemplate.Height = 24;
            this.dgvDocument.Size = new System.Drawing.Size(1149, 565);
            this.dgvDocument.TabIndex = 0;
            this.dgvDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocument_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dgvFile);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1155, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tải lên/xuống";
            // 
            // btnReload2
            // 
            this.btnReload2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnReload2.ForeColor = System.Drawing.Color.Black;
            this.btnReload2.Location = new System.Drawing.Point(361, 291);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.Size = new System.Drawing.Size(122, 61);
            this.btnReload2.TabIndex = 12;
            this.btnReload2.Text = "Tải lại danh sách";
            this.btnReload2.UseVisualStyleBackColor = false;
            this.btnReload2.Click += new System.EventHandler(this.btnReload2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnSearch2.ForeColor = System.Drawing.Color.Black;
            this.btnSearch2.Location = new System.Drawing.Point(225, 291);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(122, 61);
            this.btnSearch2.TabIndex = 11;
            this.btnSearch2.Text = "Tìm kiếm";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch2.Location = new System.Drawing.Point(26, 306);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(173, 32);
            this.txtSearch2.TabIndex = 10;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnDelete2.ForeColor = System.Drawing.Color.Black;
            this.btnDelete2.Location = new System.Drawing.Point(361, 170);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(122, 61);
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.Text = "Xoá";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // cbID
            // 
            this.cbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(136, 39);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(356, 32);
            this.cbID.TabIndex = 8;
            // 
            // dgvFile
            // 
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvFile.Location = new System.Drawing.Point(520, 3);
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.RowHeadersWidth = 51;
            this.dgvFile.RowTemplate.Height = 24;
            this.dgvFile.Size = new System.Drawing.Size(632, 643);
            this.dgvFile.TabIndex = 7;
            this.dgvFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFile_CellContentClick);
            // 
            // cbNative
            // 
            this.cbNative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNative.FormattingEnabled = true;
            this.cbNative.Items.AddRange(new object[] {
            "Ms. Word",
            "Ms. Excel",
            "Ms. PPT",
            "PDF"});
            this.cbNative.Location = new System.Drawing.Point(136, 89);
            this.cbNative.Name = "cbNative";
            this.cbNative.Size = new System.Drawing.Size(356, 32);
            this.cbNative.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 24);
            this.label24.TabIndex = 5;
            this.label24.Text = "Kiểu tệp";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(75, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 24);
            this.label23.TabIndex = 4;
            this.label23.Text = "Mã";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 78);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbReference);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateIssused_On);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbSupport);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbAction);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbLastest_Revision);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbRevision_Number);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbPartner_Code);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbPackage);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbJob_ID);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dateDate);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtDocument_ID);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtChecked_By);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtApproved_By);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtWork_Item);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtTo_Company);
            this.panel2.Controls.Add(this.txtIssue_Purpose);
            this.panel2.Controls.Add(this.txtIssused_Via);
            this.panel2.Controls.Add(this.txtPrepared_By);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 586);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.btnReload2);
            this.panel3.Controls.Add(this.btnUpload);
            this.panel3.Controls.Add(this.btnSearch2);
            this.panel3.Controls.Add(this.btnDownload);
            this.panel3.Controls.Add(this.txtSearch2);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.btnDelete2);
            this.panel3.Controls.Add(this.cbNative);
            this.panel3.Controls.Add(this.cbID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 643);
            this.panel3.TabIndex = 13;
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 686);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUpload";
            this.Text = "FormUpload";
            this.Load += new System.EventHandler(this.FormUpload_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateIssused_On;
        private System.Windows.Forms.ComboBox cbSupport;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.ComboBox cbLastest_Revision;
        private System.Windows.Forms.ComboBox cbRevision_Number;
        private System.Windows.Forms.ComboBox cbPartner_Code;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.ComboBox cbJob_ID;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.TextBox txtDocument_ID;
        private System.Windows.Forms.TextBox txtChecked_By;
        private System.Windows.Forms.TextBox txtApproved_By;
        private System.Windows.Forms.TextBox txtWork_Item;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIssue_Purpose;
        private System.Windows.Forms.TextBox txtPrepared_By;
        private System.Windows.Forms.TextBox txtIssused_Via;
        private System.Windows.Forms.TextBox txtTo_Company;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDocument;
        private System.Windows.Forms.ComboBox cbReference;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.ComboBox cbNative;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnReload2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}