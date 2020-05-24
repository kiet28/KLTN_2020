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
    public partial class UCDanhSachDichVu : UserControl
    {
        BindingSource bsPhong, bsDichVu, bsDichVuDaChon;
        DichVuBLL dichVuBLL;
        CTThuePhongBLL cttpBLL;
        PhongBLL pBLL;
        List<eDichVu> dsDV;
        List<eCTThuePhong> dsCTTP;
        List<ePhong> dsP;
        public UCDanhSachDichVu()
        {
            InitializeComponent();
            cttpBLL = new CTThuePhongBLL();
            dichVuBLL = new DichVuBLL();
            pBLL = new PhongBLL();
            dsCTTP = new List<eCTThuePhong>();
            dsDV = new List<eDichVu>();
            dsP = new List<ePhong>();
            bsDichVu = new BindingSource();
            bsDichVuDaChon = new BindingSource();
            bsPhong = new BindingSource();
            dsDV = dichVuBLL.LayThongTinDichVu();
            dsCTTP = cttpBLL.LayThongTinCTThuePhong();

            HienThiThongTinDichVu();
            HienThiThongTinPhong();
        }

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            using (FormQuanLyDichVu qldv = new FormQuanLyDichVu())
            {
                qldv.ShowDialog();
            }
        }

        private void UCDanhSachDichVu_Load(object sender, EventArgs e)
        {
            HienThiThongTinDichVu();
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
                    TrangThai = "còn",
                }).ToList();



            bsDichVu.DataSource = gridviewInfo;
            gridDanhSachDichVu.DataSource = bsDichVu;
        }

        private bool ThongBaoLoi()
        {
            Regex sl = new Regex("^[0-9]");
            for(int j = 0; j< gridDichVuDaChon.Rows.Count; j++)
            {
                if (!sl.IsMatch(gridDichVuDaChon.Rows[j].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Thiếu hoặc sai tên khách hàng, Vui lòng kiểm tra lại" + gridDichVuDaChon.Rows[j].Cells[1].Value.ToString());
                    return false;
                }
            }
            
            for (int i = 0; i < gridDichVuDaChon.Rows.Count; i++)
            {
                if (gridDichVuDaChon.Rows[i].Cells[3].Value.ToString() == "0")
                {
                    MessageBox.Show("Vui lòng nhập số lượng thuốc");
                    return false;
                }
            }
            return true;
        }

        private void HienThiThongTinPhong()
        {
            dsP = pBLL.LayThongTinPhong();
            var gridviewInfo = dsP
                .Where(_t => _t.TrangThai == 2)
                .Select(_t1 => _t1.TenP).ToList();

            bsPhong.DataSource = gridviewInfo;
            cbChonPhong.DataSource = bsPhong;
        }
        private void gridDichVuDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHuyDichVu.Enabled = true;
        }


        private void gridDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridDanhSachDichVu.CurrentRow.Index;
            //string maThuoc = dgvDanhSachThuocKD.CurrentRow.Cells[0].Value.ToString();
            gridDanhSachDichVu.Rows[index].Selected = true;
            if (gridDanhSachDichVu.Rows.Count == 0)
            {
                btnChonDichVu.Enabled = false;
            }
            else
                btnChonDichVu.Enabled = true;
        }


        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            string maDichvu = gridDanhSachDichVu.CurrentRow.Cells[0].Value.ToString();
            dsDV = dichVuBLL.LayThongTinDichVu();
            dsCTTP = cttpBLL.LayThongTinCTThuePhong();

            if (gridDanhSachDichVu.CurrentRow.Index >= 0)
            {
                var gridviewInfo = dsCTTP
                    .Where(x => x.MaDichVu.Equals(maDichvu))
                    .Select(x2 => new
                    {
                        DVT = x2.DVT,
                    }).ToList();
                bsDichVuDaChon.Add(bsDichVu.Current);
                gridDichVuDaChon.DataSource = bsDichVuDaChon;
                foreach (var item in gridviewInfo)
                {
                    gridDichVuDaChon.Rows[gridDichVuDaChon.Rows.Count - 1].Cells["donvicol"].Value = item.DVT;
                }
                gridDichVuDaChon.Columns[0].DisplayIndex = 4;
                gridDichVuDaChon.Columns[1].DisplayIndex = 4;
                //gridDichVuDaChon.Columns[2].DisplayIndex = 5;
                //gridDichVuDaChon.Columns[3].DisplayIndex = 0;
                //gridDichVuDaChon.Columns[4].DisplayIndex = 5;


                //gridPhongDaChon.Columns[5].HeaderText = "Loại phòng";
                //gridPhongDaChon.Columns[6].HeaderText = "Giá phòng";

                gridDichVuDaChon.Columns[4].Visible = false;
                gridDichVuDaChon.Columns[5].Visible = false;
                //gridDichVuDaChon.Columns[6].Visible = false;

                gridDichVuDaChon.Rows[gridDichVuDaChon.Rows.Count - 1].Cells[1].Value = 1;
                //gridDichVuDaChon.Rows[gridDichVuDaChon.Rows.Count - 1].Cells[2].Value = "3 viên/1 ngày";
                bsDichVu.RemoveCurrent();
            }

            btnChonDichVu.Enabled = false;
            gridDanhSachDichVu.ClearSelection();
            gridDichVuDaChon.ClearSelection();
        }

        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            dsCTTP = cttpBLL.LayThongTinCTThuePhong();
            DialogResult DR = MessageBox.Show("Bạn có chắc chắn muốn sử dụng dịch vụ hay không ?", "Sử dụng dịch vụ", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                if (ThongBaoLoi() == false)
                {

                }
                else
                {
                    eDichVu dvmoi1 = new eDichVu();
                    eCTThuePhong cttpmoi1 = new eCTThuePhong();
                    ePhong pmoi1 = new ePhong();
                    //Lưu vào csdl KH
                    //cttpmoi1.MaKH = Convert.ToInt32(txtMaKH.Text);
                    //khmoi1.TenKH = txtTenKhachHang.Text;
                    //khmoi1.SDT = txtSoDienThoai.Text;
                    //khmoi1.CMND = txtSoCMND.Text;
                    //if (rdNam.Checked)
                    //{
                    //    khmoi1.GioiTinh = "nam";
                    //}
                    //if (rdNu.Checked)
                    //{
                    //    khmoi1.GioiTinh = "nu";
                    //}
                    //if (khBLL.InsertKhachHang(khmoi1) == 0)
                    //{
                    //}
                    //else
                    //{
                    //    khBLL.InsertKhachHang(khmoi1);
                    //}
                    ////-----------------------------------//
                    ////Lưu vào csdl thuê phòng
                    //tpmoi1.MaThuePhong = Convert.ToInt32(maTP);
                    //tpmoi1.MaKhachHang = Convert.ToInt32(khmoi1.MaKH);
                    //tpmoi1.MaNhanVien = Convert.ToInt32(((FormTrangChinh)f).lblMa.Text);
                    //tpmoi1.NgayThue = Convert.ToDateTime(dateNgayNhanPhong.Text);
                    //tpmoi1.NgayTra = Convert.ToDateTime(dateNgayTraPhong.Text);
                    //tpmoi1.GioThue = txtGioNhan.Text;
                    //tpmoi1.GioTra = txtGioTra.Text;
                    //-----------------------------------//
                    int map = Convert.ToInt32(dsP
                        .Where(x => x.TenP.Contains(cbChonPhong.Text))
                        .Select(x2 => new{ 
                            x2.MaP,
                            //x2.TenP,
                        }).ToString());
                    string mtp = dsCTTP
                        .Where(t => t.MaPhong.Equals(Convert.ToInt32(map)))
                        .Select(t2 => t2.MaThuePhong).ToString();
                    //Lưu vào csdl CTThuePhong
                    int countDV = gridDichVuDaChon.Rows.Count;
                    for (int i = 0; i <= countDV - 1; i++)
                    {
                        cttpmoi1.MaDichVu = Convert.ToInt32(gridDichVuDaChon.Rows[i].Cells[2].Value);
                        MessageBox.Show(map.ToString());
                        cttpmoi1.MaPhong = map;
                        cttpmoi1.MaThuePhong = Convert.ToInt32(mtp);
                        cttpmoi1.DVT = gridDichVuDaChon.Rows[i].Cells[0].Value.ToString();
                        cttpmoi1.SoLuong = Convert.ToInt32(gridDichVuDaChon.Rows[i].Cells[1].Value);

                        cttpBLL.CapNhatThongTinThemDVVaoCTTP(cttpmoi1.MaThuePhong, cttpmoi1.MaThuePhong, cttpmoi1.MaDichVu, cttpmoi1.DVT, cttpmoi1.SoLuong);
                        //cttpBLL.InsertCTThuePhong(cttpmoi1);
                    }
                    //-----------------------------------
                    MessageBox.Show("Sử dụng dịch vụ thành công !");
                    gridDichVuDaChon.Rows.Clear();
                    HienThiThongTinDichVu();
                    UCDanhSachDichVu_Load(sender, e);


                }
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }

        private void gridDichVuDaChon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(SoLuong_KeyPress);
            if (gridDichVuDaChon.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(SoLuong_KeyPress);
                }
            }
        }


        private void gridDanhSachDichVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDanhSachDichVu.ClearSelection();
        }

        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnHuyDichVu_Click(object sender, EventArgs e)
        {
            if (gridDichVuDaChon.CurrentRow.Index >= 0)
            {
                bsDichVu.Add(bsDichVuDaChon.Current);
                gridDanhSachDichVu.DataSource = bsDichVu;
                bsDichVuDaChon.RemoveCurrent();
                if (gridDichVuDaChon.Rows.Count == 0)
                {
                    btnHuyDichVu.Enabled = false;
                    HienThiThongTinDichVu();
                }
            }
            btnHuyDichVu.Enabled = false;
            gridDichVuDaChon.ClearSelection();
        }
    }
}
