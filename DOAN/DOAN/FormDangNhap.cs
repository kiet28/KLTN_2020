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
        TaiKhoanBLL tkBLL;
        List<int> myList;
        public FormDangNhap()
        {
            InitializeComponent();
            myList = new List<int>();
            //dsQL = new List<eQuanLy>();
            //qlBLL = new QuanLyBLL();
            dsTK = new List<eTaiKhoan>();
            tkBLL = new TaiKhoanBLL();
            //dsBS = new List<eBacSi>();
            //bsBLL = new BacSiBLL();
            //nvBLL = new NhanVienBLL();
            //dsNV = new List<eNhanVien>();
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
            string username = txtTenDN.Text;
            string password = txtMatKhau.Text;
            if (Login(username,password))
            {
                FormTrangChinh tc = new FormTrangChinh();
                tc.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }


        bool Login(string username, string password)
        {
            return false;
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
