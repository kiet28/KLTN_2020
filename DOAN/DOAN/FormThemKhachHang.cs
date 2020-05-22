using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormThemKhachHang : Form
    {
        KhachHangBLL khachHangBLL;

        List<eKhachHang> dsKH;
        public FormThemKhachHang()
        {
            khachHangBLL = new KhachHangBLL();
            dsKH = new List<eKhachHang>();
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void CheckTxt()
        {
            if (Regex.IsMatch(txtSoDienThoai.Text, "[^0-9]+"))
            {
                throw new Exception("So dien thoai khong phu hop, vui long nhap lai");
            }
            //else if (!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+.+.[A-Za-z]{2,4}$"))
            //{
            //    throw new Exception("Email khong hop le, vui long nhap lai");
            //}
            else if (txtTenKhachHang.Text.Trim().Length == 0 || txtSoDienThoai.Text.Trim().Length == 0 || txtSoCMND.Text.Trim().Length == 0)
            {
                throw new Exception("Vui long nhap day du thong tin");
            }
        }

        private void ClearTextBox()
        {
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtSoCMND.Text = "";
            rdNam.Checked = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    CheckTxt();

                    eKhachHang newKH = new eKhachHang();
                    //newKH.MaKH = txtMaNhanVien.Text;
                    newKH.TenKH = txtTenKhachHang.Text;
                    newKH.SDT = Convert.ToInt32(txtSoDienThoai.Text);
                    newKH.CMND = Convert.ToInt32(txtSoCMND.Text);
                    if (rdNam.Checked == true)
                    {
                        newKH.GioiTinh = "nam";
                    }
                    else
                    {
                        newKH.GioiTinh = "nu";
                    }

                    khachHangBLL.ThemKhachHang(newKH);

                    MessageBox.Show("Thêm thành công");
                    ClearTextBox();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
