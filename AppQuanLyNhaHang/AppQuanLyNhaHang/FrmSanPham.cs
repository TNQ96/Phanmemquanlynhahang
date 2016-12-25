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
    public partial class FrmSanPham : Form
    {
        
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            
            LoadProduct();
            FillNoGirdView();
            FillCombo();
            
        }
        private void LoadProduct()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from prd in db.SanPham
                                select new
                                {
                                    MaSP = prd.MaSP,
                                    TenSP = prd.TenSP,
                                    DonViTinh = prd.Donvitinh,
                                    DonGia = prd.Dongia,
                                    MaLoaiSP = prd.MaLoaiSP,
                                    HinhSP=prd.HinhSP
                                };
                    
                    dgvSanPham.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void FillNoGirdView()
        {
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                dgvSanPham["STT", i].Value = i + 1;
        }
        private void FillCombo()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from prd in db.LoaiSP
                                select new
                                {
                                    MaLoaiSP = prd.MaLoaiSP,
                                    TenLoaiSP = prd.TenLoaiSP
                                };
                    cbbMaLoaiSP.DataSource = query.ToList();
                    cbbMaLoaiSP.DisplayMember = "TenLoaiSP";
                    cbbMaLoaiSP.ValueMember = "MaLoaiSP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var prd = new SanPham()
                    {
                        MaSP = txtMaSP.Text.Trim(),
                        TenSP = txtTenSP.Text.Trim(),
                        Dongia = double.Parse(txtDonGia.Text.Trim()),
                        Donvitinh = txtDVT.Text.Trim(),
                        MaLoaiSP = int.Parse(cbbMaLoaiSP.SelectedValue.ToString())

                    };
                    db.SanPham.AddObject(prd);
                    db.SaveChanges();
                    LoadProduct();
                    FillNoGirdView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
             {
                using (var db = new NhaHangHanEntities())
                {
                    SanPham prdToDelete =
                        (from prd in db.SanPham
                         where prd.MaSP == txtMaSP.Text
                         select prd).Single();
                    if (prdToDelete != null)
                    {
                        db.SanPham.DeleteObject(prdToDelete);
                        db.SaveChanges();
                    }
                }
                LoadProduct();
                FillNoGirdView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    SanPham prdToUpdate =
                        (from prd in db.SanPham
                         where prd.MaSP == txtMaSP.Text.Trim()
                         select prd).Single();
                    if (prdToUpdate != null)
                    {
                        prdToUpdate.TenSP = txtTenSP.Text.Trim();
                        prdToUpdate.Donvitinh = txtDVT.Text.Trim();
                        prdToUpdate.Dongia = double.Parse(txtDonGia.Text.Trim());
                        prdToUpdate.MaLoaiSP = int.Parse(cbbMaLoaiSP.SelectedValue.ToString());
                        db.SaveChanges();
                    }
                    LoadProduct();
                    FillNoGirdView();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            txtDVT.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[index].Cells[4].Value.ToString();
            cbbMaLoaiSP.Text = dgvSanPham.Rows[index].Cells[5].Value.ToString();
        }
        private void dgvHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNoGirdView();
        }

        private void dgvHangHoa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNoGirdView();
        }

        private void FrmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmQuanLy f = new FrmQuanLy();
            f.Show();
            this.Hide();
        }
     }
}
