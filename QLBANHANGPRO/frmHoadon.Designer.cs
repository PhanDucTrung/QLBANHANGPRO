namespace QLBANHANGPRO
{
    partial class frmHoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.dtpLaphd = new System.Windows.Forms.DateTimePicker();
            this.dtpNhanhang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNv = new System.Windows.Forms.ComboBox();
            this.cmbKh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnNv = new System.Windows.Forms.Button();
            this.cmbSp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.NgayNhanHang});
            this.dataGridView1.Location = new System.Drawing.Point(33, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Tên Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Tên Nhân Viên ";
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Lập HD";
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // NgayNhanHang
            // 
            this.NgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.NgayNhanHang.HeaderText = "Ngày Nhận Hàng";
            this.NgayNhanHang.Name = "NgayNhanHang";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(619, 143);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 50);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(619, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(619, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 50);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(619, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 50);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(619, 308);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 50);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(97, 85);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(100, 20);
            this.txtMahd.TabIndex = 8;
            // 
            // dtpLaphd
            // 
            this.dtpLaphd.Location = new System.Drawing.Point(337, 123);
            this.dtpLaphd.Name = "dtpLaphd";
            this.dtpLaphd.Size = new System.Drawing.Size(200, 20);
            this.dtpLaphd.TabIndex = 11;
            // 
            // dtpNhanhang
            // 
            this.dtpNhanhang.Location = new System.Drawing.Point(536, 91);
            this.dtpNhanhang.Name = "dtpNhanhang";
            this.dtpNhanhang.Size = new System.Drawing.Size(200, 20);
            this.dtpNhanhang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Hóa Đơn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày Lập Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Nhận Hàng";
            // 
            // cmbNv
            // 
            this.cmbNv.FormattingEnabled = true;
            this.cmbNv.Location = new System.Drawing.Point(304, 91);
            this.cmbNv.Name = "cmbNv";
            this.cmbNv.Size = new System.Drawing.Size(121, 21);
            this.cmbNv.TabIndex = 13;
            // 
            // cmbKh
            // 
            this.cmbKh.FormattingEnabled = true;
            this.cmbKh.Location = new System.Drawing.Point(96, 114);
            this.cmbKh.Name = "cmbKh";
            this.cmbKh.Size = new System.Drawing.Size(121, 21);
            this.cmbKh.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(233, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "DANH SÁCH HÓA ĐƠN\r\n";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(754, 252);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(78, 58);
            this.btnLoc.TabIndex = 33;
            this.btnLoc.Text = "hd theo kh";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(754, 130);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 38);
            this.btnTim.TabIndex = 34;
            this.btnTim.Text = "hd theo sp";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // btnNv
            // 
            this.btnNv.Location = new System.Drawing.Point(754, 198);
            this.btnNv.Name = "btnNv";
            this.btnNv.Size = new System.Drawing.Size(85, 38);
            this.btnNv.TabIndex = 34;
            this.btnNv.Text = "hd theo nv";
            this.btnNv.UseVisualStyleBackColor = true;
            this.btnNv.Click += new System.EventHandler(this.btnNv_Click);
            // 
            // cmbSp
            // 
            this.cmbSp.FormattingEnabled = true;
            this.cmbSp.Location = new System.Drawing.Point(580, 47);
            this.cmbSp.Name = "cmbSp";
            this.cmbSp.Size = new System.Drawing.Size(121, 21);
            this.cmbSp.TabIndex = 35;
            this.cmbSp.SelectedIndexChanged += new System.EventHandler(this.cmbSp_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSp);
            this.Controls.Add(this.btnNv);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cmbKh);
            this.Controls.Add(this.cmbNv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNhanhang);
            this.Controls.Add(this.dtpLaphd);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnHuy);
            this.Name = "frmHoadon";
            this.Text = "frmHoadon";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.DateTimePicker dtpLaphd;
        private System.Windows.Forms.DateTimePicker dtpNhanhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNv;
        private System.Windows.Forms.ComboBox cmbKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnNv;
        private System.Windows.Forms.ComboBox cmbSp;
        private System.Windows.Forms.Button button1;
    }
}