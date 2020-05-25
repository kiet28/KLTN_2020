using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormQuanLyDichVu : Form
    {
        bool isThem = false;
        bool isSua = false;
        BindingSource bsDichVu;
        DichVuBLL dichVuBLL;
        List<eDichVu> dsDV;
        public FormQuanLyDichVu()
        {
            InitializeComponent();
            dichVuBLL = new DichVuBLL();
            dsDV = new List<eDichVu>();
            bsDichVu = new BindingSource();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EnableControl(bool e)
        {
            txtTenDichVu.ReadOnly = txtDonGia.ReadOnly = !e;
            btnLuu.Enabled = rdCon.Enabled = rdHet.Enabled = e;
        }

        private void clearTXT()
        {
            txtTenDichVu.Clear();
            txtDonGia.Clear();
            rdCon.Checked = true;
        }
        private void HienThiThongTinDichVu()
        {
            dsDV = dichVuBLL.LayThongTinDichVu();
            var gridviewInfo = dsDV
                .Where(_t => _t.TrangThai == 1)
                .Select(_t1 => new
                {
                    MaDichVu = _t1.MaDV,
                    TenDichVu = _t1.TenDV,
                    DonGia = _t1.DonGia,
                    TrangThai = _t1.TrangThai
                }).ToList();



            bsDichVu.DataSource = gridviewInfo;
            gridDanhSachDichVu.DataSource = bsDichVu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsDV = dichVuBLL.LayThongTinDichVu();
            if (isThem == false)
            {
                isThem = true;
                EnableControl(true);
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.OnHoverButtonColor = Color.Crimson;
                txtMaDV.Text = (dsDV.Count + 1).ToString();
                gridDanhSachDichVu.Enabled = false;
                clearTXT();
                rdCon.Enabled = rdHet.Enabled = false;
            }
            else
            {
                isThem = false;
                EnableControl(false);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnThem.OnHoverButtonColor = Color.DodgerBlue;
                gridDanhSachDichVu.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isSua == false)
            {
                isSua = true;
                EnableControl(true);
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.OnHoverButtonColor = Color.Crimson;
                gridDanhSachDichVu.Enabled = false;
            }
            else
            {
                isSua = false;
                EnableControl(false);
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.OnHoverButtonColor = Color.LimeGreen;
                gridDanhSachDichVu.Enabled = true;
            }
        }

        private void HienThiThongTinColtrol()
        {
            if (gridDanhSachDichVu.SelectedCells.Count > 0)
            {
                txtMaDV.Text = gridDanhSachDichVu.SelectedCells[0].OwningRow.Cells["MaDichVu"].Value.ToString();
                txtTenDichVu.Text = gridDanhSachDichVu.SelectedCells[0].OwningRow.Cells["TenDichvu"].Value.ToString();
                txtDonGia.Text = gridDanhSachDichVu.SelectedCells[0].OwningRow.Cells["DonGia"].Value.ToString();
                if ((int)gridDanhSachDichVu.SelectedCells[0].OwningRow.Cells["TrangThai"].Value == 1)
                {
                    rdCon.Checked = true;
                }
                else
                {
                    rdHet.Checked = true;
                }

            }
        }

        private void gridDanhSachDichVu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            gridDanhSachDichVu.CurrentRow.Selected = true;
            HienThiThongTinColtrol();
        }
        private void CheckError()
        {
            if (txtTenDichVu.Text.Trim().Length == 0 || txtDonGia.Text.Trim().Length == 0)
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CheckError();
                if (isThem == true)
                {
                    eDichVu newDichVu = new eDichVu();
                    newDichVu.MaDV = txtMaDV.Text;
                    newDichVu.TenDV = txtTenDichVu.Text;
                    newDichVu.DonGia = Convert.ToDecimal(txtDonGia.Text);
                    if (rdCon.Checked == true)
                    {
                        newDichVu.TrangThai = 1;
                    }
                    else
                    {
                        newDichVu.TrangThai = 0;
                    }
                    dichVuBLL.ThemThongTinDichVu(newDichVu);
                    MessageBox.Show("Thêm thành công");
                    clearTXT();
                    isThem = false;
                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    gridDanhSachDichVu.Enabled = true;
                    FormQuanLyDichVu_Load(sender, e);
                }
                else
                {
                    int trangThai;
                    string maDichVu = txtMaDV.Text;
                    string tenDichVu = txtTenDichVu.Text;
                    string donGia = txtDonGia.Text;
                    if (rdCon.Checked == true)
                    {
                        trangThai = 1;
                    }
                    else
                    {
                        trangThai = 0;
                    }
                    dichVuBLL.CapNhatThongTinDichVu(maDichVu, tenDichVu, Convert.ToDecimal(donGia), Convert.ToInt32(trangThai));
                    MessageBox.Show("Cập nhật thành công");
                    isSua = false;
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    gridDanhSachDichVu.Enabled = true;
                    FormQuanLyDichVu_Load(sender, e);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ có sẵn");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormQuanLyDichVu_Load(object sender, EventArgs e)
        {
            HienThiThongTinDichVu();
            EnableControl(false);
        }

        private void txtTenDichVu_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Không được bỏ trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Không được bỏ trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void gridDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridDanhSachDichVu.CurrentRow.Selected = true;
        }

        private void gridDanhSachDichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridDanhSachDichVu.CurrentRow.Selected = true;
        }
    }
}
