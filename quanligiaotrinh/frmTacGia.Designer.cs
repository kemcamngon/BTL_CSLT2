namespace quanligiaotrinh
{
    partial class frmTacGia
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
            this.gridViewTacGia = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaTrinhDo = new System.Windows.Forms.ComboBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.lbMaTrinhDo = new System.Windows.Forms.Label();
            this.lbNamSinh = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.lbTenTacGia = new System.Windows.Forms.Label();
            this.lbMaTacGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTacGia)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewTacGia
            // 
            this.gridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTacGia.Location = new System.Drawing.Point(68, 196);
            this.gridViewTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewTacGia.Name = "gridViewTacGia";
            this.gridViewTacGia.RowHeadersWidth = 62;
            this.gridViewTacGia.RowTemplate.Height = 28;
            this.gridViewTacGia.Size = new System.Drawing.Size(541, 142);
            this.gridViewTacGia.TabIndex = 10;
            this.gridViewTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTacGia_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(213, 362);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 29);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 361);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 29);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(410, 361);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 29);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(499, 361);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(64, 29);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 361);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 29);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh Mục Tác Giả";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.cmbMaTrinhDo);
            this.groupbox1.Controls.Add(this.txtNamSinh);
            this.groupbox1.Controls.Add(this.cmbMaKhoa);
            this.groupbox1.Controls.Add(this.txtTenTacGia);
            this.groupbox1.Controls.Add(this.txtMaTacGia);
            this.groupbox1.Controls.Add(this.lbMaTrinhDo);
            this.groupbox1.Controls.Add(this.lbNamSinh);
            this.groupbox1.Controls.Add(this.lbMaKhoa);
            this.groupbox1.Controls.Add(this.lbTenTacGia);
            this.groupbox1.Controls.Add(this.lbMaTacGia);
            this.groupbox1.Location = new System.Drawing.Point(39, 50);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupbox1.Size = new System.Drawing.Size(595, 120);
            this.groupbox1.TabIndex = 17;
            this.groupbox1.TabStop = false;
            // 
            // cmbMaTrinhDo
            // 
            this.cmbMaTrinhDo.FormattingEnabled = true;
            this.cmbMaTrinhDo.Location = new System.Drawing.Point(449, 22);
            this.cmbMaTrinhDo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaTrinhDo.Name = "cmbMaTrinhDo";
            this.cmbMaTrinhDo.Size = new System.Drawing.Size(82, 21);
            this.cmbMaTrinhDo.TabIndex = 19;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(109, 94);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(129, 20);
            this.txtNamSinh.TabIndex = 18;
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(449, 58);
            this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(82, 21);
            this.cmbMaKhoa.TabIndex = 17;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(109, 58);
            this.txtTenTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(129, 20);
            this.txtTenTacGia.TabIndex = 16;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(109, 22);
            this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(129, 20);
            this.txtMaTacGia.TabIndex = 15;
            // 
            // lbMaTrinhDo
            // 
            this.lbMaTrinhDo.AutoSize = true;
            this.lbMaTrinhDo.Location = new System.Drawing.Point(365, 24);
            this.lbMaTrinhDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaTrinhDo.Name = "lbMaTrinhDo";
            this.lbMaTrinhDo.Size = new System.Drawing.Size(61, 13);
            this.lbMaTrinhDo.TabIndex = 14;
            this.lbMaTrinhDo.Text = "Mã trình độ";
            // 
            // lbNamSinh
            // 
            this.lbNamSinh.AutoSize = true;
            this.lbNamSinh.Location = new System.Drawing.Point(39, 97);
            this.lbNamSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamSinh.Name = "lbNamSinh";
            this.lbNamSinh.Size = new System.Drawing.Size(51, 13);
            this.lbNamSinh.TabIndex = 13;
            this.lbNamSinh.Text = "Năm sinh";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(377, 59);
            this.lbMaKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(49, 13);
            this.lbMaKhoa.TabIndex = 12;
            this.lbMaKhoa.Text = "Mã khoa";
            // 
            // lbTenTacGia
            // 
            this.lbTenTacGia.AutoSize = true;
            this.lbTenTacGia.Location = new System.Drawing.Point(39, 61);
            this.lbTenTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenTacGia.Name = "lbTenTacGia";
            this.lbTenTacGia.Size = new System.Drawing.Size(61, 13);
            this.lbTenTacGia.TabIndex = 11;
            this.lbTenTacGia.Text = "Tên tác giả";
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Location = new System.Drawing.Point(41, 24);
            this.lbMaTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(57, 13);
            this.lbMaTacGia.TabIndex = 10;
            this.lbMaTacGia.Text = "Mã tác giả";
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridViewTacGia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTacGia)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewTacGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.ComboBox cmbMaTrinhDo;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label lbMaTrinhDo;
        private System.Windows.Forms.Label lbNamSinh;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Label lbTenTacGia;
        private System.Windows.Forms.Label lbMaTacGia;
    }
}