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
    public partial class FrmTK_GT : Form
    {
        DataTable tableTKGT;
        public FrmTK_GT()
        {
            InitializeComponent();
        }
        private void loadDataToGridView()
        {
            string sql = "SELECT MaGT, TenGT, TenTacGia, TenChuyenNganh, NamXB, LanTB, SoTrang, TomTatNoiDung, SoLuongGT FROM DMGiaoTrinh join TacGia on DMGiaoTrinh.MaTacGia=TacGia.MaTacGia join ChuyenNganh on DMGiaoTrinh.MaChuyenNganh=ChuyenNganh.MaChuyenNganh WHERE 1=1";
            tableTKGT = DAO.LoadDataToGridView(sql);
            gridViewTK_GT.DataSource = tableTKGT;
            //gridViewTK_GT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void FrmTK_GT_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            DAO.FillDataToCombo("SELECT DISTINCT TenGT FROM DMGiaoTrinh", cmbGiaoTrinh, "TenGT", "TenGT");
            cmbGiaoTrinh.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT DISTINCT TenTacGia FROM TacGia", cmbTacGia, "TenTacGia", "TenTacGia");
            cmbTacGia.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT DISTINCT TenChuyenNganh FROM ChuyenNganh", cmbChuyenNganh, "TenChuyenNganh", "TenChuyenNganh");
            cmbChuyenNganh.SelectedIndex = -1;
            loadDataToGridView();
            gridViewTK_GT.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cmbGiaoTrinh.Focus();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cmbGiaoTrinh.Text == "") && (cmbTacGia.Text == "") && (cmbChuyenNganh.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MaGT, TenGT, TenTacGia, TenChuyenNganh, NamXB, LanTB, SoTrang, TomTatNoiDung, SoLuongGT FROM DMGiaoTrinh join TacGia on DMGiaoTrinh.MaTacGia=TacGia.MaTacGia join ChuyenNganh on DMGiaoTrinh.MaChuyenNganh=ChuyenNganh.MaChuyenNganh WHERE 1=1";
            if (cmbGiaoTrinh.Text != "")
                sql = sql + " AND TenGT = '" + cmbGiaoTrinh.Text + "' ";
            if (cmbTacGia.Text != "")
                sql = sql + " AND TenTacGia = '" + cmbTacGia.Text + "'";
            if (cmbChuyenNganh.Text != "")
                sql = sql + " AND TenChuyenNganh = '" + cmbChuyenNganh.Text + "'";
            DataTable tblGT = DAO.LoadDataToGridView(sql);
            if (tblGT.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblGT.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableTKGT = DAO.LoadDataToGridView(sql);
            gridViewTK_GT.DataSource = tableTKGT;
            ResetValues();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            cmbGiaoTrinh.Text = "";
            cmbTacGia.Text = "";
            cmbChuyenNganh.Text = "";
            gridViewTK_GT.DataSource = null;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaGT, TenGT, TenTacGia, TenChuyenNganh, NamXB, LanTB, SoTrang, TomTatNoiDung, SoLuongGT FROM DMGiaoTrinh join TacGia on DMGiaoTrinh.MaTacGia=TacGia.MaTacGia join ChuyenNganh on DMGiaoTrinh.MaChuyenNganh=ChuyenNganh.MaChuyenNganh";
            tableTKGT = DAO.LoadDataToGridView(sql);
            gridViewTK_GT.DataSource = tableTKGT;
        }
    }
}
