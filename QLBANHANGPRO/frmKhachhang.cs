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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }
        Ketnoidulieu kn = new Ketnoidulieu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        int state;
        public static string tp = null;
        public void Loadgr()
        {
            string sqlThanhPho = "SELECT* FROM ThanhPho";
            cmbTenTP.DataSource = kn.Taobang(sqlThanhPho);
            cmbTenTP.DisplayMember = "TenTP";
            cmbTenTP.ValueMember = "MaTP";

            (dataGridView1.Columns["MaTP"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlThanhPho);
            (dataGridView1.Columns["MaTP"] as DataGridViewComboBoxColumn).DisplayMember = "TenTP";
            (dataGridView1.Columns["MaTP"] as DataGridViewComboBoxColumn).ValueMember = "MaTP";
            string sqlKhachHang = "SELECT* FROM KhachHang";
            dataGridView1.DataSource = kn.Taobang(sqlKhachHang);
            dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0];
        }

        private void Loaddata()
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                txtKH.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                txtDienThoai.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
                txtTP.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
              
                cmbTenTP.SelectedValue = dataGridView1.Rows[r].Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void txtDt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachhang_Load(object sender, EventArgs e)
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
            {kn.Myclosed();
                MessageBox.Show("deo load dc !");
            }
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }
        public void mo()
        {
            btnOk.Visible = true;
            btnHuy.Visible = true;

            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        public void dong()
        {
            btnOk.Visible = false;
            btnHuy.Visible = false;

            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }
        private void Data_alt()
        {
            kn.Myopen();
            if (state == 1)
            {
                // Kiêm tra điều kiện Mã khách hàng để trống
                if (txtKH.Text == "")
                {
                    MessageBox.Show("Mã khách hàng không được để trống!!!");
                    return;
                }

                try
                {
                    int.Parse(txtKH.Text);
                }

                catch (Exception)
                {
                    MessageBox.Show("sai Mã");
                    return;
                }
                //Kiểm tra điều kiện mã khách hàng bị trùng
                string sql1 = "select * from KhachHang where MaKH='" + txtKH.Text.Trim() + "'     ";
                cmd = new SqlCommand(sql1, kn.conn);
                ;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Mã khách hàng đã có trong CSDL, nhập mã khác!!!");
                    reader.Close();
                    return;
                }
                reader.Close();
                try
                {

                  
                    string sql2 = "insert into KhachHang(MaKH,TenCongTy,DiaChi,DienThoai,MaTP) VALUES(@MKH,@TKH,@DC,@DT,@MTP)";
                    SqlCommand sqlCommand = new SqlCommand(sql2, kn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MKH", SqlDbType.Int).Value = txtKH.Text.Trim();
                    sqlCommand.Parameters.Add("@TKH", SqlDbType.NVarChar).Value = txtTenKH.Text.Trim();
                    sqlCommand.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                    sqlCommand.Parameters.Add("@DT", SqlDbType.NVarChar).Value = txtDienThoai.Text.Trim();
                    sqlCommand.Parameters.Add("@MTP", SqlDbType.Int).Value = cmbTenTP.SelectedValue.ToString();
                 
                    sqlCommand.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    Loadgr();
                    Loaddata();

                }
                catch (Exception)
                {

                    MessageBox.Show("Thêm khách hàng thất bại!!!");
                    return;
                }

            }


            else if (state == 2)
            {
                try
                {
                    string sql = "update KhachHang set TenCongTy=@TKH,DiaChi=@DC,DienThoai=@DT,MaTP=@MTP where MaKH=@MKH";
                    cmd = new SqlCommand(sql, kn.conn);
                    cmd.Parameters.Add("@MKH", SqlDbType.Int).Value = txtKH.Text.Trim();
                    cmd.Parameters.Add("@TKH", SqlDbType.NVarChar).Value = txtTenKH.Text.Trim();
                    cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                    cmd.Parameters.Add("@DT", SqlDbType.NVarChar).Value = txtDienThoai.Text.Trim();
                    cmd.Parameters.Add("@MTP", SqlDbType.Int).Value = cmbTenTP.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                    Loadgr();
                    Loaddata();
                    ;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi sửa dữ liệu khách hàng");
                    return;
                }
            }

            kn.Myclosed();
        }
        public void resetdata()
        {
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtTP.Clear();
            txtKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mo();
            resetdata();
            state = 1;
            txtKH.Clear();
            txtKH.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Data_alt();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dong();
            txtKH.Enabled = true;
            Loadgr();
            Loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtKH.Enabled = false;
            state = 2;
            mo();
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Ban có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    string sql = "delete KhachHang where MaKH='" + txtKH.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, kn.conn);
                    kn.Myopen();

                    cmd.ExecuteNonQuery();
                    Loadgr();
                    Loaddata();

                    kn.Myclosed();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           kn.Myopen();
            //string sql = "select KhachHang.MaKH,KhachHang.TenCongTy,KhachHang.DiaChi,ThanhPho.MaTP,KhachHang.DienThoai " +
            //                "from KhachHang, ThanhPho where(KhachHang.MaTP = ThanhPho.MaTP and KhachHang.MaTP ='" + cmbTenTP.SelectedValue + "')";
            string sql = "select KhachHang.MaKH,KhachHang.TenCongTy,KhachHang.DiaChi,ThanhPho.TenTP,KhachHang.DienThoai from KhachHang  join ThanhPho on KhachHang.MaTP=ThanhPho.MaTP where (KhachHang.MaTP=ThanhPho.MaTP and KhachHang.MaTP='" + txtDienThoai.Text.Trim() + "')";

            tp = cmbTenTP.SelectedValue.ToString(); ;
            dataGridView1.DataSource=kn.Taobang(sql);
            //SqlDataAdapter adapter = new SqlDataAdapter(sql, kn.conn);
            //DataSet ds = new DataSet();");
            //adapter.Fill(ds, "khachhang

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baocaokhachhang frm = new baocaokhachhang();
            frm.ShowDialog();
        }
    }

}
