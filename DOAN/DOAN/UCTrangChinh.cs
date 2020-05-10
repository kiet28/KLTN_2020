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
        //
        private void panelP301_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaaa");
        }

        //
        // hiển thị chức năng đặt phòng
        //
        private void ItemDatPhong_Click(object sender, EventArgs e)
        {
            if(panelP101.BackColor == Color.LightGreen)
            {
                using (FormDatPhong dp = new FormDatPhong())
                {
                    dp.ShowDialog();
                }
            }
        }

        //
        // hiển thị giao diện thuê phòng đặt trước
        //
        private void ItemThuePhongDatTruoc_Click(object sender, EventArgs e)
        {

        }

        //
        // hiển thị các chức năng theo trạng thái phòng
        //
        private void HienThiChucNang()
        {
        //    Panel[] listPanel = new Panel[15] {panelP101, panelP102, panelP103, panelP104, panelP105, panelP201, panelP202, panelP203, panelP204, panelP205, panelP301, panelP302, panelP303, panelP304, panelP305 };
        //    for(int i = 0; i <  15; i++)
        //    {
        //        if (listPanel[i].BackColor == Color.LightGreen)
        //        {
        //            ItemDatPhong.Enabled = true;
        //            ItemThuePhongTrucTiep.Enabled = true;
        //            ItemThuePhongDatTruoc.Enabled = false;
        //            ItemTraPhong.Enabled = false;
        //        }
        //        if (listPanel[i].BackColor == Color.Crimson)
        //        {
        //            ItemDatPhong.Enabled = false;
        //            ItemThuePhongTrucTiep.Enabled = false;
        //            ItemThuePhongDatTruoc.Enabled = false;
        //            ItemTraPhong.Enabled = true;
        //        }
        //        if (listPanel[i].BackColor == Color.Khaki)
        //        {
        //            ItemDatPhong.Enabled = false;
        //            ItemThuePhongTrucTiep.Enabled = false;
        //            ItemThuePhongDatTruoc.Enabled = true;
        //            ItemTraPhong.Enabled = false;
        //        }
        //    }
        }

        private void UCTrangChinh_Load(object sender, EventArgs e)
        {
            HienThiChucNang();
        }
    }
}
