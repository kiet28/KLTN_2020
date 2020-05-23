﻿using System;
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
using DAL;
using System.Text.RegularExpressions;

namespace DOAN
{
    public partial class UCThemNV : UserControl
    {
        NhanVienBLL nvBLL;
        List<eNhanVien> dsNV;
        BindingSource lsNV;
        public UCThemNV()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            dsNV = new List<eNhanVien>();
            lsNV = new BindingSource();
            HienThiThongTin();
        }
        //lấy thông tin để hiển thị thông tin lên datagridview
        public void HienThiThongTin()
        {
            dsNV = nvBLL.getALLNhanVien();
            var dgvTTNV = dsNV.Select(nv => new
            {
                maNhanVien = nv.maNhanVien,
                hoTen = nv.hoTen,
                gioiTinh = nv .gioiTinh,
                namSinh = nv.namSinh.ToString("dd/MM/yyyy"),
                SDT = nv.SDT,
                diaChi = nv.diaChi,
                trangThai = nv.tinhTrang
            }).ToList();
            lsNV.DataSource = dgvTTNV;
            dgvDSNV.DataSource = lsNV;
        }
        //clear hết tất cả cái fill
        public void clearText()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtNamSinh.Text = "";
        }
        public void AutoComplete()
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            eNhanVien nv = new eNhanVien();
            nv.maNhanVien = txtMaNhanVien.Text;
            nv.hoTen = txtHoTen.Text;
            if (rdbNam.Checked == true)
            {
                nv.gioiTinh = "Nam";
            }
            if (rdbNu.Checked == true)
            {
                nv.gioiTinh = "Nữ";
            }
            nv.diaChi = txtDiaChi.Text;
            nv.namSinh = Convert.ToDateTime(dtNamSinh.Text);
            nv.SDT = txtSDT.Text;
            if (cbxDangLam.Checked == true)
            {
                nv.tinhTrang = "Đang làm";
            }
            if (cbxDaNghi.Checked == true)
            {
                nv.tinhTrang = "Đã nghỉ";
            }
            nvBLL.ThemNhanVien(nv);
            MessageBox.Show("Thêm thành công");
        }
        private void UCThemNV_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            cbxDangLam.Checked = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsNV = nvBLL.getALLNhanVien();
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Text = "NV00" + (dsNV.Count + 1).ToString();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
        }
        private void txtHoTen_TextChanged_1(object sender, EventArgs e)
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearText();
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

        private void btnSearch_Click(object sender, EventArgs e)
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
            dgvDSNV.DataSource = lsNV;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
    }
}
