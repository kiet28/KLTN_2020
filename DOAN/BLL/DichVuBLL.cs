using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DichVuBLL
    {
        QLKSDataContext ks;
        public DichVuBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<eDichVu> LayThongTinDichVu()
        {
            var dsDichVu = ks.DichVus.ToList();
            List<eDichVu> dsdv = new List<eDichVu>();
            foreach (DichVus ts in dsDichVu)
            {
                eDichVu dv = new eDichVu();
                dv.MaDV = ts.maDichVu;
                dv.TenDV = ts.tenDichVu;
                dv.DonGia = Convert.ToDecimal(ts.giaDichVu);
                dv.TrangThai = Convert.ToInt32(ts.trangThai);
                dsdv.Add(dv);
            }
            return dsdv;
        }

        public void ThemThongTinDichVu(eDichVu dvMoi)
        {
            DichVus temp = new DichVus();
            temp.maDichVu = dvMoi.MaDV;
            temp.tenDichVu = dvMoi.TenDV;
            temp.giaDichVu = dvMoi.DonGia;
            temp.trangThai = dvMoi.TrangThai;

            ks.DichVus.InsertOnSubmit(temp);
            ks.SubmitChanges();

        }

        public void CapNhatThongTinDichVu(string mdv, string tdv, decimal dg, int tt)
        {
            IQueryable<DichVus> dichvu = ks.DichVus.Where(dv => dv.maDichVu.Equals(mdv));

            dichvu.First().maDichVu = mdv;
            dichvu.First().tenDichVu = tdv;
            dichvu.First().giaDichVu = dg;
            dichvu.First().trangThai = tt;

            ks.SubmitChanges();
        }
    }
}
