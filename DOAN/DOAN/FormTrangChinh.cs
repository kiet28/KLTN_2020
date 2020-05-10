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

        //
        // Button thoát chương trình
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        // icon Menu
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FormDangNhap dn = new FormDangNhap();
            //dn.Show();
            //this.Visible = false;
        }

        //
        // Hiển thị thời gian
        //
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
            labelDate.Text = dt.ToString("dd/MM/yyyy");
        }

        //
        //Thêm control chức năng vào panel
        //
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        //
        // Home
        //
        private void labelHome_Click(object sender, EventArgs e)
        {
            UCTrangChinh tc = new UCTrangChinh();
            AddControlToPanel(tc);
        }

        //
        // Load Form
        //
        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            UCTrangChinh tc = new UCTrangChinh();
            AddControlToPanel(tc);
        }

        private void ItemDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Visible = false;
        }

        private void ItemDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (FormDoiMatKhau dmk = new FormDoiMatKhau())
            {
                dmk.ShowDialog();
            }
        }
    }
}
