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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
            
        }
        SqlDataReader rd = null;
        SqlCommand cmd = null;
       Ketnoidulieu kn= new Ketnoidulieu();
        public static string CurrentPermision;
        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDn_Click(object sender, EventArgs e)
        {

            kn.Myopen();

           
            //cmbQuyen.DataSource=kn.Taobang(sqlDataset);
            //cmbQuyen.DisplayMember = "name_per";


            string sql1 = "SELECT  permision.id_per,name_user,user_name,pass,name_per " +
                "FROM dbo.users JOIN dbo.per_relationship ON per_relationship.id_user = users.id_user " +
                "JOIN dbo.permision ON	permision.id_per = per_relationship.id_per " +
                " where user_name='" + txtTk.Text.Trim() + "' and pass='" + txtMk.Text.Trim() + "' ";
            //cmbQuyen.DataSource = kn.Taobang(sql1);
            //cmbQuyen.DisplayMember = "name_per";
            //cmbQuyen.ValueMember = "permision.id_per";
          


            cmd = new SqlCommand(sql1, kn.conn);
           
            rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Close();
                //     string sqlDataset = "SELECT name_per  " +
                //                     "FROM   dbo.permision,dbo.users,dbo.per_relationship" +
                //"WHERE per_relationship.id_user = users.id_user " +
                //"AND permision.id_per = per_relationship.id_per " +
                //"AND users.user_name=N'" + txtTk.Text.Trim() + "'" +
                //"AND  dbo.users.pass=N'" + txtMk.Text.Trim() + "'";
                string sql = $"SELECT dbo.permision.name_per\r\nFROM dbo.users,dbo.permision,dbo.per_relationship\r\nWHERE dbo.users.id_user = dbo.per_relationship.id_user\r\nAND dbo.per_relationship.id_per = dbo.permision.id_per\r\nAND dbo.users.user_name = N'{txtTk.Text.Trim()}' AND dbo.users.pass = N'{txtMk.Text.Trim()}'";

                DataTable dt = kn.Taobang(sql);
                DataRow firstRow = dt.Rows[0];
               CurrentPermision = firstRow["name_per"].ToString();
                MessageBox.Show("wellcome");

                frmMain frm = new frmMain();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("sai acc or pass");
                rd.Close();
                return;
            }









        }
    }
}
