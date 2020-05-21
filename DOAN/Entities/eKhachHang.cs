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
        public int CMND { get; set; }
        public string GioiTinh { get; set; }
        public int SDT { get; set; }

        public eKhachHang()
        {
            this.MaKH = 0;
            this.TenKH = "";
            this.CMND = 0;
            this.GioiTinh = "";
            this.SDT = 0;
        }

        public eKhachHang(int mkh, string tkh, int cmnd, string gt, int sdt)
        {
            this.MaKH = mkh;
            this.TenKH = tkh;
            this.CMND = cmnd;
            this.GioiTinh = gt;
            this.SDT = sdt;
        }
    }
}
