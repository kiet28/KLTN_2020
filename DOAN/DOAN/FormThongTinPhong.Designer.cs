namespace DOAN
{
    partial class FormThongTinPhong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNgayPhong = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Location = new System.Drawing.Point(549, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 52);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(16, 7);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(224, 31);
            this.label20.TabIndex = 35;
            this.label20.Text = "Thông tin phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(137, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ngày:";
            // 
            // lblNgayPhong
            // 
            this.lblNgayPhong.AutoSize = true;
            this.lblNgayPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.lblNgayPhong.Location = new System.Drawing.Point(211, 90);
            this.lblNgayPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayPhong.Name = "lblNgayPhong";
            this.lblNgayPhong.Size = new System.Drawing.Size(120, 25);
            this.lblNgayPhong.TabIndex = 50;
            this.lblNgayPhong.Text = "dd/MM/yyyy";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.Location = new System.Drawing.Point(211, 484);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGhiChu.Size = new System.Drawing.Size(353, 115);
            this.txtGhiChu.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(108, 484);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(29, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTenKH.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.Location = new System.Drawing.Point(211, 337);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(353, 35);
            this.txtTenKH.TabIndex = 46;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaPhong.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGiaPhong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.ForeColor = System.Drawing.Color.Black;
            this.txtGiaPhong.Location = new System.Drawing.Point(211, 279);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.ReadOnly = true;
            this.txtGiaPhong.Size = new System.Drawing.Size(353, 35);
            this.txtGiaPhong.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(87, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Giá phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(87, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Trạng thái:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTrangThai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.Location = new System.Drawing.Point(211, 225);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(353, 35);
            this.txtTrangThai.TabIndex = 42;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiPhong.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTenLoaiPhong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(211, 174);
            this.txtTenLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.ReadOnly = true;
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(353, 35);
            this.txtTenLoaiPhong.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(76, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(84, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhong.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTenPhong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.Black;
            this.txtTenPhong.Location = new System.Drawing.Point(211, 126);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(353, 35);
            this.txtTenPhong.TabIndex = 38;
            // 
            // txtDichVu
            // 
            this.txtDichVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDichVu.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDichVu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVu.ForeColor = System.Drawing.Color.Black;
            this.txtDichVu.Location = new System.Drawing.Point(211, 396);
            this.txtDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDichVu.Multiline = true;
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.ReadOnly = true;
            this.txtDichVu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDichVu.Size = new System.Drawing.Size(353, 80);
            this.txtDichVu.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(35, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Dịch vụ sử dụng:";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FormThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 620);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNgayPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLoaiPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThongTinPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTinPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNgayPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerTime;
    }
}