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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReference = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateIssused_On = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSupport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLastest_Revision = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRevision_Number = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPartner_Code = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbJob_ID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocument_ID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtChecked_By = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtApproved_By = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtWork_Item = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTo_Company = new System.Windows.Forms.TextBox();
            this.txtIssue_Purpose = new System.Windows.Forms.TextBox();
            this.txtIssused_Via = new System.Windows.Forms.TextBox();
            this.txtPrepared_By = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnReload2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.cbNative = new System.Windows.Forms.ComboBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(113, 265);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(92, 50);
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
            this.btnDownload.Location = new System.Drawing.Point(238, 265);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(92, 50);
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 661);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(976, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài liệu";
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
            this.panel2.Location = new System.Drawing.Point(2, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 579);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài liệu";
            // 
            // cbReference
            // 
            this.cbReference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbReference.FormattingEnabled = true;
            this.cbReference.Items.AddRange(new object[] {
            "BCMP VIETNAM"});
            this.cbReference.Location = new System.Drawing.Point(681, 248);
            this.cbReference.Margin = new System.Windows.Forms.Padding(5);
            this.cbReference.Name = "cbReference";
            this.cbReference.Size = new System.Drawing.Size(227, 27);
            this.cbReference.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã công việc";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(598, 482);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bưu kiện";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(434, 482);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 50);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mục công việc";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(270, 482);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(104, 50);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sửa đổi mới nhất";
            // 
            // dateIssused_On
            // 
            this.dateIssused_On.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateIssused_On.CustomFormat = "yyyy-mm-dd";
            this.dateIssused_On.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIssused_On.Location = new System.Drawing.Point(681, 322);
            this.dateIssused_On.Margin = new System.Windows.Forms.Padding(5);
            this.dateIssused_On.Name = "dateIssused_On";
            this.dateIssused_On.Size = new System.Drawing.Size(227, 27);
            this.dateIssused_On.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 363);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày";
            // 
            // cbSupport
            // 
            this.cbSupport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSupport.FormattingEnabled = true;
            this.cbSupport.Items.AddRange(new object[] {
            "BCMP VIETNAM"});
            this.cbSupport.Location = new System.Drawing.Point(681, 211);
            this.cbSupport.Margin = new System.Windows.Forms.Padding(5);
            this.cbSupport.Name = "cbSupport";
            this.cbSupport.Size = new System.Drawing.Size(227, 27);
            this.cbSupport.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mục đích phát hành";
            // 
            // cbAction
            // 
            this.cbAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "BCMP KOREA",
            "BCMP - PASSET"});
            this.cbAction.Location = new System.Drawing.Point(681, 174);
            this.cbAction.Margin = new System.Windows.Forms.Padding(5);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(227, 27);
            this.cbAction.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Được soạn bởi";
            // 
            // cbLastest_Revision
            // 
            this.cbLastest_Revision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLastest_Revision.FormattingEnabled = true;
            this.cbLastest_Revision.Items.AddRange(new object[] {
            "Latest"});
            this.cbLastest_Revision.Location = new System.Drawing.Point(212, 322);
            this.cbLastest_Revision.Margin = new System.Windows.Forms.Padding(5);
            this.cbLastest_Revision.Name = "cbLastest_Revision";
            this.cbLastest_Revision.Size = new System.Drawing.Size(227, 27);
            this.cbLastest_Revision.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số sửa đổi";
            // 
            // cbRevision_Number
            // 
            this.cbRevision_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRevision_Number.FormattingEnabled = true;
            this.cbRevision_Number.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbRevision_Number.Location = new System.Drawing.Point(212, 285);
            this.cbRevision_Number.Margin = new System.Windows.Forms.Padding(5);
            this.cbRevision_Number.Name = "cbRevision_Number";
            this.cbRevision_Number.Size = new System.Drawing.Size(227, 27);
            this.cbRevision_Number.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "KIểm tra bằng";
            // 
            // cbPartner_Code
            // 
            this.cbPartner_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPartner_Code.FormattingEnabled = true;
            this.cbPartner_Code.Location = new System.Drawing.Point(212, 248);
            this.cbPartner_Code.Margin = new System.Windows.Forms.Padding(5);
            this.cbPartner_Code.Name = "cbPartner_Code";
            this.cbPartner_Code.Size = new System.Drawing.Size(227, 27);
            this.cbPartner_Code.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Được chấp nhận bởi";
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
            this.cbType.Location = new System.Drawing.Point(212, 211);
            this.cbType.Margin = new System.Windows.Forms.Padding(5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(227, 27);
            this.cbType.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(591, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hoạt động";
            // 
            // cbPackage
            // 
            this.cbPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Items.AddRange(new object[] {
            "Common",
            "Licence"});
            this.cbPackage.Location = new System.Drawing.Point(212, 137);
            this.cbPackage.Margin = new System.Windows.Forms.Padding(5);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(227, 27);
            this.cbPackage.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(620, 215);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hỗ trợ";
            // 
            // cbJob_ID
            // 
            this.cbJob_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJob_ID.FormattingEnabled = true;
            this.cbJob_ID.Location = new System.Drawing.Point(212, 100);
            this.cbJob_ID.Margin = new System.Windows.Forms.Padding(5);
            this.cbJob_ID.Name = "cbJob_ID";
            this.cbJob_ID.Size = new System.Drawing.Size(227, 27);
            this.cbJob_ID.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(585, 252);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 15;
            this.label16.Text = "Tham khảo";
            // 
            // dateDate
            // 
            this.dateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateDate.Checked = false;
            this.dateDate.CustomFormat = "yyyy-mm-dd";
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(212, 359);
            this.dateDate.Margin = new System.Windows.Forms.Padding(5);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(227, 27);
            this.dateDate.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(610, 289);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Công ty";
            // 
            // txtDocument_ID
            // 
            this.txtDocument_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocument_ID.Location = new System.Drawing.Point(212, 63);
            this.txtDocument_ID.Margin = new System.Windows.Forms.Padding(5);
            this.txtDocument_ID.Name = "txtDocument_ID";
            this.txtDocument_ID.Size = new System.Drawing.Size(227, 27);
            this.txtDocument_ID.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(560, 326);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 19);
            this.label18.TabIndex = 17;
            this.label18.Text = "Ban hành ngày";
            // 
            // txtChecked_By
            // 
            this.txtChecked_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChecked_By.Location = new System.Drawing.Point(681, 100);
            this.txtChecked_By.Margin = new System.Windows.Forms.Padding(5);
            this.txtChecked_By.Name = "txtChecked_By";
            this.txtChecked_By.Size = new System.Drawing.Size(227, 27);
            this.txtChecked_By.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(638, 363);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cấp";
            // 
            // txtApproved_By
            // 
            this.txtApproved_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApproved_By.Location = new System.Drawing.Point(681, 137);
            this.txtApproved_By.Margin = new System.Windows.Forms.Padding(5);
            this.txtApproved_By.Name = "txtApproved_By";
            this.txtApproved_By.Size = new System.Drawing.Size(227, 27);
            this.txtApproved_By.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(615, 400);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 19);
            this.label20.TabIndex = 19;
            this.label20.Text = "Tựa đề";
            // 
            // txtWork_Item
            // 
            this.txtWork_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWork_Item.Location = new System.Drawing.Point(212, 174);
            this.txtWork_Item.Margin = new System.Windows.Forms.Padding(5);
            this.txtWork_Item.Name = "txtWork_Item";
            this.txtWork_Item.Size = new System.Drawing.Size(227, 27);
            this.txtWork_Item.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(124, 252);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 19);
            this.label21.TabIndex = 20;
            this.label21.Text = "Mã đối tác";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(681, 396);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(227, 27);
            this.txtTitle.TabIndex = 26;
            // 
            // txtTo_Company
            // 
            this.txtTo_Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTo_Company.Location = new System.Drawing.Point(681, 285);
            this.txtTo_Company.Margin = new System.Windows.Forms.Padding(5);
            this.txtTo_Company.Name = "txtTo_Company";
            this.txtTo_Company.Size = new System.Drawing.Size(227, 27);
            this.txtTo_Company.TabIndex = 21;
            // 
            // txtIssue_Purpose
            // 
            this.txtIssue_Purpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIssue_Purpose.Location = new System.Drawing.Point(212, 396);
            this.txtIssue_Purpose.Margin = new System.Windows.Forms.Padding(5);
            this.txtIssue_Purpose.Name = "txtIssue_Purpose";
            this.txtIssue_Purpose.Size = new System.Drawing.Size(227, 27);
            this.txtIssue_Purpose.TabIndex = 24;
            // 
            // txtIssused_Via
            // 
            this.txtIssused_Via.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIssused_Via.Location = new System.Drawing.Point(681, 359);
            this.txtIssused_Via.Margin = new System.Windows.Forms.Padding(5);
            this.txtIssused_Via.Name = "txtIssused_Via";
            this.txtIssused_Via.Size = new System.Drawing.Size(227, 27);
            this.txtIssused_Via.TabIndex = 22;
            // 
            // txtPrepared_By
            // 
            this.txtPrepared_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrepared_By.Location = new System.Drawing.Point(681, 63);
            this.txtPrepared_By.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrepared_By.Name = "txtPrepared_By";
            this.txtPrepared_By.Size = new System.Drawing.Size(227, 27);
            this.txtPrepared_By.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.label22.Location = new System.Drawing.Point(2, 2);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(972, 46);
            this.label22.TabIndex = 41;
            this.label22.Text = "Tài liệu";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 5;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(976, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách các tài liệu";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(601, 11);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(180, 41);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Tải lại danh sách";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(478, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvDocument
            // 
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocument.Location = new System.Drawing.Point(2, 65);
            this.dgvDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowHeadersWidth = 51;
            this.dgvDocument.RowTemplate.Height = 24;
            this.dgvDocument.Size = new System.Drawing.Size(972, 562);
            this.dgvDocument.TabIndex = 0;
            this.dgvDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocument_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 63);
            this.panel1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dgvFile);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(976, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tải lên/xuống";
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
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 625);
            this.panel3.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(77, 175);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 19);
            this.label23.TabIndex = 4;
            this.label23.Text = "Mã";
            // 
            // btnReload2
            // 
            this.btnReload2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnReload2.ForeColor = System.Drawing.Color.Black;
            this.btnReload2.Location = new System.Drawing.Point(238, 339);
            this.btnReload2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.Size = new System.Drawing.Size(92, 50);
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
            this.btnSearch2.Location = new System.Drawing.Point(364, 422);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(92, 50);
            this.btnSearch2.TabIndex = 11;
            this.btnSearch2.Text = "Tìm kiếm";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch2.Location = new System.Drawing.Point(113, 435);
            this.txtSearch2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(247, 27);
            this.txtSearch2.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 212);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 19);
            this.label24.TabIndex = 5;
            this.label24.Text = "Kiểu tệp";
            // 
            // btnDelete2
            // 
            this.btnDelete2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(168)))));
            this.btnDelete2.ForeColor = System.Drawing.Color.Black;
            this.btnDelete2.Location = new System.Drawing.Point(364, 265);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(92, 50);
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.Text = "Xoá";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
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
            this.cbNative.Location = new System.Drawing.Point(113, 209);
            this.cbNative.Margin = new System.Windows.Forms.Padding(5);
            this.cbNative.Name = "cbNative";
            this.cbNative.Size = new System.Drawing.Size(343, 27);
            this.cbNative.TabIndex = 6;
            // 
            // cbID
            // 
            this.cbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(113, 172);
            this.cbID.Margin = new System.Windows.Forms.Padding(5);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(343, 27);
            this.cbID.TabIndex = 8;
            // 
            // dgvFile
            // 
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvFile.Location = new System.Drawing.Point(500, 2);
            this.dgvFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.RowHeadersWidth = 51;
            this.dgvFile.RowTemplate.Height = 24;
            this.dgvFile.Size = new System.Drawing.Size(474, 625);
            this.dgvFile.TabIndex = 7;
            this.dgvFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFile_CellContentClick);
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpload";
            this.Text = "FormUpload";
            this.Load += new System.EventHandler(this.FormUpload_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
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