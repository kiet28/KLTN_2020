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
                dscttp.Add(cttp);
            }
            return dscttp;
        }
        public int InsertCTThuePhong(eCTThuePhong cttpmoi)
        {
            CTThuePhongs cttptemp = new CTThuePhongs();
            cttptemp.maThuePhong = cttpmoi.MaThuePhong;
            cttptemp.maPhong = cttpmoi.MaPhong;
            ks.CTThuePhongs.InsertOnSubmit(cttptemp);
            ks.SubmitChanges();
            return 1;
        }
    }
}
