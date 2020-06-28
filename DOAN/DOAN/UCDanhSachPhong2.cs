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

            bs = new BindingSource();
            tpBLL = new ThuePhongBLL();
            cttpBLL = new CTThuePhongBLL();
            pBLL = new PhongBLL();
            dsTP = new List<eThuePhong>();
            dsCTTP = new List<eCTThuePhong>();
            dsP = new List<ePhong>();
            dsTP = tpBLL.LayThongTinThuePhong();
            dsP = pBLL.LayThongTinPhong();
            HienThiThongTinPhong();
        }

        public void HienThiThongTinPhong()
        {
            var gridviewInfo = dsP.Select(dt => new
            {
                MaPhong = dt.MaP,
                TenPhong = dt.TenP,
                TrangThai = dt.TrangThai,
                LoaiPhong = dt.LoaiPhong,
                GiaPhong = dt.GiaPhong,
                GhiChu = dt.GhiChu,
            }).ToList();
            bs.DataSource = gridviewInfo;
            gridDanhSachPhong.DataSource = bs;
            gridDanhSachPhong.Columns[0].HeaderText = "Mã phòng";
            gridDanhSachPhong.Columns[1].HeaderText = "Tên phòng";
            gridDanhSachPhong.Columns[2].HeaderText = "Trạng thái";
            gridDanhSachPhong.Columns[3].HeaderText = "Loại phòng";
            gridDanhSachPhong.Columns[4].HeaderText = "Giá phòng";
            gridDanhSachPhong.Columns[5].HeaderText = "Ghi chú";
            //int countP = gridDanhSachPhong.Rows.Count;
            //for (int i = 0; i <= countP; i++)
            //{
            //    if (gridDanhSachPhong.Rows[i].Cells[2].Value.ToString().Contains("1"))
            //    {
            //        gridDanhSachPhong.Rows[i].Cells[2].Value = "Còn trống";
            //    }
            //    else if(gridDanhSachPhong.Rows[i].Cells[2].Value.ToString().Contains("2")){
            //        gridDanhSachPhong.Rows[i].Cells[2].Value = "Đang thuê";
            //    }
            //}
        }

    }
}
