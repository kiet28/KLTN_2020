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
    public partial class FormThuePhongDatTruoc : Form
    {
        public FormThuePhongDatTruoc()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region
        //
        // Hint textbox
        //
        private bool hasTextBeenTyped;
        private void txtTimTheoCMND_TextChanged(object sender, EventArgs e)
        {
            hasTextBeenTyped = !String.IsNullOrEmpty(txtTimTheoCMND.Text);

            if (hasTextBeenTyped)
            {
                txtTimTheoCMND.ForeColor = Color.Black;
            }
        }
        private void txtTimTheoCMND_Click(object sender, EventArgs e)
        {
            if (!hasTextBeenTyped)
            {
                txtTimTheoCMND.Text = "";
            }
        }
        private void txtTimTheoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            hasTextBeenTyped = true;
        }


        #endregion

    }
}
