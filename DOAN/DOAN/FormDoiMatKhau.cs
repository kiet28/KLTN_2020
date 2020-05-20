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
    public partial class FormDoiMatKhau : Form
    {
        TaiKhoanBLL tkBLL;
        List<eTaiKhoan> dsTK;
        public FormDoiMatKhau()
        {
            tkBLL = new TaiKhoanBLL();
            dsTK = new List<eTaiKhoan>();
            dsTK = tkBLL.LayThongTinTaiKhoan();
            InitializeComponent();
        }
        //
        // button exit
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //
        // button đổi mật khẩu
        //
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var taiKhoan = dsTK.Where(tk => tk.UserName == txtTenDangNhap.Text && tk.Pass == txtMatKhauCu.Text).Any();
            var tenTK = dsTK.Where(tk => tk.UserName == txtTenDangNhap.Text && tk.Pass == txtMatKhauCu.Text).Select(tk => tk.UserName).FirstOrDefault();
            if (taiKhoan == true)
            {
                if (txtXacNhanMatKhau.Text == txtMatKhauMoi.Text)
                {
                    string repass = txtXacNhanMatKhau.Text;
                    tkBLL.DoiMKTaiKhoan(tenTK.ToString(), txtXacNhanMatKhau.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không giống nhau");
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu cũ");
            }
        }
    }
}
