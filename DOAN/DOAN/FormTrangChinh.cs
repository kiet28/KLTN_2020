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
            CustomizeDesign();
            timerTime.Start();
        }
        //
        //
        //
        private void CustomizeDesign()
        {
            panelThuePhong.Visible = false;
            panelThongKeSubMenu.Visible = false;
            panelQuanLiPhongSubMenu.Visible = false;
            panelQuanLiKhachHangSubMenu.Visible = false;
            panelQuanLiNhanVienSubMenu.Visible = false;
        }

        //
        //
        //
        private void HideSubMenu()
        {
            if (panelThuePhong.Visible == true)
                panelThuePhong.Visible = false;
            if (panelThongKeSubMenu.Visible == true)
                panelThongKeSubMenu.Visible = false;
            if (panelQuanLiPhongSubMenu.Visible == true)
                panelQuanLiPhongSubMenu.Visible = false;
            if (panelQuanLiKhachHangSubMenu.Visible == true)
                panelQuanLiKhachHangSubMenu.Visible = false;
            if (panelQuanLiNhanVienSubMenu.Visible == true)
                panelQuanLiNhanVienSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThuePhong);
        }

        private void btnThuePhongTrucTiep_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            using (FormThuePhongTrucTiep tptt = new FormThuePhongTrucTiep())
            {
                tptt.ShowDialog();
            }
            
        }

        private void btnThuePhongDatTruoc_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            using (FormThuePhongDatTruoc tpdt = new FormThuePhongDatTruoc())
            {
                tpdt.ShowDialog();
            }
        }
    }
}
