﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormTrangChinh tc = new FormTrangChinh();
            tc.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            using (FormDoiMatKhau dmk = new FormDoiMatKhau())
            {
                dmk.ShowDialog();
            }
        }
    }
}
