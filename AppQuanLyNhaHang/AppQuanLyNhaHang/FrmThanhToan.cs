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
    public partial class FrmThanhToan : Form
    {
        DataTable dtDSCT = new System.Data.DataTable();
        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadcbbNhanVien();
            LoadcbbKhachHang();
            LoadcbbHangHoa();
            loadDonGia();
        }
        private void LoadcbbHangHoa()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from prd in db.SanPham
                                select new
                                {
                                    MaSP = prd.MaSP,
                                    TenSP = prd.TenSP
                                };
                    cbbSanPham.DataSource = query.ToList();
                    cbbSanPham.DisplayMember = "TenSP";
                    cbbSanPham.ValueMember = "MaSP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadcbbNhanVien()
        {
            try
             {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from emp in db.NhanVien
                                select new
                                {
                                    MaNV = emp.MaNV,
                                    TenNV = emp.TenNV
                                };
                    cbbNhanVien.DataSource = query.ToList();
                    cbbNhanVien.DisplayMember = "TenNV";
                    cbbNhanVien.ValueMember = "MaNV";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadcbbKhachHang()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from cus in db.KhachHang
                                select new
                                {
                                    MaKH = cus.MaKH,
                                    TenKH = cus.TenKH
                                };
                    cbbKhachHang.DataSource = query.ToList();
                    cbbKhachHang.DisplayMember = "TenKH";
                    cbbKhachHang.ValueMember = "MaKH";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadHoaDon()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from HD in db.HoaDon
                                select new
                                {
                                    MaHD = HD.MaHD,
                                    MaKH = HD.MaKH,
                                    MaNV = HD.MaNV,
                                    NgayLap = HD.NgayLapHD
                                };
                    dgvDSHD.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*private void LoadCTHD()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from CTHD in db.CTDH
                                select new
                                {
                                    MaHD = CTHD.MaHD,
                                    MaSP = CTHD.MaSP,
                                    SoLuong = CTHD.Soluong
                                };
                    dgvDSHH.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void btAddHD_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var HD = new HoaDon()
                    {
                        MaHD = int.Parse(txtMaHD.Text.Trim()),
                        MaKH = int.Parse(cbbKhachHang.SelectedValue.ToString()),
                        MaNV = int.Parse(cbbNhanVien.SelectedValue.ToString()),
                        NgayLapHD = datetimeHD.Value
                    };
                    db.HoaDon.AddObject(HD);
                    db.SaveChanges();
                    FrmThanhToan_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=e.RowIndex;
            txtMaHD.Text = dgvDSHD.Rows[index].Cells[0].Value.ToString();
            cbbNhanVien.Text = dgvDSHD.Rows[index].Cells[1].Value.ToString();
            cbbKhachHang.Text = dgvDSHD.Rows[index].Cells[2].Value.ToString();
            datetimeHD.Value = DateTime.Parse(dgvDSHD.Rows[index].Cells[3].Value.ToString());
        }
        private void btDelHD_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var MAHD = int.Parse(txtMaHD.Text);
                    HoaDon HDToDelete =
                        (from HD in db.HoaDon
                         where HD.MaHD == MAHD
                         select HD).Single();
                    if (HDToDelete != null)
                    {
                        db.HoaDon.DeleteObject(HDToDelete);
                        db.SaveChanges();
                    }
                }
                FrmThanhToan_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btPrintHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nâng cấp");
        }

        private void btAddSP_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaHD.Text))
            {
                try
                {
                    using (var db = new NhaHangHanEntities())
                    {
                        var SLuong = short.Parse(txtSoLuong.Text.Trim());
                        var CTDH = new CTDH
                        {
                            MaHD = int.Parse(txtMaHD.Text.Trim()),
                            MaSP= cbbSanPham.SelectedValue.ToString(),
                            Soluong=SLuong
                        };
                        db.CTDH.AddObject(CTDH);
                        db.SaveChanges();
                        FrmThanhToan_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống!");
                txtMaHD.Focus();
            }
        }
        private void loadDonGia()
        {
            try
            {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from prd in db.SanPham
                                where prd.MaSP == cbbSanPham.SelectedValue.ToString()
                                select prd.Dongia;
                    txtDonGia.Text = query.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
