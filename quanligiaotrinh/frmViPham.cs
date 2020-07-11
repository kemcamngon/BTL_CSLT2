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
    public partial class frmViPham : Form
    {
        public frmViPham()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from ViPham";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable ViPham = new DataTable();
                myAdapter.Fill(ViPham);
                gridViewViPham.DataSource = ViPham;
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
            txtMaViPham.Text = "";
            txtTenViPham.Text = "";
        }
        private void frmViPham_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaViPham.Text = DAO.CreateKey("VP");
            txtMaViPham.Enabled = false;
            txtMaViPham.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaViPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã vi pham", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaViPham.Focus();
                return;
            }
            if (txtTenViPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên vi phạm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenViPham.Focus();
                return;
            }

            sql = "SELECT MaViPham FROM ViPham WHERE MaViPham = N'" + txtMaViPham.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã vi phạm này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaViPham.Focus();
                txtMaViPham.Text = "";
                return;
            }
            sql = "INSERT INTO ViPham VALUES ('" + txtMaViPham.Text + "',N'" + txtTenViPham.Text + "')";
            DAO.RunSql(sql);
            ResetValues();
            LoadDataToGridView();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaViPham.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaViPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenViPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên vi phạm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenViPham.Focus();
                return;
            }
            sql = "UPDATE ViPham SET TenViPham=N'" + txtTenViPham.Text + "'WHERE MaViPham=N'" + txtMaViPham.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaViPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ViPham WHERE MaViPham=N'" + txtMaViPham.Text + "'";
                DAO.RunSql(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaViPham.Text = gridViewViPham.CurrentRow.Cells["MaViPham"].Value.ToString();
            txtTenViPham.Text = gridViewViPham.CurrentRow.Cells["TenViPham"].Value.ToString();
            txtMaViPham.Enabled = false;
        }
    }
}
