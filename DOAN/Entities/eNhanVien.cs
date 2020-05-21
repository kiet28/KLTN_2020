using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public int maNhanVien { get; set; }
        public string hoTen { get; set; }
        public DateTime namSinh { get; set; }
        public int gioiTinh { get; set; }
        public string diaChi { get; set; }
        public int SDT { get; set; }
        public eNhanVien()
        {
            this.maNhanVien = 0;
            this.hoTen = "";
            this.namSinh = DateTime.Now;
            this.gioiTinh = 0;
            this.diaChi = "";
            this.SDT = 0;
        }
        public eNhanVien(int mNV, string hoten, DateTime namsinh, int gt, string dc, int sdt)
        {
            this.maNhanVien = mNV;
            this.hoTen = hoten;
            this.namSinh = namsinh;
            this.gioiTinh = gt;
            this.diaChi = dc;
            this.SDT = sdt;
        }
    }
}
