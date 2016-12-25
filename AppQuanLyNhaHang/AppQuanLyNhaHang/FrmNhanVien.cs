using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppQuanLyNhaHang
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void LoadEmployee()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from emp in db.NhanVien
                                select new
                                {
                                    MaNV = emp.MaNV,
                                    HoNV = emp.HoNV,
                                    TenNV = emp.TenNV,
                                    NgaySinh = emp.NgaysinhNV,
                                    DiaChi = emp.Diachi,
                                    SoDienThoai = emp.Dienthoai,
                                    ChucVu = emp.Chucvu
                                };
                    dgvNhanVien.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
