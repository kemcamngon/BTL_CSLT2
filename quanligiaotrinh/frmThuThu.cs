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
    public partial class frmThuThu : Form
    {
        public frmThuThu()
        {
            InitializeComponent();
        }

        private void frmThuThu_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaQue, TenQue FROM Que",
           cmbMaQue, "MaQue", "TenQue");
            cmbMaQue.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from ThuThu";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable ThuThu = new DataTable();
                myAdapter.Fill(ThuThu);
                gridViewThuThu.DataSource = ThuThu;
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
            txtMaThuThu.Text = "";
            txtTenThuThu.Text = "";
            txtDiaChi.Text = "";
            mskDienThoaiCD.Text = "";
            mskDienThoaiDD.Text = "";
            cmbMaQue.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaThuThu.Text = DAO.CreateKey("TT");
            txtMaThuThu.Enabled = false;
            txtMaThuThu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaThuThu.Focus();
                return;
            }
            if (txtTenThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thủ thư", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuThu.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienThoaiDD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại di động", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                mskDienThoaiDD.Focus();
                return;
            }
            if (cmbMaQue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quê", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaQue.Focus();
                return;
            }

            sql = "SELECT MaThuThu FROM ThuThu WHERE MaThuThu=N'" + txtMaThuThu.Text.Trim() + "'";
            if (DAO.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã thủ thư này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuThu.Focus();
                txtMaThuThu.Text = "";
                return;
            }
            sql = "INSERT INTO ThuThu(MaThuThu, TenThuThu, DiaChi, DienThoaiCD, DienThoaiDD, MaQue) VALUES(N'"
                + txtMaThuThu.Text.Trim() + "',N'" + txtTenThuThu.Text.Trim() + "',N'"
                + txtDiaChi.Text.Trim() + "',N'" + mskDienThoaiCD.Text.Trim() + "',N'"
                + mskDienThoaiDD.Text.Trim() + "',N'" + cmbMaQue.SelectedValue + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnDong.Enabled = true;
            btnLuu.Enabled = false;
            txtMaThuThu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaThuThu.Focus();
                return;
            }
            if (txtTenThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thủ thư", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuThu.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienThoaiDD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại di động", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                mskDienThoaiDD.Focus();
                return;
            }
            if (cmbMaQue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quê", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaQue.Focus();
                return;
            }

            sql = "UPDATE ThuThu SET TenThuThu=N'" + txtTenThuThu.Text +
                "',DiaChi=N'" + txtDiaChi.Text +
                "',DienThoaiCD=N'" + mskDienThoaiCD.Text +
                "',DienThoaiDD=N'" + mskDienThoaiDD.Text +
                "',MaQue=N'" + cmbMaQue.Text+
                "' WHERE MaThuThu=N'" + txtMaThuThu.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnDong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuThu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ThuThu WHERE MaThuThu=N'" + txtMaThuThu.Text + "'";
                DAO.RunSql(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThuThu.Text = gridViewThuThu.CurrentRow.Cells["MaThuThu"].Value.ToString();
            txtTenThuThu.Text = gridViewThuThu.CurrentRow.Cells["TenThuThu"].Value.ToString();
            txtDiaChi.Text = gridViewThuThu.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienThoaiCD.Text = gridViewThuThu.CurrentRow.Cells["DienThoaiCD"].Value.ToString();
            mskDienThoaiDD.Text = gridViewThuThu.CurrentRow.Cells["DienThoaiDD"].Value.ToString();
            cmbMaQue.Text = gridViewThuThu.CurrentRow.Cells["MaQue"].Value.ToString();
            txtMaThuThu.Enabled = false;
        }
    }
}
