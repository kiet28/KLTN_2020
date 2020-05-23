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
    public class NhanVienBLL
    {
        QLKSDataContext ks;

        public NhanVienBLL()
        {
            ks = new QLKSDataContext();
        }

        public List<eNhanVien> LayThongTinNhanVien()
        {
            var dsNhanVien = ks.NhanViens.ToList();
            List<eNhanVien> dsnv = new List<eNhanVien>();
            foreach (var item in dsNhanVien)
            {
                eNhanVien nv = new eNhanVien();
                nv.MaNhanVien = item.maNhanVien;
                nv.TenNhanVien = item.hoTen;
                nv.NamSinh = item.namSinh.ToString();
                nv.DiaChi = item.diaChi.ToString();
                nv.SDT = item.SDT;
                nv.TinhTrang = item.trangThai;
                dsnv.Add(nv);
            }
            return dsnv;
        }
    }
}
