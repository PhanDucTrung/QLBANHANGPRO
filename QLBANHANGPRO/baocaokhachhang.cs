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
using Microsoft.Reporting.WinForms;

namespace QLBANHANGPRO
{
    public partial class baocaokhachhang : Form
    {
        public baocaokhachhang()
        {
            InitializeComponent();
        }
        Ketnoidulieu kn= new Ketnoidulieu();
        private void baocaokhachhang_Load(object sender, EventArgs e)
        {
            kn.Myopen();

            string sql = "select KhachHang.MaKH,KhachHang.TenCongTy,KhachHang.DiaChi,ThanhPho.TenTP,KhachHang.DienThoai from KhachHang  join ThanhPho on KhachHang.MaTP=ThanhPho.MaTP where (KhachHang.MaTP=ThanhPho.MaTP and KhachHang.MaTP='" +frmKhachhang.tp+ "')";

            //string sql = frmKhachhang.tp;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, kn.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"khachhang");

           
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANGPRO.Report1.rdlc";
            ReportDataSource report = new ReportDataSource();
            report.Name = "DataSet1";
            report.Value = ds.Tables["khachhang"];
            reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
