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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Ketnoidulieu kn =new Ketnoidulieu();
        private void caoNguToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmHoadon frm = new frmHoadon();
            frm.ShowDialog();   
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frm=new frmNhanvien();
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChitiethd frm = new frmChitiethd();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhPho frm =new frmThanhPho();
            frm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham frm=new frmSanpham();
            frm.ShowDialog();
        }
    }
}
