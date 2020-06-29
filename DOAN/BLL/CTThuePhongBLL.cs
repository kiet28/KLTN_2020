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
                cttp.MaCTTP = item.maCTTP;
                cttp.MaThuePhong = item.maThuePhong;
                cttp.MaPhong = item.maPhong;
                cttp.MaDichVu = item.maDichVu;
                cttp.DVT = item.DVT;
                cttp.SoLuong = Convert.ToInt32(item.soLuong);
                dscttp.Add(cttp);
            }
            return dscttp;
        }
        public int InsertCTThuePhong(eCTThuePhong cttpmoi)
        {
            CTThuePhongs cttptemp = new CTThuePhongs();
            cttptemp.maCTTP = cttpmoi.MaCTTP;
            cttptemp.maThuePhong = cttpmoi.MaThuePhong;
            cttptemp.maPhong = cttpmoi.MaPhong;
            cttptemp.maDichVu = "0";
            cttptemp.DVT = "Không";
            ks.CTThuePhongs.InsertOnSubmit(cttptemp);
            ks.SubmitChanges();
            return 1;
        }
        public int InsertDichVu(eCTThuePhong cttpmoi)
        {
            CTThuePhongs cttptemp = new CTThuePhongs();
            cttptemp.maCTTP = cttpmoi.MaCTTP;
            cttptemp.maThuePhong = cttpmoi.MaThuePhong;
            cttptemp.maPhong = cttpmoi.MaPhong;
            cttptemp.maDichVu = cttpmoi.MaDichVu;
            cttptemp.DVT = cttpmoi.DVT;
            cttptemp.soLuong = cttpmoi.SoLuong;
            ks.CTThuePhongs.InsertOnSubmit(cttptemp);
            ks.SubmitChanges();
            return 1;
        }
        public void DeleteCTThuePhong(string maThuePhong)
        {
            CTThuePhongs cttptemp = ks.CTThuePhongs.Where(x => x.maThuePhong == maThuePhong).FirstOrDefault();
            ks.CTThuePhongs.DeleteOnSubmit(cttptemp);
            ks.SubmitChanges();
        }
    }
}
