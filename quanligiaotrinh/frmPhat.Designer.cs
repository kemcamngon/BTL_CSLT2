namespace quanligiaotrinh
{
    partial class frmPhat
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
            this.lbMaPhat = new System.Windows.Forms.Label();
            this.lbTienPhat = new System.Windows.Forms.Label();
            this.txtMaPhat = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewPhat = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaPhat
            // 
            this.lbMaPhat.AutoSize = true;
            this.lbMaPhat.Location = new System.Drawing.Point(64, 51);
            this.lbMaPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaPhat.Name = "lbMaPhat";
            this.lbMaPhat.Size = new System.Drawing.Size(46, 13);
            this.lbMaPhat.TabIndex = 0;
            this.lbMaPhat.Text = "Mã phạt";
            // 
            // lbTienPhat
            // 
            this.lbTienPhat.AutoSize = true;
            this.lbTienPhat.Location = new System.Drawing.Point(409, 51);
            this.lbTienPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTienPhat.Name = "lbTienPhat";
            this.lbTienPhat.Size = new System.Drawing.Size(52, 13);
            this.lbTienPhat.TabIndex = 1;
            this.lbTienPhat.Text = "Tiền phạt";
            // 
            // txtMaPhat
            // 
            this.txtMaPhat.Location = new System.Drawing.Point(153, 48);
            this.txtMaPhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhat.Name = "txtMaPhat";
            this.txtMaPhat.Size = new System.Drawing.Size(111, 20);
            this.txtMaPhat.TabIndex = 32;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(499, 48);
            this.txtTienPhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(111, 20);
            this.txtTienPhat.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bảng Phạt";
            // 
            // gridViewPhat
            // 
            this.gridViewPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPhat.Location = new System.Drawing.Point(117, 142);
            this.gridViewPhat.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewPhat.Name = "gridViewPhat";
            this.gridViewPhat.RowHeadersWidth = 62;
            this.gridViewPhat.RowTemplate.Height = 28;
            this.gridViewPhat.Size = new System.Drawing.Size(454, 161);
            this.gridViewPhat.TabIndex = 35;
            this.gridViewPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewPhat_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(79, 366);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 30);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(192, 366);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 30);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(308, 366);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 30);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(424, 366);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 30);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(539, 366);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 30);
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridViewPhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.txtMaPhat);
            this.Controls.Add(this.lbTienPhat);
            this.Controls.Add(this.lbMaPhat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhat";
            this.Text = "frmPhat";
            this.Load += new System.EventHandler(this.frmPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaPhat;
        private System.Windows.Forms.Label lbTienPhat;
        private System.Windows.Forms.TextBox txtMaPhat;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewPhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
    }
}