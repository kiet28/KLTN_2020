using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TinhTrang { get; set; }

        public eNhanVien()
        {
            this.MaNhanVien = 0;
            this.TenNhanVien = "";
            this.GioiTinh = "";
            this.NamSinh = "";
            this.DiaChi = "";
            this.SDT = "";
            this.TinhTrang = "";
        }

        public eNhanVien(int mnv, string tnv, string gt, string ns, string dc, string sdt, string tt)
        {
            this.MaNhanVien = mnv;
            this.TenNhanVien = tnv;
            this.GioiTinh = gt;
            this.NamSinh = ns;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.TinhTrang = tt;
        }
    }
}
