namespace DOAN
{
    partial class UCThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThuePhong));
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNgayNhanPhong = new MetroFramework.Controls.MetroDateTime();
            this.dateNgayTraPhong = new MetroFramework.Controls.MetroDateTime();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new MetroFramework.Controls.MetroComboBox();
            this.btnTaoLai = new DOAN.Button_WOC();
            this.btnHuyChon = new DOAN.Button_WOC();
            this.btnChonPhong = new DOAN.Button_WOC();
            this.btnThuePhong = new DOAN.Button_WOC();
            this.btnDanhSachKhachHang = new DOAN.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label20.Location = new System.Drawing.Point(503, 12);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(363, 39);
            this.label20.TabIndex = 35;
            this.label20.Text = "Thuê phòng khách sạn";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.Location = new System.Drawing.Point(221, 135);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(394, 27);
            this.txtTenKhachHang.TabIndex = 40;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoai.Location = new System.Drawing.Point(819, 135);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(410, 27);
            this.txtSoDienThoai.TabIndex = 42;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(669, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số điện thoại:";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.ForeColor = System.Drawing.Color.Black;
            this.txtSoCMND.Location = new System.Drawing.Point(220, 181);
            this.txtSoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(394, 27);
            this.txtSoCMND.TabIndex = 44;
            this.txtSoCMND.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(96, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(31, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày nhận phòng:";
            // 
            // dateNgayNhanPhong
            // 
            this.dateNgayNhanPhong.Location = new System.Drawing.Point(220, 226);
            this.dateNgayNhanPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayNhanPhong.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateNgayNhanPhong.Name = "dateNgayNhanPhong";
            this.dateNgayNhanPhong.Size = new System.Drawing.Size(395, 30);
            this.dateNgayNhanPhong.TabIndex = 48;
            this.dateNgayNhanPhong.ValueChanged += new System.EventHandler(this.dateNgayNhanPhong_ValueChanged);
            // 
            // dateNgayTraPhong
            // 
            this.dateNgayTraPhong.Location = new System.Drawing.Point(220, 270);
            this.dateNgayTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTraPhong.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateNgayTraPhong.Name = "dateNgayTraPhong";
            this.dateNgayTraPhong.Size = new System.Drawing.Size(395, 30);
            this.dateNgayTraPhong.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(53, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Ngày trả phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(78, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Chọn phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label10.Location = new System.Drawing.Point(708, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienCoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.ForeColor = System.Drawing.Color.Black;
            this.txtTienCoc.Location = new System.Drawing.Point(819, 230);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(410, 27);
            this.txtTienCoc.TabIndex = 64;
            this.txtTienCoc.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label11.Location = new System.Drawing.Point(695, 276);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Trạng thái:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.rdNu.Location = new System.Drawing.Point(896, 181);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(51, 24);
            this.rdNu.TabIndex = 69;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.rdNam.Location = new System.Drawing.Point(819, 182);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(65, 24);
            this.rdNam.TabIndex = 68;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label9.Location = new System.Drawing.Point(713, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 67;
            this.label9.Text = "Giới tính:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gridDanhSachPhong
            // 
            this.gridDanhSachPhong.AllowUserToResizeColumns = false;
            this.gridDanhSachPhong.AllowUserToResizeRows = false;
            this.gridDanhSachPhong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridDanhSachPhong.ColumnHeadersHeight = 29;
            this.gridDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDanhSachPhong.Location = new System.Drawing.Point(222, 321);
            this.gridDanhSachPhong.MultiSelect = false;
            this.gridDanhSachPhong.Name = "gridDanhSachPhong";
            this.gridDanhSachPhong.RowHeadersWidth = 51;
            this.gridDanhSachPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDanhSachPhong.RowTemplate.Height = 24;
            this.gridDanhSachPhong.Size = new System.Drawing.Size(1007, 274);
            this.gridDanhSachPhong.TabIndex = 72;
            this.gridDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachPhong_CellClick);
            this.gridDanhSachPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachPhong_CellDoubleClick);
            this.gridDanhSachPhong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridDanhSachPhong_DataBindingComplete);
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(221, 93);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(85, 27);
            this.txtMaKH.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(51, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Mã khách hàng:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.ItemHeight = 24;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Thuê phòng",
            "Đặt phòng"});
            this.cboTrangThai.Location = new System.Drawing.Point(819, 274);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(410, 30);
            this.cboTrangThai.TabIndex = 79;
            this.cboTrangThai.UseSelectable = true;
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.BorderColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnTaoLai.FlatAppearance.BorderSize = 0;
            this.btnTaoLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnTaoLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLai.Location = new System.Drawing.Point(1085, 72);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnTaoLai.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.Size = new System.Drawing.Size(144, 56);
            this.btnTaoLai.TabIndex = 74;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.BorderColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.btnHuyChon.FlatAppearance.BorderSize = 0;
            this.btnHuyChon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnHuyChon.Location = new System.Drawing.Point(656, 423);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnHuyChon.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyChon.Size = new System.Drawing.Size(128, 47);
            this.btnHuyChon.TabIndex = 71;
            this.btnHuyChon.Text = "<< Hủy chọn";
            this.btnHuyChon.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnChonPhong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnChonPhong.FlatAppearance.BorderSize = 0;
            this.btnChonPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChonPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChonPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnChonPhong.Location = new System.Drawing.Point(656, 370);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnChonPhong.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnChonPhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonPhong.Size = new System.Drawing.Size(128, 47);
            this.btnChonPhong.TabIndex = 70;
            this.btnChonPhong.Text = "Chọn phòng >>";
            this.btnChonPhong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonPhong.UseVisualStyleBackColor = true;
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnThuePhong.FlatAppearance.BorderSize = 0;
            this.btnThuePhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuePhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnThuePhong.Location = new System.Drawing.Point(510, 601);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnThuePhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnThuePhong.Size = new System.Drawing.Size(395, 65);
            this.btnThuePhong.TabIndex = 59;
            this.btnThuePhong.Text = "Thuê phòng";
            this.btnThuePhong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnDanhSachKhachHang.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.btnDanhSachKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDanhSachKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnDanhSachKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachKhachHang.Image")));
            this.btnDanhSachKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(393, 67);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDanhSachKhachHang.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnDanhSachKhachHang.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(221, 56);
            this.btnDanhSachKhachHang.TabIndex = 58;
            this.btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            this.btnDanhSachKhachHang.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // UCThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.gridDanhSachPhong);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnChonPhong);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThuePhong);
            this.Controls.Add(this.btnDanhSachKhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateNgayTraPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateNgayNhanPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCThuePhong";
            this.Size = new System.Drawing.Size(1329, 693);
            this.Load += new System.EventHandler(this.UCThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime dateNgayNhanPhong;
        private MetroFramework.Controls.MetroDateTime dateNgayTraPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Button_WOC btnDanhSachKhachHang;
        private Button_WOC btnThuePhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView gridDanhSachPhong;
        private Button_WOC btnHuyChon;
        private Button_WOC btnChonPhong;
        private Button_WOC btnTaoLai;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cboTrangThai;
    }
}
