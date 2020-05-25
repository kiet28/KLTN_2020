using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDichVu
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }
        public int TrangThai { get; set; }

        public eDichVu()
        {
            this.MaDV = "";
            this.TenDV = "";
            this.DonGia = 0m;
            this.TrangThai = 0;
        }

        public eDichVu(string mdv, string tdv, decimal dg, int tt)
        {
            this.MaDV = mdv;
            this.TenDV = tdv;
            this.DonGia = dg;
            this.TrangThai = tt;
        }
    }
}
