using DAL;
using DAL.Properties;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        QLKSDataContext ks;
        public KhachHangBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<eKhachHang> LayThongTinBenhNhan()
        {
            var dsKhachHang = ks.KhachHangs.ToList();
            List<eKhachHang> dsbn = new List<eKhachHang>();
            foreach (KhachHangs item in dsKhachHang)
            {
                eKhachHang kh = new eKhachHang();
                kh.MaKH = item.maKhachHang;
                kh.TenKH = item.tenKhachHang;
                kh.CMND = Convert.ToInt32(item.CMND);
                kh.GioiTinh = item.gioiTinh;
                kh.SDT = Convert.ToInt32(item.SDT);
                dsbn.Add(kh);
            }
            return dsbn;
        }

        public void ThemThongTinKhachHang(eKhachHang newKH)
        {
            KhachHangs temp = new KhachHangs();
            temp.maKhachHang = newKH.MaKH;
            temp.tenKhachHang = newKH.TenKH;
            temp.CMND = newKH.CMND;
            temp.gioiTinh = newKH.GioiTinh;
            temp.SDT = newKH.SDT;

            ks.KhachHangs.InsertOnSubmit(temp);
            ks.SubmitChanges();
        }
        public int InsertKhachHang(eKhachHang khmoi)
        {
            if (CheckExisted(khmoi.MaKH))
                return 0;
            KhachHangs khtemp = new KhachHangs();
            khtemp.maKhachHang = khmoi.MaKH;
            khtemp.tenKhachHang = khmoi.TenKH;
            khtemp.CMND = khmoi.CMND;
            khtemp.gioiTinh = khmoi.GioiTinh;
            khtemp.SDT = khmoi.SDT;
            ks.KhachHangs.InsertOnSubmit(khtemp);
            ks.SubmitChanges();
            return 1;
        }
        public bool CheckExisted(int maKhachHang)
        {
            KhachHangs khtemp = ks.KhachHangs.Where(x => x.maKhachHang == maKhachHang).FirstOrDefault();
            if (khtemp != null)
                return true;
            return false;
        }

        public void ThemKhachHang(eKhachHang khMoi)
        {
            KhachHangs temp = new KhachHangs();
            temp.maKhachHang = khMoi.MaKH;
            temp.tenKhachHang = khMoi.TenKH;
            temp.gioiTinh = khMoi.GioiTinh;
            temp.SDT = khMoi.SDT;
            temp.CMND = khMoi.CMND;

            ks.KhachHangs.InsertOnSubmit(temp);
            ks.SubmitChanges();

        }
    }
}
