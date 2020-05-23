using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public string maNhanVien { get; set; }
        public string hoTen { get; set; }
        public DateTime namSinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public string tinhTrang { get; set; }
        public eNhanVien()
        {
            this.maNhanVien = "";
            this.hoTen = "";
            this.namSinh = DateTime.Now;
            this.gioiTinh = "";
            this.diaChi = "";
            this.SDT = "";
            this.tinhTrang = "";
        }
        public eNhanVien(string mNV, string hoten, DateTime namsinh, string gt, string dc, string sdt, string tt)
        {
            this.maNhanVien = mNV;
            this.hoTen = hoten;
            this.namSinh = namsinh;
            this.gioiTinh = gt;
            this.diaChi = dc;
            this.SDT = sdt;
            this.tinhTrang = tt;
        }
    }
}
