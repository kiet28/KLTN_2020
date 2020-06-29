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

namespace DOAN
{
    public partial class UCDanhSachPhong2 : UserControl
    {
        BindingSource bs;
        ThuePhongBLL tpBLL;
        CTThuePhongBLL cttpBLL;
        PhongBLL pBLL;
        List<eThuePhong> dsTP;
        List<eCTThuePhong> dsCTTP;
        List<ePhong> dsP;
        public UCDanhSachPhong2()
        {
            InitializeComponent();

            //TimeSpan oneday = new System.TimeSpan(1, 0, 0, 0);
            DateTime date = DateTime.Now;
            cboTrangThaiPhong.Text = "Còn trống";
            bs = new BindingSource();
            tpBLL = new ThuePhongBLL();
            cttpBLL = new CTThuePhongBLL();
            pBLL = new PhongBLL();
            dsTP = new List<eThuePhong>();
            dsCTTP = new List<eCTThuePhong>();
            dsP = new List<ePhong>();
            dsTP = tpBLL.LayThongTinThuePhong();
            dsCTTP = cttpBLL.LayThongTinCTThuePhong();
            dsP = pBLL.LayThongTinPhong();
            TimPhongTrong(date);
        }

        public void HienThiThongTinPhong()
        {
            var gridviewInfo = dsP.Select(dt => new
            {
                MaPhong = dt.MaP,
                TenPhong = dt.TenP,
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
            gridDanhSachPhong.Columns[3].Width = 215;
            gridDanhSachPhong.Columns[4].Width = 215;

        }
        public void TimPhongTrong(DateTime date)
        {
            var gridviewInfo2 = dsP
                .Join(dsCTTP, p => p.MaP, ctp => ctp.MaPhong, (p, ctp) => new { p, ctp })
                .Join(dsTP, _tp => _tp.ctp.MaThuePhong, tp => tp.MaThuePhong, (_tp, tp) => new { _tp, tp })
                .Where(_dt => Convert.ToDateTime(_dt.tp.NgayTra) > date && _dt.tp.NgayThue <= date)
                .Select(dt => new
                {
                    MaPhong = dt._tp.p.MaP,
                    TenPhong = dt._tp.p.TenP,
                    LoaiPhong = dt._tp.p.LoaiPhong,
                    GiaPhong = dt._tp.p.GiaPhong,
                    GhiChu = dt._tp.p.GhiChu,
                }).ToList();

            //var gridviewInfo2 = dsTP
            //    .Join(dsCTTP, tp => tp.MaThuePhong, cttp => cttp.MaThuePhong, (tp, cttp) => new { tp, cttp })
            //    .Join(dsP, tp => tp.cttp.MaPhong, p => p.MaPhong , (tp, p) => new { tp, p })
            //    .Where(_dt => Convert.ToDateTime(_dt.tp.NgayThue) <= date && Convert.ToDateTime(_dt.tp.NgayTra) > date)
            //    .Select(dt => new
            //    {
            //        MaPhong = dt.cttp.MaPhong,
            //        TenPhong = dt.cttp.p.TenP,
            //        LoaiPhong = dt._tp.p.LoaiPhong,
            //        GiaPhong = dt._tp.p.GiaPhong,
            //        GhiChu = dt._tp.p.GhiChu,

            //    }).ToList();
            var gridviewInfo1 = dsP.Select(dt => new
            {
                MaPhong = dt.MaP,
                TenPhong = dt.TenP,
                LoaiPhong = dt.LoaiPhong,
                GiaPhong = dt.GiaPhong,
                GhiChu = dt.GhiChu,
            }).ToList();
            foreach (var item in gridviewInfo2)
            {

            }
            var pp = gridviewInfo1.Except(gridviewInfo2).ToArray();

            bs.DataSource = pp;
            gridDanhSachPhong.DataSource = bs;
            gridDanhSachPhong.Columns[0].HeaderText = "Mã phòng";
            gridDanhSachPhong.Columns[1].HeaderText = "Tên phòng";
            gridDanhSachPhong.Columns[2].HeaderText = "Loại phòng";
            gridDanhSachPhong.Columns[3].HeaderText = "Giá phòng";
            gridDanhSachPhong.Columns[4].HeaderText = "Ghi chú";
            gridDanhSachPhong.Columns[3].Width = 215;
            gridDanhSachPhong.Columns[4].Width = 215;
        }
        public void TimPhongDaDat(DateTime date)
        {
            var gridviewInfo = dsP
                .Join(dsCTTP, p => p.MaP, ctp => ctp.MaPhong, (p, ctp) => new { p, ctp })
                .Join(dsTP, _tp => _tp.ctp.MaThuePhong, tp => tp.MaThuePhong, (_tp, tp) => new { _tp, tp })
                .Where(_dt => Convert.ToDateTime(_dt.tp.NgayTra) > date && _dt.tp.NgayThue <= date)
                .Select(dt => new
                {
                    MaPhong = dt._tp.p.MaP,
                    TenPhong = dt._tp.p.TenP,
                    LoaiPhong = dt._tp.p.LoaiPhong,
                    GiaPhong = dt._tp.p.GiaPhong,
                    GhiChu = dt._tp.p.GhiChu,
                }).ToList();

            bs.DataSource = gridviewInfo;
            gridDanhSachPhong.DataSource = bs;
            gridDanhSachPhong.Columns[0].HeaderText = "Mã phòng";
            gridDanhSachPhong.Columns[1].HeaderText = "Tên phòng";
            gridDanhSachPhong.Columns[2].HeaderText = "Loại phòng";
            gridDanhSachPhong.Columns[3].HeaderText = "Giá phòng";
            gridDanhSachPhong.Columns[4].HeaderText = "Ghi chú";
            gridDanhSachPhong.Columns[3].Width = 215;
            gridDanhSachPhong.Columns[4].Width = 215;

        }

        private void cboTrangThaiPhong_TextUpdate(object sender, EventArgs e)
        {
            if (cboTrangThaiPhong.Text == "Còn trống")
            {
                btnTraPhong.Enabled = false;
                btnTraPhong.ButtonColor = Color.Gray;
                btnHuyDatPhong.Enabled = false;
                btnHuyDatPhong.ButtonColor = Color.Gray;
            }
            else if (cboTrangThaiPhong.Text == "Đã đặt")
            {
                btnTraPhong.Enabled = true;
                btnTraPhong.ButtonColor = Color.DarkCyan;
                btnHuyDatPhong.Enabled = true;
                btnHuyDatPhong.ButtonColor = Color.DarkCyan;
            }
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            dateChonNgay.Text = DateTime.Now.ToString();
            cboTrangThaiPhong.SelectedIndex = 0;
            btnTraPhong.Enabled = false;
            btnTraPhong.ButtonColor = Color.Gray;
            btnHuyDatPhong.Enabled = false;
            btnHuyDatPhong.ButtonColor = Color.Gray;
        }
        public void KiemTraChonTrangThai()
        {
            if(cboTrangThaiPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimeSpan oneday = new System.TimeSpan(1, 0, 0, 0);
            DateTime date = Convert.ToDateTime(dateChonNgay.Text);
            if (date >= DateTime.Now.Subtract(oneday))
            {
                KiemTraChonTrangThai();
                if (cboTrangThaiPhong.Text == "Còn trống")
                {
                    TimPhongTrong(date);
                }
                else if (cboTrangThaiPhong.Text == "Đã đặt")
                {
                    TimPhongDaDat(date);
                }
            }
            else
            {
                MessageBox.Show("Không được chọn ngày nhỏ hơn ngày hiện tại");
                //dateChonNgay.Text = DateTime.Now.ToString();
                btnTaoLai_Click(sender, e);
            }
        }

        private void gridDanhSachPhong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDanhSachPhong.ClearSelection();
        }

        private void gridDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridDanhSachPhong.CurrentRow.Index;
            gridDanhSachPhong.Rows[index].Selected = true;
        }

        private void gridDanhSachPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gridDanhSachPhong.CurrentRow.Index;
                gridDanhSachPhong.Rows[index].Selected = true;
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Nhấn một lần thôi");
            }
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn hủy đặt phòng không?", "Hủy đặt phòng", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DateTime datetime = Convert.ToDateTime(dateChonNgay.Text);
                if (gridDanhSachPhong.SelectedRows.Count == 1)
                {
                    //eThuePhong tp = new eThuePhong();
                    //eCTThuePhong cttp = new eCTThuePhong();
                    string maPhong = gridDanhSachPhong.CurrentRow.Cells[0].Value.ToString();
                    var gridviewInfo = dsCTTP
                    .Join(dsTP, _tp => _tp.MaThuePhong, tp => tp.MaThuePhong, (_tp, tp) => new { _tp, tp })
                    .Where(_dt => _dt._tp.MaPhong.Contains(maPhong) && (Convert.ToDateTime(_dt.tp.NgayThue) <= datetime && datetime < Convert.ToDateTime(_dt.tp.NgayTra)))
                    .Select(dt => dt._tp.MaThuePhong).ToList();
                    string maThuePhong = gridviewInfo[0].ToString();
                    //MessageBox.Show(maThuePhong);
                    cttpBLL.DeleteCTThuePhong(maThuePhong);
                    tpBLL.DeleteThuePhong(maThuePhong);
                    MessageBox.Show("Hủy đặt phòng thành công");
                    UCDanhSachPhong2_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng muốn hủy");
                }
            }
        }

        private void UCDanhSachPhong2_Load(object sender, EventArgs e)
        {
            UCDanhSachPhong2 dsp = new UCDanhSachPhong2();
            DateTime datetime = Convert.ToDateTime(dateChonNgay.Text);
            TimPhongTrong(datetime);
        }
    }
}
