using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTThuePhong
    {
        public int MaThuePhong { get; set; }
        public int MaPhong { get; set; }
        public int MaDichVu { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }

        public eCTThuePhong()
        {
            this.MaThuePhong = 0;
            this.MaPhong = 0;
            this.MaDichVu = 0;
            this.DVT = "";
            this.SoLuong = 0;
        }

        public eCTThuePhong(int mtp, int mp, int mdv, string dvt, int sl)
        {
            this.MaThuePhong = mtp;
            this.MaPhong = mp;
            this.MaDichVu = mdv;
            this.DVT = dvt;
            this.SoLuong = sl;
        }
    }
}
