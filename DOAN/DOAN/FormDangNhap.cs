using BLL;
using Entities;
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
    public partial class FormDangNhap : Form
    {
        List<eTaiKhoan> dsTK;
        List<eNhanVien> dsNV;
        NhanVienBLL nvBLL;
        TaiKhoanBLL tkBLL;
        //BacSiBLL bsBLL;
        //List<eBacSi> dsBS;
        List<int> myList;
        QuanLyBLL qlBLL;
        List<eQuanLy> dsQL;
        public FormDangNhap()
        {
            InitializeComponent();
            myList = new List<int>();
            dsQL = new List<eQuanLy>();
            qlBLL = new QuanLyBLL();
            dsTK = new List<eTaiKhoan>();
            tkBLL = new TaiKhoanBLL();
            //dsBS = new List<eBacSi>();
            //bsBLL = new BacSiBLL();
            nvBLL = new NhanVienBLL();
            dsNV = new List<eNhanVien>();
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
            dsQL = qlBLL.LayThongTinQuanLy();
            dsNV = nvBLL.LayThongTinNhanVien();
            dsTK = tkBLL.LayThongTinTaiKhoan();
            
            var taiKhoan = dsTK.Where(tk => tk.UserName == txtTenDN.Text && tk.Pass == txtMatKhau.Text)
                .Select(tk => tk.LoaiTK).FirstOrDefault();
            var taiKhoanTest = dsTK.Where(tk => tk.UserName == txtTenDN.Text && tk.Pass == txtMatKhau.Text)
                            .Select(tk => tk.LoaiTK).Any();
            if (taiKhoanTest == false)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng nhập lại!");
            }
            else
            {
                
                if (taiKhoan == "NV")
                {
                    FormTrangChinh tc = new FormTrangChinh();
                    var tenNV = dsNV.Join(dsTK, tk => tk.MaNhanVien, bs => bs.MaNV, (tk, bs) => new { tk, bs })
                    .Where(bs1 => bs1.bs.MaNV == bs1.tk.MaNhanVien)
                    .Select(bs2 => bs2.tk.TenNhanVien).FirstOrDefault();

                    tc.lblTenDangNhap.Text = tenNV.ToString();
                    tc.btnQuanLiPhong.Enabled = false;
                    tc.btnQuanLiNhanVien.Enabled = false;
                    tc.btnQuanLiKhachHang.Enabled = false;//tạo label vào form bán hàng để hiển thị tên lên form
                    tc.Show();
                    this.Hide();
                }
                
                if (taiKhoan == "QL")
                {
                    FormTrangChinh tc = new FormTrangChinh();
                    var tenQL = dsQL.Join(dsTK, tk => tk.MaNQL, bs => bs.MaNQL, (tk, bs) => new { tk, bs })
                    .Where(bs1 => bs1.bs.MaNQL == bs1.tk.MaNQL)
                    .Select(bs2 => bs2.tk.TenNQL).FirstOrDefault();
                    
                    tc.lblTenDangNhap.Text = tenQL.ToString(); //tạo label vào form quản lý để hiển thị tên lên form
                    tc.btnQuanLiPhong.Enabled = true;
                    tc.btnQuanLiNhanVien.Enabled = true;
                    tc.btnQuanLiKhachHang.Enabled = true;
                    tc.Show();
                    this.Hide();
                }
            }
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
