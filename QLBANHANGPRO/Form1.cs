using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANGPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ketnoidulieu kn =new Ketnoidulieu();
        public void Loadgr()
        {
            //string sqlkh = "SELECT* FROM KhachHang";
            //cmbKh.DataSource = kn.Taobang(sqlkh);
            //cmbKh.ValueMember = "MaKH";
            //cmbKh.DisplayMember = "TenCongTy";

            //(dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlkh);
            //(dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCongTy";
            //(dataGridView1.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            //string sqlnv = "SELECT* FROM NHanVien";
            //cmbNv.DataSource = kn.Taobang(sqlnv);
            //cmbNv.ValueMember = "MaNV";
            //cmbNv.DisplayMember = "TenNV";
            //(dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = kn.Taobang(sqlnv);
            //(dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "TenNV";
            //(dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
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

        //private void Loaddata()
        //{
        //    try
        //    {
        //        int r = dataGridView1.CurrentCell.RowIndex;

        //        txtMahd.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
        //        cmbKh.SelectedValue = dataGridView1.Rows[r].Cells[1].Value.ToString();
        //        cmbNv.SelectedValue = dataGridView1.Rows[r].Cells[2].Value.ToString();
        //        dtpLaphd.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        //        dtpNhanhang.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();

        //    }
        //    catch
        //    {
        //        MessageBox.Show("chọn vùng không có thông tin");
        //    }

        //}
        private void Form1_Load(object sender, EventArgs e)
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
                //Loaddata();
            }
            catch (Exception)
            {
                MessageBox.Show("khong tai uoc du lieu len bang");


            }

        }
    }
}
