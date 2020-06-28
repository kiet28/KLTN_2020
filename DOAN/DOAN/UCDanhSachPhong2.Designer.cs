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
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTrangThaiPhong = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateChonNgay = new MetroFramework.Controls.MetroDateTime();
            this.gridDanhSachPhong = new System.Windows.Forms.DataGridView();
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
            this.label19.Location = new System.Drawing.Point(447, 74);
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
            "Đã thuê",
            "Đã đặt"});
            this.cboTrangThaiPhong.Location = new System.Drawing.Point(568, 105);
            this.cboTrangThaiPhong.Name = "cboTrangThaiPhong";
            this.cboTrangThaiPhong.Size = new System.Drawing.Size(328, 30);
            this.cboTrangThaiPhong.TabIndex = 65;
            this.cboTrangThaiPhong.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(395, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Trạng thái phòng:";
            // 
            // dateChonNgay
            // 
            this.dateChonNgay.Location = new System.Drawing.Point(568, 69);
            this.dateChonNgay.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateChonNgay.Name = "dateChonNgay";
            this.dateChonNgay.Size = new System.Drawing.Size(328, 30);
            this.dateChonNgay.TabIndex = 66;
            // 
            // gridDanhSachPhong
            // 
            this.gridDanhSachPhong.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachPhong.GridColor = System.Drawing.Color.White;
            this.gridDanhSachPhong.Location = new System.Drawing.Point(175, 167);
            this.gridDanhSachPhong.Name = "gridDanhSachPhong";
            this.gridDanhSachPhong.RowHeadersWidth = 51;
            this.gridDanhSachPhong.RowTemplate.Height = 24;
            this.gridDanhSachPhong.Size = new System.Drawing.Size(1001, 501);
            this.gridDanhSachPhong.TabIndex = 67;
            // 
            // UCDanhSachPhong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDanhSachPhong);
            this.Controls.Add(this.dateChonNgay);
            this.Controls.Add(this.cboTrangThaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Name = "UCDanhSachPhong2";
            this.Size = new System.Drawing.Size(1329, 693);
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
    }
}
