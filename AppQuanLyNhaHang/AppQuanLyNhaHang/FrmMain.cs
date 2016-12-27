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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnQuanLy_Click(object sender, EventArgs e)
        {
            FrmQuanLy f = new FrmQuanLy();
            f.Show();
            this.Hide();
        }

        private void btnThanToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan f = new FrmThanhToan();
            f.Show();
            this.Hide();
        }
    }
}
