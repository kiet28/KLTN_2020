using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongBLL
    {
        QLKSDataContext ks;
        public PhongBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<ePhong> LayThongTinPhong()
        {
            var dsPhong = ks.Phongs.ToList();
            List<ePhong> dsp = new List<ePhong>();
            foreach (Phongs ts in dsPhong)
            {
                ePhong p = new ePhong();
                p.MaP = ts.maPhong;
                p.TenP = ts.tenPhong;
                p.TrangThai = Convert.ToInt32(ts.trangThai);
                p.GhiChu = ts.ghiChu;
                p.LoaiPhong = ts.loaiPhong;
                p.GiaPhong = Convert.ToDecimal(ts.giaPhong);
                dsp.Add(p);
            }
            return dsp;
        }

        public void CapNhatTrangThaiPhong(string mp,int tt)
        {
            IQueryable<Phongs> phong = ks.Phongs.Where(p => p.maPhong.Equals(mp));

            phong.First().maPhong = mp;
            phong.First().trangThai = tt;

            ks.SubmitChanges();
        }
    }
}
