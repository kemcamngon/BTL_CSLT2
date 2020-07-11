using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanligiaotrinh
{
    public partial class frmHoSoTra : Form
    {
        DataTable tblTHST;
        DataTable tblHST2;
        public frmHoSoTra()
        {
            InitializeComponent();
        }

        private void frmHoSoTra_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtMaHSTra.Enabled = true;
            cmbMaHSM.Enabled = true;
            cmbMaThuThu.Enabled = true;
            txtTongTienPhat.Enabled = true;
            dtpNgayNopPhat.Enabled = true;
            dtpNgayTra.Enabled = true;
            txtSoLuong.Enabled = false;
            DAO.FillDataToCombo("SELECT MaHSM, MaHSM FROM HoSoMuon", cmbMaHSM, "MaHSM", "MaHSM");
            cmbMaHSM.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaThuThu, TenThuThu FROM ThuThu", cmbMaThuThu, "MaThuThu", "TenThuThu");
            cmbMaThuThu.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaGT FROM DMGiaoTrinh", cmbMaGT, "MaGT", "MaGT");
            cmbMaGT.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaViPham, TenViPham FROM ViPham", cmbMaViPham, "MaViPham", "MaViPham");
            cmbMaViPham.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaPhat, TienPhat FROM Phat", cmbMaPhat, "MaPhat", "MaPhat");
            cmbMaPhat.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaHSTra FROM HoSoTra", cmbHST, "MaHSTra", "MaHSTra");
            cmbHST.SelectedIndex = -1;
            DAO.FillDataToCombo("select a.MaThe FROM TheMuon a join HoSoMuon b on a.MaThe = b.MaThe join HoSoTra c on b.MaHSM = c.MaHSM join ChitietHSTra d on d.MaHSTra = c.MaHSTra", comboBox2, "MaThe", "MaThe");
            cmbHST.SelectedIndex = -1;
            txtSoLuong.Text = "1";
            LoadDataToGridView();
            ResetValues();    
        }
        private void LoadDataToGridView()
        {
            DAO.OpenConnection();
            string sql;
            sql = "select a.MaThe, HoTen, GioiTinh, MaLop, MaKhoa,MaViPham, SoLuongMuon, NgayNopPhat , " +
   "(CASE WHEN MaViPham != '' and NgayNopPhat = ''" +
                   "  THEN 'TRUE'" +
                 " ELSE 'FALSE'" +
             "END) as KhoaThe FROM TheMuon a join HoSoMuon b on a.MaThe = b.MaThe join HoSoTra c on b.MaHSM = c.MaHSM join ChitietHSTra d on d.MaHSTra = c.MaHSTra WHERE 1 = 1; ";
            DAO.RunSQL(sql);
            tblHST2 = DAO.LoadDataToGridView(sql);
            grvHSTra2.DataSource = tblHST2;
            grvHSTra2.Update();
            grvHSTra2.Refresh();
            string sql1;
            sql1 = "select ht.MaHSTra, ht.MaHSM, ht.MaThuThu, ht.NgayTra, ht.TongTienPhat, cm.MaGT, ct.MaPhat, ct.MaViPham, ht.NgayNopPhat from (HoSoTra ht join ChiTietHSMuon cm on ht.MaHSM = cm.MaHSM) join ChiTietHSTra ct on ct.MaHSTra = ht.MaHSTra where cm.ChuaTra ='NO'";
            DAO.RunSQL(sql1);
            tblTHST = DAO.LoadDataToGridView(sql1);
            grvHST.DataSource = tblTHST;
            grvHST.Update();
            grvHST.Refresh();
        }

        private void ResetValues()
        {
            txtMaHSTra.Text = "";
            cmbMaHSM.Text = "";
            cmbMaThuThu.Text = "";
            txtTongTienPhat.Text = "";
            dtpNgayNopPhat.Text = "";
            dtpNgayTra.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cmbMaHSM.Enabled = true;
            cmbMaThuThu.Enabled = true;
            txtMaHSTra.ReadOnly = true;
            dtpNgayTra.Enabled = true;
            ResetValues();
            txtMaHSTra.Text = DAO.CreateKey("HST");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            string sql;
            //double Sl = 0, SLcon, tong, Tongmoi;
            //sql = "SELECT MaHSM FROM HoSoMuon WHERE MaHSM=N'" + cmbMaHSM.Text.Trim() + "'";
            //if (!DAO.checkKeyExit(sql))
            //{
            //    // Mã hồ sơ mượn chưa xuất hienj trong tbl HST, tiến hành lưu các thông tin chung
            //    if (cmbMaHSM.Text.Length == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mã thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        cmbMaHSM.Focus();
            //        return;
            //    }
            //    if (cmbMaThuThu.Text.Length == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        cmbMaThuThu.Focus();
            //        return;
            //    }
            //    sql = "INSERT INTO HoSoTra(MaHSTra, MaHSM, NgayTra, TongTienPhat, NgayNopPhat, MaThuThu) VALUES (N'" + txtMaHSTra.Text.Trim() + "',N'" +
            //            cmbMaHSM.SelectedValue + "',N'" + dtpNgayTra.Value + "',N'" + txtTongTienPhat.Text.Trim() + "',N'" + dtpNgayNopPhat.Value + "',N'" +
            //            cmbMaThuThu.SelectedValue + "'); Insert into ChiTietHSTra(MaHSTra, MaGT,MaViPham, MaPhat) Values(N'" + txtMaHSTra.Text.Trim() + "', N'" + cmbMaGT.Text.Trim() + "', N'" + cmbMaViPham.Text.Trim() + "',N'" + cmbMaPhat.Text.Trim() + "'); ";
            //    DAO.RunSql(sql);
            //}
            //else
            //{

            //}
            //Lưu thông tin của các quyển sách
            /*if (cmbMaGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã GT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaGT.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            // kiểm tra MaGT đã tồn tại trong chi tiết hồ sơ mượn chưa
            sql = "SELECT MaGT FROM ChiTietHSMuon WHERE MaGT=N'" + cmbMaGT.SelectedValue + "' AND MaHSM = N'" + txtMaHSM.Text.Trim() + "'";
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã GT này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaGT.SelectedValue = "";
                cmbMaGT.Focus();
                return;
            }*/
            try
            {
                //thực hiện insert
                sql = "INSERT INTO HoSoTra(MaHSTra, MaHSM, NgayTra, TongTienPhat, NgayNopPhat, MaThuThu) VALUES (N'" + txtMaHSTra.Text.Trim() + "',N'" +
                           cmbMaHSM.SelectedValue + "',N'" + dtpNgayTra.Value + "',N'" + txtTongTienPhat.Text.Trim() + "',N'" + dtpNgayNopPhat.Value + "',N'" +
                           cmbMaThuThu.SelectedValue + "');Insert into ChiTietHSTra(MaHSTra, MaGT,MaViPham, MaPhat) Values(N'" + txtMaHSTra.Text.Trim() + "', N'" + cmbMaGT.Text.Trim() + "', N'" + cmbMaViPham.Text.Trim() + "',N'" + cmbMaPhat.Text.Trim() + "');";
                DAO.RunSQL(sql);
                MessageBox.Show("Thêm THÀNH CÔNG !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadDataToGridView();                
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG Thêm ĐƯỢC!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cập nhật lại số lượng của GT vào bảng DMGiaoTrinh khi trả 
            string sql1;
            int SL, SLcon; 
            SL=Convert.ToInt32(DAO.GetFieldValues("SELECT SoLuongGT FROM DMGiaoTrinh WHERE MaGT = N'" + cmbMaGT.SelectedValue + "'")); 
           SLcon = SL + Convert.ToInt32(txtSoLuong.Text); sql1 = "UPDATE DMGiaoTrinh SET SoLuongGT =" + SLcon + " WHERE MaGT= N'" + cmbMaGT.SelectedValue + "'"; 
            DAO.RunSql(sql1);

            /*//Cập nhật lại số lượng mượn cho thẻ mượn khi trả
            string sql2;
             int SLMmoi, Slg;
            Slg = Convert.ToInt32(DAO.GetFieldValues("select SoLuongMuon from TheMuon a join HoSoMuon b on a.MaThe =b.MaThe join ChitietHSMuon c on b.MaHSM = c.MaHSM where b.MaHSM = N'" + cmbMaHSM.Text + "'"));
            SLMmoi = Slg- Convert.ToInt32(txtSoLuong.Text);;
            sql2 = "UPDATE TheMuon SET SoLuongMuon =" + SLMmoi + " WHERE MaThe = select MaThe from TheMuon d join HoSoMuon a on d.MaThe=a.MaThe join HoSoTra b on a.MaHSM = c.MaHSM  where MaHSM = N'" + cmbMaHSM.Text + "'";
            DAO.RunSql(sql2);*/

            /*cmbMaGT.SelectedValue = "";
            txtSoLuong.Text = "";
            txtTenGT.Text = "";
            btnHuyPhieu.Enabled = true;
            btnThemPhieu.Enabled = true;
            btnDong.Enabled = true;*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHSTra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE HoSoTra SET MaHSM=N'" + cmbMaHSM.Text +
                "',NgayPhaiTra=N'" + dtpNgayTra.Text +
                "',TongTienPhat=N'" + txtTongTienPhat.Text +
                "',NgayNopPhat=N'" + dtpNgayNopPhat.Text +
                "',MaThuThu=N'" + cmbMaThuThu.Text +
                "' WHERE MaHSM=N'" + txtMaHSTra.Text + "'";
            DAO.RunSQL(sql);
            LoadDataToGridView();
            ResetValues();
            btnDong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "DELETE FROM ChiTietHSTra Where MaHSM = '" + cmbMaHSM.Text + "';DELETE FROM ThuThu Where MaThuThu ='" + cmbMaThuThu.Text + "';DELETE FROM HoSoTra Where MaHStra = '" + txtMaHSTra.Text + "'";
            DAO.RunSQL(sql);
            tblTHST = DAO.LoadDataToGridView(sql);
            grvHST.DataSource = tblTHST;
            grvHST.Refresh();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (tb == DialogResult.Yes)
            //    Application.Exit();
            this.Close();
        }

        /*private void grvHST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHSTra.Text = grvHST.CurrentRow.Cells["MaHST"].Value.ToString();
            cmbMaHSM.Text = grvHST.CurrentRow.Cells["MaHSM"].Value.ToString();
            cmbMaThuThu.Text = grvHST.CurrentRow.Cells["MaThuThu"].Value.ToString();
            txtTongTienPhat.Text = grvHST.CurrentRow.Cells["TongTienPhat"].Value.ToString();
            dtpNgayNopPhat.Text = grvHST.CurrentRow.Cells["NgayNopPhat"].Value.ToString();
            dtpNgayTra.Text = grvHST.CurrentRow.Cells["NgayTra"].Value.ToString();
            txtMaHSTra.Enabled = false;
            cmbMaHSM.Enabled = false;
        }*/

        private void btnTimHoaDonNhap_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select ht.MaHSTra, ht.MaHSM, ht.MaThuThu, ht.NgayTra, ht.TongTienPhat, cm.MaGT, ct.MaPhat, ct.MaViPham, ht.NgayNopPhat from (HoSoTra ht join ChiTietHSMuon cm on ht.MaHSM = cm.MaHSM) join ChiTietHSTra ct on ct.MaHSTra = ht.MaHSTra where cm.ChuaTra ='NO'and ht.MaHSTra = '" + cmbHST.Text + "';";
            DAO.RunSQL(sql);
            tblTHST = DAO.LoadDataToGridView(sql);
            grvHST.DataSource = tblTHST;
        }

        private void grvHSTra2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timmathe(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "select a.MaThe, HoTen, GioiTinh, MaLop, MaKhoa,MaViPham, SoLuongMuon, NgayNopPhat , " +
   "(CASE WHEN MaViPham != '' and NgayNopPhat = ''" +
                   "  THEN 'TRUE'" +
                 " ELSE 'FALSE'" +
             "END) as KhoaThe FROM TheMuon a join HoSoMuon b on a.MaThe = b.MaThe join HoSoTra c on b.MaHSM = c.MaHSM join ChitietHSTra d on d.MaHSTra = c.MaHSTra WHERE 1 = 1 and a.MaThe='"+comboBox2.Text+"'; ";
            DAO.RunSQL(sql);
            tblHST2 = DAO.LoadDataToGridView(sql);
            grvHSTra2.DataSource = tblHST2;
        }
    }
}
