namespace DOAN
{
    partial class UCCapNhatTTNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCapNhatTTNV));
            this.dgvCapNhatNV = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxDaNghi = new MetroFramework.Controls.MetroCheckBox();
            this.cbxDangLam = new MetroFramework.Controls.MetroCheckBox();
            this.txtMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapNhatNV
            // 
            this.dgvCapNhatNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.hoTen,
            this.namSinh,
            this.gioiTinh,
            this.SDT,
            this.diaChi,
            this.trangThai});
            this.dgvCapNhatNV.Location = new System.Drawing.Point(0, 48);
            this.dgvCapNhatNV.Name = "dgvCapNhatNV";
            this.dgvCapNhatNV.Size = new System.Drawing.Size(831, 309);
            this.dgvCapNhatNV.TabIndex = 0;
            this.dgvCapNhatNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhatNV_CellContentClick);
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ và tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 150;
            // 
            // namSinh
            // 
            this.namSinh.DataPropertyName = "namSinh";
            this.namSinh.HeaderText = "Năm sinh";
            this.namSinh.Name = "namSinh";
            this.namSinh.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 70;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 150;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvCapNhatNV);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(750, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseSelectable = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(632, 19);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(112, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDaNghi);
            this.groupBox2.Controls.Add(this.cbxDangLam);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.rdbNu);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Controls.Add(this.dtNamSinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(3, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // cbxDaNghi
            // 
            this.cbxDaNghi.AutoSize = true;
            this.cbxDaNghi.Location = new System.Drawing.Point(697, 140);
            this.cbxDaNghi.Name = "cbxDaNghi";
            this.cbxDaNghi.Size = new System.Drawing.Size(64, 15);
            this.cbxDaNghi.TabIndex = 28;
            this.cbxDaNghi.Text = "Đã nghỉ";
            this.cbxDaNghi.UseSelectable = true;
            this.cbxDaNghi.CheckedChanged += new System.EventHandler(this.cbxDaNghi_CheckedChanged);
            // 
            // cbxDangLam
            // 
            this.cbxDangLam.AutoSize = true;
            this.cbxDangLam.Location = new System.Drawing.Point(522, 140);
            this.cbxDangLam.Name = "cbxDangLam";
            this.cbxDangLam.Size = new System.Drawing.Size(74, 15);
            this.cbxDangLam.TabIndex = 27;
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
            this.txtMaNhanVien.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtMaNhanVien.CustomButton.Name = "";
            this.txtMaNhanVien.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaNhanVien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaNhanVien.CustomButton.TabIndex = 1;
            this.txtMaNhanVien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaNhanVien.CustomButton.UseSelectable = true;
            this.txtMaNhanVien.CustomButton.Visible = false;
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Lines = new string[0];
            this.txtMaNhanVien.Location = new System.Drawing.Point(99, 20);
            this.txtMaNhanVien.MaxLength = 32767;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.SelectionLength = 0;
            this.txtMaNhanVien.SelectionStart = 0;
            this.txtMaNhanVien.ShortcutsEnabled = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(281, 23);
            this.txtMaNhanVien.TabIndex = 26;
            this.txtMaNhanVien.UseSelectable = true;
            this.txtMaNhanVien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaNhanVien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(749, 170);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 24);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Mã nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(638, 170);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(697, 101);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 15);
            this.rdbNu.TabIndex = 22;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseSelectable = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(522, 101);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(49, 15);
            this.rdbNam.TabIndex = 21;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseSelectable = true;
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Location = new System.Drawing.Point(99, 58);
            this.dtNamSinh.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(281, 29);
            this.dtNamSinh.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.CustomButton.Image = null;
            this.txtDiaChi.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtDiaChi.CustomButton.Name = "";
            this.txtDiaChi.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiaChi.CustomButton.TabIndex = 1;
            this.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiaChi.CustomButton.UseSelectable = true;
            this.txtDiaChi.CustomButton.Visible = false;
            this.txtDiaChi.Lines = new string[0];
            this.txtDiaChi.Location = new System.Drawing.Point(99, 101);
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
            this.txtDiaChi.TabIndex = 17;
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
            this.txtSDT.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtSDT.CustomButton.Name = "";
            this.txtSDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDT.CustomButton.TabIndex = 1;
            this.txtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDT.CustomButton.UseSelectable = true;
            this.txtSDT.CustomButton.Visible = false;
            this.txtSDT.Lines = new string[0];
            this.txtSDT.Location = new System.Drawing.Point(522, 58);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(281, 23);
            this.txtSDT.TabIndex = 16;
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
            this.txtHoTen.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtHoTen.CustomButton.Name = "";
            this.txtHoTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoTen.CustomButton.TabIndex = 1;
            this.txtHoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoTen.CustomButton.UseSelectable = true;
            this.txtHoTen.CustomButton.Visible = false;
            this.txtHoTen.Lines = new string[0];
            this.txtHoTen.Location = new System.Drawing.Point(522, 20);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.ShortcutsEnabled = true;
            this.txtHoTen.Size = new System.Drawing.Size(281, 23);
            this.txtHoTen.TabIndex = 15;
            this.txtHoTen.UseSelectable = true;
            this.txtHoTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(430, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Trạng thái:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(430, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Giới tính:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(430, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Số điện thoại";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 101);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Địa chỉ:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Năm sinh:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(430, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Họ và tên:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCCapNhatTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCCapNhatTTNV";
            this.Size = new System.Drawing.Size(837, 563);
            this.Load += new System.EventHandler(this.UCCapNhatTTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapNhatNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtMaNhanVien;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroRadioButton rdbNu;
        private MetroFramework.Controls.MetroRadioButton rdbNam;
        private MetroFramework.Controls.MetroDateTime dtNamSinh;
        private MetroFramework.Controls.MetroTextBox txtDiaChi;
        private MetroFramework.Controls.MetroTextBox txtSDT;
        private MetroFramework.Controls.MetroTextBox txtHoTen;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox cbxDaNghi;
        private MetroFramework.Controls.MetroCheckBox cbxDangLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
