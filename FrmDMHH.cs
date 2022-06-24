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

namespace LopPTUD2022_Sang
{
    public partial class FrmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        String sql, constr;
        int i;

        public FrmDMHH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void FrmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BHJG7MK\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaNhom, MaHH, TenHH, dvt, dgvnd, sanxuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDonGia.Text = grdData.Rows[i].Cells["dgvnd"].Value.ToString();
            txtSanXuat.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
            

        }
    }
}
