using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CTThuePhongBLL
    {
        QLKSDataContext ks;
        public CTThuePhongBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<eCTThuePhong> LayThongTinCTThuePhong()
        {
            var dsCTThuePhong = ks.CTThuePhongs.ToList();
            List<eCTThuePhong> dscttp = new List<eCTThuePhong>();
            foreach (CTThuePhongs item in dsCTThuePhong)
            {
                eCTThuePhong cttp = new eCTThuePhong();
                cttp.MaThuePhong = item.maThuePhong;
                cttp.MaPhong = Convert.ToInt32(item.maPhong);
                cttp.MaDichVu = Convert.ToInt32(item.maDichVu);
                cttp.DVT = item.DVT;
                cttp.SoLuong = Convert.ToInt32(item.soLuong);
                dscttp.Add(cttp);
            }
            return dscttp;
        }
        public int InsertCTThuePhong(eCTThuePhong cttpmoi)
        {
            CTThuePhongs cttptemp = new CTThuePhongs();
            cttptemp.maThuePhong = cttpmoi.MaThuePhong;
            cttptemp.maPhong = cttpmoi.MaPhong;
            cttptemp.maDichVu = 0;
            ks.CTThuePhongs.InsertOnSubmit(cttptemp);
            ks.SubmitChanges();
            return 1;
        }
        public void CapNhatThongTinThemDVVaoCTTP(int mtp, int mp, int mdv, string dvt, int sl)
        {
            IQueryable<CTThuePhongs> cttp = ks.CTThuePhongs.Where(dv => dv.maThuePhong.Equals(mtp) && dv.maPhong.Equals(mp));

            cttp.First().maThuePhong = mtp;
            cttp.First().maPhong = mp;
            cttp.First().maDichVu = mdv;
            cttp.First().DVT = dvt;
            cttp.First().soLuong = sl;

            ks.SubmitChanges();
        }
    }
}
