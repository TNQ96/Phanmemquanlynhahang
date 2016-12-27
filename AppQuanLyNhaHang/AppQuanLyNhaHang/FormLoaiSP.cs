using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AppQuanLyNhaHang
{
    public partial class FormLoaiSP : Form
    {
        string cnStr;
        SqlConnection cn;

        public FormLoaiSP()
        {
            InitializeComponent();
        }

        // 
        private void Form1_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            LoadData(); // Load data from Database to GridView
            FillNoGirdView();
        }

        private void FillNoGirdView()
        {
            for (int i = 0; i < grvData.Rows.Count; i++)
                grvData["STT", i].Value = i + 1;
        }

        private void LoadData ()
        {
            try {
                using (var db = new NhaHangHanEntities())
                {
                    var query = from prd in db.LoaiSP // Query dữ liệu từ bảng LoaiSP
                                select new
                                {
                                    MaLoaiSP = prd.MaLoaiSP,
                                    TenLoaiSP = prd.TenLoaiSP
                                };

                    grvData.DataSource = query.ToList(); // Đưa dữ liệu vào GridView
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenHH.Text.Trim() != "")
                {
                    // Thêm dữ liệu vào database
                    using (var db = new NhaHangHanEntities())
                    {
                        // Tạo biến chứa dữ liệu loại sản phẩm
                        var prd = new LoaiSP()
                        {
                            TenLoaiSP = txtTenHH.Text.Trim()
                        };
                        db.LoaiSP.AddObject(prd);
                        db.SaveChanges();
                        LoadData();
                        FillNoGirdView();
                    }
                }
                else
                {
                    MessageBox.Show("Please specify required field(s)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenHH.Text.Trim() != "")
                {
                    int maHH = int.Parse(txtMaHang.Text);
                    using (var db = new NhaHangHanEntities())
                    {
                        LoaiSP prdToUpdate =
                            (from prd in db.LoaiSP
                             where prd.MaLoaiSP == maHH
                             select prd).Single();
                        if (prdToUpdate != null)
                        {
                            prdToUpdate.TenLoaiSP = txtTenHH.Text.Trim();
                            db.SaveChanges();
                        }
                        LoadData();
                        FillNoGirdView();
                    }
                }
                else
                {
                    MessageBox.Show("Please specify required field(s)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int maHH = int.Parse(txtMaHang.Text);
                using (var db = new NhaHangHanEntities())
                {
                    LoaiSP prdToDelete =
                        (from prd in db.LoaiSP
                         where prd.MaLoaiSP == maHH
                         select prd).Single();
                    if (prdToDelete != null)
                    {
                        db.LoaiSP.DeleteObject(prdToDelete);
                        db.SaveChanges();
                    }
                }
                LoadData();
                FillNoGirdView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLoaiSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmQuanLy f = new FrmQuanLy();
            f.Show();
            this.Hide();
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHang.Text = grvData.Rows[index].Cells[1].Value.ToString();
            txtTenHH.Text = grvData.Rows[index].Cells[2].Value.ToString();
        }

        private void grvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillNoGirdView();
        }

        private void grvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillNoGirdView();
        }
    }
}
