namespace QLBANHANGPRO
{
    partial class frmThanhPho
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
            this.dgvThanhpho = new System.Windows.Forms.DataGridView();
            this.MaTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.txtTentp = new System.Windows.Forms.TextBox();
            this.txtMatp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhpho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThanhpho
            // 
            this.dgvThanhpho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhpho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTP,
            this.TenTP});
            this.dgvThanhpho.Location = new System.Drawing.Point(43, 134);
            this.dgvThanhpho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvThanhpho.Name = "dgvThanhpho";
            this.dgvThanhpho.Size = new System.Drawing.Size(427, 257);
            this.dgvThanhpho.TabIndex = 5;
            this.dgvThanhpho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhpho_CellClick);
            // 
            // MaTP
            // 
            this.MaTP.DataPropertyName = "MaTP";
            this.MaTP.HeaderText = "Mã TP";
            this.MaTP.Name = "MaTP";
            // 
            // TenTP
            // 
            this.TenTP.DataPropertyName = "TenTP";
            this.TenTP.HeaderText = "Tên TP";
            this.TenTP.Name = "TenTP";
            this.TenTP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(503, 355);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(74, 36);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(503, 295);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(74, 36);
            this.btnGhi.TabIndex = 16;
            this.btnGhi.Text = "ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Visible = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // txtTentp
            // 
            this.txtTentp.Location = new System.Drawing.Point(439, 94);
            this.txtTentp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTentp.Name = "txtTentp";
            this.txtTentp.Size = new System.Drawing.Size(116, 20);
            this.txtTentp.TabIndex = 13;
            // 
            // txtMatp
            // 
            this.txtMatp.Location = new System.Drawing.Point(135, 94);
            this.txtMatp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatp.Name = "txtMatp";
            this.txtMatp.Size = new System.Drawing.Size(116, 20);
            this.txtMatp.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên TP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "MaTP";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(503, 241);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 36);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(503, 186);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(503, 134);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(168, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "DANH SÁCH THÀNH PHỐ\r\n";
            // 
            // frmThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvThanhpho);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.txtTentp);
            this.Controls.Add(this.txtMatp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmThanhPho";
            this.Text = "frmThanhPho";
            this.Load += new System.EventHandler(this.frmThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhpho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThanhpho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTP;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.TextBox txtTentp;
        private System.Windows.Forms.TextBox txtMatp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
    }
}