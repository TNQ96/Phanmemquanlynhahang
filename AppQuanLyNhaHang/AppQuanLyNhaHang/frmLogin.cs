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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    NhanVien Login = (from Log in db.NhanVien
                                      where Log.TenNV == txtNameLogin.Text && txtPass.Text=="123"
                                      select Log).Single();
                    if (Login != null)
                    {
                        FrmMain f = new FrmMain(Login.Chucvu);
                        f.Show();
                        this.Hide();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
