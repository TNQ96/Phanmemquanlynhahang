using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AppQuanLyNhaHang
{
    public partial class FrmKhachHang : Form
    {
        //string cnStr;
       // SqlConnection cn;
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
          //  cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
           // cn = new SqlConnection(cnStr);
            //FillNoGirdView();
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from cus in db.KhachHang
                                select new
                                {
                                    MaKH = cus.MaKH,
                                    TenKH = cus.TenKH,
                                    HoKH = cus.HoKH,
                                    Ngaysinh = cus.Ngaysinh,
                                    Diachi = cus.Diachi,
                                    Dienthoai = cus.Dienthoai
                                };

                    dgvKhachHang.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /*private void FillNoGirdView()
        {
            for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
                dgvKhachHang["STT", i].Value = i + 1;
        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var cus = new KhachHang()
                    {
                        HoKH = txtHo.Text.Trim(),
                        MaKH = int.Parse(txtID.Text.Trim()),
                        TenKH = txtName.Text.Trim(),
                        Diachi = txtAddress.Text.Trim(),
                        Ngaysinh = dtKH.Value,
                        Dienthoai = txtPhone.Text.Trim()

                    };
                    db.KhachHang.AddObject(cus);
                    db.SaveChanges();
                    LoadCustomer();
                    //FillNoGirdView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Text = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txtName.Text = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
            dtKH.Value = DateTime.Parse(dgvKhachHang.Rows[index].Cells[3].Value.ToString());
            txtAddress.Text = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
            txtPhone.Text = dgvKhachHang.Rows[index].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var MAKH = int.Parse(txtID.Text);
                    KhachHang cusToDelete =
                        (from cus in db.KhachHang
                         where cus.MaKH == MAKH
                         select cus).Single();
                    if (cusToDelete != null)
                    {
                        db.KhachHang.DeleteObject(cusToDelete);
                        db.SaveChanges();
                    }
                }
                LoadCustomer();
                // FillNoGirdView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var MAKH = int.Parse(txtID.Text);
                    KhachHang cusToUpdate =
                        (from cus in db.KhachHang
                         where cus.MaKH == MAKH
                         select cus).Single();
                    if (cusToUpdate != null)
                    {
                        cusToUpdate.TenKH = txtName.Text.Trim();
                        cusToUpdate.Diachi = txtAddress.Text.Trim();
                        cusToUpdate.Ngaysinh = dtKH.Value;
                        cusToUpdate.Dienthoai = txtPhone.Text.Trim();
                        db.SaveChanges();
                    }
                    LoadCustomer();
                    //FillNoGirdView();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
