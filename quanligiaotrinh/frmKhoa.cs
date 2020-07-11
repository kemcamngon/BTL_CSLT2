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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            ResetValues();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from Khoa";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable Khoa = new DataTable();
                myAdapter.Fill(Khoa);
                gridViewKhoa.DataSource = Khoa;
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

        private void gridViewKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = gridViewKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = gridViewKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
            mskDienThoai.Text = gridViewKhoa.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaKhoa.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            mskDienThoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Focus();
            ResetValues();
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return;
            }
            if (mskDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            sql = "SELECT MaKhoa FROM Khoa WHERE MaKhoa = N'" + txtMaKhoa.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã khoa này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                txtMaKhoa.Text = "";
                return;
            }
            //sql = "INSERT INTO Khoa(MaKhoa, TenKhoa, DienThoai) VALUES (N'" + txtMaKhoa.Text.Trim() + "',N" + txtTenKhoa.Text.Trim() + "',N" + mskDienThoai.Text + "')";
            sql = "INSERT INTO Khoa VALUES ('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "',N'" + mskDienThoai.Text + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return;
            }
            if (mskDienThoai.Text == "( ) -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            sql = "UPDATE Khoa SET TenKhoa=N'" + txtTenKhoa.Text.Trim().ToString() + "',DienThoai=N'" + mskDienThoai.Text.ToString() + "'WHERE MaKhoa=N'" + txtMaKhoa.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Khoa WHERE MaKhoa=N'" + txtMaKhoa.Text + "'";
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
