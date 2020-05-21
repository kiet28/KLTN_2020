using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using DAL;

namespace DOAN
{
    public partial class UCThemNV : UserControl
    {
        NhanVienBLL nvBLL;
        public UCThemNV()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
        }
        public void InitColumn(ListView lvw)
        {
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("STT");
            lvw.Columns.Add("Họ và tên");
            lvw.Columns.Add("Giới tính");
            lvw.Columns.Add("Năm sinh");
            lvw.Columns.Add("Số điện thoại");
            lvw.Columns.Add("Địa chỉ");
        }
        public ListViewItem CreateItem(eNhanVien nv)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(nv.maNhanVien.ToString());
            lvwItem.SubItems.Add(nv.hoTen);
            lvwItem.SubItems.Add(nv.gioiTinh.ToString());
            lvwItem.SubItems.Add(nv.namSinh.ToString());
            lvwItem.SubItems.Add(nv.SDT.ToString());
            lvwItem.SubItems.Add(nv.diaChi);
            return lvwItem;
        }
        public void HienThiNhanVien(ListView lvw, IEnumerable<eNhanVien> lsNV)
        {
            lvw.Items.Clear();
            ListViewItem lvwItem;
            foreach (var item in lsNV)
            {
                lvwItem = CreateItem(item);
                lvw.Items.Add(lvwItem);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            eNhanVien nv = new eNhanVien();
            nv.maNhanVien = 1;
            nv.hoTen = txtHoTen.Text;
            if(rdbNam.Checked == true)
            {
                nv.gioiTinh = 1;
            }
            if(rdbNu.Checked==true)
            {
                nv.gioiTinh = 0;
            }
            nv.diaChi = txtDiaChi.Text;
            nv.namSinh = Convert.ToDateTime(dtNamSinh.Text);
            nv.SDT = Convert.ToInt32(txtSDT.Text);
            nvBLL.ThemNhanVien(nv);
            MessageBox.Show("Thêm thành công");
        }

        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCThemNV_Load(object sender, EventArgs e)
        {
            InitColumn(lvwDSNV);
            IEnumerable<eNhanVien> dsNV = nvBLL.getALLNhanVien();
            HienThiNhanVien(lvwDSNV,dsNV);
        }
    }
}
