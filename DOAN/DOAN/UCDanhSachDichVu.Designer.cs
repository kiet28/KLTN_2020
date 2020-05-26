namespace DOAN
{
    partial class UCDanhSachDichVu
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
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChonPhong = new MetroFramework.Controls.MetroComboBox();
            this.gridDichVuDaChon = new System.Windows.Forms.DataGridView();
            this.donvicol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuDungDichVu = new DOAN.Button_WOC();
            this.btnQuanLyDichVu = new DOAN.Button_WOC();
            this.btnHuyDichVu = new DOAN.Button_WOC();
            this.btnChonDichVu = new DOAN.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVuDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label20.Location = new System.Drawing.Point(471, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(295, 39);
            this.label20.TabIndex = 35;
            this.label20.Text = "Dịch vụ khách sạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Danh sách dịch vụ:";
            // 
            // gridDanhSachDichVu
            // 
            this.gridDanhSachDichVu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachDichVu.Location = new System.Drawing.Point(27, 147);
            this.gridDanhSachDichVu.Name = "gridDanhSachDichVu";
            this.gridDanhSachDichVu.RowHeadersWidth = 51;
            this.gridDanhSachDichVu.RowTemplate.Height = 24;
            this.gridDanhSachDichVu.Size = new System.Drawing.Size(523, 388);
            this.gridDanhSachDichVu.TabIndex = 41;
            this.gridDanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachDichVu_CellClick);
            this.gridDanhSachDichVu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridDanhSachDichVu_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(704, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Chọn phòng:";
            // 
            // cbChonPhong
            // 
            this.cbChonPhong.FormattingEnabled = true;
            this.cbChonPhong.ItemHeight = 24;
            this.cbChonPhong.Items.AddRange(new object[] {
            "Danh sách phòng đã thuê"});
            this.cbChonPhong.Location = new System.Drawing.Point(837, 100);
            this.cbChonPhong.Name = "cbChonPhong";
            this.cbChonPhong.Size = new System.Drawing.Size(406, 30);
            this.cbChonPhong.TabIndex = 43;
            this.cbChonPhong.UseSelectable = true;
            // 
            // gridDichVuDaChon
            // 
            this.gridDichVuDaChon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridDichVuDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDichVuDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donvicol,
            this.soluongcol});
            this.gridDichVuDaChon.Location = new System.Drawing.Point(709, 147);
            this.gridDichVuDaChon.Name = "gridDichVuDaChon";
            this.gridDichVuDaChon.RowHeadersWidth = 51;
            this.gridDichVuDaChon.RowTemplate.Height = 24;
            this.gridDichVuDaChon.Size = new System.Drawing.Size(534, 388);
            this.gridDichVuDaChon.TabIndex = 44;
            this.gridDichVuDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDichVuDaChon_CellClick);
            this.gridDichVuDaChon.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridDichVuDaChon_EditingControlShowing);
            // 
            // donvicol
            // 
            this.donvicol.HeaderText = "Đơn vị tính";
            this.donvicol.MinimumWidth = 6;
            this.donvicol.Name = "donvicol";
            this.donvicol.ReadOnly = true;
            this.donvicol.Width = 125;
            // 
            // soluongcol
            // 
            this.soluongcol.HeaderText = "Số lượng";
            this.soluongcol.MinimumWidth = 6;
            this.soluongcol.Name = "soluongcol";
            this.soluongcol.Width = 125;
            // 
            // btnSuDungDichVu
            // 
            this.btnSuDungDichVu.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuDungDichVu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.btnSuDungDichVu.FlatAppearance.BorderSize = 0;
            this.btnSuDungDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSuDungDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuDungDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuDungDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuDungDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnSuDungDichVu.Location = new System.Drawing.Point(407, 552);
            this.btnSuDungDichVu.Name = "btnSuDungDichVu";
            this.btnSuDungDichVu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSuDungDichVu.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnSuDungDichVu.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuDungDichVu.Size = new System.Drawing.Size(447, 65);
            this.btnSuDungDichVu.TabIndex = 65;
            this.btnSuDungDichVu.Text = "Sử dụng dịch vụ";
            this.btnSuDungDichVu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuDungDichVu.UseVisualStyleBackColor = true;
            this.btnSuDungDichVu.Click += new System.EventHandler(this.btnSuDungDichVu_Click);
            // 
            // btnQuanLyDichVu
            // 
            this.btnQuanLyDichVu.BorderColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDichVu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnQuanLyDichVu.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnQuanLyDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDichVu.Location = new System.Drawing.Point(323, 80);
            this.btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            this.btnQuanLyDichVu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDichVu.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnQuanLyDichVu.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyDichVu.Size = new System.Drawing.Size(227, 61);
            this.btnQuanLyDichVu.TabIndex = 64;
            this.btnQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.btnQuanLyDichVu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyDichVu.UseVisualStyleBackColor = true;
            this.btnQuanLyDichVu.Click += new System.EventHandler(this.btnQuanLyDichVu_Click);
            // 
            // btnHuyDichVu
            // 
            this.btnHuyDichVu.BorderColor = System.Drawing.Color.Transparent;
            this.btnHuyDichVu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.btnHuyDichVu.FlatAppearance.BorderSize = 0;
            this.btnHuyDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHuyDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHuyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnHuyDichVu.Location = new System.Drawing.Point(556, 336);
            this.btnHuyDichVu.Name = "btnHuyDichVu";
            this.btnHuyDichVu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHuyDichVu.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnHuyDichVu.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyDichVu.Size = new System.Drawing.Size(147, 68);
            this.btnHuyDichVu.TabIndex = 63;
            this.btnHuyDichVu.Text = "<< Hủy dịch vụ";
            this.btnHuyDichVu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuyDichVu.UseVisualStyleBackColor = true;
            this.btnHuyDichVu.Click += new System.EventHandler(this.btnHuyDichVu_Click);
            // 
            // btnChonDichVu
            // 
            this.btnChonDichVu.BorderColor = System.Drawing.Color.Transparent;
            this.btnChonDichVu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnChonDichVu.FlatAppearance.BorderSize = 0;
            this.btnChonDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChonDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChonDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(66)))), ((int)(((byte)(135)))));
            this.btnChonDichVu.Location = new System.Drawing.Point(556, 262);
            this.btnChonDichVu.Name = "btnChonDichVu";
            this.btnChonDichVu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnChonDichVu.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.btnChonDichVu.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonDichVu.Size = new System.Drawing.Size(147, 68);
            this.btnChonDichVu.TabIndex = 62;
            this.btnChonDichVu.Text = "Chọn dịch vụ >>";
            this.btnChonDichVu.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonDichVu.UseVisualStyleBackColor = true;
            this.btnChonDichVu.Click += new System.EventHandler(this.btnChonDichVu_Click);
            // 
            // UCDanhSachDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnSuDungDichVu);
            this.Controls.Add(this.btnQuanLyDichVu);
            this.Controls.Add(this.btnHuyDichVu);
            this.Controls.Add(this.btnChonDichVu);
            this.Controls.Add(this.gridDichVuDaChon);
            this.Controls.Add(this.cbChonPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDanhSachDichVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDanhSachDichVu";
            this.Size = new System.Drawing.Size(1329, 693);
            this.Load += new System.EventHandler(this.UCDanhSachDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVuDaChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDanhSachDichVu;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cbChonPhong;
        private System.Windows.Forms.DataGridView gridDichVuDaChon;
        private Button_WOC btnChonDichVu;
        private Button_WOC btnHuyDichVu;
        private Button_WOC btnSuDungDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvicol;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongcol;
        public Button_WOC btnQuanLyDichVu;
    }
}
