using System;
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
    public partial class FormTrangChinh : Form
    {
        public FormTrangChinh()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Visible = false;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
            labelDate.Text = dt.ToString("dd/MM/yyyy");
        }
    }
}
