using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eThuePhong
    {
        public string MaThuePhong { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime NgayTra { get; set; }
        public string GioThue { get; set; }
        public string GioTra { get; set; }

        public eThuePhong()
        {
            this.MaThuePhong = "";
            this.MaNhanVien = "";
            this.MaKhachHang = "";
            this.NgayThue = DateTime.Now;
            this.NgayTra = DateTime.Now;
            this.GioThue = "14h";
            this.GioTra = "12h";
        }

        public eThuePhong(string mtp, string mnv, string mkh, DateTime nt, DateTime ntr, string gt, string gtr)
        {
            this.MaThuePhong = mtp;
            this.MaNhanVien = mnv;
            this.MaKhachHang = mkh;
            this.NgayThue = nt;
            this.NgayTra = ntr;
            this.GioThue = gt;
            this.GioTra = gtr;
        }
    }
}
