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
            //btnXemDanhSachPhong.BackColor = Color.Black;
            //btnXemDanhSachPhong.Width = 1000;
            //btnXemDanhSachPhong.Height = 1000;
        }
        //
        //
        //
        private void CustomizeDesign()
        {
            panelThongKeSubMenu.Visible = false;
            panelQuanLySubMenu.Visible = false;

        }

        //
        //
        //
        private void HideSubMenu()
        {
            if (panelThongKeSubMenu.Visible == true)
                panelThongKeSubMenu.Visible = false;
            if (panelQuanLySubMenu.Visible == true)
                panelQuanLySubMenu.Visible = false;
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

        private void ChangeColorDefault()
        {
            if (btnXemDanhSachPhong.BackColor == Color.DarkGray)
                btnXemDanhSachPhong.BackColor = Color.Transparent;
            if (btnThuePhong.BackColor == Color.DarkGray)
                btnThuePhong.BackColor = Color.Transparent;
            if (btnTraPhong.BackColor == Color.DarkGray)
                btnTraPhong.BackColor = Color.Transparent;
            if (btnXemDanhSachDichVu.BackColor == Color.DarkGray)
                btnXemDanhSachDichVu.BackColor = Color.Transparent;
            if (btnThongKe.BackColor == Color.DarkGray)
                btnThongKe.BackColor = Color.Transparent;
            if (btnQuanLy.BackColor == Color.DarkGray)
                btnQuanLy.BackColor = Color.Transparent;
        }

        private void ChangeColorSelected(Button btn)
        {
            if (btn.BackColor == Color.Transparent)
            {
                ChangeColorDefault();
                btn.BackColor = Color.DarkGray;
            }
            //else
            //    btn.BackColor = Color.Transparent;
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
        //Thêm usercontrol chức năng vào panel
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
            HideSubMenu();
            ChangeColorSelected(btnThuePhong);
            UCThuePhong tp = new UCThuePhong();
            AddControlToPanel(tp);

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
            UCThuePhong tp = new UCThuePhong();
            AddControlToPanel(tp);
        }

        //
        // button tra phong
        //
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ChangeColorSelected(btnTraPhong);
            UCTraPhong trp = new UCTraPhong();
            AddControlToPanel(trp);
        }

        //
        // button thống kê
        //
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThongKeSubMenu);
            ChangeColorSelected(btnThongKe);
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
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQuanLySubMenu);
            ChangeColorSelected(btnQuanLy);
        }


        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }


        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnXemDanhSachPhong_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ChangeColorSelected(btnXemDanhSachPhong);
            UCDanhSachPhong2 dsp = new UCDanhSachPhong2();
            AddControlToPanel(dsp);
        }

        private void btnXemDanhSachDichVu_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ChangeColorSelected(btnXemDanhSachDichVu);
            UCDanhSachDichVu dsdv = new UCDanhSachDichVu();
            AddControlToPanel(dsdv);
        }
    }
}
