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
            foreach (var item in listNV)
            {
                eNhanVien nv = new eNhanVien();
                nv.maNhanVien = item.maNhanVien;
                nv.hoTen = item.hoTen;
                nv.namSinh = Convert.ToDateTime(item.namSinh);
                nv.gioiTinh = item.gioiTinh;
                nv.diaChi = item.diaChi;
                nv.SDT = item.SDT;
                nv.tinhTrang = item.trangThai;
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
            temp.trangThai = newnv.tinhTrang;
            _db.NhanViens.InsertOnSubmit(temp);
            _db.SubmitChanges();
        }
        public void CapNhatThongTinNhanVien(string manv, string hoten, DateTime namsinh, string gt, string dc, string sdt, string tt)
        {
            IQueryable<NhanVien> nhanvien = _db.NhanViens.Where(nv => nv.maNhanVien.Equals(manv));
            nhanvien.First().maNhanVien = manv;
            nhanvien.First().hoTen = hoten;
            nhanvien.First().namSinh = namsinh;
            nhanvien.First().gioiTinh = gt;
            nhanvien.First().diaChi = dc;
            nhanvien.First().SDT = sdt;
            nhanvien.First().trangThai = tt;
            _db.SubmitChanges();
        }
    }
}
