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
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dn.Show();
                this.Hide();
            }
        }

        private void ItemDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (FormDoiMatKhau dmk = new FormDoiMatKhau())
            {
                dmk.ShowDialog();
            }
        }

        //
        // button Thue Phong
        //
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThuePhong);
        }

        //
        // button thue phong truc tiep
        //
        private void btnThuePhongTrucTiep_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            using (FormThuePhongTrucTiep tptt = new FormThuePhongTrucTiep())
            {
                tptt.ShowDialog();
            }
            
        }

        //
        // button thue phong dat truoc
        //
        private void btnThuePhongDatTruoc_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            using (FormThuePhongDatTruoc tpdt = new FormThuePhongDatTruoc())
            {
                tpdt.ShowDialog();
            }
        }

        //
        // button tra phong
        //
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            
        }

        //
        // button thống kê
        //
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThongKeSubMenu);
        }

        //
        //thống kê doanh thu
        //
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            //code chức năng
        }

        //
        //thống kê phòng đã đặt
        //
        private void btnThongKePhongDaDat_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        //
        //thống kê phòng còn trống
        //
        private void btnThongKePhongConTrong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        //
        // button quản lí phòng
        //
        private void btnQuanLiPhong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLiPhongSubMenu);
        }

        //
        // thêm phòng
        //
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        //
        //cập nhật phòng
        //
        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLiKhachHangSubMenu);
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLiNhanVienSubMenu);
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnXemDanhSachPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            UCDanhSachPhong dsp = new UCDanhSachPhong();
            AddControlToPanel(dsp);
        }
    }
}
