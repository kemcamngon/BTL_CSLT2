namespace quanligiaotrinh
{
    partial class frmDMGiaoTrinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewDMGiaoTrinh = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cmbMaTacGia = new System.Windows.Forms.ComboBox();
            this.txtSoLuongGT = new System.Windows.Forms.TextBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtTomTatNoiDung = new System.Windows.Forms.TextBox();
            this.lbSoLuongGT = new System.Windows.Forms.Label();
            this.lbTomTatNoiDung = new System.Windows.Forms.Label();
            this.lbSoTrang = new System.Windows.Forms.Label();
            this.lbMaChuyenNganh = new System.Windows.Forms.Label();
            this.txtLanTB = new System.Windows.Forms.TextBox();
            this.lbLanTB = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.lbNamXB = new System.Windows.Forms.Label();
            this.txtTenGT = new System.Windows.Forms.TextBox();
            this.lbMaTacGia = new System.Windows.Forms.Label();
            this.lbTenGT = new System.Windows.Forms.Label();
            this.txtMaGT = new System.Windows.Forms.TextBox();
            this.lbMaGT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMGiaoTrinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Giáo Trình";
            // 
            // gridViewDMGiaoTrinh
            // 
            this.gridViewDMGiaoTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMGiaoTrinh.Location = new System.Drawing.Point(68, 322);
            this.gridViewDMGiaoTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewDMGiaoTrinh.Name = "gridViewDMGiaoTrinh";
            this.gridViewDMGiaoTrinh.RowHeadersWidth = 62;
            this.gridViewDMGiaoTrinh.RowTemplate.Height = 28;
            this.gridViewDMGiaoTrinh.Size = new System.Drawing.Size(631, 138);
            this.gridViewDMGiaoTrinh.TabIndex = 19;
            this.gridViewDMGiaoTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDMGiaoTrinh_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(235, 495);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 33);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(336, 495);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 33);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(435, 495);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 33);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(535, 495);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(67, 33);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(134, 495);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 33);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbMaChuyenNganh);
            this.groupBox1.Controls.Add(this.cmbMaTacGia);
            this.groupBox1.Controls.Add(this.txtSoLuongGT);
            this.groupBox1.Controls.Add(this.txtSoTrang);
            this.groupBox1.Controls.Add(this.txtTomTatNoiDung);
            this.groupBox1.Controls.Add(this.lbSoLuongGT);
            this.groupBox1.Controls.Add(this.lbTomTatNoiDung);
            this.groupBox1.Controls.Add(this.lbSoTrang);
            this.groupBox1.Controls.Add(this.lbMaChuyenNganh);
            this.groupBox1.Controls.Add(this.txtLanTB);
            this.groupBox1.Controls.Add(this.lbLanTB);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.lbNamXB);
            this.groupBox1.Controls.Add(this.txtTenGT);
            this.groupBox1.Controls.Add(this.lbMaTacGia);
            this.groupBox1.Controls.Add(this.lbTenGT);
            this.groupBox1.Controls.Add(this.txtMaGT);
            this.groupBox1.Controls.Add(this.lbMaGT);
            this.groupBox1.Location = new System.Drawing.Point(33, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(689, 201);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giáo trình";
            // 
            // cmbMaChuyenNganh
            // 
            this.cmbMaChuyenNganh.FormattingEnabled = true;
            this.cmbMaChuyenNganh.Location = new System.Drawing.Point(500, 90);
            this.cmbMaChuyenNganh.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaChuyenNganh.Name = "cmbMaChuyenNganh";
            this.cmbMaChuyenNganh.Size = new System.Drawing.Size(103, 21);
            this.cmbMaChuyenNganh.TabIndex = 43;
            // 
            // cmbMaTacGia
            // 
            this.cmbMaTacGia.FormattingEnabled = true;
            this.cmbMaTacGia.Location = new System.Drawing.Point(145, 90);
            this.cmbMaTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaTacGia.Name = "cmbMaTacGia";
            this.cmbMaTacGia.Size = new System.Drawing.Size(101, 21);
            this.cmbMaTacGia.TabIndex = 42;
            // 
            // txtSoLuongGT
            // 
            this.txtSoLuongGT.Location = new System.Drawing.Point(145, 157);
            this.txtSoLuongGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongGT.Name = "txtSoLuongGT";
            this.txtSoLuongGT.Size = new System.Drawing.Size(68, 20);
            this.txtSoLuongGT.TabIndex = 41;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(145, 122);
            this.txtSoTrang.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(68, 20);
            this.txtSoTrang.TabIndex = 40;
            // 
            // txtTomTatNoiDung
            // 
            this.txtTomTatNoiDung.Location = new System.Drawing.Point(500, 122);
            this.txtTomTatNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtTomTatNoiDung.Name = "txtTomTatNoiDung";
            this.txtTomTatNoiDung.Size = new System.Drawing.Size(178, 20);
            this.txtTomTatNoiDung.TabIndex = 39;
            // 
            // lbSoLuongGT
            // 
            this.lbSoLuongGT.AutoSize = true;
            this.lbSoLuongGT.Location = new System.Drawing.Point(20, 161);
            this.lbSoLuongGT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuongGT.Name = "lbSoLuongGT";
            this.lbSoLuongGT.Size = new System.Drawing.Size(95, 13);
            this.lbSoLuongGT.TabIndex = 38;
            this.lbSoLuongGT.Text = "Số lượng giáo trình";
            // 
            // lbTomTatNoiDung
            // 
            this.lbTomTatNoiDung.AutoSize = true;
            this.lbTomTatNoiDung.Location = new System.Drawing.Point(377, 125);
            this.lbTomTatNoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTomTatNoiDung.Name = "lbTomTatNoiDung";
            this.lbTomTatNoiDung.Size = new System.Drawing.Size(87, 13);
            this.lbTomTatNoiDung.TabIndex = 37;
            this.lbTomTatNoiDung.Text = "Tóm tắt nội dung";
            // 
            // lbSoTrang
            // 
            this.lbSoTrang.AutoSize = true;
            this.lbSoTrang.Location = new System.Drawing.Point(21, 126);
            this.lbSoTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTrang.Name = "lbSoTrang";
            this.lbSoTrang.Size = new System.Drawing.Size(47, 13);
            this.lbSoTrang.TabIndex = 36;
            this.lbSoTrang.Text = "Số trang";
            // 
            // lbMaChuyenNganh
            // 
            this.lbMaChuyenNganh.AutoSize = true;
            this.lbMaChuyenNganh.Location = new System.Drawing.Point(377, 92);
            this.lbMaChuyenNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaChuyenNganh.Name = "lbMaChuyenNganh";
            this.lbMaChuyenNganh.Size = new System.Drawing.Size(93, 13);
            this.lbMaChuyenNganh.TabIndex = 35;
            this.lbMaChuyenNganh.Text = "Mã chuyên ngành";
            // 
            // txtLanTB
            // 
            this.txtLanTB.Location = new System.Drawing.Point(500, 57);
            this.txtLanTB.Margin = new System.Windows.Forms.Padding(2);
            this.txtLanTB.Name = "txtLanTB";
            this.txtLanTB.Size = new System.Drawing.Size(103, 20);
            this.txtLanTB.TabIndex = 34;
            // 
            // lbLanTB
            // 
            this.lbLanTB.AutoSize = true;
            this.lbLanTB.Location = new System.Drawing.Point(377, 60);
            this.lbLanTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLanTB.Name = "lbLanTB";
            this.lbLanTB.Size = new System.Drawing.Size(60, 13);
            this.lbLanTB.TabIndex = 33;
            this.lbLanTB.Text = "Lần tái bản";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(500, 28);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(103, 20);
            this.txtNamXB.TabIndex = 32;
            // 
            // lbNamXB
            // 
            this.lbNamXB.AutoSize = true;
            this.lbNamXB.Location = new System.Drawing.Point(377, 30);
            this.lbNamXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamXB.Name = "lbNamXB";
            this.lbNamXB.Size = new System.Drawing.Size(73, 13);
            this.lbNamXB.TabIndex = 31;
            this.lbNamXB.Text = "Năm xuất bản";
            // 
            // txtTenGT
            // 
            this.txtTenGT.Location = new System.Drawing.Point(145, 59);
            this.txtTenGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenGT.Name = "txtTenGT";
            this.txtTenGT.Size = new System.Drawing.Size(134, 20);
            this.txtTenGT.TabIndex = 30;
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Location = new System.Drawing.Point(21, 92);
            this.lbMaTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(57, 13);
            this.lbMaTacGia.TabIndex = 29;
            this.lbMaTacGia.Text = "Mã tác giả";
            // 
            // lbTenGT
            // 
            this.lbTenGT.AutoSize = true;
            this.lbTenGT.Location = new System.Drawing.Point(21, 60);
            this.lbTenGT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenGT.Name = "lbTenGT";
            this.lbTenGT.Size = new System.Drawing.Size(72, 13);
            this.lbTenGT.TabIndex = 28;
            this.lbTenGT.Text = "Tên giáo trình";
            // 
            // txtMaGT
            // 
            this.txtMaGT.Location = new System.Drawing.Point(145, 27);
            this.txtMaGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaGT.Name = "txtMaGT";
            this.txtMaGT.Size = new System.Drawing.Size(134, 20);
            this.txtMaGT.TabIndex = 27;
            // 
            // lbMaGT
            // 
            this.lbMaGT.AutoSize = true;
            this.lbMaGT.Location = new System.Drawing.Point(21, 31);
            this.lbMaGT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaGT.Name = "lbMaGT";
            this.lbMaGT.Size = new System.Drawing.Size(71, 13);
            this.lbMaGT.TabIndex = 26;
            this.lbMaGT.Text = "Mã giáo trình ";
            // 
            // frmDMGiaoTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridViewDMGiaoTrinh);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDMGiaoTrinh";
            this.Text = "Danh mục giáo trình";
            this.Load += new System.EventHandler(this.frmDMGiaoTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMGiaoTrinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewDMGiaoTrinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMaChuyenNganh;
        private System.Windows.Forms.ComboBox cmbMaTacGia;
        private System.Windows.Forms.TextBox txtSoLuongGT;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtTomTatNoiDung;
        private System.Windows.Forms.Label lbSoLuongGT;
        private System.Windows.Forms.Label lbTomTatNoiDung;
        private System.Windows.Forms.Label lbSoTrang;
        private System.Windows.Forms.Label lbMaChuyenNganh;
        private System.Windows.Forms.TextBox txtLanTB;
        private System.Windows.Forms.Label lbLanTB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label lbNamXB;
        private System.Windows.Forms.TextBox txtTenGT;
        private System.Windows.Forms.Label lbMaTacGia;
        private System.Windows.Forms.Label lbTenGT;
        private System.Windows.Forms.TextBox txtMaGT;
        private System.Windows.Forms.Label lbMaGT;
    }
}