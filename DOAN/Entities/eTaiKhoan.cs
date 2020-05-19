using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTaiKhoan
    {
        public string UserName { set; get; }
        public string Pass { set; get; }
        public string LoaiTK { set; get; }
        public int MaNV { set; get; }
        public int MaNQL { set; get; }
        public int MaTK { set; get; }
        public eTaiKhoan()
        {
            this.UserName = "";
            this.Pass = "";
            this.LoaiTK = "";
            this.MaNV = 0;
            this.MaNQL = 0;
            this.MaTK = 0;
        }
        public eTaiKhoan(string user, string p, string loaitk, int manv, int manql, int matk)
        {
            this.UserName = user;
            this.Pass = p;
            this.LoaiTK = loaitk;
            this.MaNV = manv;
            this.MaNQL = manql;
            this.MaTK = matk;
        }
    }
}
