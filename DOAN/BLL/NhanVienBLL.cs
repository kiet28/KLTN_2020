using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NhanVienBLL
    {
        QLKSDataContext _db;
        public NhanVienBLL()
        {
            _db = new QLKSDataContext();
        }
        public List<eNhanVien> getALLNhanVien()
        {
            var listNV = _db.NhanViens.ToList();
            List<eNhanVien> ls = new List<eNhanVien>();
            foreach (var item in ls)
            {
                eNhanVien nv = new eNhanVien();
                nv.maNhanVien = item.maNhanVien;
                nv.hoTen = item.hoTen;
                nv.namSinh = item.namSinh;
                nv.gioiTinh = item.gioiTinh;
                nv.diaChi = item.diaChi;
                nv.SDT = item.SDT;
                ls.Add(nv);
            }
            return ls;
        }
        public void ThemNhanVien(eNhanVien newnv)
        {
            NhanVien temp = new NhanVien();
            temp.maNhanVien = newnv.maNhanVien;
            temp.hoTen = newnv.hoTen;
            temp.namSinh = newnv.namSinh;
            temp.gioiTinh = newnv.gioiTinh;
            temp.diaChi = newnv.diaChi;
            temp.SDT = newnv.SDT;
            _db.NhanViens.InsertOnSubmit(temp);
            _db.SubmitChanges();
        }
    }
}
