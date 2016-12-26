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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            dtNgaySinhNV.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells[3].Value.ToString());
            txtDiaChiNV.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtDienThoaiNV.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var emp = new NhanVien()
                    {
                        MaNV = int.Parse(txtMaNV.Text),
                        HoNV = txtHo.Text,
                        TenNV = txtTen.Text,
                        NgaysinhNV = dtNgaySinhNV.Value,
                        Diachi = txtDiaChiNV.Text,
                        Dienthoai = txtDienThoaiNV.Text,
                        Chucvu = txtChucVu.Text
                    };
                    db.NhanVien.AddObject(emp);
                    db.SaveChanges();
                    LoadEmployee();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    NhanVien empToUpdate =
                        (from emp in db.NhanVien
                         where emp.MaNV == int.Parse(txtMaNV.Text)
                         select emp).Single();
                    if (empToUpdate != null)
                    {
                        empToUpdate.HoNV = txtHo.Text;
                        empToUpdate.TenNV = txtTen.Text;
                        empToUpdate.NgaysinhNV = dtNgaySinhNV.Value;
                        empToUpdate.Chucvu = txtChucVu.Text;
                        db.SaveChanges();
                    }
                    LoadEmployee();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var MANV = int.Parse(txtMaNV.Text);
                    NhanVien empToDelete =
                        (from emp in db.NhanVien
                         where emp.MaNV == MANV
                         select emp).Single();
                    if (empToDelete != null)
                    {
                        db.NhanVien.DeleteObject(empToDelete);
                        db.SaveChanges();
                    }
                }
                LoadEmployee();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
