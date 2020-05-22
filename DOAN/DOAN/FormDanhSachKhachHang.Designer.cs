namespace DOAN
{
    partial class FormDanhSachKhachHang
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.btnChonKhachHang = new DOAN.Button_WOC();
            this.gridDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.dragControl1 = new DOAN.DragControl();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.btnThoat);
            this.panelHeader.Controls.Add(this.label20);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(734, 59);
            this.panelHeader.TabIndex = 52;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Location = new System.Drawing.Point(670, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 59);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(13, 12);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(311, 31);
            this.label20.TabIndex = 41;
            this.label20.Text = "Danh sách khách hàng";
            // 
            // txtTimKiemKhachHang
            // 
            this.txtTimKiemKhachHang.AcceptsReturn = true;
            this.txtTimKiemKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiemKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemKhachHang.Location = new System.Drawing.Point(193, 67);
            this.txtTimKiemKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            this.txtTimKiemKhachHang.Size = new System.Drawing.Size(375, 34);
            this.txtTimKiemKhachHang.TabIndex = 57;
            this.txtTimKiemKhachHang.TextChanged += new System.EventHandler(this.txtTimKiemKhachHang_TextChanged);
            this.txtTimKiemKhachHang.Enter += new System.EventHandler(this.txtTimKiemKhachHang_Enter);
            this.txtTimKiemKhachHang.Leave += new System.EventHandler(this.txtTimKiemKhachHang_Leave);
            // 
            // btnChonKhachHang
            // 
            this.btnChonKhachHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnChonKhachHang.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.btnChonKhachHang.FlatAppearance.BorderSize = 0;
            this.btnChonKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChonKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChonKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonKhachHang.Location = new System.Drawing.Point(12, 407);
            this.btnChonKhachHang.Name = "btnChonKhachHang";
            this.btnChonKhachHang.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnChonKhachHang.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.btnChonKhachHang.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonKhachHang.Size = new System.Drawing.Size(710, 63);
            this.btnChonKhachHang.TabIndex = 55;
            this.btnChonKhachHang.Text = "Chọn khách hàng";
            this.btnChonKhachHang.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonKhachHang.UseVisualStyleBackColor = true;
            this.btnChonKhachHang.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridDanhSachKhachHang
            // 
            this.gridDanhSachKhachHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachKhachHang.Location = new System.Drawing.Point(12, 108);
            this.gridDanhSachKhachHang.Name = "gridDanhSachKhachHang";
            this.gridDanhSachKhachHang.RowHeadersWidth = 51;
            this.gridDanhSachKhachHang.RowTemplate.Height = 24;
            this.gridDanhSachKhachHang.Size = new System.Drawing.Size(710, 293);
            this.gridDanhSachKhachHang.TabIndex = 58;
            this.gridDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDanhSachKhachHang_CellClick);
            this.gridDanhSachKhachHang.DoubleClick += new System.EventHandler(this.gridDanhSachKhachHang_DoubleClick);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // FormDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.gridDanhSachKhachHang);
            this.Controls.Add(this.txtTimKiemKhachHang);
            this.Controls.Add(this.btnChonKhachHang);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemKhachHang";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_WOC btnChonKhachHang;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTimKiemKhachHang;
        private System.Windows.Forms.DataGridView gridDanhSachKhachHang;
        private DragControl dragControl1;
    }
}