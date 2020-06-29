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
                tp.MaNhanVien = item.maNhanVien;
                tp.MaKhachHang = item.maKhachHang;
                tp.NgayThue = Convert.ToDateTime(item.ngayThuePhong);
                tp.NgayTra = Convert.ToDateTime(item.ngayTraPhong);
                tp.TienCoc = Convert.ToDecimal(item.tienCoc);
                tp.TrangThai = item.trangThai;
                dstp.Add(tp);
            }
            return dstp;
        }

        public int InsertThuePhong(eThuePhong tpmoi)
        {
            //if (CheckExisted(tpmoi.MaThuePhong))
            //    return 0;
            ThuePhongs tptemp = new ThuePhongs();
            tptemp.maThuePhong = tpmoi.MaThuePhong;
            tptemp.maNhanVien = tpmoi.MaNhanVien;
            tptemp.maKhachHang = tpmoi.MaKhachHang;
            tptemp.ngayThuePhong = tpmoi.NgayThue;
            tptemp.ngayTraPhong = tpmoi.NgayTra;
            tptemp.tienCoc = tpmoi.TienCoc;
            tptemp.trangThai = tpmoi.TrangThai;
            ks.ThuePhongs.InsertOnSubmit(tptemp);
            ks.SubmitChanges();
            return 1;
        }
        public bool CheckExisted(string maThuePhong)
        {
            ThuePhongs tptemp = ks.ThuePhongs.Where(x => x.maThuePhong == maThuePhong).FirstOrDefault();
            if (tptemp != null)
                return true;
            return false;
        }
        public void DeleteThuePhong(string maThuePhong)
        {
            ThuePhongs tptemp = ks.ThuePhongs.Where(x => x.maThuePhong == maThuePhong).FirstOrDefault();
            ks.ThuePhongs.DeleteOnSubmit(tptemp);
            ks.SubmitChanges();
        }
    }
}
