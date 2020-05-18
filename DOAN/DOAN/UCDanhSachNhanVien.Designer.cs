namespace DOAN
{
    partial class UCDanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDanhSachNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.lvwDanhSachNV = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 25);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 25);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(768, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 26);
            this.txtSearch.TabIndex = 17;
            // 
            // ptbSearch
            // 
            this.ptbSearch.BackColor = System.Drawing.Color.Transparent;
            this.ptbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSearch.Image = ((System.Drawing.Image)(resources.GetObject("ptbSearch.Image")));
            this.ptbSearch.Location = new System.Drawing.Point(1013, 91);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(34, 26);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 18;
            this.ptbSearch.TabStop = false;
            // 
            // lvwDanhSachNV
            // 
            this.lvwDanhSachNV.HideSelection = false;
            this.lvwDanhSachNV.Location = new System.Drawing.Point(0, 150);
            this.lvwDanhSachNV.Name = "lvwDanhSachNV";
            this.lvwDanhSachNV.Size = new System.Drawing.Size(1050, 300);
            this.lvwDanhSachNV.TabIndex = 19;
            this.lvwDanhSachNV.UseCompatibleStateImageBehavior = false;
            // 
            // UCDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwDanhSachNV);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UCDanhSachNhanVien";
            this.Size = new System.Drawing.Size(1050, 450);
            this.Load += new System.EventHandler(this.UCDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.ListView lvwDanhSachNV;
    }
}
