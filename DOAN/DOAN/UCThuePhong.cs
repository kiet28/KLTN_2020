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
        BindingSource bs, bsPhongDaChon;
        ThuePhongBLL tpBLL;
        CTThuePhongBLL cttpBLL;
        KhachHangBLL khBLL;
        PhongBLL pBLL;
        List<eThuePhong> dsTP;
        List<eCTThuePhong> dsCTTP;
        List<eKhachHang> dsKH;
        List<ePhong> dsP;
        public UCThuePhong()
        {
            InitializeComponent();

            bs = new BindingSource();
            bsPhongDaChon = new BindingSource();
            tpBLL = new ThuePhongBLL();
            cttpBLL = new CTThuePhongBLL();
            khBLL = new KhachHangBLL();
            pBLL = new PhongBLL();
            dsTP = new List<eThuePhong>();
            dsCTTP = new List<eCTThuePhong>();
            dsKH = new List<eKhachHang>();
            dsP = new List<ePhong>();
            dsTP = tpBLL.LayThongTinThuePhong();
            dsKH = khBLL.LayThongTinKhachHang();
            dsP = pBLL.LayThongTinPhong();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormThuePhong"];
            HienThiThongTinPhong();
        }


        public void HienThiThongTinPhong()
        {
            dsP = pBLL.LayThongTinPhong();
            bs = new BindingSource();
            var gridviewInfo = dsP
                .Where(x => x.TrangThai.ToString().Contains(1.ToString()))
                .Select(dt => new
            {
                MaPhong = dt.MaP,
                TenPhong = dt.TenP,
                //TrangThai = dt.TrangThai,
                LoaiPhong = dt.LoaiPhong,
                GiaPhong = dt.GiaPhong,
                GhiChu = dt.GhiChu,
            }).ToList();
            bs.DataSource = gridviewInfo;
            gridDanhSachPhong.DataSource = bs;
            gridDanhSachPhong.Columns[0].HeaderText = "Mã phòng";
            gridDanhSachPhong.Columns[1].HeaderText = "Tên phòng";
            gridDanhSachPhong.Columns[2].HeaderText = "Loại phòng";
            gridDanhSachPhong.Columns[3].HeaderText = "Giá phòng";
            gridDanhSachPhong.Columns[4].HeaderText = "Ghi chú";
            //gridDanhSachKhachHang.Columns[1].Width = 170;
        }
        private void UCThuePhong_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = (dsKH.Count + 1).ToString();
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
        public void GetValue(int makh, String tkh, String cmnd, String gt, String sdt)
        {// khai báo 1 hàm với 2 tham số đầu vào là str1, và str2 nó sẽ đưa dữ liệu vào 2 lable
            txtMaKH.Text = makh.ToString();
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
            Regex cmnd = new Regex("^[0-9]");
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
            if (!cmnd.IsMatch(txtSoCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập số CMND");
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

        private void gridDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridDanhSachPhong.CurrentRow.Index;
            //string maThuoc = dgvDanhSachThuocKD.CurrentRow.Cells[0].Value.ToString();
            gridDanhSachPhong.Rows[index].Selected = true;
            if (gridDanhSachPhong.Rows.Count == 0)
            {
                btnChonPhong.Enabled = false;
            }
            else
                btnChonPhong.Enabled = true;
            //else
            //{
            //    for (int j = 0; j < dgvThuocDaChonKD.Rows.Count; j++)
            //    {
            //        if (maThuoc == dgvThuocDaChonKD.Rows[j].Cells[3].Value.ToString())
            //        {
            //            MessageBox.Show("Thuốc đã có trong đơn thuốc");
            //            textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
            //            textBoxTimKiemThuocKD.ForeColor = Color.Gray;
            //            btnThem.Enabled = false;
            //            break;
            //        }
            //        else
            //        {
            //            btnThem.Enabled = true;
            //        }
            //    }
            //}
        }

        private void gridPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHuyChon.Enabled = true;
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            string maPhong = gridDanhSachPhong.CurrentRow.Cells[0].Value.ToString();
            dsP = pBLL.LayThongTinPhong();

            if (gridDanhSachPhong.CurrentRow.Index >= 0)
            {
                var gridviewInfo = dsP
                    .Where(x => x.TrangThai.ToString().Contains(1.ToString()))
                    .Select(x2 => new
                    {
                        MaPhong = x2.MaP,
                        TenPhong = x2.TenP,
                        //TrangThai = dt.TrangThai,
                        LoaiPhong = x2.LoaiPhong,
                        GiaPhong = x2.GiaPhong,
                        GhiChu = x2.GhiChu,
                    }).ToList();
                bsPhongDaChon.Add(bs.Current);
                gridPhongDaChon.DataSource = bsPhongDaChon;
                //foreach (var item in gridviewInfo)
                //{
                //    gridPhongDaChon.Rows[gridPhongDaChon.Rows.Count - 1].Cells["donvicol"].Value = item.DVT;
                //}
                gridPhongDaChon.Columns[0].DisplayIndex = 1;
                gridPhongDaChon.Columns[1].DisplayIndex = 2;
                gridPhongDaChon.Columns[2].DisplayIndex = 3;
                gridPhongDaChon.Columns[3].DisplayIndex = 4;
                //gridPhongDaChon.Columns[5].HeaderText = "Loại phòng";
                //gridPhongDaChon.Columns[6].HeaderText = "Giá phòng";

                //gridPhongDaChon.Columns[1].Visible = false;
                //gridPhongDaChon.Columns[5].Visible = false;
                //gridPhongDaChon.Columns[6].Visible = false;

                //gridPhongDaChon.Rows[gridPhongDaChon.Rows.Count - 1].Cells[1].Value = maPhong;
                //gridPhongDaChon.Rows[gridPhongDaChon.Rows.Count - 1].Cells[2].Value = "3 viên/1 ngày";
                bs.RemoveCurrent();
            }

            btnChonPhong.Enabled = false;
            gridDanhSachPhong.ClearSelection();
            gridPhongDaChon.ClearSelection();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormTrangChinh"];
            dsTP = tpBLL.LayThongTinThuePhong();
            string maTP = (dsTP.Count + 1).ToString();
            DialogResult DR = MessageBox.Show("Bạn có chắc chắn muốn thuê phòng hay không ?", "Thuê phòng", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                if (ThongBaoLoi() == false)
                {

                }
                else
                {
                    eThuePhong tpmoi1 = new eThuePhong();
                    eKhachHang khmoi1 = new eKhachHang();
                    eCTThuePhong cttpmoi1 = new eCTThuePhong();
                    //ePhong p = new ePhong();
                    //Lưu vào csdl Khách hàng
                    khmoi1.MaKH = Convert.ToInt32(txtMaKH.Text);
                    khmoi1.TenKH = txtTenKhachHang.Text;
                    khmoi1.SDT = txtSoDienThoai.Text;
                    khmoi1.CMND = txtSoCMND.Text;
                    if (rdNam.Checked)
                    {
                        khmoi1.GioiTinh = "nam";
                    }
                    if (rdNu.Checked)
                    {
                        khmoi1.GioiTinh = "nu";
                    }
                    if (khBLL.InsertKhachHang(khmoi1) == 0)
                    {
                    }
                    else
                    {
                        khBLL.InsertKhachHang(khmoi1);
                    }
                    //-----------------------------------//
                    //Lưu vào csdl thuê phòng
                    tpmoi1.MaThuePhong = Convert.ToInt32(maTP);
                    tpmoi1.MaKhachHang = Convert.ToInt32(khmoi1.MaKH);
                    tpmoi1.MaNhanVien = Convert.ToInt32(((FormTrangChinh)f).lblMa.Text);
                    tpmoi1.NgayThue = Convert.ToDateTime(dateNgayNhanPhong.Text);
                    tpmoi1.NgayTra = Convert.ToDateTime(dateNgayTraPhong.Text);
                    tpmoi1.GioThue = txtGioNhan.Text;
                    tpmoi1.GioTra = txtGioTra.Text;
                    //-----------------------------------//
                    int kq = tpBLL.InsertThuePhong(tpmoi1);
                    if (kq == 1)
                    {
                        //Lưu vào csdl CTThuePhong
                        int countCTTP = gridPhongDaChon.Rows.Count;
                        for (int i = 0; i <= countCTTP - 1; i++)
                        {
                            cttpmoi1.MaPhong = Convert.ToInt32(gridPhongDaChon.Rows[i].Cells[0].Value);
                            cttpmoi1.MaThuePhong = tpmoi1.MaThuePhong;

                            pBLL.CapNhatTrangThaiPhong(cttpmoi1.MaPhong, 2);
                            cttpBLL.InsertCTThuePhong(cttpmoi1);
                        }
                        //-----------------------------------
                        MessageBox.Show("Thuê phòng thành công !");
                        pBLL.CapNhatTrangThaiPhong(cttpmoi1.MaPhong, 2);
                        gridPhongDaChon.Rows.Clear();
                        txtTenKhachHang.Clear();
                        txtSoCMND.Clear();
                        txtSoDienThoai.Clear();
                        HienThiThongTinPhong();
                        rdNam.Checked = true;
                        rdNu.Checked = false;
                        UCThuePhong_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sai hoặc thiếu thông tin, vui lòng kiểm tra lại!");
                }
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn tạo lại đơn thuốc hay không ?", "Tạo lại", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                gridPhongDaChon.Rows.Clear();
                txtTenKhachHang.Clear();
                txtTenKhachHang.Enabled = true;
                txtSoCMND.Clear();
                txtSoCMND.Enabled = true;
                txtSoDienThoai.Clear();
                txtSoDienThoai.Enabled = true;
                HienThiThongTinPhong();
                rdNam.Checked = true;
                rdNam.Enabled = true;
                rdNu.Checked = false;
                rdNu.Enabled = true;
                UCThuePhong_Load(sender, e);
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }

        private void gridDanhSachPhong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDanhSachPhong.ClearSelection();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            if (gridPhongDaChon.CurrentRow.Index >= 0)
            {
                bs.Add(bsPhongDaChon.Current);
                gridDanhSachPhong.DataSource = bs;
                bsPhongDaChon.RemoveCurrent();
                if (gridPhongDaChon.Rows.Count == 0)
                {
                    btnHuyChon.Enabled = false;
                    HienThiThongTinPhong();
                }
            }
            btnHuyChon.Enabled = false;
            gridPhongDaChon.ClearSelection();
        }
    }

}
