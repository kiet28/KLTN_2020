using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        QLKSDataContext ks;
        public TaiKhoanBLL()
        {
            this.ks = new QLKSDataContext();
        }
        public List<eTaiKhoan> LayThongTinTaiKhoan()
        {
            var dsTaiKhoan = ks.TaiKhoans.ToList();
            List<eTaiKhoan> dsTK = new List<eTaiKhoan>();
            foreach (TaiKhoan tkn in dsTaiKhoan)
            {
                eTaiKhoan tks = new eTaiKhoan();
                tks.UserName = tkn.userName;
                tks.Pass = tkn.passWord;
                tks.LoaiTK = tkn.loaiTaiKhoan;
                tks.MaTK = tkn.maTaiKhoan;
                tks.MaNV = (Int32)tkn.maNhanVien;
                tks.MaNQL = (Int32)tkn.maNQL;
                dsTK.Add(tks);
            }
            return dsTK;
        }

        public void DoiMKTaiKhoan(string user, string pass)
        {
            IQueryable<TaiKhoan> taikhoan = ks.TaiKhoans.Where(nv => nv.userName.Equals(user));
            taikhoan.First().passWord = pass;
            ks.SubmitChanges();
        }
    }
}
