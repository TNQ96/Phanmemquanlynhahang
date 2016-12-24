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

namespace QLNhaHang
{
    public partial class FormLoaiSP : Form
    {
        public FormLoaiSP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Thêm_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FillNOGridview()
        {
            for (int i = 0; i < grvData.Rows.Count; i++)
                grvData["STT", i].Value = i + 1;
        }
        private void LoadData ()
        {
            //1: Tao ket noi
            string strCon = @"server=.\sqlexpress;
                            database=NhaHangHan;
                            interated security=true;";
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                //2: thao tac
                string strQuery = "LoaiSP";
                SqlCommand cmd = new SqlCommand(strQuery, sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtHang = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtHang);

                grvData.DataSource = dtHang;

            }
            catch (Exception)
            {
                MessageBox.Show("Loi:" + ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
