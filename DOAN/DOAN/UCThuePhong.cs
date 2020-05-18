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
            ChonPhong();
        }

        public void ChonPhong()
        {
            cboTenPhong.Text = "";
            for (int i = 0; i < cboTenPhong.Items.Count; i++)
            {
                if (cboTenPhong.SelectedIndex == i)
                {
                    cboTenPhong.Text = cboTenPhong.Items[i].ToString() + ",";
                }
            }
        }

        private void UCThuePhong_Load(object sender, EventArgs e)
        {
            cboTenPhong.Text = "--Chọn tên phòng";
        }
    }

}
