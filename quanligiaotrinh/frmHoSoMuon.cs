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
    public partial class frmHoSoMuon : Form
    {
        DataTable tblCTHSM;
        public frmHoSoMuon()
        {
            InitializeComponent();
        }

        private void frmHoSoMuon_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            cmbMaHSM.Enabled = true;
            cmbMaThe.Enabled = false;
            cmbMaThuThu.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayPhaiTra.Enabled = false;
            DAO.FillDataToCombo("SELECT MaHSM, MaHSM FROM HoSoMuon", cmbMaHSM, "MaHSM", "MaHSM");
            cmbMaHSM.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaThuThu, TenThuThu FROM ThuThu", cmbMaThuThu, "MaThuThu", "TenThuThu");
            cmbMaThuThu.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaThe, HoTen FROM TheMuon", cmbMaThe, "MaThe", "HoTen");
            cmbMaThe.SelectedIndex = -1;
            LoadDataToGridView();
            ResetValues();
        }
        private void LoadDataToGridView()
        {
            string sql;
            //sql = "select a.MaTV, a.SoLuong, a.DonGia, a.GiamGia,a.ThanhTien from ChiTietHSMuon a WHERE a.SoHDN ='" + txtMaHSM.Text.Trim() + "'";
            sql = "SELECT a.MaGT , b.TenGT, a.SoLuong FROM ChiTietHSMuon AS a, DMGiaoTrinh AS b  WHERE a.MaHSM = N'" + cmbMaHSM.Text + "' AND a.MaGT=b.MaGT;";
            tblCTHSM = DAO.GetDataToTable(sql);
            grvHSM.DataSource = tblCTHSM;
            grvHSM.Columns[0].HeaderText = "Mã GT";
            grvHSM.Columns[1].HeaderText = "Tên GT";
            grvHSM.Columns[2].HeaderText = "Số lượng";
            grvHSM.Columns[0].Width = 100;
            grvHSM.Columns[1].Width = 100;
            grvHSM.Columns[2].Width = 100;
            grvHSM.AllowUserToAddRows = false;
            grvHSM.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            cmbMaHSM.Text = "";
            cmbMaThuThu.Text = "";
            cmbMaThe.Text = "";
            dtpNgayMuon.Text = "";
            dtpNgayPhaiTra.Text = "";
        }
        private void LoadInfoHSM()
        {
            string str;
            str = "SELECT MaThe FROM HoSoMuon WHERE MaHSM = N'" + cmbMaHSM.Text.Trim() + "'";
            cmbMaThe.Text = DAO.GetFieldValues(str);
            str = "SELECT MaThuThu FROM HoSoMuon WHERE MaHSM = N'" + cmbMaHSM.Text.Trim() + "'";
            cmbMaThuThu.Text = DAO.GetFieldValues(str);
            str = "SELECT NgayMuon FROM HoSoMuon WHERE MaHSM = N'" + cmbMaHSM.Text.Trim() + "'";
            dtpNgayMuon.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "SELECT NgayPhaiTra FROM HoSoMuon WHERE MaHSM = N'" + cmbMaHSM.Text.Trim() + "'";
            dtpNgayPhaiTra.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (cmbMaHSM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE HoSoMuon SET MaThe=N'" + cmbMaThe.Text +
                "',MaThuThu=N'" + cmbMaThuThu.Text +
                "',NgayMuon=N'" + dtpNgayMuon.Text +
                "',NgayPhaiTra=N'" + dtpNgayPhaiTra.Text +
                "' WHERE MaHSM=N'" + cmbMaHSM.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnDong.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (cmbMaHSM.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hồ sơ mượn để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaHSM.Focus();
                return;
            }
            LoadInfoHSM();
            LoadDataToGridView();
            cmbMaThe.Enabled = true;
            cmbMaThuThu.Enabled = true;
            dtpNgayMuon.Enabled = true;
            dtpNgayPhaiTra.Enabled = true;
        }
    }
}
