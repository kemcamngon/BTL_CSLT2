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
    public partial class frmDMGiaoTrinh : Form
    {
        public frmDMGiaoTrinh()
        {
            InitializeComponent();
        }

        private void frmDMGiaoTrinh_Load(object sender, EventArgs e)
        {
            txtMaGT.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaTacGia, TenTacGia FROM TacGia",
           cmbMaTacGia, "MaTacGia", "TenTacGia");
            cmbMaTacGia.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaChuyenNganh, TenChuyenNganh FROM ChuyenNganh",
           cmbMaChuyenNganh, "MaChuyenNganh", "TenChuyenNganh");
            cmbMaChuyenNganh.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from DMGiaoTrinh";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable DMGiaoTrinh = new DataTable();
                myAdapter.Fill(DMGiaoTrinh);
                gridViewDMGiaoTrinh.DataSource = DMGiaoTrinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }
        private void ResetValues()
        {
            txtMaGT.Text = "";
            txtTenGT.Text = "";
            cmbMaTacGia.Text = "";
            txtNamXB.Text = "";
            txtLanTB.Text = "";
            cmbMaChuyenNganh.Text = "";
            txtSoTrang.Text = "";
            txtTomTatNoiDung.Text = "";
            txtSoTrang.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaGT.Text = DAO.CreateKey("GT");
            txtMaGT.Enabled = false;
            txtTenGT.Focus();   
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giáo trình", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaGT.Focus();
                return;
            }
            if (txtTenGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo trình", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGT.Focus();
                return;
            }
            if (cmbMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tác giả", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaTacGia.Focus();
                return;
            }
            if (txtNamXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtNamXB.Focus();
                return;
            }
            if (txtLanTB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần tái bản", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtLanTB.Focus();
                return;
            }
            if (cmbMaChuyenNganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn chuyên ngành", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (txtSoTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtSoTrang.Focus();
                return;
            }
            if (txtSoLuongGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng giáo trình", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtSoLuongGT.Focus();
                return;
            }

            sql = "SELECT MaGT FROM DMGiaoTrinh WHERE MaGT=N'" + txtMaGT.Text.Trim() + "'";
            if (DAO.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã giáo trình này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGT.Focus();
                txtMaGT.Text = "";
                return;
            }
            sql = "INSERT INTO DMGiaoTrinh(MaGT, TenGT, MaTacGia, NamXB, LanTB, MaChuyenNganh, SoTrang, TomTatNoiDung, SoLuongGT) VALUES(N'"
                + txtMaGT.Text + "',N'" + txtTenGT.Text + "',N'"
                + cmbMaTacGia.Text + "',N'" + txtNamXB.Text + "',N'"
                + txtLanTB.Text + "',N'" + cmbMaChuyenNganh.Text + "',N'"
                + txtSoTrang.Text + "',N'" + txtTomTatNoiDung.Text + "',N'"
                + txtSoLuongGT.Text + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnDong.Enabled = true;
            btnLuu.Enabled = false;
            txtMaGT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giáo trình", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaGT.Focus();
                return;
            }
            if (txtTenGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo trình", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGT.Focus();
                return;
            }
            if (cmbMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tác giả", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaTacGia.Focus();
                return;
            }
            if (txtNamXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtNamXB.Focus();
                return;
            }
            if (txtLanTB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần tái bản", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtLanTB.Focus();
                return;
            }
            if (cmbMaChuyenNganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn chuyên ngành", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (txtSoTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtSoTrang.Focus();
                return;
            }
            if (txtSoLuongGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng giáo trình", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtSoLuongGT.Focus();
                return;
            }

            sql = "UPDATE DMGiaoTrinh SET TenGT=N'" + txtTenGT.Text.Trim().ToString() +
                "',MaTacGia=N'" + cmbMaTacGia.SelectedValue.ToString() +
                "',NamXB=N'" + txtNamXB.Text.Trim().ToString() +
                "',LanTB=N'" + txtLanTB.Text.Trim().ToString() +
                "',MaChuyenNganh=N'" + cmbMaChuyenNganh.SelectedValue.ToString() +
                "',SoTrang=N'" + txtSoTrang.Text.Trim().ToString() +
                "',TomTatNoiDung=N'" + txtTomTatNoiDung.Text.Trim().ToString() +
                "',SoLuongGT=N'" + txtSoLuongGT.Text.Trim().ToString() +
                "' WHERE MaGT=N'" + txtMaGT.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnDong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE DMGiaoTrinh WHERE MaGT=N'" + txtMaGT.Text + "'";
                DAO.RunSql(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDMGiaoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGT.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["MaGT"].Value.ToString();
            txtTenGT.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["TenGT"].Value.ToString();
            cmbMaTacGia.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtNamXB.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["NamXB"].Value.ToString();
            txtLanTB.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["LanTB"].Value.ToString();
            cmbMaChuyenNganh.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["MaChuyenNganh"].Value.ToString();
            txtSoTrang.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["SoTrang"].Value.ToString();
            txtTomTatNoiDung.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["TomTatNoiDung"].Value.ToString();
            txtSoLuongGT.Text = gridViewDMGiaoTrinh.CurrentRow.Cells["SoLuongGT"].Value.ToString();
            txtMaGT.Enabled = false;
        }
    }
}
