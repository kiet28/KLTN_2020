﻿namespace DOAN
{
    partial class UCThemNV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThemNV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDaNghi = new MetroFramework.Controls.MetroCheckBox();
            this.cbxDangLam = new MetroFramework.Controls.MetroCheckBox();
            this.txtMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.rdbNu = new MetroFramework.Controls.MetroRadioButton();
            this.rdbNam = new MetroFramework.Controls.MetroRadioButton();
            this.dtNamSinh = new MetroFramework.Controls.MetroDateTime();
            this.txtDiaChi = new MetroFramework.Controls.MetroTextBox();
            this.txtSDT = new MetroFramework.Controls.MetroTextBox();
            this.txtHoTen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDaNghi);
            this.groupBox1.Controls.Add(this.cbxDangLam);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.dtNamSinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cbxDaNghi
            // 
            this.cbxDaNghi.AutoSize = true;
            this.cbxDaNghi.Location = new System.Drawing.Point(697, 146);
            this.cbxDaNghi.Name = "cbxDaNghi";
            this.cbxDaNghi.Size = new System.Drawing.Size(64, 15);
            this.cbxDaNghi.TabIndex = 30;
            this.cbxDaNghi.Text = "Đã nghỉ";
            this.cbxDaNghi.UseSelectable = true;
            this.cbxDaNghi.CheckedChanged += new System.EventHandler(this.cbxDaNghi_CheckedChanged);
            // 
            // cbxDangLam
            // 
            this.cbxDangLam.AutoSize = true;
            this.cbxDangLam.Location = new System.Drawing.Point(522, 146);
            this.cbxDangLam.Name = "cbxDangLam";
            this.cbxDangLam.Size = new System.Drawing.Size(74, 15);
            this.cbxDangLam.TabIndex = 29;
            this.cbxDangLam.Text = "Đang làm";
            this.cbxDangLam.UseSelectable = true;
            this.cbxDangLam.CheckedChanged += new System.EventHandler(this.cbxDangLam_CheckedChanged);
            // 
            // txtMaNhanVien
            // 
            // 
            // 
            // 
            this.txtMaNhanVien.CustomButton.Image = null;
            this.txtMaNhanVien.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtMaNhanVien.CustomButton.Name = "";
            this.txtMaNhanVien.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaNhanVien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaNhanVien.CustomButton.TabIndex = 1;
            this.txtMaNhanVien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaNhanVien.CustomButton.UseSelectable = true;
            this.txtMaNhanVien.CustomButton.Visible = false;
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Lines = new string[0];
            this.txtMaNhanVien.Location = new System.Drawing.Point(99, 22);
            this.txtMaNhanVien.MaxLength = 32767;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.SelectionLength = 0;
            this.txtMaNhanVien.SelectionStart = 0;
            this.txtMaNhanVien.ShortcutsEnabled = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(281, 23);
            this.txtMaNhanVien.TabIndex = 7;
            this.txtMaNhanVien.UseSelectable = true;
            this.txtMaNhanVien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaNhanVien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(749, 172);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 26);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Mã nhân viên:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(522, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(638, 172);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(697, 103);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 15);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseSelectable = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(522, 103);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(49, 15);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseSelectable = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Location = new System.Drawing.Point(99, 60);
            this.dtNamSinh.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(281, 29);
            this.dtNamSinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.CustomButton.Image = null;
            this.txtDiaChi.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtDiaChi.CustomButton.Name = "";
            this.txtDiaChi.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiaChi.CustomButton.TabIndex = 1;
            this.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiaChi.CustomButton.UseSelectable = true;
            this.txtDiaChi.CustomButton.Visible = false;
            this.txtDiaChi.Lines = new string[] {
        "12 Nguyen Van Bao"};
            this.txtDiaChi.Location = new System.Drawing.Point(99, 103);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.ShortcutsEnabled = true;
            this.txtDiaChi.Size = new System.Drawing.Size(281, 92);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.Text = "12 Nguyen Van Bao";
            this.txtDiaChi.UseSelectable = true;
            this.txtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiaChi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.CustomButton.Image = null;
            this.txtSDT.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtSDT.CustomButton.Name = "";
            this.txtSDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDT.CustomButton.TabIndex = 1;
            this.txtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDT.CustomButton.UseSelectable = true;
            this.txtSDT.CustomButton.Visible = false;
            this.txtSDT.Lines = new string[] {
        "0981234567"};
            this.txtSDT.Location = new System.Drawing.Point(522, 60);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(281, 23);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.Text = "0981234567";
            this.txtSDT.UseSelectable = true;
            this.txtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.CustomButton.Image = null;
            this.txtHoTen.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtHoTen.CustomButton.Name = "";
            this.txtHoTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoTen.CustomButton.TabIndex = 1;
            this.txtHoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoTen.CustomButton.UseSelectable = true;
            this.txtHoTen.CustomButton.Visible = false;
            this.txtHoTen.Lines = new string[] {
        "Nguyen Van A"};
            this.txtHoTen.Location = new System.Drawing.Point(522, 22);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.ShortcutsEnabled = true;
            this.txtHoTen.Size = new System.Drawing.Size(281, 23);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyen Van A";
            this.txtHoTen.UseSelectable = true;
            this.txtHoTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged_1);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(430, 142);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Trạng thái:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(430, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Giới tính:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(430, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Số điện thoại:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 103);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Địa chỉ:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Năm sinh:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(430, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dgvDSNV);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(3, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.hoTen,
            this.Column1,
            this.Column2,
            this.Column3,
            this.column4,
            this.Column5});
            this.dgvDSNV.Location = new System.Drawing.Point(0, 48);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.Size = new System.Drawing.Size(831, 297);
            this.dgvDSNV.TabIndex = 3;
            this.dgvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "maNhanVien";
            this.STT.HeaderText = "Mã nhân viên";
            this.STT.Name = "STT";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ và tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "namSinh";
            this.Column1.HeaderText = "Năm sinh";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "gioiTinh";
            this.Column2.HeaderText = "Giới tính";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // column4
            // 
            this.column4.DataPropertyName = "diaChi";
            this.column4.HeaderText = "Địa chỉ";
            this.column4.Name = "column4";
            this.column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trangThai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(638, 19);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(112, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(756, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UCThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCThemNV";
            this.Size = new System.Drawing.Size(837, 563);
            this.Load += new System.EventHandler(this.UCThemNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtHoTen;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rdbNu;
        private MetroFramework.Controls.MetroRadioButton rdbNam;
        private MetroFramework.Controls.MetroDateTime dtNamSinh;
        private MetroFramework.Controls.MetroTextBox txtDiaChi;
        private MetroFramework.Controls.MetroTextBox txtSDT;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private MetroFramework.Controls.MetroTextBox txtMaNhanVien;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroCheckBox cbxDaNghi;
        private MetroFramework.Controls.MetroCheckBox cbxDangLam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
