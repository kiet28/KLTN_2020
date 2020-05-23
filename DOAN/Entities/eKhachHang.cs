using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eKhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string CMND { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }

        public eKhachHang()
        {
            this.MaKH = 0;
            this.TenKH = "";
            this.CMND = "";
            this.GioiTinh = "";
            this.SDT = "";
        }

        public eKhachHang(int mkh, string tkh, string cmnd, string gt, string sdt)
        {
            this.MaKH = mkh;
            this.TenKH = tkh;
            this.CMND = cmnd;
            this.GioiTinh = gt;
            this.SDT = sdt;
        }
    }
}
