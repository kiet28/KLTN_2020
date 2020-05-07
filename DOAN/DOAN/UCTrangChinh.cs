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
    public partial class UCTrangChinh : UserControl
    {
        public UCTrangChinh()
        {
            InitializeComponent();
        }


        //
        //hiển thị thông tin phòng
        //
        private void panel1_Click(object sender, EventArgs e)
        {
            using (FormThongTinPhong ttp = new FormThongTinPhong())
            {
                ttp.ShowDialog();
            }
        }

        //
        // hiển thị các chức năng đặt phòng, thuê phòng ...
        private void panelP301_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");
        }
    }
}
