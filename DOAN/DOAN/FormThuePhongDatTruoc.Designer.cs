namespace DOAN
{
    partial class FormThuePhongDatTruoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThuePhongDatTruoc));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimTheoCMND = new System.Windows.Forms.TextBox();
            this.picTimTheoCMND = new System.Windows.Forms.PictureBox();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimTheoCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(561, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 64;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(147, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(306, 32);
            this.label20.TabIndex = 63;
            this.label20.Text = "Thuê phòng đặt trước";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(10, 541);
            this.flowLayoutPanel3.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 10);
            this.panel2.TabIndex = 61;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(607, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(10, 551);
            this.flowLayoutPanel2.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 10);
            this.panel1.TabIndex = 59;
            // 
            // txtTimTheoCMND
            // 
            this.txtTimTheoCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimTheoCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoCMND.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimTheoCMND.Location = new System.Drawing.Point(153, 73);
            this.txtTimTheoCMND.Name = "txtTimTheoCMND";
            this.txtTimTheoCMND.Size = new System.Drawing.Size(263, 26);
            this.txtTimTheoCMND.TabIndex = 65;
            this.txtTimTheoCMND.TabStop = false;
            this.txtTimTheoCMND.Text = "Nhập số CMND";
            this.txtTimTheoCMND.Click += new System.EventHandler(this.txtTimTheoCMND_Click);
            this.txtTimTheoCMND.TextChanged += new System.EventHandler(this.txtTimTheoCMND_TextChanged);
            this.txtTimTheoCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimTheoCMND_KeyPress);
            // 
            // picTimTheoCMND
            // 
            this.picTimTheoCMND.Image = ((System.Drawing.Image)(resources.GetObject("picTimTheoCMND.Image")));
            this.picTimTheoCMND.Location = new System.Drawing.Point(422, 72);
            this.picTimTheoCMND.Name = "picTimTheoCMND";
            this.picTimTheoCMND.Size = new System.Drawing.Size(31, 27);
            this.picTimTheoCMND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimTheoCMND.TabIndex = 66;
            this.picTimTheoCMND.TabStop = false;
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Location = new System.Drawing.Point(16, 121);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.Size = new System.Drawing.Size(585, 374);
            this.dgvDatPhong.TabIndex = 67;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNhanPhong.FlatAppearance.BorderSize = 0;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.ForeColor = System.Drawing.Color.Black;
            this.btnNhanPhong.Location = new System.Drawing.Point(16, 501);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(585, 44);
            this.btnNhanPhong.TabIndex = 68;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            // 
            // FormThuePhongDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(617, 561);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.dgvDatPhong);
            this.Controls.Add(this.picTimTheoCMND);
            this.Controls.Add(this.txtTimTheoCMND);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThuePhongDatTruoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThuePhongDatTruoc";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimTheoCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimTheoCMND;
        private System.Windows.Forms.PictureBox picTimTheoCMND;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private System.Windows.Forms.Button btnNhanPhong;
    }
}