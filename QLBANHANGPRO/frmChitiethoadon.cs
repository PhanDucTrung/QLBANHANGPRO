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
    public partial class frmChitiethd : Form
    {
        public frmChitiethd()
        {
            InitializeComponent();
        }
        Ketnoidulieu kn = new Ketnoidulieu();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        int state;
        public void Loadgr()
        {
            string sqlkh = "SELECT* FROM HoaDon";
            cmbHd.DataSource = kn.Taobang(sqlkh);
            cmbHd.ValueMember = "MaHD";
            cmbHd.DisplayMember = "MaHD";
         
            string sqlnv = "SELECT* FROM SanPham";
            cmbSp.DataSource = kn.Taobang(sqlnv);
            cmbSp.ValueMember = "MaSP";
            cmbSp.DisplayMember = "TenSP";
            (dataGridView1.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlnv);
            (dataGridView1.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dataGridView1.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";
         
            string sqlhd = "select * from ChiTietHoaDon";
            dataGridView1.DataSource = kn.Taobang(sqlhd);
            dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0];
        }

        private void Loaddata()
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                txtSoluong.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                cmbHd.SelectedValue = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cmbSp.SelectedValue = dataGridView1.Rows[r].Cells[1].Value.ToString();
               

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void frmChitiethd_Load(object sender, EventArgs e)
        {
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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dong();    
            Loadgr();
            Loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = 1;
            Mo();
            txtSoluong.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = 2;
            Mo();
        }
        public void them()
        {
            string sql = "select * from ChiTietHoaDon where MaHD=@HD and MaSP=@SP";
            cmd = new SqlCommand(sql, kn.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@HD", SqlDbType.Int).Value = cmbHd.SelectedValue.ToString();
            cmd.Parameters.Add("@SP", SqlDbType.Int).Value = cmbSp.SelectedValue.ToString();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("hoa don nay da co san pham nay roi");
                reader.Close();
                return;

            }
            reader.Close();

            try
            {
                string sql1 = " insert into ChiTietHoaDon(MaHD,MaSP,SoLuong) values(@HD,@SP,@SL) ";
                cmd = new SqlCommand(sql1, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@SL", SqlDbType.Int).Value = txtSoluong.Text.Trim();
                cmd.Parameters.Add("@HD", SqlDbType.Int).Value = cmbHd.SelectedValue.ToString();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = cmbSp.SelectedValue.ToString();

                cmd.ExecuteNonQuery();
               
            }
            catch (Exception)
            {
                MessageBox.Show("khong thêm dc");
                return;
            }
           
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
                    string sql = "delete ChiTietHoaDon where MaHD=@HD and MaSP=@SP ";
                    cmd = new SqlCommand(sql, kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@HD", SqlDbType.Int).Value = cmbHd.SelectedValue.ToString();
                    cmd.Parameters.Add("@SP", SqlDbType.Int).Value = cmbSp.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                   
                    Loadgr();
                    Loaddata();
                }


            }
            kn.Myclosed();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            kn.Myopen();

            if (state == 1)
            {
                them();
                Loadgr();
                Loaddata();
               
            }
            else if (state == 2)
            {
                string sql2 = "select * from ChiTietHoaDon where MaHD=@HD and MaSP=@SP";
                cmd = new SqlCommand(sql2, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@HD", SqlDbType.Int).Value = cmbHd.SelectedValue.ToString();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = cmbSp.SelectedValue.ToString();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("hoa don nay da co san pham nay roi");
                    reader.Close();
                    return;

                }
                reader.Close();
                //them data moi
                try
                {
                    string sql1 = " insert into ChiTietHoaDon(MaHD,MaSP,SoLuong) values(@HD,@SP,@SL) ";
                    cmd = new SqlCommand(sql1, kn.conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@SL", SqlDbType.Int).Value = txtSoluong.Text.Trim();
                    cmd.Parameters.Add("@HD", SqlDbType.Int).Value = cmbHd.SelectedValue.ToString();
                    cmd.Parameters.Add("@SP", SqlDbType.Int).Value = cmbSp.SelectedValue.ToString();

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    MessageBox.Show("khong thêm dc");
                    return;
                }
                    

                //xoa du lieu cu
                string sql = "delete ChiTietHoaDon where MaHD=@HD and MaSP=@SP ";
                cmd = new SqlCommand(sql, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@HD", SqlDbType.Int).Value = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = dataGridView1.Rows[r].Cells[1].Value.ToString();
                cmd.ExecuteNonQuery();

              
                Loadgr();
                Loaddata();
            }
            kn.Myclosed();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.Myopen();
            string sql = "select ChiTietHoaDon.MaHD,HoaDon.NgayLapHD,HoaDon.NgayNhanHang  " +
                            "from HoaDon, ChiTietHoaDon where(ChiTietHoaDon.MaHD = HoaDon.MaHD and ChiTietHoaDon.MaHD = '"+cmbHd.SelectedValue+"')";
            dataGridView1.DataSource = kn.Taobang(sql);
        }
    }
}
