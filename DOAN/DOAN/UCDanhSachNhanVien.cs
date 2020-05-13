using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class UCDanhSachNhanVien : UserControl
    {
        public void InitColumn(ListView lvw)
        {
            lvw.View = View.Details;
            lvw.FullRowSelect = true;
            lvw.GridLines = true;
            lvw.Columns.Add("STT", 50);
            lvw.Columns.Add("Họ và tên", 100);
            lvw.Columns.Add("Giới tính", 50);
            lvw.Columns.Add("Năm sinh", 100);
            lvw.Columns.Add("Số điện thoại", 100);
            lvw.Columns.Add("Địa chỉ", 200);
        }
        public UCDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void UCDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            InitColumn(lvwDanhSachNV);
        }
    }
}
