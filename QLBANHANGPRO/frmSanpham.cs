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
namespace QLBANHANGPRO
{
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }

        Ketnoidulieu kn = new Ketnoidulieu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        int state;
        public void Loadgr()
        {

            string sql = "SELECT* FROM SanPham";
            dataGridView1.DataSource = kn.Taobang(sql);
            dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0];
        }

        private void Loaddata()
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                txtSp.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                txtTensp.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                txtGia.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
                txtDv.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();



            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            try
            {

                kn.Myopen();
                MessageBox.Show("ket noi thanh cong");

            }
            catch
            {
                MessageBox.Show("ket noi sever that bai !");
            }
            try
            {
                Loadgr();
                Loaddata();
            }
            catch
            {
                MessageBox.Show("deo load dc !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }
        private void Mo()
        {
            btnOk.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        private void Dong()
        {
            btnOk.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
           txtSp.Enabled=true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dong();
            
            Loadgr();
            Loaddata();
        }
        public void Resetdata()
        {
            txtSp.Clear();
            txtGia.Clear();
            txtTensp.Clear();
            txtDv.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            state = 1;
            Mo();
            Resetdata();
            txtSp.Focus();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = 2;
            Mo();
            txtSp.Enabled = false;
            txtTensp.Focus();

        }
        public void Lam()
        {
            kn.Myopen();

            if (state == 1)
            {
                if (txtSp.Text == "")
                {
                    MessageBox.Show("ma khong dc de trong");
                    return;

                }
                string sql = "select * from SanPham where MaSP=@SP";
                cmd = new SqlCommand(sql, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSp.Text.Trim();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("da co ma  sp nay trong csdl nhap cai khac");
                    reader.Close();
                    return;

                }
                reader.Close();


                try
                {
                    string sql1 = " insert into SanPham(MaSP,TenSP,DonViTinh,Gia) values(@SP,@TSP,@DV,@GIA )";
                    cmd = new SqlCommand(sql1, kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSp.Text.Trim();
                    cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = txtTensp.Text.Trim();
                    cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = txtDv.Text.Trim();
                    cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = txtGia.Text.ToString();
                   
                    cmd.ExecuteNonQuery();
                    Loaddata();
                    Loadgr();
                }
                catch (Exception)
                {
                    MessageBox.Show("khong thêm dc");
                    return;
                }
            }
            else if (state == 2)
            {
                string sql3 = "update  SanPham set   TenSP=@TSP,DonViTinh=@DV, Gia=@GIA  where MaSP=@SP";
                cmd = new SqlCommand(sql3, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSp.Text.Trim();
                cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = txtTensp.Text.Trim();
                cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = txtDv.Text.Trim();
                cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = txtGia.Text.ToString();
                cmd.ExecuteNonQuery();
                Loaddata();
                Loadgr();
            }
            kn.Myclosed();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Myopen();
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("ban co muon xoa khong ?", "thong bao ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    string sql = "delete SanPham where MaSP=@SP ";
                    cmd = new SqlCommand(sql, kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSp.Text.Trim();
                    cmd.ExecuteNonQuery();
                    Loaddata();
                    Loadgr();

                }
            }
            kn.Myclosed();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Lam();
        }
    }
}
