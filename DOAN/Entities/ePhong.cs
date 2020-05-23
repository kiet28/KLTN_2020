using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhong
    {
        public int MaP { get; set; }
        public string TenP { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public decimal GiaPhong { get; set; }
        public string LoaiPhong { get; set; }


        public ePhong()
        {
            this.MaP = 0;
            this.TenP = "";
            this.TrangThai = 0;
            this.GhiChu = "";
            this.GiaPhong = 0;
            this.LoaiPhong = "";
        }

        public ePhong(int mp, string tp, int tt, string gc, decimal gp, string lp)
        {
            this.MaP = mp;
            this.TenP = tp;
            this.TrangThai = tt;
            this.GhiChu = gc;
            this.GiaPhong = gp;
            this.LoaiPhong = lp;
        }
    }
}
