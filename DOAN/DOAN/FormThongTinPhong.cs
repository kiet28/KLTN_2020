using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormThongTinPhong : Form
    {
        public FormThongTinPhong()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //labelTime.Text = dt.ToString("HH:mm:ss");
            lblNgayPhong.Text = dt.ToString("dd/MM/yyyy");
        }
    }
}
