using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eQuanLy
    {
        public int MaNQL { get; set; }
        public string TenNQL { get; set; }
        public eQuanLy()
        {
            this.MaNQL = 0;
            this.TenNQL = "";
        }
        public eQuanLy(int ma, string ten)
        {
            this.MaNQL = ma;
            this.TenNQL = ten;
        }
    }
}
