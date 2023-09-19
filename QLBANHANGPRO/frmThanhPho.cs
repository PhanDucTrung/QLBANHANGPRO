using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANGPRO
{
    public partial class frmThanhPho : Form
    {
        public frmThanhPho()
        {
            InitializeComponent();
        }
        Ketnoidulieu cnn = new Ketnoidulieu();
        SqlDataReader reader = null;

        int state;
        public void load_gr()
        {
            string sql = "SELECT* FROM ThanhPho";
            dgvThanhpho.DataSource = cnn.Taobang(sql);
            dgvThanhpho.Rows[dgvThanhpho.RowCount - 2].Selected = true;
            dgvThanhpho.CurrentCell = dgvThanhpho.Rows[dgvThanhpho.RowCount - 2].Cells[0];
        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Myopen();
                MessageBox.Show("ketnoithanhcomg");
            }
            catch (Exception)
            {
                MessageBox.Show("ketnoithatbai");
                throw;
            }
            try
            {
                load_gr();
                load_data();
            }
            catch (Exception)
            {
                MessageBox.Show("loi load len bang or len textbox");
                throw;
            }

        }
        public void load_data()
        {
            try
            {
                int r = dgvThanhpho.CurrentCell.RowIndex;
                txtMatp.Text = dgvThanhpho.Rows[r].Cells[0].Value.ToString();
                txtTentp.Text = dgvThanhpho.Rows[r].Cells[1].Value.ToString();
                //txtGhichu.Text = dgvThanhpho.Rows[r].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("khong co data");

            }
        }
        public void mo()
        {
            btnGhi.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        public void dong()
        {
            txtMatp.Enabled = true;
            btnGhi.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }
        public void resetdata()
        {
            txtTentp.Clear();
            txtMatp.Clear();
        }

        private void dgvThanhpho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mo();
            resetdata();
            state = 1;
            txtMatp.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMatp.Enabled = false;
            mo();
            state = 2;
            txtTentp.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThanhpho.Rows.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Ban có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    string sql = "delete  ThanhPho where MaTP=@MTP";


                    SqlCommand sqlCommand = new SqlCommand(sql, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MTP", SqlDbType.Int).Value = txtMatp.Text.Trim();

                    cnn.Myopen();
                    sqlCommand.ExecuteNonQuery();

                    load_gr();
                    load_data();

                    cnn.Myclosed();
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

            if (state == 1)
            {
                if (txtMatp.Text == "")
                {
                    MessageBox.Show("thieu ma tp");
                    return;
                }
                try
                {
                    int.Parse(txtMatp.Text);
                }

                catch (Exception)
                {
                    MessageBox.Show("sai Mã");
                    return;
                }
                string sql1 = "select * from KhachHang where MaTP=@MTP";
                SqlCommand sqlCommand = new SqlCommand(sql1, cnn.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add("@MTP", SqlDbType.Int).Value = txtMatp.Text.Trim();
                cnn.Myopen();
                reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("da co ma khach hang nay nhap cai khac");
                    reader.Close();
                    return;
                }
                reader.Close();


                try
                {
                    string sql = "insert into thanhpho(MaTP,TenTP) values(@MTP,@TP)";
                    sqlCommand = new SqlCommand(sql, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MTP", SqlDbType.Int).Value = txtMatp.Text.Trim();
                    sqlCommand.Parameters.Add("@TP", SqlDbType.NVarChar).Value = txtTentp.Text.Trim();
                    //sqlCommand.Parameters.Add("@GC", SqlDbType.NVarChar).Value = txtGhichu.Text.Trim();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("them thanh cong");
                    load_data();
                    load_gr();



                }
                catch (Exception)
                {

                    MessageBox.Show("them that bai");
                    return;
                }
                cnn.Myclosed();
            }
            if (state == 2)
            {
                try
                {
                    string sql3 = "update  thanhpho set TenTP=@TP   where MaTP=@MTP";
                    SqlCommand sqlCommand = new SqlCommand(sql3, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MTP", SqlDbType.Int).Value = txtMatp.Text.Trim();
                    sqlCommand.Parameters.Add("@TP", SqlDbType.NVarChar).Value = txtTentp.Text.Trim();
                    //sqlCommand.Parameters.Add("@GC", SqlDbType.NVarChar).Value = txtGhichu.Text.Trim();
                    cnn.Myopen();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("sua thanh cong");
                    load_data();
                    load_gr();
                }
                catch (Exception)
                {
                    MessageBox.Show("sua that bai");
                    return;

                }
                cnn.Myclosed();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dong();
            load_gr();
            load_data();
        }
    }
}
