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
    public partial class frmPhat : Form
    {
        public frmPhat()
        {
            InitializeComponent();
        }

        private void frmPhat_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from Phat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable Phat = new DataTable();
                myAdapter.Fill(Phat);
                gridViewPhat.DataSource = Phat;
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
            txtMaPhat.Text = "";
            txtTienPhat.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaPhat.Focus();
            ResetValues();
            txtMaPhat.Text = DAO.CreateKey("P");
            txtMaPhat.Enabled = false;
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhat.Focus();
                return;
            }
            if (txtTienPhat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiền phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienPhat.Focus();
                return;
            }
            sql = "SELECT MaPhat FROM Phat WHERE MaPhat = N'" + txtMaPhat.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã phạt này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhat.Focus();
                txtMaPhat.Text = "";
                return;
            }
            //sql = "INSERT INTO Khoa(MaKhoa, TenKhoa, DienThoai) VALUES (N'" + txtMaKhoa.Text.Trim() + "',N" + txtTenKhoa.Text.Trim() + "',N" + mskDienThoai.Text + "')";
            sql = "INSERT INTO Phat VALUES ('" + txtMaPhat.Text + "',N'" + txtTienPhat.Text + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhat.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTienPhat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiền phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienPhat.Focus();
                return;
            }
            sql = "UPDATE Phat SET TienPhat=N'" + txtTienPhat.Text + "'WHERE MaPhat=N'" + txtMaPhat.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhat.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Phat WHERE MaPhat=N'" + txtMaPhat.Text + "'";
                DAO.RunSqlDel(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhat.Text = gridViewPhat.CurrentRow.Cells["MaPhat"].Value.ToString();
            txtTienPhat.Text = gridViewPhat.CurrentRow.Cells["TienPhat"].Value.ToString();
            txtMaPhat.Enabled = false;
        }
    }
}
