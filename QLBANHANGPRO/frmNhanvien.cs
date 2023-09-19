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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }
        Ketnoidulieu cnn = new Ketnoidulieu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;

        int state;


        public void LoadGr()
        {

            string sql = "SELECT* FROM NhanVien";
            dgvNhanvien.DataSource = cnn.Taobang(sql);

        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            try
            {

                cnn.Myopen();
                MessageBox.Show("ket noi thanh cong");

            }
            catch
            {
                MessageBox.Show("ket noi sever that bai !");
            }
            try
            {
                LoadGr();
                Load_data();
            }
            catch
            {
                MessageBox.Show("deo load dc !");
            }
        }


        private void Load_data()
        {
            try
            {
                int r = dgvNhanvien.CurrentCell.RowIndex;

                txtNv.Text = dgvNhanvien.Rows[r].Cells[0].Value.ToString();
                txtTennv.Text = dgvNhanvien.Rows[r].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhanvien.Rows[r].Cells[3].Value.ToString();
                txtDienThoai.Text = dgvNhanvien.Rows[r].Cells[4].Value.ToString();
                dtpNv.Text = dgvNhanvien.Rows[r].Cells[5].Value.ToString();
               cmbGioitinh.SelectedIndex = Convert.ToBoolean(dgvNhanvien.Rows[r].Cells[2].Value.ToString()) == true ? 1:0;
               


            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }
        public void Mo()
        {
            btnGhi.Visible = true;
            btnKoGhi.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        public void Dong()
        {
            btnGhi.Visible = false;
            btnKoGhi.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            txtNv.Enabled = true;
        }
        public void Resetdata()
        {

            txtTennv.Clear();
            txtNv.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtNv.Focus();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            state = 1;
            Resetdata();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            state = 2;
            txtNv.Enabled = false;
        }

        private void btnKoGhi_Click(object sender, EventArgs e)
        {
            Dong();
            LoadGr();
            Load_data();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

            cnn.Myopen();
            if (state == 1)
            {

                if (txtNv.Text == "")
                {
                    MessageBox.Show("khong dc de trong ma nv");
                    return;
                }

                string sql1 = "select * from NhanVien where MaNV='" + txtNv.Text.Trim() + "'     ";
                cmd = new SqlCommand(sql1, cnn.conn);

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

                    //string sql2 = "insert into KhachHang(MaKH,TenKH,DiaChi,DienThoai,MaTP,GhiChu) " +
                    //"values('" + txtKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "',N'" + txtDienThoai.Text.Trim() + "','" + cmbTenTP.SelectedValue + "',N'" + txtGhiChu.Text.Trim() + "')";
                    string sql2 = "insert into NhanVien(MaNV,TenNV,GioiTinh,DiaChi,DienThoai,NgayNV) VALUES(@MNV,@TNV,@GT,@DC,@DT,@NNV)";
                    SqlCommand sqlCommand = new SqlCommand(sql2, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MNV", SqlDbType.Int).Value = txtNv.Text.Trim();
                    sqlCommand.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = txtTennv.Text.Trim();
                    sqlCommand.Parameters.Add("@GT", SqlDbType.Bit).Value = cmbGioitinh.SelectedIndex;
                    sqlCommand.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                    sqlCommand.Parameters.Add("@DT", SqlDbType.NVarChar).Value = txtDienThoai.Text.Trim();

                    sqlCommand.Parameters.Add("@NNV", SqlDbType.Date).Value = dtpNv.Text.Trim();
                    sqlCommand.ExecuteNonQuery();
                    LoadGr();
                    Load_data();
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
                    string sql3 = "update  NhanVien set TenNV=@TNV, GioiTinh=@GT,DiaChi=@DC, DienThoai=@DT,NgayNV=@NNV   where MaNV=@MNV";
                    SqlCommand sqlCommand = new SqlCommand(sql3, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MNV", SqlDbType.Int).Value = txtNv.Text.Trim();
                    sqlCommand.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = txtTennv.Text.Trim();
                    sqlCommand.Parameters.Add("@GT", SqlDbType.Bit).Value = cmbGioitinh.SelectedIndex;
                    sqlCommand.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                    sqlCommand.Parameters.Add("@DT", SqlDbType.NVarChar).Value = txtDienThoai.Text.Trim();
                    sqlCommand.Parameters.Add("@NNV", SqlDbType.Date).Value = dtpNv.Text.Trim();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("sua thanh cong");
                    LoadGr();
                    Load_data();
                }
                catch (Exception)
                {
                    MessageBox.Show("sua that bai");
                    return;
                }
            }
            cnn.Myclosed();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.Rows.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Ban có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    string sql = "delete  NhanVien where MaNV=@MNV";


                    SqlCommand sqlCommand = new SqlCommand(sql, cnn.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add("@MNV", SqlDbType.Int).Value = txtNv.Text.Trim();

                    cnn.Myopen();
                    sqlCommand.ExecuteNonQuery();

                    Load_data();
                    LoadGr();

                    cnn.Myclosed();
                }
            }
        }

    }
}
