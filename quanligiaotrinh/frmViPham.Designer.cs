namespace quanligiaotrinh
{
    partial class frmViPham
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
            this.lbMaViPham = new System.Windows.Forms.Label();
            this.txtMaViPham = new System.Windows.Forms.TextBox();
            this.lbTenViPham = new System.Windows.Forms.Label();
            this.txtTenViPham = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewViPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaViPham
            // 
            this.lbMaViPham.AutoSize = true;
            this.lbMaViPham.Location = new System.Drawing.Point(73, 64);
            this.lbMaViPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaViPham.Name = "lbMaViPham";
            this.lbMaViPham.Size = new System.Drawing.Size(62, 13);
            this.lbMaViPham.TabIndex = 0;
            this.lbMaViPham.Text = "Mã vi phạm";
            // 
            // txtMaViPham
            // 
            this.txtMaViPham.Location = new System.Drawing.Point(166, 61);
            this.txtMaViPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaViPham.Name = "txtMaViPham";
            this.txtMaViPham.Size = new System.Drawing.Size(119, 20);
            this.txtMaViPham.TabIndex = 1;
            // 
            // lbTenViPham
            // 
            this.lbTenViPham.AutoSize = true;
            this.lbTenViPham.Location = new System.Drawing.Point(385, 64);
            this.lbTenViPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenViPham.Name = "lbTenViPham";
            this.lbTenViPham.Size = new System.Drawing.Size(66, 13);
            this.lbTenViPham.TabIndex = 2;
            this.lbTenViPham.Text = "Tên vi phạm";
            // 
            // txtTenViPham
            // 
            this.txtTenViPham.Location = new System.Drawing.Point(482, 61);
            this.txtTenViPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenViPham.Name = "txtTenViPham";
            this.txtTenViPham.Size = new System.Drawing.Size(119, 20);
            this.txtTenViPham.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 352);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(306, 352);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(424, 352);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(188, 352);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(541, 352);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 30);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bảng Vi Phạm";
            // 
            // gridViewViPham
            // 
            this.gridViewViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewViPham.Location = new System.Drawing.Point(112, 139);
            this.gridViewViPham.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewViPham.Name = "gridViewViPham";
            this.gridViewViPham.RowHeadersWidth = 62;
            this.gridViewViPham.RowTemplate.Height = 28;
            this.gridViewViPham.Size = new System.Drawing.Size(454, 161);
            this.gridViewViPham.TabIndex = 11;
            this.gridViewViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewViPham_CellClick);
            // 
            // frmViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.gridViewViPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenViPham);
            this.Controls.Add(this.lbTenViPham);
            this.Controls.Add(this.txtMaViPham);
            this.Controls.Add(this.lbMaViPham);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViPham";
            this.Text = "frmViPham";
            this.Load += new System.EventHandler(this.frmViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaViPham;
        private System.Windows.Forms.TextBox txtMaViPham;
        private System.Windows.Forms.Label lbTenViPham;
        private System.Windows.Forms.TextBox txtTenViPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewViPham;
    }
}