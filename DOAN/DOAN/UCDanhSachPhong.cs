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
    public partial class UCDanhSachPhong : UserControl
    {
        public UCDanhSachPhong()
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
            ToolStripItem item = (sender as ToolStripItem);

            ContextMenuStrip owner = item.Owner as ContextMenuStrip;
            if (owner.SourceControl.BackColor == Color.LightGreen || owner.SourceControl.BackColor == Color.DarkGray)
            {
                using (FormDatPhong dp = new FormDatPhong())
                {
                    dp.ShowDialog();
                }
            }
            else
                MessageBox.Show("Phòng này không thể đặt!");


        }

        //
        // hiển thị giao diện thuê phòng đặt trước
        //
        private void ItemThuePhongDatTruoc_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);

            ContextMenuStrip owner = item.Owner as ContextMenuStrip;
            if (owner.SourceControl.BackColor == Color.Khaki)
            {
                using (FormThuePhongDatTruoc tpdt = new FormThuePhongDatTruoc())
                {
                    tpdt.ShowDialog();
                }
            }
            else
                MessageBox.Show("Phòng này chưa đặt trước!");
            
        }


        private void UCTrangChinh_Load(object sender, EventArgs e)
        {
            
        }
    }
}
