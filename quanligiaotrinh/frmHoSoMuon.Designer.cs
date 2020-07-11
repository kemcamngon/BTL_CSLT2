namespace quanligiaotrinh
{
    partial class frmHoSoMuon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaThuThu = new System.Windows.Forms.ComboBox();
            this.grvHSM = new System.Windows.Forms.DataGridView();
            this.cmbMaThe = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayPhaiTra = new System.Windows.Forms.DateTimePicker();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.cmbMaHSM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvHSM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Thủ thư";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày phải trả";
            // 
            // cmbMaThuThu
            // 
            this.cmbMaThuThu.FormattingEnabled = true;
            this.cmbMaThuThu.Location = new System.Drawing.Point(142, 183);
            this.cmbMaThuThu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaThuThu.Name = "cmbMaThuThu";
            this.cmbMaThuThu.Size = new System.Drawing.Size(141, 21);
            this.cmbMaThuThu.TabIndex = 7;
            // 
            // grvHSM
            // 
            this.grvHSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHSM.Location = new System.Drawing.Point(326, 132);
            this.grvHSM.Margin = new System.Windows.Forms.Padding(2);
            this.grvHSM.Name = "grvHSM";
            this.grvHSM.RowHeadersWidth = 62;
            this.grvHSM.RowTemplate.Height = 28;
            this.grvHSM.Size = new System.Drawing.Size(364, 163);
            this.grvHSM.TabIndex = 10;
            // 
            // cmbMaThe
            // 
            this.cmbMaThe.FormattingEnabled = true;
            this.cmbMaThe.Location = new System.Drawing.Point(142, 133);
            this.cmbMaThe.Name = "cmbMaThe";
            this.cmbMaThe.Size = new System.Drawing.Size(141, 21);
            this.cmbMaThe.TabIndex = 12;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(565, 313);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hồ Sơ Mượn";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MMM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(142, 230);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(141, 20);
            this.dtpNgayMuon.TabIndex = 29;
            // 
            // dtpNgayPhaiTra
            // 
            this.dtpNgayPhaiTra.CustomFormat = "dd/MMM/yyyy";
            this.dtpNgayPhaiTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhaiTra.Location = new System.Drawing.Point(142, 275);
            this.dtpNgayPhaiTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayPhaiTra.Name = "dtpNgayPhaiTra";
            this.dtpNgayPhaiTra.Size = new System.Drawing.Size(141, 20);
            this.dtpNgayPhaiTra.TabIndex = 30;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(433, 70);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 31;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // cmbMaHSM
            // 
            this.cmbMaHSM.FormattingEnabled = true;
            this.cmbMaHSM.Location = new System.Drawing.Point(225, 70);
            this.cmbMaHSM.Name = "cmbMaHSM";
            this.cmbMaHSM.Size = new System.Drawing.Size(141, 21);
            this.cmbMaHSM.TabIndex = 32;
            // 
            // frmHoSoMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.cmbMaHSM);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.dtpNgayPhaiTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cmbMaThe);
            this.Controls.Add(this.grvHSM);
            this.Controls.Add(this.cmbMaThuThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoSoMuon";
            this.Text = "frmHoSoMuon";
            this.Load += new System.EventHandler(this.frmHoSoMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHSM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaThuThu;
        private System.Windows.Forms.DataGridView grvHSM;
        private System.Windows.Forms.ComboBox cmbMaThe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayPhaiTra;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.ComboBox cmbMaHSM;
    }
}