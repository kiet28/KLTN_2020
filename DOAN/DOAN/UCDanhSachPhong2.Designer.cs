namespace DOAN
{
    partial class UCDanhSachPhong2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDanhSachPhong2));
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTrangThaiPhong = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateChonNgay = new MetroFramework.Controls.MetroDateTime();
            this.gridDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btnHuyDatPhong = new DOAN.Button_WOC();
            this.btnTraPhong = new DOAN.Button_WOC();
            this.btnTaoLai = new DOAN.Button_WOC();
            this.btnTimKiem = new DOAN.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label20.Location = new System.Drawing.Point(448, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(448, 39);
            this.label20.TabIndex = 62;
            this.label20.Text = "Danh sách phòng khách sạn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label19.Location = new System.Drawing.Point(334, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 25);
            this.label19.TabIndex = 61;
            this.label19.Text = "Chọn ngày:";
            // 
            // cboTrangThaiPhong
            // 
            this.cboTrangThaiPhong.FormattingEnabled = true;
            this.cboTrangThaiPhong.ItemHeight = 24;
            this.cboTrangThaiPhong.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt"});
            this.cboTrangThaiPhong.Location = new System.Drawing.Point(455, 114);
            this.cboTrangThaiPhong.Name = "cboTrangThaiPhong";
            this.cboTrangThaiPhong.Size = new System.Drawing.Size(328, 30);
            this.cboTrangThaiPhong.TabIndex = 65;
            this.cboTrangThaiPhong.UseSelectable = true;
            this.cboTrangThaiPhong.SelectionChangeCommitted += new System.EventHandler(this.cboTrangThaiPhong_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(282, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Trạng thái phòng:";
            // 
            // dateChonNgay
            // 
            this.dateChonNgay.Location = new System.Drawing.Point(455, 78);
            this.dateChonNgay.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateChonNgay.Name = "dateChonNgay";
            this.dateChonNgay.Size = new System.Drawing.Size(328, 30);
            this.dateChonNgay.TabIndex = 66;
            // 
            // gridDanhSachPhong
            // 
            this.gridDanhSachPhong.AllowUserToResizeColumns = false;
            this.gridDanhSachPhong.AllowUserToResizeRows = false;
            this.gridDanhSachPhong.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDanhSachPhong.ColumnHeadersHeight = 29;
            this.gridDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDanhSachPhong.GridColor = System.Drawing.Color.White;
            this.gridDanhSachPhong.Location = new System.Drawing.Point(175, 167);
            this.gridDanhSachPhong.MultiSelect = false;
            this.gridDanhSachPhong.Name = "gridDanhSachPhong";
            this.gridDanhSachPhong.RowHeadersWidth = 51;
            this.gridDanhSachPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDanhSachPhong.RowTemplate.Height = 24;
            this.gridDanhSachPhong.Size = new System.Drawing.Size(1001, 427);
            this.gridDanhSachPhong.TabIndex = 67;
            this.gridDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachPhong_CellClick);
            this.gridDanhSachPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachPhong_CellDoubleClick);
            this.gridDanhSachPhong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridDanhSachPhong_DataBindingComplete);
            // 
            // btnHuyDatPhong
            // 
            this.btnHuyDatPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnHuyDatPhong.ButtonColor = System.Drawing.Color.Gray;
            this.btnHuyDatPhong.Enabled = false;
            this.btnHuyDatPhong.FlatAppearance.BorderSize = 0;
            this.btnHuyDatPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHuyDatPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHuyDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnHuyDatPhong.Location = new System.Drawing.Point(705, 600);
            this.btnHuyDatPhong.Name = "btnHuyDatPhong";
            this.btnHuyDatPhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHuyDatPhong.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnHuyDatPhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyDatPhong.Size = new System.Drawing.Size(319, 65);
            this.btnHuyDatPhong.TabIndex = 77;
            this.btnHuyDatPhong.Text = "Hủy đặt phòng";
            this.btnHuyDatPhong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyDatPhong.UseVisualStyleBackColor = true;
            this.btnHuyDatPhong.Click += new System.EventHandler(this.btnHuyDatPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnTraPhong.ButtonColor = System.Drawing.Color.Gray;
            this.btnTraPhong.Enabled = false;
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTraPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnTraPhong.Location = new System.Drawing.Point(339, 600);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTraPhong.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnTraPhong.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTraPhong.Size = new System.Drawing.Size(322, 65);
            this.btnTraPhong.TabIndex = 76;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTraPhong.UseVisualStyleBackColor = true;
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
            this.btnTaoLai.Location = new System.Drawing.Point(966, 83);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTaoLai.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnTaoLai.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.Size = new System.Drawing.Size(114, 56);
            this.btnTaoLai.TabIndex = 75;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(798, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimKiem.Size = new System.Drawing.Size(162, 56);
            this.btnTimKiem.TabIndex = 68;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // UCDanhSachPhong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnHuyDatPhong);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gridDanhSachPhong);
            this.Controls.Add(this.dateChonNgay);
            this.Controls.Add(this.cboTrangThaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Name = "UCDanhSachPhong2";
            this.Size = new System.Drawing.Size(1329, 693);
            this.Load += new System.EventHandler(this.UCDanhSachPhong2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private MetroFramework.Controls.MetroComboBox cboTrangThaiPhong;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dateChonNgay;
        private System.Windows.Forms.DataGridView gridDanhSachPhong;
        private Button_WOC btnTimKiem;
        private Button_WOC btnTaoLai;
        private Button_WOC btnTraPhong;
        private Button_WOC btnHuyDatPhong;
    }
}
