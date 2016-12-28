using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppQuanLyNhaHang
{
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }

     
        private void FrmQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void btQLSP_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            f.Show();
            this.Hide();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.Show();
            this.Hide();
        }

        private void btnQLLSP_Click(object sender, EventArgs e)
        {
            FormLoaiSP f = new FormLoaiSP();
            f.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.Show();
            this.Hide();
        }
    }
}
