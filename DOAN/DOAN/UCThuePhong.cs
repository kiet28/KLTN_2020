using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using System.Text.RegularExpressions;

namespace DOAN
{
    public partial class UCThuePhong : UserControl
    {
        public FormDanhSachKhachHang formDSKH = new FormDanhSachKhachHang();

        KhachHangBLL khBLL;
        List<eKhachHang> dsKH;
        public UCThuePhong()
        {
            khBLL = new KhachHangBLL();
            dsKH = new List<eKhachHang>();
            dsKH = khBLL.LayThongTinKhachHang();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormThuePhong"];

            InitializeComponent();
        }



        private void UCThuePhong_Load(object sender, EventArgs e)
        {
            
        }

        #region CacHamHoTro

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            Regex ten = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            if (txtTenKhachHang.Text == "")
            {
                errorProvider1.SetError(txtTenKhachHang, "");
            }
            else
            {
                if (!ten.IsMatch(txtTenKhachHang.Text))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Không được dùng số hoặc kí tự đặc biệt");
                }
                else
                {
                    errorProvider1.SetError(txtTenKhachHang, "");
                }
            }
        }
        public void GetValue(int makh, String tkh, int cmnd, String gt, int sdt)
        {// khai báo 1 hàm với 2 tham số đầu vào là str1, và str2 nó sẽ đưa dữ liệu vào 2 lable
            txtTenKhachHang.Text = tkh;
            txtSoCMND.Text = cmnd.ToString();
            txtSoDienThoai.Text = sdt.ToString();
            txtTenKhachHang.Enabled = false;
            txtSoCMND.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            txtSoDienThoai.Enabled = false;
            if (gt == "nam")
            {
                rdNam.Checked = true;
            }
            if (gt == "nu")
            {
                rdNu.Checked = true;
            }
        }
        private bool ThongBaoLoi()
        {
            txtSoDienThoai.MaxLength = 12;
            txtSoCMND.MaxLength = 12;
            Regex ten = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            Regex namsinh = new Regex("^(19|20)[0-9]{2}$");
            Regex mota = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            Regex sdt = new Regex("^[0-9]{10}$");
            if (!ten.IsMatch(txtTenKhachHang.Text))
            {
                MessageBox.Show("Thiếu hoặc sai tên khách hàng, Vui lòng kiểm tra lại");
                return false;
            }
            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính, Vui lòng kiểm tra lại");
                return false;
            }

            if (!sdt.IsMatch(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return false;
            }
            if (!sdt.IsMatch(txtSoCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập số CMND");
                return false;
            }
            if (!mota.IsMatch(txtGioNhan.Text))
            {
                MessageBox.Show("Thiếu hoặc sai thông tin mô tả, Vui lòng kiểm tra lại");
                return false;
            }


            return true;
        }
        private void KhaiBao()
        {

        }


        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            Regex sdt = new Regex("^[0-9]{10}$");
            if (txtSoDienThoai.Text == "")
            {
                errorProvider1.SetError(txtSoDienThoai, "");
            }
            else
            {
                if (!sdt.IsMatch(txtSoDienThoai.Text))
                {
                    errorProvider1.SetError(txtSoDienThoai, "Không dùng chữ hoặc kí tự đặc biệt");
                }
                else
                {
                    errorProvider1.SetError(txtSoDienThoai, "");
                }
            }
        }

        #endregion

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (formDSKH.IsDisposed == true)
            {
                formDSKH = new FormDanhSachKhachHang();
            }
            formDSKH.HienThiThongTinKhachHang();
            formDSKH.MyGetData = new FormDanhSachKhachHang.GetString(GetValue);
            formDSKH.ShowDialog();
        }

    }

}
