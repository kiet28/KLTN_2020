using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTThuePhong
    {
        public int MaCTTP { get; set; }
        public string MaThuePhong { get; set; }
        public string MaPhong { get; set; }
        public string MaDichVu { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }

        public eCTThuePhong()
        {
            this.MaCTTP = 0;
            this.MaThuePhong = "";
            this.MaPhong = "";
            this.MaDichVu = "";
            this.DVT = "";
            this.SoLuong = 0;
        }

        public eCTThuePhong(int mcttp, string mtp, string mp, string mdv, string dvt, int sl)
        {
            this.MaCTTP = mcttp;
            this.MaThuePhong = mtp;
            this.MaPhong = mp;
            this.MaDichVu = mdv;
            this.DVT = dvt;
            this.SoLuong = sl;
        }
    }
}
