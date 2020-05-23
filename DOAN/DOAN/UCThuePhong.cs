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
        KhachHangBLL khBLL;
        PhongBLL pBLL;
        List<eThuePhong> dsTP;
        List<eKhachHang> dsKH;
        List<ePhong> dsP;
        public UCThuePhong()
        {
            InitializeComponent();

            bs = new BindingSource();
            bsPhongDaChon = new BindingSource();
            tpBLL = new ThuePhongBLL();
            khBLL = new KhachHangBLL();
            pBLL = new PhongBLL();
            dsTP = new List<eThuePhong>();
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
            string maDT = (dsTP.Count + 1).ToString();
            DialogResult DR = MessageBox.Show("Bạn có muốn lập đơn thuốc hay không ?", "Lập đơn thuốc", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                if (ThongBaoLoi() == false)
                {

                }
                else
                {
                    eDonThuoc dtmoi1 = new eDonThuoc();
                    eBenhNhan bnmoi1 = new eBenhNhan();
                    eCTDonThuoc ctdtmoi1 = new eCTDonThuoc();
                    //Lưu vào csdl Bệnh Nhân
                    bnmoi1.MaBenhNhan = tbMaBN.Text;
                    bnmoi1.TenBenhNhan = txtTenKhachHangKD.Text;
                    bnmoi1.SDT = tbSDT.Text;
                    bnmoi1.DiaChi = cbbTP.Text;
                    if (rdNam.Checked)
                    {
                        bnmoi1.GioiTinh = "Nam";
                    }
                    if (rdNu.Checked)
                    {
                        bnmoi1.GioiTinh = "Nu";
                    }
                    bnmoi1.NamSinh = Convert.ToInt32(txtNamSinhKD.Text);
                    if (bnBLL.InsertBenhNhan(bnmoi1) == 0)
                    {
                    }
                    else
                    {
                        bnBLL.InsertBenhNhan(bnmoi1);
                    }
                    //-----------------------------------//
                    //Lưu vào csdl đơn thuốc
                    dtmoi1.MaDonThuoc = maDT;
                    dtmoi1.MaBenhNhan = bnmoi1.MaBenhNhan;
                    dtmoi1.MaBacSi = ((FormKeDonThuoc)f).lblMa.Text;
                    dtmoi1.MoTaBenh = txtLoaiBenhKD.Text;
                    //-----------------------------------//
                    int kq = dtBLL.InsertDonThuoc(dtmoi1);
                    if (kq == 1)
                    {
                        //Lưu vào csdl CTHoaDon
                        int countCTDT = dgvThuocDaChonKD.Rows.Count;
                        for (int i = 0; i <= countCTDT - 1; i++)
                        {
                            ctdtmoi1.MaThuoc = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[3].Value);
                            ctdtmoi1.MaDonThuoc = dtmoi1.MaDonThuoc;
                            ctdtmoi1.SoLuong = Convert.ToInt32(dgvThuocDaChonKD.Rows[i].Cells[1].Value);
                            ctdtmoi1.DVT = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[0].Value);
                            ctdtmoi1.GhiChu = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[2].Value);
                            ctdtBLL.InsertCTDonThuoc(ctdtmoi1);
                        }
                        //-----------------------------------
                        MessageBox.Show("Lập đơn thuốc thành công !");
                        dgvThuocDaChonKD.Rows.Clear();
                        txtTenKhachHangKD.Clear();
                        txtNamSinhKD.Clear();
                        txtLoaiBenhKD.Clear();
                        txtLoaiBenhKD.Clear();
                        tbSDT.Clear();
                        cbbTP.Text = "";
                        HienThiThongTinThuoc();
                        rdNam.Checked = false;
                        rdNu.Checked = false;
                        btnHuy.Enabled = false;
                        UCKeDonThuoc_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sai hoặc thiếu thông tin, vui lòng kiểm tra lại!");
                }
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {

        }
    }

}
