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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtMaLop.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaKhoa, TenKhoa FROM Khoa", cmbMaKhoa, "MaKhoa", "TenKhoa");
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cmbMaKhoa.Text = "";
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from Lop";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable Lop = new DataTable();
                myAdapter.Fill(Lop);
                gridViewLop.DataSource = Lop;
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
        private void gridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = gridViewLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = gridViewLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cmbMaKhoa.Text = gridViewLop.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtMaLop.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaLop.Enabled = true;
            txtTenLop.Focus();
            ResetValues();
            txtMaLop.Text = DAO.CreateKey("L");
            txtMaLop.Enabled = false;
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaKhoa.Focus();
                return;
            }
            sql = "SELECT MaLop FROM Lop WHERE MaLop = N'" + txtMaLop.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                txtMaLop.Text = "";
                return;
            }
            sql = "INSERT INTO Lop VALUES ('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "',N'" + cmbMaKhoa.SelectedValue + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLop.Enabled = false;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaKhoa.Focus();
                return;
            }
            sql = "UPDATE Lop SET TenLop=N'" + txtTenLop.Text + "',MaKhoa=N'" + cmbMaKhoa.Text + "'WHERE MaLop=N'" + txtMaLop.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Lop WHERE MaLop=N'" + txtMaLop.Text + "'";
                DAO.RunSqlDel(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
