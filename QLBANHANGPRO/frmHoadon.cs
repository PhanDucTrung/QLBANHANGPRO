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
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        Ketnoidulieu kn = new Ketnoidulieu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        int state;
       
        
        public void Phanquyen()
        {

            if (frmDangnhap.CurrentPermision== "Read only")
            {
                ok();
            }





        }
      

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            Phanquyen();
            try
            {
                kn.Myopen();
               
            }
            catch (Exception)
            {
                MessageBox.Show("khong ket noi dc voi database");
                throw;
            }
            try
            {
                Loadgr();
                Loaddata();
            }
            catch (Exception)
            {
                MessageBox.Show("khong tai uoc du lieu len bang");
                
           
            }
        }
        public void ok()
        {
            btnHuy.Enabled = false;
            btnOk.Enabled = false;
            btnSua.Enabled = false; 
            btnThem.Visible = false;
            btnXoa.Enabled = false;
            btnLoc.Enabled = false;
            btnNv.Enabled = false;
            btnTim.Enabled = false;
        }
        public void Loadgr()
        {
            string sqlkh = "SELECT* FROM KhachHang";
            cmbKh.DataSource=kn.Taobang(sqlkh);
            cmbKh.ValueMember = "MaKH";
            cmbKh.DisplayMember = "TenCongTy";

            (dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlkh);
            (dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCongTy";
            (dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            string sqlnv = "SELECT* FROM NHanVien";
            cmbNv.DataSource = kn.Taobang(sqlnv);
            cmbNv.ValueMember = "MaNV";
            cmbNv.DisplayMember = "TenNV";
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlnv);
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "TenNV";
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
            //string sqlhd = "SELECT dbo.HoaDon.MaHD,dbo.KhachHang.TenCongTy" +
            //    ",dbo.NhanVien.TenNV,NgayLapHD,NgayNhanHang " +
            //    "FROM HoaDon JOIN dbo.KhachHang ON	KhachHang.MaKH = HoaDon.MaKH " +
            //    "JOIN dbo.NhanVien ON NhanVien.MaNV = HoaDon.MaNV";
            string sqlhd = "select * from HoaDon";
            dataGridView1.DataSource = kn.Taobang(sqlhd);
            dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0];
            string sqlsp = "SELECT* FROM SanPham";
            cmbSp.DataSource = kn.Taobang(sqlsp);
            cmbSp.ValueMember = "MaSP";
            cmbSp.DisplayMember = "TenSP";
        }

        private void Loaddata()
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                txtMahd.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();    
                cmbKh.SelectedValue = dataGridView1.Rows[r].Cells[1].Value.ToString();
                cmbNv.SelectedValue = dataGridView1.Rows[r].Cells[2].Value.ToString();
                dtpLaphd.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
                dtpNhanhang.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
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
            txtMahd.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dong();
            Loaddata();
            Loadgr();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = 1;
            Mo();
            txtMahd.Clear();
            txtMahd.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = 2;
            Mo();
            txtMahd.Enabled = false;
            
        }
        public void Lam()
        {
            kn.Myopen();

            if (state == 1)
            {
                if (txtMahd.Text == "")
                {
                    MessageBox.Show("ma khong dc de trong");
                    return;

                }
                string sql = "select * from HoaDon where MaHD=@HD";
                cmd = new SqlCommand(sql, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@HD", SqlDbType.Int).Value = txtMahd.Text.Trim();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("da co ma hd nay trong csdl nhap cai khac");
                    reader.Close();
                    return;

                }
                reader.Close();


                try
                {
                    string sql1 = " insert into HoaDon(MaHD,MaKH,MaNV,NgayLapHD,NgayNhanHang) values(@HD,@KH,@NV,@LHD,@NH) ";
                    cmd = new SqlCommand(sql1, kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@HD", SqlDbType.Int).Value = txtMahd.Text.Trim();
                    cmd.Parameters.Add("@KH", SqlDbType.Int).Value = cmbKh.SelectedValue.ToString();
                    cmd.Parameters.Add("@NV", SqlDbType.Int).Value = cmbNv.SelectedValue.ToString();
                    cmd.Parameters.Add("@LHD", SqlDbType.Date).Value = dtpLaphd.Text.ToString();
                    cmd.Parameters.Add("@NH", SqlDbType.Date).Value = dtpNhanhang.Text.ToString();
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
                string sql3 = "update  HoaDon set NgayNhanHang=@NH  ,MaKH=@KH,MaNV=@NV, NgayLapHD=@LHD  where MaHD=@HD";
                cmd = new SqlCommand(sql3, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@HD", SqlDbType.Int).Value = txtMahd.Text.Trim();
                cmd.Parameters.Add("@KH", SqlDbType.Int).Value = cmbKh.SelectedValue.ToString();
                cmd.Parameters.Add("@NV", SqlDbType.Int).Value = cmbNv.SelectedValue.ToString();
                cmd.Parameters.Add("@LHD", SqlDbType.Date).Value = dtpLaphd.Value.ToString();
                cmd.Parameters.Add("@NH", SqlDbType.Date).Value = dtpNhanhang.Value.ToString();
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
                    string sql = "delete HoaDon where MaHD=@HD ";
                    cmd = new SqlCommand(sql,kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@HD", SqlDbType.Int).Value = txtMahd.Text.Trim();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
           
                kn.Myopen();
                string sql = "select HoaDon.MaHD,KhachHang.TenCongTy,NhanVien.TenNV,HoaDon.NgayLapHD,HoaDon.NgayNhanHang " +
                                "from HoaDon, KhachHang, NhanVien where(HoaDon.MaKH = KhachHang.MaKH and HoaDon.MaNV = NhanVien.MaNV and HoaDon.MaKH = '" + cmbKh.SelectedValue + "')";
                dataGridView1.DataSource = kn.Taobang(sql);
          
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            kn.Myopen();
            string sql = "select HoaDon.MaHD,HoaDon.MaKH,HoaDon.MaNV,HoaDon.NgayLapHD,HoaDon.NgayNhanHang,ChiTietHoaDon.MaSP from ChiTietHoaDon,HoaDon,SanPham " +
                            "where(HoaDon.MaHD = ChiTietHoaDon.MaHD and ChiTietHoaDon.MaSP = SanPham.MaSP and SanPham.MaSP = '"+cmbSp.SelectedValue+"')";
            dataGridView1.DataSource = kn.Taobang(sql);
        }

        private void btnNv_Click(object sender, EventArgs e)
        {
            kn.Myopen();
            string sql = "select HoaDon.MaHD,NhanVien.TenNV,HoaDon.NgayLapHD,HoaDon.NgayNhanHang " +
                            "from HoaDon, NhanVien where(HoaDon.MaNV = NhanVien.MaNV and HoaDon.MaNV = '" + cmbNv.SelectedValue + "')";
            dataGridView1.DataSource = kn.Taobang(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Loadgr();
            Loaddata();
        }

        private void cmbSp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
