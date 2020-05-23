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

        public eCTThuePhong()
        {
            this.MaThuePhong = 0;
            this.MaPhong = 0;
        }

        public eCTThuePhong(int mtp, int mp)
        {
            this.MaThuePhong = mtp;
            this.MaPhong = mp;
        }
    }
}
