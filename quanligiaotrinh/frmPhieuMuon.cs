using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanligiaotrinh
{
    public partial class frmPhieuMuon : Form
    {
        DataTable tblCTPM;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtTenGT.Enabled = false;
            txtHoTen.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Enabled = false;
            btnThemSach.Enabled = false;
            btnThemPhieu.Enabled = true;
            btnHuyPhieu.Enabled = false;
            btnLuu.Enabled = false;
            btnXoaSach.Enabled = false;
            txtMaHSM.ReadOnly = true;
            cmbMaGT.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbMaThe.Enabled = false;
            cmbMaThuThu.Enabled = false;
            txtSoLuong.Enabled = false;
            DAO.FillDataToCombo("SELECT MaThuThu, TenThuThu FROM ThuThu", cmbMaThuThu, "MaThuThu", "TenThuThu");
            cmbMaThuThu.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaThe FROM TheMuon", cmbMaThe, "MaThe", "MaThe");
            cmbMaThe.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaLop, TenLop FROM Lop", cmbMaLop, "MaLop", "TenLop");
            cmbMaLop.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaGT, MaGT FROM DMGiaoTrinh", cmbMaGT, "MaGT", "MaGT");
            cmbMaGT.SelectedIndex = -1;
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            string sql;
            //sql = "select a.MaTV, a.SoLuong, a.DonGia, a.GiamGia,a.ThanhTien from ChiTietHSMuon a WHERE a.SoHDN ='" + txtMaHSM.Text.Trim() + "'";
            sql = "SELECT a.MaGT , b.TenGT, a.SoLuong FROM ChiTietHSMuon AS a, DMGiaoTrinh AS b  WHERE a.MaHSM = N'" + txtMaHSM.Text + "' AND a.MaGT=b.MaGT;";
            tblCTPM = DAO.GetDataToTable(sql);
            grvPM.DataSource = tblCTPM;
            grvPM.Columns[0].HeaderText = "Mã GT";
            grvPM.Columns[1].HeaderText = "Tên GT";
            grvPM.Columns[2].HeaderText = "Số lượng";
            grvPM.Columns[0].Width = 100;
            grvPM.Columns[1].Width = 100;
            grvPM.Columns[2].Width = 100;
            grvPM.AllowUserToAddRows = false;
            grvPM.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cmbMaThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str1, str2;
            if (cmbMaThe.Text == "")
            {
                txtHoTen.Text = "";
                cmbMaLop.Text = "";
            }
            str1 = "SELECT HoTen FROM TheMuon WHERE MaThe =N'" + cmbMaThe.SelectedValue + "'";
            str2 = "SELECT MaLop FROM TheMuon WHERE MaThe =N'" + cmbMaThe.SelectedValue + "'";
            txtHoTen.Text = DAO.GetFieldValues(str1);
            cmbMaLop.Text = DAO.GetFieldValues(str2);
        }

        private void cmbMaGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            //if (cmbMaGT.Text == "")
            //{
            //    txtTenGT.Text = "";
            //   
            //}
            txtSoLuong.Text = "1";
            str = "SELECT TenGT FROM DMGiaoTrinh WHERE MaGT =N'" + cmbMaGT.SelectedValue + "'";
            txtTenGT.Text = DAO.GetFieldValues(str);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = true;
            btnXoaSach.Enabled = true;
            cmbMaGT.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenGT.Enabled = false;
            string sql;
            sql = "SELECT MaHSM FROM HoSoMuon WHERE MaHSM=N'" + txtMaHSM.Text.Trim() + "'";
            if (!DAO.checkKeyExit(sql))
            {
                // Mã hồ sơ mượn chưa có, tiến hành lưu các thông tin chung
                if (cmbMaThuThu.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaThuThu.Focus();
                    return;
                }
                if (cmbMaThe.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaThe.Focus();
                    return;
                }
                if (cmbMaLop.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaLop.Focus();
                    return;
                }
                sql = "INSERT INTO HoSoMuon(MaHSM, MaThe, MaThuThu, NgayMuon, NgayPhaiTra) VALUES (N'" + txtMaHSM.Text.Trim() + "',N'" +
                        cmbMaThe.SelectedValue + "',N'" + cmbMaThuThu.SelectedValue + "',N'" + dtpNgayMuon.Value + "',N'" + dtpNgayTra.Value + "')";
                DAO.RunSQL(sql);
            }
            // Lưu thông tin của các quyển sách
            if (cmbMaGT.Text.Trim().Length == 0)
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
            }
            //thực hiện insert
            sql = "INSERT INTO ChiTietHSMuon (MaHSM, MaGT, SoLuong) VALUES (N'" + txtMaHSM.Text.Trim() + "',N'" + cmbMaGT.SelectedValue + "',N'" + txtSoLuong.Text.Trim() + "')";
            DAO.RunSQL(sql);
            LoadDataToGridView();
            //Cập nhật lại số lượng của GT vào bảng DMGiaoTrinh khi mượn
            double sl, slcon;
            sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuongGT FROM DMGiaoTrinh WHERE MaGT = N'" + cmbMaGT.SelectedValue + "'"));
            slcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE DMGiaoTrinh SET SoLuongGT =" + slcon + " WHERE MaGT= N'" + cmbMaGT.SelectedValue + "'";
            DAO.RunSQL(sql);

            //Cập nhật lại số lượng mượn cho thẻ mượn khi mượn
            int SLM, SLMmoi;
            SLM = Convert.ToInt32(DAO.GetFieldValues("select SoLuongMuon from TheMuon a join HoSoMuon b on a.MaThe =b.MaThe join ChitietHSMuon c on b.MaHSM = c.MaHSM where b.MaHSM = N'" + txtMaHSM.Text + "'"));
            SLMmoi = SLM + Convert.ToInt32(txtSoLuong.Text);
            sql = "UPDATE TheMuon SET SoLuongMuon =" + SLMmoi + " WHERE MaThe =N'" + cmbMaThe.SelectedValue + "'";
            DAO.RunSQL(sql);

            cmbMaGT.SelectedValue = "";
            txtSoLuong.Enabled = false;
            txtTenGT.Text = "";
            btnHuyPhieu.Enabled = true;
            btnThemPhieu.Enabled = true;
            btnDong.Enabled = true;
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            btnHuyPhieu.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            btnThemPhieu.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbMaThe.Enabled = true;
            cmbMaThuThu.Enabled = true;
            txtMaHSM.ReadOnly = true;
            dtpNgayTra.Enabled = true;
            cmbMaGT.Enabled = true;
            txtSoLuong.Enabled = false;
            txtTenGT.Enabled = false;
            btnThemSach.Enabled = false;
            ResetValues();
            grvPM.DataSource = null;
            txtMaHSM.Text = DAO.CreateKey("HSM");
        }
        private void ResetValues()
        {
            txtMaHSM.Text = "";
            dtpNgayMuon.Value = DateTime.Now;
            cmbMaLop.Text = "";
            cmbMaThe.Text = "";
            cmbMaThuThu.Text = "";
            txtHoTen.Text = "";
            cmbMaGT.Text = "";
            txtSoLuong.Text = "";
            txtTenGT.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            cmbMaGT.Text = "";
            txtSoLuong.Text = "";
            txtTenGT.Enabled = false;
            cmbMaGT.Enabled = true;
            txtSoLuong.Enabled = true;
            btnThemSach.Enabled = false;
            btnHuyPhieu.Enabled = true;
            btnThemPhieu.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.grvPM.SelectedRows)
            {
                grvPM.Rows.RemoveAt(item.Index);
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            txtMaHSM.Text = "";
            cmbMaThuThu.Text = "";
            cmbMaThe.Text = "";
            cmbMaLop.Text = "";
            txtHoTen.Text = "";
            dtpNgayTra.Text = "";
            cmbMaGT.Text = "";
            txtTenGT.Text = "";
            txtSoLuong.Text = "";
            grvPM.DataSource = "";
        }
    }
}
