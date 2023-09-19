namespace QLBANHANGPRO
{
    partial class frmNhanvien
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
            this.dtpNv = new System.Windows.Forms.DateTimePicker();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNv = new System.Windows.Forms.TextBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.btnKoGhi = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNv
            // 
            this.dtpNv.Location = new System.Drawing.Point(423, 153);
            this.dtpNv.Name = "dtpNv";
            this.dtpNv.Size = new System.Drawing.Size(200, 20);
            this.dtpNv.TabIndex = 58;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "DienThoai";
            this.Dienthoai.HeaderText = "Điện Thoại";
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "GioiTinh";
            this.Gioitinh.HeaderText = "Nam";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gioitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenNV";
            this.TenNv.HeaderText = "Tên Nhân Viên";
            this.TenNv.Name = "TenNv";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(673, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 53);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // NgayNv
            // 
            this.NgayNv.DataPropertyName = "NgayNV";
            this.NgayNv.HeaderText = "Ngày Nv";
            this.NgayNv.Name = "NgayNv";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(673, 428);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 53);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(673, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 53);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Items.AddRange(new object[] {
            "nữ ",
            "nam"});
            this.cmbGioitinh.Location = new System.Drawing.Point(423, 121);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(89, 21);
            this.cmbGioitinh.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ngày NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tên Nhân Viên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Nhân Viên ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(136, 121);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(160, 20);
            this.txtDienThoai.TabIndex = 44;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(423, 85);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(154, 20);
            this.txtTennv.TabIndex = 43;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(136, 153);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 20);
            this.txtDiaChi.TabIndex = 42;
            // 
            // txtNv
            // 
            this.txtNv.Location = new System.Drawing.Point(136, 89);
            this.txtNv.Name = "txtNv";
            this.txtNv.Size = new System.Drawing.Size(160, 20);
            this.txtNv.TabIndex = 41;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNv,
            this.Gioitinh,
            this.DiaChi,
            this.Dienthoai,
            this.NgayNv});
            this.dgvNhanvien.Location = new System.Drawing.Point(33, 194);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(608, 287);
            this.dgvNhanvien.TabIndex = 39;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // btnKoGhi
            // 
            this.btnKoGhi.Location = new System.Drawing.Point(673, 356);
            this.btnKoGhi.Name = "btnKoGhi";
            this.btnKoGhi.Size = new System.Drawing.Size(70, 53);
            this.btnKoGhi.TabIndex = 56;
            this.btnKoGhi.Text = "Hủy";
            this.btnKoGhi.UseVisualStyleBackColor = true;
            this.btnKoGhi.Click += new System.EventHandler(this.btnKoGhi_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(673, 229);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(70, 53);
            this.btnGhi.TabIndex = 55;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNv);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cmbGioitinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNv);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.btnKoGhi);
            this.Controls.Add(this.btnGhi);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNv;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Button btnKoGhi;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Label label1;
    }
}