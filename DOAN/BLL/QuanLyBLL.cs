using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyBLL
    {
        QLKSDataContext ks;
        public QuanLyBLL()
        {
            ks = new QLKSDataContext();
        }
        public List<eQuanLy> LayThongTinQuanLy()
        {
            var dsQuanLy = ks.NguoiQuanLies.ToList();
            List<eQuanLy> dsQL = new List<eQuanLy>();
            foreach (NguoiQuanLy qls in dsQuanLy)
            {
                eQuanLy qln = new eQuanLy();
                qln.MaNQL = qls.maNQL;
                qln.TenNQL = qls.tenNQL;
                dsQL.Add(qln);
            }
            return dsQL;
        }
    }
}
