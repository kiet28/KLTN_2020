using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FormDanhSachKhachHang : Form
    {
        KhachHangBLL khachHangBLL;
        List<eKhachHang> dsKH;
        BindingSource bsKH;
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
            bsKH = new BindingSource();
            khachHangBLL = new KhachHangBLL();
            dsKH = new List<eKhachHang>();
            dsKH = khachHangBLL.LayThongTinKhachHang();
            HienThiThongTinKhachHang();
            AutoComplete();
            txtTimKiemKhachHang.Text = "Nhập tên khách hàng";
            txtTimKiemKhachHang.ForeColor = Color.Gray;
        }

        public delegate void GetString(int mkh, String tkh, int cmnd, String gt, int sdt);
        public GetString MyGetData;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void HienThiThongTinKhachHang()
        {
            var gridviewInfo = dsKH.Select(dt => new
            {
                MaKhachHang = dt.MaKH,
                TenKhachHang = dt.TenKH,
                SoCMND = dt.CMND,
                GioiTinh = dt.GioiTinh,
                SDT = dt.SDT,
            }).ToList();
            bsKH.DataSource = gridviewInfo;
            gridDanhSachKhachHang.DataSource = bsKH;
            gridDanhSachKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            gridDanhSachKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            gridDanhSachKhachHang.Columns[2].HeaderText = "Số CMND";
            gridDanhSachKhachHang.Columns[3].HeaderText = "Giới Tính";
            gridDanhSachKhachHang.Columns[4].HeaderText = "SĐT";
            gridDanhSachKhachHang.Columns[1].Width = 170;
            gridDanhSachKhachHang.Columns[0].Width = 150;
            gridDanhSachKhachHang.Columns[2].Width = 60;
            gridDanhSachKhachHang.Columns[3].Width = 57;
        }

        private void AutoComplete()
        {
            txtTimKiemKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (var item in dsKH)
            {
                col.Add(item.MaKH.ToString());
            }
            txtTimKiemKhachHang.AutoCompleteCustomSource = col;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int index = gridDanhSachKhachHang.CurrentRow.Index;
            if (MyGetData != null)
            {
                MyGetData(Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[0].Value.ToString()), gridDanhSachKhachHang.Rows[index].Cells[1].Value.ToString(), Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[2].Value.ToString()), gridDanhSachKhachHang.Rows[index].Cells[3].Value.ToString(), Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[4].Value.ToString()));
            }
            this.Close();
            this.Dispose();
        }

        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemKhachHang.Text == "Nhập tên khách hàng")
            {
                HienThiThongTinKhachHang();
            }
            else
            {
                var newList = dsKH.Where(bn1 => bn1.TenKH.Contains(txtTimKiemKhachHang.Text))
                .Select(t2 => new
                {
                    MaKhachHang = t2.MaKH,
                    TenKhachHang = t2.TenKH,
                    SoCMND = t2.CMND,
                    GioiTinh = t2.GioiTinh,
                }).ToList();
                bsKH.DataSource = newList;
                gridDanhSachKhachHang.DataSource = bsKH;
            }
        }

        private void txtTimKiemKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemKhachHang.Text == "Nhập tên khách hàng")
            {
                txtTimKiemKhachHang.Text = "";
                txtTimKiemKhachHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemKhachHang_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemKhachHang.Text == "")
            {
                txtTimKiemKhachHang.Text = "Nhập mã khách hàng";
                txtTimKiemKhachHang.ForeColor = Color.Gray;
            }
        }

        private void gridDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridDanhSachKhachHang.CurrentRow.Index;
            gridDanhSachKhachHang.Rows[index].Selected = true;
        }

        private void gridDanhSachKhachHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = gridDanhSachKhachHang.CurrentRow.Index;
                if (MyGetData != null)
                {
                    MyGetData(Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[0].Value.ToString()), gridDanhSachKhachHang.Rows[index].Cells[1].Value.ToString(), Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[2].Value.ToString()), gridDanhSachKhachHang.Rows[index].Cells[3].Value.ToString(), Convert.ToInt32(gridDanhSachKhachHang.Rows[index].Cells[4].Value.ToString()));
                }
                this.Close();
                this.Dispose();
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Nhấn một lần thôi");
            }
        }
    }
}
