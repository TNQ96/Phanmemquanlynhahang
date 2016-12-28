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
        string chucvu = "";
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string chucvu)
        {
            InitializeComponent();
            this.chucvu = chucvu;
        }
        private void BtnQuanLy_Click(object sender, EventArgs e)
        {
            if (chucvu == "Quản Lý")
            {
                FrmQuanLy f = new FrmQuanLy();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!"); 
            }

        }

        private void btnThanToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan f = new FrmThanhToan();
            f.Show();
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
