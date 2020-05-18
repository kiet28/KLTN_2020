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
    public partial class FormQuanLyNhanVien : Form
    {
        private void AddControlPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            timeTimer.Start();
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            FormTrangChinh frm = new FormTrangChinh();
            frm.Show();
            this.Dispose();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
            labelDate.Text = dt.ToString("dd/MM/yyyy");
        }

        private void btnThemV_Click(object sender, EventArgs e)
        {
            UCThemNhanVien ucThemNV = new UCThemNhanVien();
            AddControlPanel(ucThemNV);
        }

        private void btnCapNhatThongTinNV_Click(object sender, EventArgs e)
        {
            UCCapNhatTTNhanVien ucCapNhatTT = new UCCapNhatTTNhanVien();
            AddControlPanel(ucCapNhatTT);
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            UCDanhSachNhanVien ucDanhSachNV = new UCDanhSachNhanVien();
            AddControlPanel(ucDanhSachNV);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ứng dụng?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
