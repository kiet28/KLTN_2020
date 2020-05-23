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
            this.txtGioNhan = new System.Windows.Forms.TextBox();
            this.txtGioTra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.gridPhongDaChon = new System.Windows.Forms.DataGridView();
            this.btnHuyChon = new DOAN.Button_WOC();
            this.btnChonPhong = new DOAN.Button_WOC();
            this.btnThuePhong = new DOAN.Button_WOC();
            this.btnDanhSachKhachHang = new DOAN.Button_WOC();
            this.btnTaoLai = new DOAN.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label20.Location = new System.Drawing.Point(489, 21);
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
            this.txtTenKhachHang.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.Location = new System.Drawing.Point(221, 135);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(353, 35);
            this.txtTenKhachHang.TabIndex = 40;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
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
            this.txtSoDienThoai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoai.Location = new System.Drawing.Point(819, 135);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(353, 35);
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
            this.txtSoCMND.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.ForeColor = System.Drawing.Color.Black;
            this.txtSoCMND.Location = new System.Drawing.Point(221, 193);
            this.txtSoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.ReadOnly = true;
            this.txtSoCMND.Size = new System.Drawing.Size(353, 35);
            this.txtSoCMND.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(101, 197);
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
            this.label5.Location = new System.Drawing.Point(29, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày nhận phòng:";
            // 
            // dateNgayNhanPhong
            // 
            this.dateNgayNhanPhong.Location = new System.Drawing.Point(221, 252);
            this.dateNgayNhanPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayNhanPhong.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateNgayNhanPhong.Name = "dateNgayNhanPhong";
            this.dateNgayNhanPhong.Size = new System.Drawing.Size(352, 30);
            this.dateNgayNhanPhong.TabIndex = 48;
            // 
            // dateNgayTraPhong
            // 
            this.dateNgayTraPhong.Location = new System.Drawing.Point(221, 309);
            this.dateNgayTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTraPhong.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateNgayTraPhong.Name = "dateNgayTraPhong";
            this.dateNgayTraPhong.Size = new System.Drawing.Size(352, 30);
            this.dateNgayTraPhong.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(51, 314);
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
            this.label7.Location = new System.Drawing.Point(76, 371);
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
            this.label10.Location = new System.Drawing.Point(704, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Giờ nhận:";
            // 
            // txtGioNhan
            // 
            this.txtGioNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGioNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioNhan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioNhan.ForeColor = System.Drawing.Color.Black;
            this.txtGioNhan.Location = new System.Drawing.Point(819, 249);
            this.txtGioNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioNhan.Name = "txtGioNhan";
            this.txtGioNhan.ReadOnly = true;
            this.txtGioNhan.Size = new System.Drawing.Size(353, 35);
            this.txtGioNhan.TabIndex = 64;
            this.txtGioNhan.Text = "14h";
            // 
            // txtGioTra
            // 
            this.txtGioTra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGioTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioTra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioTra.ForeColor = System.Drawing.Color.Black;
            this.txtGioTra.Location = new System.Drawing.Point(819, 306);
            this.txtGioTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioTra.Name = "txtGioTra";
            this.txtGioTra.ReadOnly = true;
            this.txtGioTra.Size = new System.Drawing.Size(353, 35);
            this.txtGioTra.TabIndex = 66;
            this.txtGioTra.Text = "12h";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label11.Location = new System.Drawing.Point(704, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Giờ trả:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.rdNu.Location = new System.Drawing.Point(896, 199);
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
            this.rdNam.Location = new System.Drawing.Point(819, 200);
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
            this.label9.Location = new System.Drawing.Point(704, 197);
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
            this.gridDanhSachPhong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachPhong.Location = new System.Drawing.Point(221, 371);
            this.gridDanhSachPhong.Name = "gridDanhSachPhong";
            this.gridDanhSachPhong.RowHeadersWidth = 51;
            this.gridDanhSachPhong.RowTemplate.Height = 24;
            this.gridDanhSachPhong.Size = new System.Drawing.Size(352, 150);
            this.gridDanhSachPhong.TabIndex = 72;
            this.gridDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachPhong_CellClick);
            // 
            // gridPhongDaChon
            // 
            this.gridPhongDaChon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridPhongDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhongDaChon.Location = new System.Drawing.Point(819, 371);
            this.gridPhongDaChon.Name = "gridPhongDaChon";
            this.gridPhongDaChon.RowHeadersWidth = 51;
            this.gridPhongDaChon.RowTemplate.Height = 24;
            this.gridPhongDaChon.Size = new System.Drawing.Size(353, 150);
            this.gridPhongDaChon.TabIndex = 73;
            this.gridPhongDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhongDaChon_CellClick);
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
            this.btnHuyChon.Location = new System.Drawing.Point(634, 424);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnHuyChon.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyChon.Size = new System.Drawing.Size(128, 47);
            this.btnHuyChon.TabIndex = 71;
            this.btnHuyChon.Text = "<< Hủy chọn";
            this.btnHuyChon.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
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
            this.btnChonPhong.Location = new System.Drawing.Point(634, 371);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnChonPhong.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnChonPhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonPhong.Size = new System.Drawing.Size(128, 47);
            this.btnChonPhong.TabIndex = 70;
            this.btnChonPhong.Text = "Chọn phòng >>";
            this.btnChonPhong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.btnThuePhong.FlatAppearance.BorderSize = 0;
            this.btnThuePhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuePhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnThuePhong.Location = new System.Drawing.Point(455, 597);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnThuePhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnThuePhong.Size = new System.Drawing.Size(447, 65);
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
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(221, 72);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDanhSachKhachHang.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnDanhSachKhachHang.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(203, 56);
            this.btnDanhSachKhachHang.TabIndex = 58;
            this.btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            this.btnDanhSachKhachHang.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
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
            this.btnTaoLai.Location = new System.Drawing.Point(1028, 72);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnTaoLai.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.Size = new System.Drawing.Size(144, 56);
            this.btnTaoLai.TabIndex = 74;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.UseVisualStyleBackColor = true;
            // 
            // UCThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.gridPhongDaChon);
            this.Controls.Add(this.gridDanhSachPhong);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnChonPhong);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGioTra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGioNhan);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongDaChon)).EndInit();
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
        private System.Windows.Forms.TextBox txtGioNhan;
        private System.Windows.Forms.TextBox txtGioTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView gridPhongDaChon;
        private System.Windows.Forms.DataGridView gridDanhSachPhong;
        private Button_WOC btnHuyChon;
        private Button_WOC btnChonPhong;
        private Button_WOC btnTaoLai;
    }
}
