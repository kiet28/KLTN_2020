using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuePhongBLL
    {

        QLKSDataContext ks;
        public ThuePhongBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<eThuePhong> LayThongTinThuePhong()
        {
            var dsThuePhong = ks.ThuePhongs.ToList();
            List<eThuePhong> dstp = new List<eThuePhong>();
            foreach (ThuePhongs item in dsThuePhong)
            {
                eThuePhong tp = new eThuePhong();
                tp.MaThuePhong = item.maThuePhong;
                tp.MaNhanVien = Convert.ToInt32(item.maNhanVien);
                tp.MaKhachHang = Convert.ToInt32(item.maKhachHang);
                tp.NgayThue = Convert.ToDateTime(item.ngayThuePhong);
                tp.NgayTra = Convert.ToDateTime(item.ngayTraPhong);
                tp.GioThue = item.gioThue;
                tp.GioTra = item.gioTra;
                dstp.Add(tp);
            }
            return dstp;
        }

        public int InsertThuePhong(eThuePhong tpmoi)
        {
            if (CheckExisted(tpmoi.MaThuePhong))
                return 0;
            ThuePhongs tptemp = new ThuePhongs();
            tptemp.maThuePhong = tpmoi.MaThuePhong;
            tptemp.maNhanVien = tpmoi.MaNhanVien;
            tptemp.maKhachHang = tpmoi.MaKhachHang;
            tptemp.ngayThuePhong = tpmoi.NgayThue;
            tptemp.ngayTraPhong = tpmoi.NgayTra;
            tptemp.gioThue = tpmoi.GioThue;
            tptemp.gioTra = tpmoi.GioTra;
            ks.ThuePhongs.InsertOnSubmit(tptemp);
            ks.SubmitChanges();
            return 1;
        }
        public bool CheckExisted(int maThuePhong)
        {
            ThuePhongs tptemp = ks.ThuePhongs.Where(x => x.maThuePhong == maThuePhong).FirstOrDefault();
            if (tptemp != null)
                return true;
            return false;
        }
    }
}
