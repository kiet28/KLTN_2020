using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using System.Text.RegularExpressions;

namespace DOAN
{
    public partial class UCCapNhatTTNV : UserControl
    {
        NhanVienBLL nvBLL;
        List<eNhanVien> dsNV;
        BindingSource lsNV;
        public UCCapNhatTTNV()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            dsNV = new List<eNhanVien>();
            lsNV = new BindingSource();
            HienThiThongTin();
        }
        public void HienThiThongTin()   //lấy thông tin để hiển thị lên datagrid
        {
            dsNV = nvBLL.getALLNhanVien();
            var dgvTTNV = dsNV.Select(nv => new
            {
                maNhanVien = nv.maNhanVien,
                hoTen = nv.hoTen,
                gioiTinh = nv.gioiTinh,
                namSinh = nv.namSinh.ToString("dd/MM/yyyy"),
                SDT = nv.SDT,
                diaChi = nv.diaChi,
                trangThai = nv.tinhTrang
            }).ToList();
            lsNV.DataSource = dgvTTNV;
            dgvCapNhatNV.DataSource = lsNV;
        }
        public void clearText() //clear hết các field
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtNamSinh.Text = "";
        }
        public void HienThiThongTinNhanVienDaChon()
        {
            if (dgvCapNhatNV.SelectedCells.Count > 0)
            {
                txtMaNhanVien.Text = dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["maNhanVien"].Value.ToString();
                txtHoTen.Text = dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["hoTen"].Value.ToString();
                txtSDT.Text = dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["diaChi"].Value.ToString();
                if (dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["gioiTinh"].Value.ToString().Equals("Nam"))
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                if(dgvCapNhatNV.SelectedCells[0].OwningRow.Cells["trangThai"].Value.ToString().Equals("Đang làm"))
                {
                    cbxDangLam.Checked = true;
                }
                else
                {
                    cbxDaNghi.Checked = true;
                }   
            }
        }
        private void UCCapNhatTTNV_Load(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            dtNamSinh.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dgvCapNhatNV.SelectedCells.Count==0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật thông tin");
            }
            else
            {
                string maNV = txtMaNhanVien.Text;
                string hoTen = txtHoTen.Text;
                DateTime namSinh = dtNamSinh.Value;
                string sdt = txtSDT.Text;
                string dc = txtDiaChi.Text;
                string gt;
                if (rdbNam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                string tt;
                if (cbxDangLam.Checked == true)
                {
                    tt = "Đang làm";
                }
                else
                {
                    tt = "Đã nghỉ";
                }
                nvBLL.CapNhatThongTinNhanVien(maNV, hoTen, namSinh, gt, dc, sdt, tt);
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void dgvCapNhatNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinNhanVienDaChon();
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            dtNamSinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void cbxDangLam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDangLam.Checked == true)
            {
                cbxDaNghi.Checked = false;
            }
        }

        private void cbxDaNghi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDaNghi.Checked == true)
            {
                cbxDangLam.Checked = false;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!Regex.IsMatch(ctr.Text, @"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ +
            ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ +
            ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$"))
            {
                errorProvider.SetError(ctr, "Họ tên không hợp lệ");
            }
            else
            {
                errorProvider.SetError(ctr, null);
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!Regex.IsMatch(ctr.Text, @"^([0]\d{2})?([1-9]\d{6})$"))
            {
                errorProvider.SetError(ctr, "Số điện thoại không đúng định dạng");          
            }
            else
            {
                errorProvider.SetError(ctr, null);
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!Regex.IsMatch(ctr.Text, @"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ +
            ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ +
            ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ0-9\\s]+$"))
            {
                errorProvider.SetError(ctr, "Địa chỉ không hợp lệ");
            }
            else
            {
                errorProvider.SetError(ctr, null);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsNV = nvBLL.getALLNhanVien();
            var gridViewInfo = dsNV.Where(w => w.hoTen.Contains(txtSearch.Text))
                                    .Select(s => new
                                    {
                                        maNhanVien = s.maNhanVien,
                                        hoTen = s.hoTen,
                                        gioiTinh = s.gioiTinh,
                                        namSinh = s.namSinh.ToString("dd/MM/yyyy"),
                                        SDT = s.SDT,
                                        diaChi = s.diaChi,
                                        trangThai = s.tinhTrang
                                    }).ToList();
            lsNV.DataSource = gridViewInfo;
            dgvCapNhatNV.DataSource = lsNV;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
    }
}
