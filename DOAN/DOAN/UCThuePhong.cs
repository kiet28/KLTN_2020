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
    public partial class UCThuePhong : UserControl
    {
        public UCThuePhong()
        {
            InitializeComponent();
        }



        private void UCThuePhong_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            using(FormThemKhachHang tkh = new FormThemKhachHang())
            {
                tkh.ShowDialog();
            }
        }
    }

}
